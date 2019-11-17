using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace LOGIN
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }

        private void Log_Load(object sender, EventArgs e)
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

        private void Entrar_Button_Click(object sender, EventArgs e)
        {
            string Usuario = Usuario_TextBox.Text;
            string Contraseña = Contraseña_TextBox.Text;

            MySqlConnection conexion = new MySqlConnection("server = 127.0.0.1; database = sistemabloodabase; Uid = root; pwd = 2000;");
            conexion.Open();

            MySqlCommand login = new MySqlCommand();
            login.CommandText = "SELECT * FROM médico WHERE nom_med = @Usuario AND contraseña_med = @Contraseña";
            login.Parameters.AddWithValue("@Usuario", Usuario);
            login.Parameters.AddWithValue("@Contraseña", Contraseña);
            login.Connection = conexion;

            MySqlDataReader leer = login.ExecuteReader();
            if (leer.Read())
            {
                MessageBox.Show("Bienvenido", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexion.Close();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexion.Close();
            }

            /*
            MySqlConnection conectarse = new MySqlConnection();
            login.Connection = conexion;
            login.CommandText = ("SELECT * FROM médico WHERE nom_med = '" + Usuario_TextBox + "' AND contraseña_med = '" + Contraseña_TextBox + "' ");

            login.CommandText = "SELECT * FROM médico WHERE nom_med = @"

            MySqlDataReader leer = login.ExecuteReader();

            if(leer.Read())
            {
                MessageBox.Show("Bienvenido", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.Close();
            */
        }

        private void Registrarse_Button_Click(object sender, EventArgs e)
        {
            Registro Form2 = new Registro();
            this.Hide();
            Form2.Show();
        }

        private void Usuario_TextBox_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
