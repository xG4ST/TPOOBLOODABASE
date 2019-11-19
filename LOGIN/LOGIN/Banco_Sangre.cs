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
    public partial class Banco_Sangre : Form
    {
        public Banco_Sangre()
        {
            InitializeComponent();
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //Nada
        }
        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Condiciones Form5 = new Condiciones();
            this.Hide();
            Form5.Show();
        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Alta_Donante Form6 = new Alta_Donante();
            this.Hide();
            Form6.Show();
        }

        private void BunifuFlatButton5_Click(object sender, EventArgs e)
        {
            Cita Form7 = new Cita();
            this.Hide();
            Form7.Show();
        }

        private void BunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Examen_de_sangre Form8 = new Examen_de_sangre();
            this.Hide();
            Form8.Show();
        }

        private void BunifuFlatButton6_Click(object sender, EventArgs e)
        {
            Departamento Form9 = new Departamento();
            this.Hide();
            Form9.Show();
        }

        private void BunifuFlatButton7_Click(object sender, EventArgs e)
        {
            Estadisticas Form10 = new Estadisticas();
            this.Hide();
            Form10.Show();
        }

        private void Banco_Sangre_Load(object sender, EventArgs e)
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            Administrador Form3 = new Administrador();
            this.Hide();
            Form3.Show();
        }

        private void RegistrarIngreso_Button_Click(object sender, EventArgs e)
        {
            RegistrarIngreso_Banco Form1 = new RegistrarIngreso_Banco();
            Form1.ShowDialog();
        }

        private void RegistrarSalida_Button_Click(object sender, EventArgs e)
        {
            RegistrarSalida_Banco Form2 = new RegistrarSalida_Banco();
            Form2.ShowDialog();
        }
    }
}
