using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareInterface
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
        //item price
        double blueperry = 40, applecinnamon=35, choclatemuffin=30,carrotmuffin=35,strawberrycupcakes=40,lemoncupcake=35,coffeecupcake=30,lottuscupcake=35;
        double lemonmint = 15, orange = 10, water = 7, pistachiodonuts = 35, nutelladonuts = 40, lottusdonuts = 30, cinnamondonuts = 35, strawberry = 35, glazeddonuts = 35;
        //totalprice
        double blueperrytp , applecinnamontp, choclatemuffintp,carrotmuffintp, strawberrycupcakestp, lemoncupcaketp, coffeecupcaketp, lottuscupcaketp;
        double lemonminttp, orangetp, watertp, pistachiodonutstp, nutelladonutstp, lottusdonutstp, cinnamondonutstp, strawberrydonutstp, glazeddonutstp;

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            subtotal = 0;
            label18.Text = "";
            checkBox10.Checked = false;
            checkBox11.Checked = false;     
            checkBox1.Checked = false; 
            checkBox9.Checked = false; 
            checkBox8.Checked = false;
            checkBox7.Checked = false;
            checkBox6.Checked = false;
            checkBox5.Checked = false;
            checkBox3.Checked = false;
            checkBox2.Checked = false;
            checkBox19.Checked=false;
            checkBox17.Checked = false; 
            checkBox13.Checked = false; 
            checkBox12.Checked = false; 
            checkBox15.Checked = false;
            checkBox14.Checked = false;
            checkBox16.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            blueperrytp = blueperry * Convert.ToDouble(textBox8.Text);
            applecinnamontp = applecinnamon * Convert.ToDouble(textBox2.Text);
            choclatemuffintp = choclatemuffin * Convert.ToDouble(textBox6.Text);
            carrotmuffintp = carrotmuffin * Convert.ToDouble(textBox7.Text);
            strawberrycupcakestp = strawberrycupcakes * Convert.ToDouble(textBox1.Text);
            lemoncupcaketp = lemoncupcake * Convert.ToDouble(textBox5.Text);
            coffeecupcaketp = coffeecupcake * Convert.ToDouble(textBox4.Text);
            lottuscupcaketp = lottuscupcake * Convert.ToDouble(textBox3.Text);
            lemonminttp = lemonmint * Convert.ToDouble(textBox11.Text);
            orangetp = orange * Convert.ToDouble(textBox9.Text);
            watertp = water * Convert.ToDouble(textBox10.Text);
            pistachiodonutstp = pistachiodonuts * Convert.ToDouble(textBox19.Text);
            nutelladonutstp = nutelladonuts * Convert.ToDouble(textBox16.Text);
            lottusdonutstp = lottusdonuts * Convert.ToDouble(textBox15.Text);
            cinnamondonutstp = cinnamondonuts * Convert.ToDouble(textBox12.Text);
            strawberrydonutstp = strawberry * Convert.ToDouble(textBox13.Text);
            glazeddonutstp = glazeddonuts * Convert.ToDouble(textBox14.Text);

            //add products to cart
            richTextBox1.Clear();
            richTextBox1.AppendText("\t\t Cart"+ Environment.NewLine);
            
            if (checkBox10.Checked == true)
            {
                richTextBox1.AppendText("Blueberry Muffin:\t"+ blueperrytp+"L.E"+Environment.NewLine);
                subtotal = subtotal + blueperrytp;
                label18.Text="" + subtotal;
            }
            if (checkBox9.Checked == true)
            {
                richTextBox1.AppendText("AppleCinnamon Muffin:\t" + applecinnamon + "L.E" + Environment.NewLine);
                subtotal = subtotal + applecinnamontp;
                label18.Text = "" + subtotal;
            }
            if (checkBox8.Checked == true)
            {
                richTextBox1.AppendText("Chocolate Muffin:\t" + choclatemuffin + "L.E" + Environment.NewLine);
                subtotal = subtotal + choclatemuffintp;
                label18.Text = "" + subtotal;
            }
            if (checkBox7.Checked == true)
            {
                richTextBox1.AppendText("Carrot Muffin:\t" + carrotmuffintp + "L.E" + Environment.NewLine);
                subtotal = subtotal + carrotmuffintp;
                label18.Text = "" + subtotal;
            }
            if (checkBox14.Checked == true)
            {
                richTextBox1.AppendText("Lemon Mint:\t" + lemonminttp + "L.E" + Environment.NewLine);
                subtotal = subtotal + lemonminttp;
                label18.Text = "" + subtotal;
            }
            
            if (checkBox13.Checked == true)
            {
                richTextBox1.AppendText("Orange:\t" + orangetp + "L.E" + Environment.NewLine);
                subtotal = subtotal + orangetp;
                label18.Text = "" + subtotal;
            }
            if (checkBox12.Checked == true)
            {
                richTextBox1.AppendText("Water:\t" + watertp + "L.E" + Environment.NewLine);
                subtotal = subtotal + watertp;
                label18.Text = "" + subtotal;
            }
            if (checkBox1.Checked == true)
            {
                richTextBox1.AppendText("Strawberry cupcake:\t" + strawberrycupcakestp + "L.E" + Environment.NewLine);
                subtotal = subtotal + strawberrycupcakestp;
                label18.Text = "" + subtotal;
            }
            if (checkBox2.Checked == true)
            {
                richTextBox1.AppendText("Lemon cupcake:\t" + lemoncupcaketp + "L.E" + Environment.NewLine);
                subtotal = subtotal + lemoncupcaketp;
                label18.Text = "" + subtotal;
            }
            if (checkBox3.Checked == true)
            {
                richTextBox1.AppendText("coffee cupcake:\t" + coffeecupcaketp + "L.E" + Environment.NewLine);
                subtotal = subtotal + coffeecupcaketp;
                label18.Text = "" + subtotal;
            }
            if (checkBox5.Checked == true)
            {
                richTextBox1.AppendText("Lottus cupcake:\t" + lottuscupcaketp + "L.E" + Environment.NewLine);
                subtotal = subtotal + lottuscupcaketp;
                label18.Text = "" + subtotal;
            }
            if (checkBox16.Checked == true)
            {
                richTextBox1.AppendText("Pistachio donut:\t" + pistachiodonutstp + "L.E" + Environment.NewLine);
                subtotal = subtotal + pistachiodonutstp;
                label18.Text = "" + subtotal;
            }
            if (checkBox17.Checked == true)
            {
                richTextBox1.AppendText("Nuttela donut:\t" + nutelladonutstp + "L.E" + Environment.NewLine);
                subtotal = subtotal + nutelladonutstp;
                label18.Text = "" + subtotal;
            }
            if (checkBox15.Checked == true)
            {
                richTextBox1.AppendText("Lottus donut:\t" + lottusdonutstp + "L.E" + Environment.NewLine);
                subtotal = subtotal + lottusdonutstp;
                label18.Text = "" + subtotal;
            }
            if (checkBox11.Checked == true)
            {
                richTextBox1.AppendText("Cinnamon donut:\t" + cinnamondonutstp + "L.E" + Environment.NewLine);
                subtotal = subtotal + cinnamondonutstp;
                label18.Text = "" + subtotal;
            }
            if (checkBox6.Checked == true)
            {
                richTextBox1.AppendText("Strawberry donut:\t" + strawberrydonutstp + "L.E" + Environment.NewLine);
                subtotal = subtotal + strawberrydonutstp;
                label18.Text = "" + subtotal;
            }
            if (checkBox19.Checked == true)
            {
                richTextBox1.AppendText("Glazed donut:\t" + glazeddonutstp + "L.E" + Environment.NewLine);
                subtotal = subtotal + glazeddonutstp;
                label18.Text = "" + subtotal;
            }
        }

        double subtotal = 0;
        private void button11_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form4 logout = new Form4();
            logout.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form5 logout = new Form5();
            logout.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 logout = new Form1();
            logout.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form6 logout = new Form6();
            logout.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form7 logout = new Form7();
            logout.Show();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                textBox8.Enabled = true;    
            }
            else
            {
                textBox8.Enabled = false;
                textBox8.Text = "0";
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                textBox2.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
                textBox2.Text = "0";
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                textBox6.Enabled = true;
            }
            else
            {
                textBox6.Enabled = false;
                textBox6.Text = "0";
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                textBox7.Enabled = true;
            }
            else
            {
                textBox7.Enabled = false;
                textBox7.Text = "0";
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true)
            {
                textBox11.Enabled = true;
            }
            else
            {
                textBox11.Enabled = false;
                textBox11.Text = "0";
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                textBox9.Enabled = true;
            }
            else
            {
                textBox9.Enabled = false;
                textBox9.Text = "0";
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                textBox10.Enabled = true;
            }
            else
            {
                textBox10.Enabled = false;
                textBox10.Text = "0";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
                textBox1.Text = "0";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox5.Enabled = true;
            }
            else
            {
                textBox5.Enabled = false;
                textBox5.Text = "0";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox4.Enabled = true;
            }
            else
            {
                textBox4.Enabled = false;
                textBox4.Text = "0";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                textBox3.Enabled = true;
            }
            else
            {
                textBox3.Enabled = false;
                textBox3.Text = "0";
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked == true)
            {
                textBox19.Enabled = true;
            }
            else
            {
                textBox19.Enabled = false;
                textBox19.Text = "0";
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked == true)
            {
                textBox16.Enabled = true;
            }
            else
            {
                textBox16.Enabled = false;
                textBox16.Text = "0";
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {
                textBox15.Enabled = true;
            }
            else
            {
                textBox15.Enabled = false;
                textBox15.Text = "0";
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                textBox12.Enabled = true;
            }
            else
            {
                textBox12.Enabled = false;
                textBox12.Text = "0";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                textBox13.Enabled = true;
            }
            else
            {
                textBox13.Enabled = false;
                textBox13.Text = "0";
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked == true)
            {
                textBox14.Enabled = true;
            }
            else
            {
                textBox14.Enabled = false;
                textBox14.Text = "0";
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
