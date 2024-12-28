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
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data source=Data Source=DESKTOP-0414CBD\SQLEXPRESS;Initial Catalog=Customerdb;Integrated Security=True;Trust Server Certificate=True");

            con.Open();
            SqlCommand cnn = new SqlCommand("insert into booktab values(@id,@Guestname,@room_No,@room_type,@hottel_code)", con);

            cnn.Parameters.AddWithValue("@id", int.Parse(textId.Text));
            cnn.Parameters.AddWithValue("@GuestName", int.Parse(textGuestname.Text));
            cnn.Parameters.AddWithValue("@Room_No", int.Parse(textRoom_No.Text));
            cnn.Parameters.AddWithValue("@Room_Type", int.Parse(textRoom_Type.Text));
            cnn.Parameters.AddWithValue("@Hottel_Code", int.Parse(textHottel_code.Text));

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Saved successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data source=Data Source=DESKTOP-0414CBD\SQLEXPRESS;Initial Catalog=Customerdb;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand cnn = new SqlCommand("select * from booktab",con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            da.Fill(table);
            dataGridView1.DataSource = table;


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textGuestname.Text = "";
            textHottel_code.Text = "";
            textId.Text = "";
            textRoom_No.Text = "";
            textRoom_Type.Text = "";

        }
    }
}
