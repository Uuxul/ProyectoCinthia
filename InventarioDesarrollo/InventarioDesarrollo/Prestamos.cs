using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InventarioDesarrollo
{
    public partial class Prestamos : Form
    {
        public Prestamos()
        {
            InitializeComponent();
        }
        //private static string conex = "SERVER=localhost; PORT=3306;DATABASE=desarrollobd;UID=root;PASSWORD=170403";

        static string conex = "SERVER=localhost; PORT=3306;DATABASE=desarrollobd;UID=root;PASSWORD=170403";

        private void Prestamos_Load(object sender, EventArgs e)
        {
            lista();

            lista2();

        }

        private void lista()
        {
            using (MySqlConnection cn = new MySqlConnection(conex))
            {
                try
                {
                    cn.Open();
                    using (MySqlDataAdapter dato = new MySqlDataAdapter("SELECT * FROM prestamos", cn))
                    {
                        DataTable dt = new DataTable();
                        dato.Fill(dt);
                        prestamos_data.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void lista2()
        {
            using (MySqlConnection cn = new MySqlConnection(conex))
            {
                try
                {
                    cn.Open();
                    using (MySqlDataAdapter dato = new MySqlDataAdapter("SELECT id, nombre , cantidad FROM herramientas", cn))
                    {
                        DataTable dt = new DataTable();
                        dato.Fill(dt);
                        herramientasdb.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }



        private void btnPrestar_Click(object sender, EventArgs e)
        {
        }

        private void prestamos_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar si los campos obligatorios están llenos
            if (string.IsNullOrWhiteSpace(txtIdHerramienta.Text) ||
                string.IsNullOrWhiteSpace(txtUsuarioAsignado.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar si los valores ingresados son números válidos
            if (!int.TryParse(txtIdHerramienta.Text, out int idHerramienta) ||
                !int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("El ID de la herramienta y la cantidad deben ser números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection cn = new MySqlConnection(conex))
            {
                try
                {
                    cn.Open();

                    // Obtener la cantidad total de herramientas disponibles
                    string queryCantidad = "SELECT cantidad FROM herramientas WHERE id = @id_herramienta";
                    using (MySqlCommand cmdCantidad = new MySqlCommand(queryCantidad, cn))
                    {
                        cmdCantidad.Parameters.AddWithValue("@id_herramienta", idHerramienta);
                        object cantidadDisponible = cmdCantidad.ExecuteScalar();

                        if (cantidadDisponible == null)
                        {
                            MessageBox.Show("La herramienta no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        int totalDisponible = Convert.ToInt32(cantidadDisponible);

                        // Obtener la cantidad de herramientas prestadas actualmente
                        string queryPrestadas = "SELECT SUM(cantidad) FROM prestamos WHERE id_herramienta = @id_herramienta AND estado = 'En Uso'";
                        using (MySqlCommand cmdPrestadas = new MySqlCommand(queryPrestadas, cn))
                        {
                            cmdPrestadas.Parameters.AddWithValue("@id_herramienta", idHerramienta);
                            object prestadas = cmdPrestadas.ExecuteScalar();
                            int totalPrestadas = prestadas != DBNull.Value ? Convert.ToInt32(prestadas) : 0;

                            // Verificar si hay suficientes herramientas disponibles
                            if (totalDisponible - totalPrestadas < cantidad)
                            {
                                MessageBox.Show("No hay suficientes herramientas disponibles para prestar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }

                    // Registrar el préstamo
                    string query = "INSERT INTO prestamos (id_herramienta, usuario_asignado, cantidad) VALUES (@id_herramienta, @usuario_asignado, @cantidad)";
                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@id_herramienta", idHerramienta);
                        cmd.Parameters.AddWithValue("@usuario_asignado", txtUsuarioAsignado.Text.Trim());
                        cmd.Parameters.AddWithValue("@cantidad", cantidad);

                        int resultado = cmd.ExecuteNonQuery();
                        if (resultado > 0)
                        {
                            MessageBox.Show("Préstamo registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtIdHerramienta.Clear();
                            txtUsuarioAsignado.Clear();
                            txtCantidad.Clear();
                            lista(); // Refrescar la tabla después de insertar
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar el préstamo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        //este metodo no se toca ya devulve sin problema unicamente seleccionando 
        //la casilla que quieres!
        private void button2_Click(object sender, EventArgs e)
        {
            if (prestamos_data.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un préstamo para marcarlo como devuelto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idPrestamo = Convert.ToInt32(prestamos_data.SelectedRows[0].Cells["id_prestamo"].Value);

            using (MySqlConnection cn = new MySqlConnection(conex))
            {
                try
                {
                    cn.Open();
                    string query = "UPDATE prestamos SET hora_entrada = NOW(), estado = 'Devuelta' WHERE id_prestamo = @id_prestamo";

                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@id_prestamo", idPrestamo);
                        int resultado = cmd.ExecuteNonQuery();

                        if (resultado > 0)
                        {
                            MessageBox.Show("Préstamo marcado como devuelto.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lista(); 
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el préstamo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}