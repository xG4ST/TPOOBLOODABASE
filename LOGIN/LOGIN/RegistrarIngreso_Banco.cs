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
    public partial class RegistrarIngreso_Banco : Form
    {
        public RegistrarIngreso_Banco()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sangre registroSangre  = new Sangre();
            registroSangre.cap_ban = 1200;
            registroSangre.tipomlsangre_ban = CantidadDonada_TextBox.Text.Trim();
            //registroSangre.Departamento_id_dept = 0;
            //registroSangre.Estudio_tipo_est1 = "Estudio de Sangre";

            if (string.IsNullOrEmpty(CantidadDonada_TextBox.Text) || TipoSangre_ComboBox.SelectedItem == null)
            {
                MessageBox.Show("Los campos no pueden quedar vacios", "Registrar Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                registroSangre.tiposangre_don = TipoSangre_ComboBox.SelectedItem.ToString();
                int resultado = RegistrarSangre.agregar(registroSangre);
                if (resultado > 0)
                {
                    MessageBox.Show("Sangre Registrada con Exito!", "Registrar Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RegistrarIngreso_Banco Form1 = new RegistrarIngreso_Banco();
                    this.Hide();
                    Form1.Show();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el ingreso de Sangre", "Registrar Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
