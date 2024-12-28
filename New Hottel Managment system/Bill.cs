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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data source=Data Source=DESKTOP-0414CBD\SQLEXPRESS;Initial Catalog=Customerdb;Integrated Security=True;Trust Server Certificate=True");

            con.Open();
            SqlCommand cnn = new SqlCommand("insert into booktab values(@id,@Guest name,@Room_Type,@Room_Price,@Services)", con);

            cnn.Parameters.AddWithValue("@id", int.Parse(textId.Text));
            cnn.Parameters.AddWithValue("@Guest Name", (textGname.Text));
            cnn.Parameters.AddWithValue("@Room_type", (textRtype.Text));
            cnn.Parameters.AddWithValue("@Room_Price", int.Parse(textRprice.Text));
            cnn.Parameters.AddWithValue("@Services", (textServices.Text));

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Saved successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data source=Data Source=DESKTOP-0414CBD\SQLEXPRESS;Initial Catalog=Customerdb;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand cnn = new SqlCommand("select * from billtab", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textId.Text = "";
            textGname.Text = "";
            textRtype.Text = "";
             textRprice.Text = "";
             textServices.Text = "";

        }
    }
}
