using LOGIN.Mysql;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

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
            Sangre registroSangre = new Sangre();
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

        private void RegistrarIngreso_Banco_Load(object sender, EventArgs e)
        {

        }


        //En construcción
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server = 127.0.0.1; database = sistemabloodabase; Uid = root; pwd = 2000;");

            string query = @"SELECT id_don, nom_don* FROM Donador";

            MySqlCommand cmd = new MySqlCommand(query, conexion);
            conexion.Open();

            //SeleccionarDonador_ComboBox.Items.Add(leer[0]);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet(); //
            sda.Fill(ds, "Donador");

            SeleccionarDonador_ComboBox.ValueMember = "id_don";
            SeleccionarDonador_ComboBox.DisplayMember = "nom_don";
            SeleccionarDonador_ComboBox.DataSource = ds.Tables[0];

            conexion.Close();
        }
    }
}
