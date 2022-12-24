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
using System.Reflection;
using WinFormsApp22.db;

namespace SoftwareInterface
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 SignIn = new Form8();
            SignIn.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 SignIn = new Form3();
            SignIn.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Paymentmethod;
            if (radioButton1.Checked == true)
            {
                Paymentmethod = "cash on delivery";
            }
            else
            {
                Paymentmethod = "credit card";
            }
            
            string selectcity = textBox1.Text;
            string enteryourarea = textBox2.Text;
            string paymentmethod = Paymentmethod;
           int cardnumber = int.Parse(textBox3.Text);
           int totalamount= int.Parse(textBox4.Text);

            Orrder m = new Orrder();
            m.Paymentmethod = Paymentmethod;    
            m.city = selectcity;
            m.Area = enteryourarea;
            m.Cardnumber = cardnumber;
            m.Totalamount = totalamount;

            bakeryContext c = new bakeryContext();
            c.Database.EnsureCreated();
            c.Orrders.Add(m);
            c.SaveChanges();
           
         //  dataGridView1.DataSource = c.Orrders.ToList();

            MessageBox.Show("Order was placed successfully");
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            bakeryContext c = new bakeryContext();

            c.Database.EnsureCreated();

          //  dataGridView1.DataSource = c.Orrders.ToList();

        }
    }
}
