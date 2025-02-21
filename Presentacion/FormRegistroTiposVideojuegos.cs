using System;
using System.Windows.Forms;
using Proyecto1.Entidades;
using Proyecto1.AccesoDatos;

namespace Proyecto1.Presentacion
{
    public partial class FormRegistroTiposVideojuegos : Form
    {
        public FormRegistroTiposVideojuegos()
        {
            InitializeComponent();
            btnGuardar.Click += new EventHandler(btnGuardar_Click); // Asegúrate de que el evento esté asociado
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos no estén vacíos
                if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDescripcion.Text))
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

                // Crear el objeto TipoVideojuegoEntidad
                TipoVideojuegoEntidad tipoVideojuego = new TipoVideojuegoEntidad
                {
                    Id = id,
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text
                };

                // Guardar en el arreglo
                bool guardado = GuardarEnArreglo(tipoVideojuego);

                if (guardado)
                {
                    MessageBox.Show("Tipo de videojuego registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    
                }
                else
                {
                    MessageBox.Show("No se pueden ingresar más registros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El ID debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ExisteId(int id)
        {
            // Verificar si el Id ya existe en el arreglo
            foreach (var tipo in Datos.TiposVideojuegos)
            {
                if (tipo != null && tipo.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        private bool GuardarEnArreglo(TipoVideojuegoEntidad tipoVideojuego)
        {
            // Buscar una posición vacía en el arreglo
            for (int i = 0; i < Datos.TiposVideojuegos.Length; i++)
            {
                if (Datos.TiposVideojuegos[i] == null)
                {
                    Datos.TiposVideojuegos[i] = tipoVideojuego;
                    return true; // Registro guardado exitosamente
                }
            }
            return false; // No hay espacio en el arreglo
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
        }


    }
}
