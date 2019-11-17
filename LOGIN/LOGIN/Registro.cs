using LOGIN.Mysql;
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

        private void Registrarse_Button_Click(object sender, EventArgs e)
        {
            CuentaMed nuevaCuenta = new CuentaMed();
            nuevaCuenta.nom_med = Nombre_TextBox.Text.Trim();
            nuevaCuenta.especialidad_med = Especialidad_TextBox.Text.Trim();
            nuevaCuenta.correo_med = Correo_TextBox.Text.Trim();
            nuevaCuenta.contraseña_med = Contraseña_TextBox.Text.Trim();

            int resultado = RegistrarCuentaMed.agregar(nuevaCuenta);
            if (resultado > 0)
            {
                MessageBox.Show("Usuario Registrado con Exito!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Log Form1 = new Log();
                this.Hide();
                Form1.Show();
            }
            else
            {
                MessageBox.Show("No se pudo guardar el Usuario", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
