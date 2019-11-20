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
    public partial class RegistrarSalida_Banco : Form
    {
        public RegistrarSalida_Banco()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Edad_TextBox.Text) || comboBox1.SelectedItem == null || TipoSangre_ComboBox.SelectedItem == null)
            {
                MessageBox.Show("Los campos no pueden quedar vacios", "Registrar Salida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Salida de Sangre Registrada con Exito!", "Registrar Salida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
