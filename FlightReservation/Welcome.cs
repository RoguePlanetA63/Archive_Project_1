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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FlightList.mdf;Integrated Security=True;";
        private void btnSearch_Click(object sender, EventArgs e)
        {
            FlightList.BeforeDate = dateTimePicker1.Value;
            FlightList.searchDestination=txtDes.Text;

            FlightList flightList = new FlightList();
            flightList.MdiParent = this.MdiParent;
            flightList.Dock = DockStyle.Right;
            flightList.Show();

            Status status = new Status();
            status.MdiParent = this.MdiParent;
            status.Dock = DockStyle.Left;
            status.Show();
            this.Close();

        }
    }
}
