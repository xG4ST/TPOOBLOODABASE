using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace LOGIN
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void Banco_Sangre_Button_Click(object sender, EventArgs e)
        {
            Banco_Sangre Form1 = new Banco_Sangre();
            this.Hide();
            Form1.Show();
        }

        private void Min_Nav_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_Nav_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Condiciones_Button_Click(object sender, EventArgs e)
        {
            Condiciones Form5 = new Condiciones();
            this.Hide();
            Form5.Show();
        }

        private void Alta_Donante_Button_Click(object sender, EventArgs e)
        {
            Alta_Donante Form6 = new Alta_Donante();
            this.Hide();
            Form6.Show();
        }

        private void Cita_Button_Click(object sender, EventArgs e)
        {
            Cita Form7 = new Cita();
            this.Hide();
            Form7.Show();
        }

        private void Examen_de_Sangre_Button_Click(object sender, EventArgs e)
        {
            Examen_de_sangre Form8 = new Examen_de_sangre();
            this.Hide();
            Form8.Show();
        }

        private void Departamento_Button_Click(object sender, EventArgs e)
        {
            Departamento Form9 = new Departamento();
            this.Hide();
            Form9.Show();
        }

        private void Estadisticas_Button_Click(object sender, EventArgs e)
        {
            Estadisticas Form10 = new Estadisticas();
            this.Hide();
            Form10.Show();
        }



        private void Buscar_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                string Busqueda = Buscar_TextBox.Text;

                MySqlConnection conexion = new MySqlConnection("server = 127.0.0.1; database = sistemabloodabase; Uid = root; pwd = 2000;");
                conexion.Open();

                string query = "SELECT * FROM donador WHERE nom_don LIKE '%" + Busqueda + "%' OR id_don LIKE '%" + Busqueda + "%'";
                //WHERE nom_don = @Nombre"

                MySqlCommand cmdBus = new MySqlCommand(query, conexion);
                //cmdBus.CommandText = "SELECT * FROM donador WHERE nom_don = @Nombre";
                //cmdBus.Parameters.AddWithValue("@Nombre", Busqueda);
                //cmdBus.Connection = conexion;

                if (String.IsNullOrWhiteSpace(Buscar_TextBox.Text))
                {
                    MessageBox.Show("No puede quedar el campo vacio", "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter(cmdBus);
                    DataSet ds;
                    ds = new DataSet();
                    sda.Fill(ds);

                    Buscar_DataGrid.DataSource = ds.Tables[0];
                    conexion.Close();

                    /*
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    Buscar_DataGrid.DataSource = dt;
                    */
                    //MessageBox.Show("El Donador elegido es: " + Buscar_TextBox.Text);

                    //MessageBox.Show("Donante encontrado", "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //MessageBox.Show("Donante no encontrado", "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                /*
                MySqlDataReader read = cmdBus.ExecuteReader();
                read.Read();
                if(read.Read())
                {
                    Busqueda.Add(read["Nombre"].ToString());
                }
                */

                /*
                while (read.Read())
                {
                    //Busqueda = read.GetString(0);
                    MySqlDataAdapter sda = new MySqlDataAdapter(cmdBus);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    Buscar_DataGrid.DataSource = dt;
                    MessageBox.Show("El Donador elegido es: " + Buscar_TextBox.Text);
                    MessageBox.Show("Si se encontro usuario", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                */

                //conexion.Close();

                //string selec = @"SELECT * FROM donador";

                //MySqlCommand cmdSel = new MySqlCommand(selec, conexion);
                //cmdSel.Parameters.AddWithValue("@Data", Buscar_TextBox.Text);

                /*DataSet ds;
                DataTable dat;
                string selec = @"SELECT * FROM donador WHERE nom_don = 'Buscar_TextBox'";

                MySqlDataAdapter sda = new MySqlDataAdapter(selec, conexion);
                ds = new DataSet("Donador");
                sda.FillSchema(ds, SchemaType, "Donador");
                sda.Fill(ds, "Donador");

                dat = ds.Tables["Donador"];
                Buscar_DataGrid.DataSource = dat;
                */
            }
        }
    }
}
