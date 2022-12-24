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
    public partial class Form2 : Form
    {
        bakeryContext c = new bakeryContext();
        bakeryContext db = new bakeryContext();
        public Form2()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox7.Text == "" ||
                textBox2.Text == "" || textBox3.Text == ""  || textBox4.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Fill All The Fields");
            }
            else {
                
                string firstName = textBox1.Text;
                string lastName = textBox7.Text;    
                string Email = textBox2.Text;
                string phone = textBox3.Text;
                string password= textBox4.Text;
                string password2 = textBox6.Text;

                    if (password != password2)
                    {
                        MessageBox.Show("the 2 passwords are unmatched");
                    }
                
                else
                {
                    Account s = new Account();
                    s.firstName = firstName;
                    s.lastName = lastName;
                    s.email = Email; 
                    s.phoneNumber = phone;
                    s.Password= password;   
                    s.Confirmpassword = password2;

                    var res = db.Accounts.Where(x => x.email == Email);
                    if (res.Count() > 0)
                    {
                        MessageBox.Show("ACCOUNT ALREADY ECXISTS");
                    }
                    else
                    {

                        c.Database.EnsureCreated();
                        c.Accounts.Add(s);
                        c.SaveChanges();
                        MessageBox.Show("ACCOUNT CREATED");
                        // dataGridView1.DataSource = c.Accounts.ToList();



                        //using (var context = new bakeryContext())
                        //{
                        //    //Get all values from database  
                        //    foreach (var emp in context.Accounts)
                        //    {
                        //        Console.WriteLine("Employee ID : " + emp.email);
                        //        Console.WriteLine("Employee Name : " + emp.Password);
                        //    }
                        //}


                    }

                }

            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            bakeryContext c = new bakeryContext();

            c.Database.EnsureCreated();

          // dataGridView1.DataSource = c.Accounts.ToList();
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 SignIn = new Form1();
            SignIn.Show();
        }

      
    }
}
