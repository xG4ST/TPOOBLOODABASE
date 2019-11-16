using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Close_Nav_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 
        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void Min_Nav_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Max_Nav_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Log Form1 = new Log();
            this.Hide();
            Form1.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Font = new Font("Lato", 15, FontStyle.Regular);
        }
    }
}
