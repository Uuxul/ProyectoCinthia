using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InventarioDesarrollo
{
    public partial class actualizar : Form
    {
        private string conexStr = "SERVER=localhost; PORT=3306; DATABASE=desarrollobd; UID=root; PASSWORD=170403;";

        public actualizar()
        {
            InitializeComponent();
        }

        // BOTÓN BUSCAR
        private void button1_Click(object sender, EventArgs e)
        {
            buscador();
        }

        public void buscador()
        {
            using (MySqlConnection conex = new MySqlConnection(conexStr))
            {
                try
                {
                    conex.Open();

                    using (MySqlCommand cmd = new MySqlCommand("SELECT nombre, cantidad, descripcion FROM herramientas WHERE nombre = @nombre", conex))
                    {
                        cmd.Parameters.AddWithValue("@nombre", textBox1.Text);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Verifica si se encontró algún registro
                            {
                                textBox1.Text = reader["nombre"].ToString();
                                textBox2.Text = reader["cantidad"].ToString();
                                textBox3.Text = reader["descripcion"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el registro.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // BOTÓN ACTUALIZAR
        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conex = new MySqlConnection(conexStr))
            {
                try
                {
                    conex.Open();

                    using (MySqlCommand cmd = new MySqlCommand("UPDATE herramientas SET cantidad=@cantidad, descripcion=@descripcion WHERE nombre=@nombre;", conex))
                    {
                        cmd.Parameters.AddWithValue("@nombre", textBox1.Text);
                        cmd.Parameters.AddWithValue("@cantidad", Convert.ToInt32(textBox2.Text));
                        cmd.Parameters.AddWithValue("@descripcion", textBox3.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro actualizado correctamente.");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el registro.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // BUSCAR AL PRESIONAR ENTER
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita que el Enter provoque un comportamiento extraño en los TextBox
                buscador();
            }
        }

        private void actualizar_Load(object sender, EventArgs e)
        {

        }
    }
}
