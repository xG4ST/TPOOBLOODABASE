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
    public partial class Alta_Donante : Form
    {
        public Alta_Donante()
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
            //nada
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

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Alta_Donante Form6 = new Alta_Donante();
            this.Hide();
            Form6.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            string Nombre = Nombre_TextBox.Text;
            string Sexo = ""; //Radio Button If
            if (Hombre_RadioButton.Checked)
            {
                Sexo = "Hombre";
            }
            else
            {

            }
            if(Mujer_RadioButton.Checked)
            {
                Sexo = "Mujer";
            }
            else
            {

            }
            if (Otro_RadioButton.Checked)
            {
                Sexo = "Otro";
            }
            else
            {

            }
            string Edad = Edad_TextBox.Text;
            string Teléfono = Teléfono_TextBox.Text;
            if (TipoSangre_ComboBox.SelectedItem == null)
            {
                MessageBox.Show("Los campos no pueden quedar vacios", "Registrar Donante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string Sangre = TipoSangre_ComboBox.SelectedItem.ToString();
            }
            string Fecha = Fecha_TimePicker.Text;
            Fecha_TimePicker.Format = DateTimePickerFormat.Custom;
            //MessageBox.Show("Bienvenido" + Fecha, "Log In", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string Dirección = Dirección_TextBox.Text;
            string Correo = Correo_TextBox.Text;

            if (string.IsNullOrEmpty(Nombre_TextBox.Text) || string.IsNullOrEmpty(Sexo) || string.IsNullOrEmpty(Edad_TextBox.Text) || string.IsNullOrEmpty(Teléfono_TextBox.Text) || string.IsNullOrEmpty(Fecha) || string.IsNullOrEmpty(Dirección_TextBox.Text) || string.IsNullOrEmpty(Correo_TextBox.Text))
            {
                MessageBox.Show("Los campos no pueden quedar vacios", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
