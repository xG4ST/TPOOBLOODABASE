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
    public partial class Departamento : Form
    {
        public Departamento()
        {
            InitializeComponent();
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Banco_Sangre Form4 = new Banco_Sangre();
            this.Hide();
            Form4.Show();
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Condiciones Form5 = new Condiciones();
            this.Hide();
            Form5.Show();
        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Alta_Donante Form7 = new Alta_Donante();
            this.Hide();
            Form7.Show();
        }

        private void BunifuFlatButton5_Click(object sender, EventArgs e)
        {
            Cita Form7 = new Cita();
            this.Hide();
            Form7.Show();
        }

        private void BunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Examen_de_sangre  Form7 = new Examen_de_sangre ();
            this.Hide();
            Form7.Show();
        }

        private void BunifuFlatButton6_Click(object sender, EventArgs e)
        {
            //nada
        }

        private void BunifuFlatButton7_Click(object sender, EventArgs e)
        {
            Estadisticas Form10 = new Estadisticas();
            this.Hide();
            Form10.Show();
        }
    }
}
