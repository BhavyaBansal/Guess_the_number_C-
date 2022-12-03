using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int randno;
        int count = 1;

       

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            label4.Visible = false;
            textBox1.Visible = false;
            Okbtn.Visible = false;
            Canbtn.Visible = false;
            button2.Visible = false;
            label3.Visible = false;
            button3.Visible = false;
            button5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Visible = true;
            label4.Visible = true;
            textBox1.Visible = true;
            Okbtn.Visible = true;
            Canbtn.Visible = true;
            randno = random.Next(1, 50);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            button3.Visible = true;
            button5.Visible = true;
        }

        private void Canbtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Okbtn_Click(object sender, EventArgs e)
        {
            int input = int.Parse(textBox1.Text);
            if (input == 0)
                return;
            else if (input < randno)
            {
                String message = "Low Number ,Try Again!!";
                MessageBox.Show(message, "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                textBox1.Text = "";
                count += 1;

            }
            else if (input > randno)
            {
                String message = "High Number ,Try Again!!";
                MessageBox.Show(message, "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                textBox1.Text = "";
                count += 1;
            }
            else if (input == randno)
            {
                Console.WriteLine(count);
                MessageBox.Show("You Gussed it! The Number Was " + randno.ToString(), "YOU WON!!");
                MessageBox.Show("It took you " + count.ToString() + " tries.\n", "YOU WON!!");
                button1.Visible = false;
                button2.Visible = true;
                label2.Visible = false;
                label4.Visible = false;
                textBox1.Visible = false;
                Okbtn.Visible = false;
                Canbtn.Visible = false;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            label3.Visible = false;
            button3.Visible = false;
            button5.Visible = false;
            button1.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
