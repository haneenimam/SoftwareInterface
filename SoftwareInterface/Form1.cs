using System.Security.Cryptography.X509Certificates;
using WinFormsApp22.db;

namespace SoftwareInterface
{
    public partial class Form1 : Form
    {
        bool isUserNameWritten = false;
        bool isPasswordWritten = false;
        bakeryContext db = new bakeryContext();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 1)
            {
                isUserNameWritten = true;   
            }
            else
            {
                isUserNameWritten = false;  
            }
            if ( isUserNameWritten && isPasswordWritten)
            {
                button1.Enabled = true;    
            }
            else
            {
                button1.Enabled = false;    
            }
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 SignUP = new Form2();
            SignUP.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string Email = textBox1.Text;
            string password = textBox2.Text;


            var res = db.Accounts.Where(x => x.email == Email && x.Password == password);
            if (res.Count() > 0)
            {
                this.Hide();
            Form3 SignIn = new Form3();
            SignIn.Show();

            }
            else
            {
                MessageBox.Show("invalid email");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 1)
            {
                isPasswordWritten = true;
            }
            else
            {
                isPasswordWritten = false;
            }
            if (isUserNameWritten && isPasswordWritten)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();     
        }

       
    }
}