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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textEmail.Text;
            string pass = textPass.Text;

            if (email == "admin@SeaVilla.com" && pass == "Admin741#")
            {
                MessageBox.Show("Login success !");
                this.Hide();
                MainPage obj = new MainPage();
                obj.Show();

            }
            else
            {
                MessageBox.Show("Login  not success !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
