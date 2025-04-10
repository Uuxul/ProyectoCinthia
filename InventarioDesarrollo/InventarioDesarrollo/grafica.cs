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
using System.Windows.Forms.DataVisualization.Charting;

namespace InventarioDesarrollo
{
    public partial class grafica : Form
    {
        public grafica()
        {
            InitializeComponent();
        }
        static string conexxion = "SERVER= localhost; PORT=3306;DATABASE=desarrollobd;UID=root;PASSWORD=170403";
        MySqlConnection cn = new MySqlConnection(conexxion);

        private void grafica_Load(object sender, EventArgs e)
        {
            // agregar xd = new agregar();
            // xd.FormClosed += (s, args) => lista();
            // xd.Show();
            CargarDatosEnGrafica();

        }
        private void CargarDatosEnGrafica()
        {
            try
            {
                cn.Open();
                string query = "SELECT nombre, cantidad FROM herramientas"; 
                MySqlCommand cmd = new MySqlCommand(query, cn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cn.Close();

            
                chart1.Series.Clear();
                Series serie = new Series("Inventario");
                serie.ChartType = SeriesChartType.Column; 

             
                foreach (DataRow row in dt.Rows)
                {
                    serie.Points.AddXY(row["nombre"].ToString(), Convert.ToInt32(row["cantidad"]));
                }

                chart1.Series.Add(serie);


                //chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -90; 
                //chart1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 10, FontStyle.Bold); 
                //chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.Red; 
                //chart1.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                //chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.DarkBlue;

                chart1.ChartAreas[0].AxisX.Interval = 1; // Asegura que se muestren todas las etiquetas
                chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -90; // Reduce el ángulo para mejorar visibilidad
                chart1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Fuente más pequeña
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la gráfica: " + ex.Message);
            }


        }
    }
}
