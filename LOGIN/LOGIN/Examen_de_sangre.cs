﻿using System;
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
    public partial class Examen_de_sangre : Form
    {
        public Examen_de_sangre()
        {
            InitializeComponent();
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void BunifuFlatButton1_Click_1(object sender, EventArgs e)
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
            Alta_Donante  Form7 = new Alta_Donante ();
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
            //Nada
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

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void BunifuFlatButton4_Click_1(object sender, EventArgs e)
        {

        }

        private void BunifuFlatButton6_Click_1(object sender, EventArgs e)
        {
            Departamento Form9 = new Departamento();
            this.Hide();
            Form9.Show();
        }

        private void Administrador_Button_Click(object sender, EventArgs e)
        {
            Administrador Form10 = new Administrador();
            this.Hide();
            Form10.Show();
        }

        private void BunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            Condiciones Form5 = new Condiciones();
            this.Hide();
            Form5.Show();
        }

        private void BunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            Alta_Donante Form6 = new Alta_Donante();
            this.Hide();
            Form6.Show();
        }

        private void BunifuFlatButton5_Click_1(object sender, EventArgs e)
        {
            Cita Form7 = new Cita();
            this.Hide();
            Form7.Show();
        }

        private void BunifuFlatButton7_Click_1(object sender, EventArgs e)
        {
            Estadisticas Form10 = new Estadisticas();
            this.Hide();
            Form10.Show();
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
