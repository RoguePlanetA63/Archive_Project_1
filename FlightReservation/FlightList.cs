using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightReservation
{
    public partial class FlightList : Form
    {
        private string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FlightList.mdf;Integrated Security=True;";
        public static string searchDestination;
        public static DateTime BeforeDate;
        public static int rowCount;
        public FlightList()
        {
            InitializeComponent();

        }

        private void FlightList_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            ListofFlight_Load();
        }
        private void ListofFlight_Load()
        {
            if (BeforeDate != null)
            {
                BeforeDate = DateTime.Today;
            }
            else
            {
                
            }
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string selectQuery = "SELECT DestinationPlace,  FlightDate, FlightTime, AirLineName, FlightNumber, FlightCode  FROM AirlineSchedule WHERE DestinationPlace LIKE @Destination AND FlightDate >= @FlightTime";

                SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);
                selectCommand.Parameters.AddWithValue("@Destination", "%" + searchDestination + "%");
                selectCommand.Parameters.AddWithValue("@FlightTime", BeforeDate);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                rowCount = dt.Rows.Count;
                FlightListTable.DataSource = dt;
                if(rowCount == 0)
                {
                    MessageBox.Show("No Flight Found");
                }
            }
        }
        //private void PastFlight_Tick(object sender, EventArgs e)
        //{
        //    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
        //    {
        //        sqlConnection.Open();

        //        string deleteQuery = "DELETE FROM AirlineSchedule WHERE FlightDate < @currentDate OR (FlightDate = @currentDate AND FlightTime < @currentTime)";
        //        using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlConnection))
        //        {
        //            deleteCommand.Parameters.AddWithValue("@currentDate", DateTime.Today);
        //            deleteCommand.Parameters.AddWithValue("@currentTime", DateTime.Now.TimeOfDay);
        //            deleteCommand.ExecuteNonQuery();
        //        }
        //    }
        //    List<int> flightIds = new List<int>();
        //    List<string> destinations = new List<string>();
        //    using (SqlConnection selectConnection = new SqlConnection(connectionString))
        //    {
        //        selectConnection.Open();

        //        string selectQuery = "SELECT * FROM AirlineSchedule WHERE FlightDate < @currentDate OR (FlightDate = @currentDate AND FlightTime < @currentTime)";
        //        using (SqlCommand selectCommand = new SqlCommand(selectQuery, selectConnection))
        //        {
        //            selectCommand.Parameters.AddWithValue("@currentDate", DateTime.Today);
        //            selectCommand.Parameters.AddWithValue("@currentTime", DateTime.Now.TimeOfDay);
        //            using (SqlDataReader reader = selectCommand.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    int flightId = reader.GetInt32(reader.GetOrdinal("FlightNumber"));
        //                    string destination = reader.GetString(reader.GetOrdinal("DestinationPlace"));

        //                    flightIds.Add(flightId);
        //                    destinations.Add(destination);
        //                }
        //            }
        //            selectCommand.ExecuteNonQuery();
        //        }
        //    }
        //    for (int i = 0; i < flightIds.Count; i++)
        //    {
        //        int flightId = flightIds[i];
        //        string destination = destinations[i];
        //        string des = destination.Replace(" ", "");
        //        string tableName = des +"_"+ flightId;

        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {
        //            string dropTableQuery = "DROP TABLE " + tableName;

        //            using (SqlCommand dropTableCommand = new SqlCommand(dropTableQuery, connection))
        //            {
        //                connection.Open();
        //                dropTableCommand.ExecuteNonQuery();
        //            }
        //        }
        //    }
        //}
        
        
        private void Timer_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
