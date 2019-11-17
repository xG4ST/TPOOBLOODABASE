using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOGIN.Mysql;

namespace LOGIN
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }

        private void Log_Load(object sender, EventArgs e)
        {

        }

        private void Close_Nav_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Min_Nav_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Entrar_Button_Click(object sender, EventArgs e)
        {

        }

        private void Registrarse_Button_Click(object sender, EventArgs e)
        {
            Registro Form2 = new Registro();
            this.Hide();
            Form2.Show();
        }
    }
}
