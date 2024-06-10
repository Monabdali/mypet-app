using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_mypet
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != String.Empty) &&
               (textBox3.Text != String.Empty) &&
               (textBox3.Text != String.Empty))
            {

                if ((textBox2.Text != textBox3.Text))
                {
                    MessageBox.Show("The password doesn't match");
                    textBox2.Clear();
                    textBox3.Clear();
                }
                else
                {
                    MessageBox.Show("The acc has been created");
                    Form4 form4 = new Form4();
                    form4.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("The fields can't be empty");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Form2 is "Log in" form
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Form5 is the "Send Email" form
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }
    }
}
