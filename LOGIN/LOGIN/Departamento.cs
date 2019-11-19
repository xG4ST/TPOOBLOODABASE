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

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void BunifuFlatButton6_Click_1(object sender, EventArgs e)
        {
        //nada
        }

        private void BunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            Banco_Sangre Form3 = new Banco_Sangre();
            this.Hide();
            Form3.Show();
        }

        private void Administrador_Button_Click(object sender, EventArgs e)
        {
            Administrador Form3 = new Administrador();
            this.Hide();
            Form3.Show();
        }

        private void BunifuFlatButton4_Click_1(object sender, EventArgs e)
        {
            Examen_de_sangre Form7 = new Examen_de_sangre();
            this.Hide();
            Form7.Show();
        }

        private void BunifuFlatButton5_Click_1(object sender, EventArgs e)
        {
            Cita Form7 = new Cita();
            this.Hide();
            Form7.Show();
        }

        private void BunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            Alta_Donante Form7 = new Alta_Donante();
            this.Hide();
            Form7.Show();
        }

        private void BunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            Condiciones Form5 = new Condiciones();
            this.Hide();
            Form5.Show();
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
