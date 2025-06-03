using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightReservation
{
    public partial class ReservationCont : Form
    {
        public static string pssngrName;
        public static string pssngrPassPort;
        public static string pssngrAirline;
        public static string pssngrDestination;
        public static string pssngrSource;
        public static string tableName;
        public static string pssngrcode;

        public static DateTime DateofBirth;
        public static DateTime FlightDate;
        public static string Reserve;

        private string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FlightList.mdf;Integrated Security=True;";
        public ReservationCont()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ReservationCont reservationForm = new ReservationCont();
            reservationForm.MdiParent = this.MdiParent;
            reservationForm.Dock = DockStyle.Left;
            reservationForm.Show();
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool anyEmptyField = false;
            string emptyFields = "";
            string internDomestic = "Domestic";

            

                if (chkInter.Checked)
                {
                    internDomestic = "International";
                }

                foreach (Control control in Controls)
                {
                    if (control is TextBox textBox && string.IsNullOrEmpty(textBox.Text))
                    {
                        anyEmptyField = true;
                        emptyFields += textBox.Name + "\n";
                    }
                    else if (control is ComboBox comboBox && comboBox.SelectedIndex == -1)
                    {
                        anyEmptyField = true;
                        emptyFields += comboBox.Name + "\n";
                    }
                }

                if (anyEmptyField)
                {
                    MessageBox.Show("Please fill in the following fields:\n" + emptyFields, "Empty Fields");
                }
                else
                {
                    String contactperson = txtTitle.Text + " " + txtFirstName.Text + " " + txtLastName.Text;
                    string fullAddress = txtStreet.Text + ", " + txtCity.Text + ", " + txtStateProvince.Text + " " + txtPostalZip.Text;

                    using (SqlConnection selectConnection = new SqlConnection(connectionString))
                    {
                        selectConnection.Open();

                        string selectQuery = "SELECT TOP 1 FlightNumber, FlightCode, FlightDate, FlightTime FROM AirlineSchedule WHERE DestinationPlace = @destination AND AirlineName = @Airline ORDER BY FlightNumber ASC";
                        using (SqlCommand selectCommand = new SqlCommand(selectQuery, selectConnection))
                        {
                            selectCommand.Parameters.AddWithValue("@destination", txtDes.Text);
                            selectCommand.Parameters.AddWithValue("@Airline", txtAirline.Text);
                            using (SqlDataReader reader = selectCommand.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string flightcode = reader.GetString(reader.GetOrdinal("FlightCode"));
                                    int flightId = reader.GetInt32(reader.GetOrdinal("FlightNumber"));
                                    DateTime flightDate = reader.GetDateTime(reader.GetOrdinal("FlightDate"));
                                    TimeSpan flightTime = reader.GetTimeSpan(reader.GetOrdinal("FlightTime"));
                                    FlightDate = flightDate.Date + flightTime;
                                string des = txtDes.Text.Replace(" ", "");
                                    tableName =  des + "_" + flightId;
                                    pssngrcode = flightcode +"  "+ flightId;

                                    Insert_Query(tableName, contactperson, fullAddress, internDomestic);
                                    
                            }
                                else
                                {
                                    MessageBox.Show("No matching flight found.");
                                }
                            }
                            selectCommand.ExecuteNonQuery();
                        }
                    }
                }

    }
        private void Insert_Query(string tableName, String contactperson, string fullAddress, string internDomestic)
        {
           
                string insertQuery = $"INSERT INTO {tableName} (PassengerName, BirthDate, ContactPerson, Email, PhoneNumber, Address, InternationalOrDomestic, PassportId, DepartingFrom, Destination, Airline, Fare) VALUES (@PassengerName, @BirthDate, @ContactPerson, @Email, @PhoneNumber, @FullAddress, @InternationalOrDomestic, @PassportId, @DepartingFrom, @Destination, @Airline, @Fare)";

                using (SqlConnection submitConnection = new SqlConnection(connectionString))
                {
                    submitConnection.Open();

                    using (SqlCommand command = new SqlCommand(insertQuery, submitConnection))
                    {
                        command.Parameters.AddWithValue("@PassengerName", pssngrName);
                        command.Parameters.AddWithValue("@BirthDate", DateofBirth);
                        command.Parameters.AddWithValue("@ContactPerson", contactperson);
                        command.Parameters.AddWithValue("@Email", txtEmail.Text);
                        command.Parameters.AddWithValue("@PhoneNumber", TxtPhone.Text);
                        command.Parameters.AddWithValue("@FullAddress", fullAddress);
                        command.Parameters.AddWithValue("@InternationalOrDomestic", internDomestic);
                        command.Parameters.AddWithValue("@PassportId", txtPassport.Text);
                        command.Parameters.AddWithValue("@DepartingFrom", txtDepCity.Text + ", " + txtDepFrom.Text);
                        command.Parameters.AddWithValue("@Destination", txtDesCity.Text + ", " + txtDes.Text);
                        command.Parameters.AddWithValue("@Airline", txtAirline.Text);
                        command.Parameters.AddWithValue("@Fare", txtFare.Text);

                        command.ExecuteNonQuery();
                    }
                }
                pssngrPassPort = txtPassport.Text;
                pssngrAirline = txtAirline.Text;
                pssngrDestination = txtDes.Text;
                pssngrSource = txtDepFrom.Text;
                Reserve = "Yes";

                Properties.Settings.Default.pssngrName = pssngrName;
                Properties.Settings.Default.pssngrPassPort = pssngrPassPort;
                Properties.Settings.Default.pssngrAirline = pssngrAirline;
                Properties.Settings.Default.pssngrDestination = pssngrDestination;
                Properties.Settings.Default.pssngrSource = pssngrSource;
                Properties.Settings.Default.tableName = tableName;
                Properties.Settings.Default.pssngrcode = pssngrcode;
                Properties.Settings.Default.FlightDate = FlightDate;
                Properties.Settings.Default.Reserve = Reserve;
                Properties.Settings.Default.pssngrPassPort = pssngrPassPort;
                Properties.Settings.Default.Save();

            Status status = new Status();
                status.MdiParent = this.MdiParent;
                status.Dock = DockStyle.Left;
                status.Show();
                this.Close();
            
        }

        private void chkDom_CheckedChanged(object sender, EventArgs e)
        {
            txtDes.SelectedItem = "Philippines";
        }

        private void txtDes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtDes.SelectedIndex != 7)
            {
                chkInter.Checked = true;
            }
            else
            {
                chkDom.Checked = true;
            }
        }
    }
}
