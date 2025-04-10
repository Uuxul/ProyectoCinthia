using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InventarioDesarrollo
{
    public partial class agregar : Form
    {
        public agregar()
        {
            InitializeComponent();
        }

        private void agregar_Load(object sender, EventArgs e)
        {

        }

        // BOTÓN AGREGAR
        private void button1_Click(object sender, EventArgs e)
        {
            string conexStr = "SERVER=localhost; PORT=3306; DATABASE=desarrollobd; UID=root; PASSWORD=170403;";
            using (MySqlConnection conex = new MySqlConnection(conexStr))
            {
                try
                {
                    conex.Open();

                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO herramientas (nombre, cantidad, descripcion) VALUES (@nombre, @cantidad, @descripcion)", conex))
                    {
                        cmd.Parameters.AddWithValue("@nombre", textBox1.Text);
                        cmd.Parameters.AddWithValue("@cantidad", Convert.ToInt32(textBox2.Text));
                        cmd.Parameters.AddWithValue("@descripcion", textBox3.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro insertado correctamente.");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo insertar el registro.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conex.Close();
                }
            }
        }
    }
}
