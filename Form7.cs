using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace project_mypet
{
    public partial class Form7 : Form
    {
        private string petName;
        private string petGender;
        private int petAge;
        private string petKind;
        private string petCity;
        private string petImagePath; // Store the path to the pet image

        public Form7()
        {
            InitializeComponent();
        }

        public Form7(string petName, string petGender, int petAge, string petKind, string petCity, string petImagePath)
        : this()
        {
            this.petName = petName;
            this.petGender = petGender;
            this.petAge = petAge;
            this.petKind = petKind;
            this.petCity = petCity;

            // Set label texts with pet information
            label1.Text = $"Name: {petName}";
            label2.Text = $"Gender: {petGender}";
            label3.Text = $"Age: {petAge}";
            label4.Text = $"Kind: {petKind}";
            label5.Text = $"City: {petCity}";
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Display the selected image in the PictureBox
                    petImagePath = openFileDialog.FileName;
                    pictureBox2.ImageLocation = petImagePath;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get pet information from the form
            petName = textBox1.Text;
            petGender = textBox2.Text;
            // Convert age to integer (you can add validation for this)
            if (int.TryParse(textBox3.Text, out int age))
            {
                petAge = age;
            }
            petKind = textBox4.Text;
            petCity = textBox5.Text;

            // Validate that a picture is uploaded
            if (string.IsNullOrEmpty(petImagePath))
            {
                MessageBox.Show("Please upload a picture of the pet.");
                return;
            }

            // "charachter pet" form
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }
    }
    }
