using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace videogames
{
    public partial class Form1 : Form
    {
        private Actividad actividad;
        private Random random;
        public Form1()
        {
            InitializeComponent();
            actividad = new Actividad();
            random = new Random();
            ActualizarPuntosTotales();

        }

        // Función para cargar la información de la tabla
        public void ActualizarTabla()
        {
            dgvJuegosRegistrados.DataSource = null;
            dgvJuegosRegistrados.DataSource = actividad.Videojuegos
                .Select(x => new 
                { 
                    x.Nombre,
                    x.Victorias,
                    x.Derrotas,
                    x.Puntaje
                }
            ).ToList();
        }

        // Generar el word con la info de la tabla
        public void GenerarReporte()
        {

        }

        // Actualizar Puntos totales
        public void ActualizarPuntosTotales()
        {
            txtPuntajeAcumulado.Text = $"Total: {actividad.PuntosTotales}";
        }

        // Verificar campos

        private bool verificarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombreCrear.Text))
            {
                MessageBox.Show("Debes ingresar un nombre y un marca válido.", "Error en el formulario");
                txtNombreCrear.BackColor = Color.PaleVioletRed;
                return false;
            }

            // Verificar la longitud de los campos
            if (txtNombreCrear.Text.Length < 3 || txtNombreCrear.Text.Length > 25)
            {
                MessageBox.Show("El nombre debe tener entre 3 y 25 caracteres.", "Error en el nombre");
                txtNombreCrear.BackColor = Color.PaleVioletRed;
                return false;
            }

            txtNombreCrear.BackColor = Color.LightGreen;

            return true;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (verificarCampos())
            {
                string nombre = txtNombreCrear.Text;
                var videojuego = new Videojuego(nombre);
                actividad.AgregarVideojuego(videojuego);
                cbSeleccionarJuego.Items.Add(videojuego.Nombre);
                ActualizarTabla();

            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgv_dueno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            int selectedIndex = cbSeleccionarJuego.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un videojuego.", "Error en el selector");
                cbSeleccionarJuego.BackColor = Color.PaleVioletRed;
            }
            cbSeleccionarJuego.BackColor = Color.LightGreen;

            string nombre = cbSeleccionarJuego.SelectedItem.ToString();
            // Logica para el resultado
            bool gano = random.Next(2) == 0;

            if (gano)
            {
                MessageBox.Show("Felicidades a ganado! +100", "Victoria", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Lamentablemente a perdido! -20", "Derrota", MessageBoxButtons.OK);
            }

            actividad.RegistrarPartida(nombre, gano);
            ActualizarTabla();
            ActualizarPuntosTotales();

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("reporte_videojuegos.txt"))
            {
                sw.WriteLine("Reporte de Videojuegos");
                sw.WriteLine("======================");
                sw.WriteLine();

                foreach (var videojuego in actividad.Videojuegos)
                {
                    sw.WriteLine($"Nombre: {videojuego.Nombre}");
                    sw.WriteLine($"Victorias: {videojuego.Victorias}");
                    sw.WriteLine($"Derrotas: {videojuego.Derrotas}");
                    sw.WriteLine($"Puntaje: {videojuego.Puntaje}");
                    sw.WriteLine("----------------------");
                }

                sw.WriteLine();
                sw.WriteLine($"Puntos Totales: {actividad.PuntosTotales}");
            }
        }
    }
}
