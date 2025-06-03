using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightReservation
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }
        private void ReservationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try {
                if (txtFirstName.Text != "" && txtLastName.Text != "" && MonthCmbBox.Text != "" && DayCmbBox.Text != "" && YearCmbBox.Text != "")
                {
                    string month = MonthCmbBox.Text;
                    string day = DayCmbBox.Text;
                    string year = YearCmbBox.Text;

                    if (txtTitle.Text == "")
                        ReservationCont.pssngrName = txtFirstName.Text + " " + txtLastName.Text;
                    else
                        ReservationCont.pssngrName = txtTitle.Text + " " + txtFirstName.Text + " " + txtLastName.Text;

                    int monthValue;
                    if (DateTime.TryParseExact(month, "MMMM", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedMonth))
                    {
                        monthValue = parsedMonth.Month;
                    }
                    else
                    {
                        // Parsing failed, display an error message or take appropriate action
                        MessageBox.Show("Invalid month format. Please select a valid month.", "Error");
                        return; // Stop further execution
                    }

                    int dayValue = int.Parse(day);
                    int yearValue = int.Parse(year);

                    ReservationCont.DateofBirth = new DateTime(yearValue, monthValue, dayValue);

                    ReservationCont reservationForm = new ReservationCont();
                    reservationForm.MdiParent = this.MdiParent;
                    reservationForm.Dock = DockStyle.Left;
                    reservationForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please fill all the fields");
                }
            }
            catch
            {

            }
        }
    }
}
