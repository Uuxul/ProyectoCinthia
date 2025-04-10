using System;
using System.Data;
using System.Windows.Forms;
using ClosedXML.Excel;
using MySql.Data.MySqlClient;

namespace InventarioDesarrollo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string conex = "SERVER=localhost; PORT=3306;DATABASE=desarrollobd;UID=root;PASSWORD=170403";
        MySqlConnection cn = new MySqlConnection(conex);

        private void Form1_Load(object sender, EventArgs e)
        {
            lista();
        }

        private void lista()
        {
            try
            {
                cn.Open();
                using (MySqlDataAdapter dato = new MySqlDataAdapter("SELECT * FROM herramientas", cn))
                {
                    DataTable dt = new DataTable();
                    dato.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void buscador()
        {
            try
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
                cn.Open();

                string query = string.IsNullOrWhiteSpace(textBox1.Text)
                    ? "SELECT * FROM herramientas"
                    : "SELECT * FROM herramientas WHERE nombre LIKE @nombre";

                using (MySqlCommand cmd = new MySqlCommand(query, cn))
                {
                    if (!string.IsNullOrWhiteSpace(textBox1.Text))
                    {
                        cmd.Parameters.AddWithValue("@nombre", "%" + textBox1.Text + "%");
                    }

                    using (MySqlDataAdapter dato = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        dato.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        // BOTÓN AGREGAR
        private void button1_Click(object sender, EventArgs e)
        {
            agregar xd = new agregar();
            xd.FormClosed += (s, args) => lista();
            xd.Show();
        }

        // BOTÓN BUSCAR
        private void button2_Click(object sender, EventArgs e)
        {
        }

        // BOTÓN ACTUALIZAR
        private void button3_Click(object sender, EventArgs e)
        {
            actualizar at = new actualizar();
            at.FormClosed += (s, args) => lista();
            at.Show();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                buscador();
            }
        }

        private void Bt_bORRAR_Click(object sender, EventArgs e)
        {
            borrarRegistro();
        }

        private void borrarRegistro()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string nombre = dataGridView1.SelectedRows[0].Cells["nombre"].Value.ToString();

                DialogResult confirm = MessageBox.Show($"¿Seguro que quieres eliminar '{nombre}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                       
                        using (MySqlConnection cn = new MySqlConnection(conex))
                        {
                            
                            if (cn.State == ConnectionState.Closed)
                                cn.Open();

                            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM herramientas WHERE nombre = @nombre", cn))
                            {
                                cmd.Parameters.AddWithValue("@nombre", nombre);
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Registro eliminado correctamente.");
                                    lista(); 
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo eliminar el registro.");
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
            else
            {
                MessageBox.Show("Selecciona un registro para eliminar.");
            }
        }

        private void Grafica_Click(object sender, EventArgs e)
        {
            // agregar xd = new agregar();
            // xd.FormClosed += (s, args) => lista();
            // xd.Show();

            grafica xs = new grafica();
            xs.FormClosed += (s, args) => lista();
            xs.Show();
        }

        private void EXCEL_Click(object sender, EventArgs e)
        {
            ExportarDatosAExcel();

        }

        private void ExportarDatosAExcel()
        {
            try
            {
                using (MySqlConnection cn = new MySqlConnection(conex))
                {
                    cn.Open();
                    string query = "SELECT * FROM herramientas";
                    MySqlCommand cmd = new MySqlCommand(query, cn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    cn.Close();

                    if (dt.Rows.Count > 0)
                    {
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            wb.Worksheets.Add(dt, "Inventario");

                            SaveFileDialog saveFileDialog = new SaveFileDialog();
                            saveFileDialog.Filter = "Excel Files|*.xlsx";
                            saveFileDialog.Title = "Guardar archivo Excel";
                            saveFileDialog.FileName = "Inventario.xlsx";

                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                wb.SaveAs(saveFileDialog.FileName);
                                MessageBox.Show("Datos exportados con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay datos para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Prestamos ps = new Prestamos();
            ps.FormClosed += (s, args) => lista();
            ps.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
