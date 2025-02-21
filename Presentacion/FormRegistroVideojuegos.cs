using System;
using System.Windows.Forms;
using Proyecto1.Entidades;
using Proyecto1.AccesoDatos;
/**
 *UNED Primer Cuatrimestre 2025
 *Proyecto 1: Gestion de Tiendas de Videojuegos
 *Estudiante: Jaroth Segura Valverde
 * Fecha de entrega: 23 de febrero 2025
 */
namespace Proyecto1.Presentacion
{
    public partial class FormRegistroVideojuegos : Form
    {
        public FormRegistroVideojuegos()
        {
            InitializeComponent();
            btnGuardar.Click += new EventHandler(btnGuardar_Click);
            CargarTiposVideojuegos(); // Cargar tipos de videojuegos en el ComboBox
        }

        //Metodo para cargar los tipos de videojuegos en el ComboBox
        private void CargarTiposVideojuegos()
        {
            cmbTipoVideojuego.Items.Clear();
            foreach (var tipo in Datos.TiposVideojuegos)
            {
                if (tipo != null)
                {
                    cmbTipoVideojuego.Items.Add(tipo.Nombre);
                }
            }
        }
        //metodo para guardar los videojuegos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos no estén vacíos
                if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtNombre.Text) || cmbTipoVideojuego.SelectedIndex == -1 || string.IsNullOrEmpty(txtDesarrollador.Text) || string.IsNullOrEmpty(txtLanzamiento.Text) || cmbFisico.SelectedIndex == -1)
                {
                    MessageBox.Show("Todos los campos son requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar que el Id no esté repetido
                int id = int.Parse(txtId.Text);
                if (ExisteId(id))
                {
                    MessageBox.Show("El ID ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener el tipo de videojuego seleccionado
                string nombreTipo = cmbTipoVideojuego.SelectedItem.ToString();
                TipoVideojuegoEntidad tipoVideojuego = null;
                foreach (var tipo in Datos.TiposVideojuegos)
                {
                    if (tipo != null && tipo.Nombre == nombreTipo)
                    {
                        tipoVideojuego = tipo;
                        break;
                    }
                }

                // Crear el objeto VideojuegoEntidad
                VideojuegoEntidad videojuego = new VideojuegoEntidad
                {
                    Id = id,
                    Nombre = txtNombre.Text,
                    TipoVideojuego = tipoVideojuego,
                    Desarrollador = txtDesarrollador.Text,
                    Lanzamiento = int.Parse(txtLanzamiento.Text),
                    Fisico = cmbFisico.SelectedIndex == 0 // 0: Físico, 1: Virtual
                };

                // Guardar en el arreglo
                bool guardado = GuardarEnArreglo(videojuego);

                if (guardado)
                {
                    MessageBox.Show("Videojuego registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pueden ingresar más registros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El ID y el año de lanzamiento deben ser números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //metodo para verificar si el id ya existe
        private bool ExisteId(int id)
        {
            foreach (var videojuego in Datos.Videojuegos)
            {
                if (videojuego != null && videojuego.Id == id)
                {
                    return true;
                }
            }
            return false;
        }
        //metodo para guardar en el arreglo
        private bool GuardarEnArreglo(VideojuegoEntidad videojuego)
        {
            for (int i = 0; i < Datos.Videojuegos.Length; i++)
            {
                if (Datos.Videojuegos[i] == null)
                {
                    Datos.Videojuegos[i] = videojuego;
                    return true;
                }
            }
            return false;
        }
        //metodo para limpiar campos despues de recibir el input del usuario
        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            cmbTipoVideojuego.SelectedIndex = -1;
            txtDesarrollador.Clear();
            txtLanzamiento.Clear();
            cmbFisico.SelectedIndex = -1;
        }

    }
}