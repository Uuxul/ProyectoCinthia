using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InventarioDesarrollo
{
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
            Clave.PasswordChar = '*';
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Login_KeyDown);

        }
        static string conex = "SERVER=localhost; PORT=3306;DATABASE=desarrollobd;UID=root;PASSWORD=170403";

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = Nuser.Text.Trim();
            string clave = Clave.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Por favor, ingrese el usuario y la contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ValidarUsuario(usuario, clave);
        }
        private void ValidarUsuario(string usuario, string clave)
        {
            try
            {
                using (MySqlConnection cn = new MySqlConnection(conex))
                {
                    cn.Open();
                    string query = "SELECT password FROM login WHERE username = @usuario";

                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        object resultado = cmd.ExecuteScalar();

                        if (resultado == null)
                        {
                            MessageBox.Show("El usuario no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string claveCorrecta = resultado.ToString();
                            if (clave == claveCorrecta)
                            {
                                //MessageBox.Show("Inicio de sesión exitoso.", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                Form1 formPrincipal = new Form1();
                                formPrincipal.Show();
                            }
                            else
                            {
                                MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button1.PerformClick(); 
            }
        }
    }
}
