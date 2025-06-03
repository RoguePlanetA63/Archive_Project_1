using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightReservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (txtUsername.Text=="UserName" && txtPassword.Text=="Password") {
                FlightReservation flightReservation = new FlightReservation();
                flightReservation.Show();
                this.Hide();
            //}
            //else
            //{
            //    txtUsername.Clear();
            //    txtPassword.Clear();
            //    txtUsername.Focus();
            //    MessageBox.Show("The Username and Password you enter is Incorrect");
            //}
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
