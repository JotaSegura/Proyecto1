using System;
using System.Linq;
using System.Windows.Forms;
using Proyecto1.Entidades;
using Proyecto1.AccesoDatos;

namespace Proyecto1.Presentacion
{
    public partial class FormRegistroInventario : Form
    {
        public FormRegistroInventario()
        {
            InitializeComponent();
            btnGuardar.Click += new EventHandler(btnGuardar_Click);
            CargarTiendas(); // Cargar tiendas en el ComboBox
            CargarVideojuegos(); // Cargar videojuegos en el DataGridView
        }

        private void CargarTiendas()
        {
            cmbTienda.Items.Clear();
            foreach (var tienda in Datos.Tiendas)
            {
                if (tienda != null && tienda.Activa) // Solo mostrar tiendas activas
                {
                    cmbTienda.Items.Add(tienda.Nombre);
                }
            }
        }

        private void CargarVideojuegos()
        {
            dgvVideojuegos.Rows.Clear();
            foreach (var videojuego in Datos.Videojuegos)
            {
                if (videojuego != null && videojuego.Fisico) // Solo mostrar videojuegos físicos
                {
                    dgvVideojuegos.Rows.Add(videojuego.Id, videojuego.Nombre, videojuego.TipoVideojuego.Nombre, videojuego.Desarrollador, videojuego.Lanzamiento);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos no estén vacíos
                if (cmbTienda.SelectedIndex == -1 || dgvVideojuegos.SelectedRows.Count == 0 || string.IsNullOrEmpty(txtExistencias.Text))
                {
                    MessageBox.Show("Todos los campos son requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar que la cantidad de existencias sea mayor a cero
                int existencias = int.Parse(txtExistencias.Text);
                if (existencias <= 0)
                {
                    MessageBox.Show("La cantidad de existencias debe ser mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener la tienda seleccionada
                string nombreTienda = cmbTienda.SelectedItem.ToString();
                TiendaEntidad tienda = null;
                foreach (var t in Datos.Tiendas)
                {
                    if (t != null && t.Nombre == nombreTienda)
                    {
                        tienda = t;
                        break;
                    }
                }

                // Obtener el videojuego seleccionado
                int idVideojuego = (int)dgvVideojuegos.SelectedRows[0].Cells[0].Value;
                VideojuegoEntidad videojuego = null;
                foreach (var v in Datos.Videojuegos)
                {
                    if (v != null && v.Id == idVideojuego)
                    {
                        videojuego = v;
                        break;
                    }
                }

                // Validar que no exista ya una asociación entre la tienda y el videojuego
                if (ExisteAsociacion(tienda, videojuego))
                {
                    MessageBox.Show("Este videojuego ya está asociado a la tienda seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear el objeto VideojuegosXTiendaEntidad
                VideojuegosXTiendaEntidad inventario = new VideojuegosXTiendaEntidad
                {
                    Tienda = tienda,
                    Videojuego = videojuego,
                    Existencias = existencias
                };

                // Guardar en el arreglo
                bool guardado = GuardarEnArreglo(inventario);

                if (guardado)
                {
                    MessageBox.Show("Inventario registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    MostrarDatosEnMessageBox(); // Mostrar los datos después de guardar
                }
                else
                {
                    MessageBox.Show("No se pueden ingresar más registros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("La cantidad de existencias debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ExisteAsociacion(TiendaEntidad tienda, VideojuegoEntidad videojuego)
        {
            foreach (var inv in Datos.Inventario)
            {
                if (inv != null && inv.Tienda == tienda && inv.Videojuego == videojuego)
                {
                    return true;
                }
            }
            return false;
        }

        private bool GuardarEnArreglo(VideojuegosXTiendaEntidad inventario)
        {
            for (int i = 0; i < Datos.Inventario.Length; i++)
            {
                if (Datos.Inventario[i] == null)
                {
                    Datos.Inventario[i] = inventario;
                    return true; // Registro guardado exitosamente
                }
            }
            return false; // No hay espacio en el arreglo
        }

        private void LimpiarCampos()
        {
            cmbTienda.SelectedIndex = -1;
            dgvVideojuegos.ClearSelection();
            txtExistencias.Clear();
        }

        private void MostrarDatosEnMessageBox()
        {
            string datos = "Inventario almacenado:\n";

            foreach (var inv in Datos.Inventario)
            {
                if (inv != null)
                {
                    datos += $"Tienda: {inv.Tienda.Nombre}, Videojuego: {inv.Videojuego.Nombre}, Existencias: {inv.Existencias}\n";
                }
            }

            MessageBox.Show(datos, "Datos Almacenados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            MostrarDatosEnMessageBox(); // Mostrar los datos al hacer clic en el botón
        }
    }
}