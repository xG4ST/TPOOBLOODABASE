using System;
using System.Windows.Forms;
using LOGIN.Mysql;
using MySql.Data.MySqlClient;

namespace LOGIN
{
    public partial class Cita : Form
    {
        public Cita()
        {
            InitializeComponent();
        }

        private void Cita_Load(object sender, EventArgs e)
        {

        }

        private void Max_Nav_Click(object sender, EventArgs e)
        {

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
            Alta_Donante Form5 = new Alta_Donante();
            this.Hide();
            Form5.Show();
        }

        private void BunifuFlatButton5_Click(object sender, EventArgs e)
        {
            //Nada
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

        private void BunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Administrador_Button_Click(object sender, EventArgs e)
        {
            Administrador Form11 = new Administrador();
            this.Hide();
            Form11.Show();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(Buscar_TextBox.Text) || string.IsNullOrEmpty(bunifuMaterialTextbox1.Text) || string.IsNullOrEmpty(bunifuMaterialTextbox2.Text) || string.IsNullOrEmpty(bunifuMaterialTextbox3.Text))
            {
                MessageBox.Show("No puede haber campos vacios", "Registro de cita", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Cita completa!", "Registro de cita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cita Form7 = new Cita();
                this.Hide();
                Form7.Show();
            }
            
            
            /*
            MySqlConnection conexion = new MySqlConnection("server = 127.0.0.1; database = sistemabloodabase; Uid = root; pwd = 2000;");
            conexion.Open();

            string query = @"insert into Donados_has_Estudio1(Donador_iddon1, Estudio_tipo_est1, id_dcita, hora_dcita, nom_don, tel_don, correo_don) values(@IdDonador, @EstudioTipo, @IdCita, @HoraCita, @NombreDon, @TelefonoDon, @CorreoDon)";

            
            MySqlCommand registrodonante = new MySqlCommand(query, conexion);
            registrodonante.Parameters.AddWithValue("@IdDonador", IdDonador);
            registrodonante.Parameters.AddWithValue("@EstudioTipo", EstudioTipo);
            registrodonante.Parameters.AddWithValue("@IdCita", IdCita);
            registrodonante.Parameters.AddWithValue("@HoraCita", HoraCita);
            registrodonante.Parameters.AddWithValue("@TelefonoDon", TelefonoDon);
            registrodonante.Parameters.AddWithValue("@NombreDon", NombreDon);
            registrodonante.Parameters.AddWithValue("@Dirección", Dirección);
            registrodonante.Parameters.AddWithValue("@CorreoDon", CorreoDon);

            registrodonante.ExecuteNonQuery();
            conexion.Close();
            */
        }

        private void RegistrarSalida_Button_Click(object sender, EventArgs e)
        {
            Cita Form7 = new Cita();
            this.Hide();
            Form7.Show();
        }
    }
}
    