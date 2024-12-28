using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Hottel_Managment_system
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Booking BookingInfo = new Booking();
            BookingInfo.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rooms RoomsInfo = new Rooms();
            RoomsInfo.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Guest GuestInfo = new Guest();
            GuestInfo.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Employee EmployeeInfo = new Employee();
            EmployeeInfo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
             Bill BilltInfo = new Bill();
              BilltInfo.Show();
        }
    }
}
