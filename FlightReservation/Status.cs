using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace FlightReservation
{
    public partial class Status : Form
    {
        private DateTime targetDateTime;
        private System.Timers.Timer countdownTimer;
        private string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FlightList.mdf;Integrated Security=True;";
        public Status()
        {
            InitializeComponent();
        }

        private void Status_Load(object sender, EventArgs e)
        {
            
            ReserveStatus();
        }

        private void ReserveStatus()
        {
            if (Properties.Settings.Default.Reserve == "Yes")
            {
                targetDateTime = DateTime.Now.AddMinutes(5);
                countdownTimer = new System.Timers.Timer();
                countdownTimer.Interval = 1000;
                countdownTimer.Elapsed += CountdownTimerElapsed;
                countdownTimer.Start();

                lblDestination.Text = Properties.Settings.Default.pssngrDestination;
                lblSource.Text = Properties.Settings.Default.pssngrSource;
                Note.Text = "Thank You!!";
                notes1.Text = "Have a safe trip and Enjoy your Flight!";
                label3.Visible = true;
                btnReserve.Location = new Point(120, 365);
                btnReserve.Text = "New";
                lblCode.Text = Properties.Settings.Default.pssngrcode;
            }
            else
            {
                lblDestination.Text = "- -";
                lblSource.Text = "- -";
                Note.Text = "No Reservation";
                notes1.Text = "Please Reserve!!";
                lblCountDown.Text = "--:--";
                btnReserve.Text = "Reserve";
                lblCode.Text = "";
                label3.Visible= false;
                btnReserve.Location = new Point(218, 365);
                btnCancel.Visible = false;
            }
        }

        private void CountdownTimerElapsed(object sender, ElapsedEventArgs e)
        {
            TimeSpan remainingTime = Properties.Settings.Default.FlightDate - DateTime.Now;

            if (remainingTime.TotalSeconds <= 0)
            {
                rmoveSetting();
                lblCountDown.Text = "Flight Missed";
                
            }
            else
            {
                string remainingTimeText = $"{(int)remainingTime.TotalHours:00}:{remainingTime.Minutes:00}";
                if (lblCountDown.IsHandleCreated)
                {
                    lblCountDown.Invoke((MethodInvoker)(() => lblCountDown.Text = remainingTimeText));
                }
            }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {

            Reservation reservation = new Reservation();
            reservation.MdiParent = this.MdiParent;
            reservation.Dock = DockStyle.Left;
            this.Close();
            reservation.Show();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = $"DELETE FROM {Properties.Settings.Default.tableName} WHERE PassengerName = @PassengerName AND PassportId = @PassportId AND Airline = @Airline";

                using (SqlConnection submitConnection = new SqlConnection(connectionString))
                {
                    submitConnection.Open();

                    using (SqlCommand command = new SqlCommand(insertQuery, submitConnection))
                    {
                        command.Parameters.AddWithValue("@PassengerName", Properties.Settings.Default.pssngrName);
                        command.Parameters.AddWithValue("@PassportId", Properties.Settings.Default.pssngrPassPort);
                        command.Parameters.AddWithValue("@Airline", Properties.Settings.Default.pssngrAirline);

                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Reservation Cancelled");
                rmoveSetting();
                ReserveStatus();
            }
            catch
            {

            }
        }
        private void rmoveSetting()
        {
            Properties.Settings.Default.pssngrName = string.Empty;
            Properties.Settings.Default.pssngrPassPort = string.Empty;
            Properties.Settings.Default.pssngrAirline = string.Empty;
            Properties.Settings.Default.pssngrDestination = string.Empty;
            Properties.Settings.Default.pssngrSource = string.Empty;
            Properties.Settings.Default.tableName = string.Empty;
            Properties.Settings.Default.pssngrcode = string.Empty;
            Properties.Settings.Default.FlightDate = DateTime.MinValue;
            Properties.Settings.Default.Reserve = "No";
            Properties.Settings.Default.pssngrPassPort = string.Empty;
            Properties.Settings.Default.Save();
        }
    }
}
