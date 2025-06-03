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
    public partial class FlightReservation : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FlightList.mdf;Integrated Security=True;";
        public FlightReservation()
        {
            InitializeComponent();
            CreateNewFlightTable();
        }


        private void CreateNewFlightTable()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectFlightsQuery = "SELECT * FROM AirlineSchedule";
                using (SqlCommand selectFlightsCommand = new SqlCommand(selectFlightsQuery, connection))
                {
                    using (SqlDataReader flightsReader = selectFlightsCommand.ExecuteReader())
                    {
                        while (flightsReader.Read())
                        {
                            // Get the flight details
                            int flightId = flightsReader.GetInt32(flightsReader.GetOrdinal("FlightNumber"));
                            DateTime flightDate = flightsReader.GetDateTime(flightsReader.GetOrdinal("FlightDate"));
                            TimeSpan flightTime = flightsReader.GetTimeSpan(flightsReader.GetOrdinal("FlightTime"));
                            string destination = flightsReader.GetString(flightsReader.GetOrdinal("DestinationPlace"));
                            string airline = flightsReader.GetString(flightsReader.GetOrdinal("AirlineName"));

                            string newTableName = destination.Replace(" ", "") +"_"+ flightId;
                            CreateNewTable(destination, newTableName);
                        }

                        flightsReader.Close();
                    }
                }
            }
        }

        private void CreateNewTable(string destination, string tableName)
        {
            SqlConnection newConnection = new SqlConnection(connectionString);
            string checkTableQuery = "IF OBJECT_ID('" + tableName + "', 'U') IS NULL SELECT 0 ELSE SELECT 1";
            string createTableQuery = "CREATE TABLE " + tableName + " (" +
                "PassengerName VARCHAR(100), " +
                "BirthDate DATE, " +
                "ContactPerson VARCHAR(100), " +
                "Email VARCHAR(100), " +
                "PhoneNumber VARCHAR(20), " +
                "Address VARCHAR(200), " +
                "InternationalOrDomestic VARCHAR(20), " +
                "PassportId VARCHAR(20), " +
                "DepartingFrom VARCHAR(100), " +
                "Destination VARCHAR(100), " +
                "Airline VARCHAR(100), " +
                "Fare VARCHAR(20)" +
                ")";

            using (SqlCommand checkTableCommand = new SqlCommand(checkTableQuery, newConnection))
            {
                newConnection.Open();
                int tableExists = (int)checkTableCommand.ExecuteScalar();

                if (tableExists == 0)
                {
                    using (SqlCommand createTableCommand = new SqlCommand(createTableQuery, newConnection))
                    {
                        createTableCommand.ExecuteNonQuery();
                    }
                }
                else
                {
                    // Table already exists, handle accordingly
                }
            }
        }





        private void FlightReservation_Load(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.MdiParent = this;
            welcome.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
            Welcome welcome = new Welcome();
            welcome = new Welcome();
            welcome.MdiParent = this;
            welcome.Dock= DockStyle.Fill;
            welcome.Show();
            

        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
            if (Properties.Settings.Default.Reserve == "Yes")
            {
                Status status = new Status();
                status.MdiParent = this;
                status.Dock = DockStyle.Left;
                status.Show();
            }
            else
            {
                Reservation reservation = new Reservation();
                reservation.MdiParent = this;
                reservation.Dock = DockStyle.Left;
                reservation.Show();
            }
            FlightList.searchDestination = "";
            FlightList.BeforeDate= DateTime.Now.AddDays(7);
            FlightList flightList = new FlightList();
            flightList.MdiParent = this;
            flightList.Dock = DockStyle.Right;
            flightList.Show();
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
            Status status = new Status();
            status.MdiParent = this;
            status.Dock = DockStyle.Left;
            status.Show();

            FlightList flightList = new FlightList();
            flightList.MdiParent = this;
            flightList.Dock = DockStyle.Right;
            flightList.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Flight Reservation Project\n\n" +
                     "This application allows users to make flight reservations.\n" +
                     "It provides features for searching and booking flights, managing passenger information, and more.\n" +
                     "Version: 1.0\n" +
                     "Author: (っ◕‿◕)っ\n" +
                     "© 2023 Flight Reservation Project. All rights reserved.";

            MessageBox.Show(message);
        }

        private void changeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

            menuStrip1.BackColor = randomColor;

            statusStrip1.BackColor = randomColor;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
            
            Reservation reservation = new Reservation();
            reservation.MdiParent = this;
            reservation.Dock = DockStyle.Left;
            reservation.Show();
            
            FlightList flightList = new FlightList();
            flightList.MdiParent = this;
            flightList.Dock = DockStyle.Right;
            flightList.Show();
        }

    }
}
