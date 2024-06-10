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
    public partial class Form4 : Form
    {
        private const decimal BaseSubscriptionCost = 76m;
        private const decimal AdditionalSubscriptionCost = 22m;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSubscriptionCost();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSubscriptionCost();
        }

        private void UpdateSubscriptionCost()
        {
            decimal subscriptionCost = BaseSubscriptionCost;

            if (checkBox1.Checked)
            {
                subscriptionCost += AdditionalSubscriptionCost;
            }

            if (checkBox2.Checked)
            {
                subscriptionCost += AdditionalSubscriptionCost;
            }

            // Update the UI with the calculated cost
            textBox1.Text = $"Subscription Cost: {subscriptionCost} SR";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Confirmed! Subscription Cost: {textBox1.Text}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Form6 is "put for doption" form
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }
    }
}
