using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Reflection;

namespace SoftwareInterface
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\New folder\Documents\Bakery.mdf"";Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox7.Text == "" ||
                textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Fill All The Fields");
            }
            else
            {
                con.Open();
                string query = "Update FirstName='" + textBox1.Text + "',Last Name='" + textBox7.Text + "',Email='" + textBox2.Text + "',PhoneNumber='" + textBox3.Text + "',Password='" + textBox4.Text + "',Confirm Password'" + textBox6.Text + "' where email='" + textBox2.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Updated");
                con.Close();

            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 SignIn = new Form3();
            SignIn.Show();
        }
    }
}
