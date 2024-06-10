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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Form7 "put pet info" form
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Form8 "pet charachterstics" screen pets
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
