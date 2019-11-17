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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void Banco_Sangre_Button_Click(object sender, EventArgs e)
        {
            Banco_Sangre Form1 = new Banco_Sangre();
            this.Hide();
            Form1.Show();
        }

        private void Min_Nav_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_Nav_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Condiciones_Button_Click(object sender, EventArgs e)
        {
            Condiciones Form5 = new Condiciones();
            this.Hide();
            Form5.Show();
        }

        private void Alta_Donante_Button_Click(object sender, EventArgs e)
        {
            Alta_Donante Form6 = new Alta_Donante();
            this.Hide();
            Form6.Show();
        }

        private void Cita_Button_Click(object sender, EventArgs e)
        {
            Cita Form7 = new Cita();
            this.Hide();
            Form7.Show();
        }

        private void Examen_de_Sangre_Button_Click(object sender, EventArgs e)
        {
            Examen_de_sangre Form8 = new Examen_de_sangre();
            this.Hide();
            Form8.Show();
        }

        private void Departamento_Button_Click(object sender, EventArgs e)
        {
            Departamento Form9 = new Departamento();
            this.Hide();
            Form9.Show();
        }

        private void Estadisticas_Button_Click(object sender, EventArgs e)
        {
            Estadisticas Form10 = new Estadisticas();
            this.Hide();
            Form10.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
