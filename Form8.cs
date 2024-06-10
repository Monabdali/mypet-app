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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if one radio button is selected in each group
            if (IsOneRadioButtonSelected(groupBox1) &&
                IsOneRadioButtonSelected(groupBox2) &&
                IsOneRadioButtonSelected(groupBox3))
            {
                // Display the selected choices in label2
                label3.Text = $"Choices: {GetSelectedRadioButtonText(groupBox1)}, " +
                              $"{GetSelectedRadioButtonText(groupBox2)}, " +
                              $"{GetSelectedRadioButtonText(groupBox3)}";

                // Form9 is "Home" Form
                Form9 form9 = new Form9();
                form9.Show();
                this.Hide();

            }
            else
            {
                // Display an error message if not all groups have a selected radio button
                label3.Text = "Please select one option from each group.";
            }
        }

        private bool IsOneRadioButtonSelected(GroupBox groupBox)
        {
            return groupBox.Controls.OfType<RadioButton>().Count(rb => rb.Checked) == 1;
        }

        // Helper method to get the text of the selected radio button in a group
        private string GetSelectedRadioButtonText(GroupBox groupBox)
        {
            return groupBox.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked)?.Text ?? "";
        }
    }
}
