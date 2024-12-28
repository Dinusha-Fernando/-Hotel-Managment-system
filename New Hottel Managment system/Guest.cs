using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace New_Hottel_Managment_system
{
    public partial class Guest : Form
    {
        public Guest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data source=Data Source=DESKTOP-0414CBD\SQLEXPRESS;Initial Catalog=Customerdb;Integrated Security=True;Trust Server Certificate=True");

            con.Open();
            SqlCommand cnn = new SqlCommand("insert into booktab values(@id,@name,@age,@contact,@address)", con);

            cnn.Parameters.AddWithValue("@id", int.Parse(textId.Text));
            cnn.Parameters.AddWithValue("@Name", (textName.Text));
            cnn.Parameters.AddWithValue("@Age", int.Parse(textAge.Text));
            cnn.Parameters.AddWithValue("@Contact", int.Parse(textContact.Text));
            cnn.Parameters.AddWithValue("@Address", (textAddress.Text));

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Saved successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);


            textName.Text = "";
            textAddress.Text = "";
            textContact.Text = "";
            textId.Text = "";
            textAge.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data source=Data Source=DESKTOP-0414CBD\SQLEXPRESS;Initial Catalog=Customerdb;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand cnn = new SqlCommand("select * from guesttab", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textName.Text = "";
            textAddress.Text = "";
            textContact.Text = "";
            textId.Text = "";
            textAge.Text = "";

        }
    }
}
