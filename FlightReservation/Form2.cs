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
    public partial class Form2 : Form
    {
        private string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FlightList.mdf;Integrated Security=True;";
        public Form2()
        {
            InitializeComponent();
        }

        private void NewFlight_Load()
        {
                List<string> airlineCompanies = new List<string>()
                {
                "Philippine Airlines (PAL)",
                "Cebu Pacific Air",
                "AirAsia Philippines",
                "SkyJet Airlines",
                "Philippine AirAsia",
                "PAL Express",
                "Cebgo",
                "AirSWIFT",
                "SEAir International"
                };

                List<string> places = new List<string>()
                {
                "United States",
                "Canada",
                "United Kingdom",
                "Australia",
                "Japan",
                "South Korea",
                "Philippines",
                "China",
                "Singapore",
                "Malaysia",
                "Thailand",
                "Hong Kong",
                "Taiwan",
                "Saudi Arabia",
                "United Arab Emirates",
                "Qatar",
                "Kuwait"
                };

                Random random = new Random();
                const int NumberOfSchedules = 5;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO AirlineSchedule (AirlineName, FlightDate, FlightTime, FlightNumber, FlightCode, DestinationPlace) " +
                        "VALUES (@AirlineCompany, @ScheduleDate, @ScheduleTime, @FlightNumber, @Code, @Place)";

                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        for (int i = 0; i < NumberOfSchedules; i++)
                        {
                            string airlineCompany = airlineCompanies[random.Next(airlineCompanies.Count)];
                            string place = places[random.Next(places.Count)];
                            DateTime date = DateTime.Now.AddDays(random.Next(5));
                            TimeSpan time = TimeSpan.FromHours(random.Next(24));
                            int number = random.Next(1000, 9999);
                            string code = GenerateCode();

                            insertCommand.Parameters.Clear();
                            insertCommand.Parameters.AddWithValue("@AirlineCompany", airlineCompany);
                            insertCommand.Parameters.AddWithValue("@ScheduleDate", date);
                            insertCommand.Parameters.AddWithValue("@ScheduleTime", time);
                            insertCommand.Parameters.AddWithValue("@FlightNumber", number);
                            insertCommand.Parameters.AddWithValue("@Code", code);
                            insertCommand.Parameters.AddWithValue("@Place", place);

                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }
            
        }
        private string GenerateCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder codeBuilder = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < 6; i++)
            {
                codeBuilder.Append(chars[random.Next(chars.Length)]);
            }

            return codeBuilder.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewFlight_Load();
        }
    }
}
