using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LOGIN
{
    public partial class Estadisticas : Form
    {
        public Estadisticas()
        {
            InitializeComponent();
        }

       
        private void BunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            Banco_Sangre Form4 = new Banco_Sangre();
            this.Hide();
            Form4.Show();
        }

        private void Administrador_Button_Click(object sender, EventArgs e)
        {
            Administrador Form3 = new Administrador();
            this.Hide();
            Form3.Show();
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
            //nada
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            string[] Sangre = { "O+", "O-", "A+", "A-", "B+", "B-", "AB+", "AB-" };
            int[] Cantidad = { 89, 74, 49, 55, 42, 15, 34, 16 };
            string[] Meses = { "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            //chart1.Palette = ChartColorPalette.Chocolate;

            chart1.Titles.Add("Donación por mes");

            for (int i = 0; i < Sangre.Length; i++)
            {
                Series sangre = chart1.Series.Add(Sangre[i]);

                sangre.Label = Cantidad[i].ToString();

                sangre.Points.Add(Cantidad[i]);
            }
        }
    }
}
