using LOGIN.Mysql;
using MySql.Data.MySqlClient;
using System;
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
            int Id = 0;
            string Nombre = Nombre_TextBox.Text;
            string Sexo = ""; //Radio Button If
            if (Hombre_RadioButton.Checked)
            {
                Sexo = "H";
            }
            else
            {

            }
            if (Mujer_RadioButton.Checked)
            {
                Sexo = "M";
            }
            else
            {

            }
            if (Otro_RadioButton.Checked)
            {
                Sexo = "O";
            }
            else
            {

            }
            string Edad = Edad_TextBox.Text;
            string Teléfono = Teléfono_TextBox.Text;
            string Sangre = "";
            if (TipoSangre_ComboBox.SelectedItem == null)
            {
                MessageBox.Show("Los campos no pueden quedar vacios", "Registrar Donante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Sangre = TipoSangre_ComboBox.SelectedItem.ToString();
            }

            /*
            string Fecha = Fecha_TimePicker.Text;
            Fecha_TimePicker.Format = DateTimePickerFormat.Custom;
            */

            string Fecha = Fecha_TimePicker.Value.ToString("yyyy-MM-dd");

            //MessageBox.Show("Bienvenido" + Fecha, "Log In", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string Dirección = Dirección_TextBox.Text;
            string Estado = "Nada";
            string Ciudad = "Nada";
            string Correo = Correo_TextBox.Text;

            if (string.IsNullOrEmpty(Nombre_TextBox.Text) || string.IsNullOrEmpty(Sexo) || string.IsNullOrEmpty(Edad_TextBox.Text) || string.IsNullOrEmpty(Teléfono_TextBox.Text) || string.IsNullOrEmpty(Fecha) || string.IsNullOrEmpty(Dirección_TextBox.Text) || string.IsNullOrEmpty(Correo_TextBox.Text))
            {
                MessageBox.Show("Los campos no pueden quedar vacios", "Registro del Donante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*else
            {
                MySqlConnection conexion = new MySqlConnection("server = 127.0.0.1; database = sistemabloodabase; Uid = root; pwd = 2000;");
                conexion.Open();
            }
            */
            else
            {
                MySqlConnection conexion = new MySqlConnection("server = 127.0.0.1; database = sistemabloodabase; Uid = root; pwd = 2000;");
                conexion.Open();

                string query = @"insert into donador(id_don, nom_don, sexo_don, edad_don, tel_don, tiposangre_don, fechanac_don, dir_don, estado_don, ciudad_don, correo_don) values(@Id, @Nombre, @Sexo, @Edad, @Teléfono, @Sangre, @Fecha, @Dirección, @Estado, @Ciudad, @Correo)";

                MySqlCommand registrodonante = new MySqlCommand(query, conexion);
                registrodonante.Parameters.AddWithValue("@Id", Id);
                registrodonante.Parameters.AddWithValue("@Nombre", Nombre);
                registrodonante.Parameters.AddWithValue("@Sexo", Sexo);
                registrodonante.Parameters.AddWithValue("@Edad", Edad);
                registrodonante.Parameters.AddWithValue("@Teléfono", Teléfono);
                registrodonante.Parameters.AddWithValue("@Sangre", Sangre);
                registrodonante.Parameters.AddWithValue("@Fecha", Fecha);
                registrodonante.Parameters.AddWithValue("@Dirección", Dirección);
                registrodonante.Parameters.AddWithValue("@Estado", Estado);
                registrodonante.Parameters.AddWithValue("@Ciudad", Ciudad);
                registrodonante.Parameters.AddWithValue("@Correo", Correo);

                registrodonante.ExecuteNonQuery();
                MessageBox.Show("Registro Exitoso");
                conexion.Close();






                /*int resultado = RegistrarDonante.agregar(nuevaCuentaDon);
                if (resultado > 0)
                {
                    MessageBox.Show("Donante Registrado con Exito!", "Registro del Donante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Alta_Donante Form6 = new Alta_Donante();
                    this.Hide();
                    Form6.Show();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el Usuario", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                */
            }


            /*CuentaDon nuevaCuentaDon = new CuentaDon();
            nuevaCuentaDon.nom_don = Nombre;
            nuevaCuentaDon.sexo_don = Sexo;
            nuevaCuentaDon.edad_don = Edad;
            nuevaCuentaDon.tel_don = Teléfono;
            nuevaCuentaDon.fechanac_don = Fecha;
            nuevaCuentaDon.dir_don = Dirección;
            nuevaCuentaDon.estado_don = Estado;
            nuevaCuentaDon.ciudad_don = Ciudad;
            nuevaCuentaDon.correo_don = Correo;
            */

        }

    }
}
