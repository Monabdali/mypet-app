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
    public partial class Form2 : Form
    {
        private const string CorrectUsername = "adopter";
        private const string CorrectPassword = "petmi321";
        private int loginAttempts = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Increment the login attempts
            loginAttempts++;

            // Validate the username and password
            if (ValidateCredentials())
            {
                MessageBox.Show("Login successful!");

                // Form4 is "Subscribe" form
                Form4 form4 = new Form4();
                form4.Show();
                this.Hide();
            }
            else
            {
                // Failed login
                label2.Text = $"Attempts Left: {3 - loginAttempts}";

                if (loginAttempts >= 3)
                {
                    MessageBox.Show("Sorry, we can't log you in. Please contact us!");
                    this.Close();
                }
            }
        }
        private bool ValidateCredentials()
        {
            string enteredUsername = textBox1.Text;
            string enteredPassword = textBox2.Text;

            // Check if the username has at least 4 digits
            if (enteredUsername.Length < 4)
            {
                MessageBox.Show("Username must have at least 4 digits.");
                return false;
            }

            // Check if the password is correct
            if (enteredPassword != CorrectPassword)
            {
                MessageBox.Show("Incorrect password.");
                return false;
            }

            // Check if the username is correct
            if (enteredUsername != CorrectUsername)
            {
                MessageBox.Show("Incorrect username.");
                return false;
            }

            // Both username and password are correct
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();

            this.Hide();

        }
    }
}
