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
    public partial class FormRegistroTiendas : Form
    {
        public FormRegistroTiendas()
        {
            InitializeComponent();
            btnGuardar.Click += new EventHandler(btnGuardar_Click);//asociar evento click del boton guardar
            CargarAdministradores(); // Cargar administradores en el ComboBox
        }
        //metodo para cargar los administradores en el combobox
        private void CargarAdministradores()
        {
            cmbAdministrador.Items.Clear();
            foreach (var admin in Datos.Administradores)
            {
                if (admin != null)
                {
                    cmbAdministrador.Items.Add($"{admin.Nombre} {admin.PrimerApellido} {admin.SegundoApellido}");
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos no estén vacíos
                if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtNombre.Text) || cmbAdministrador.SelectedIndex == -1 || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtTelefono.Text) || cmbActiva.SelectedIndex == -1)
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

                // Obtener el administrador seleccionado
                string nombreCompletoAdmin = cmbAdministrador.SelectedItem.ToString();
                AdministradorEntidad administrador = null;
                foreach (var admin in Datos.Administradores)
                {
                    if (admin != null && $"{admin.Nombre} {admin.PrimerApellido} {admin.SegundoApellido}" == nombreCompletoAdmin)
                    {
                        administrador = admin;
                        break;
                    }
                }

                // Crear el objeto TiendaEntidad
                TiendaEntidad tienda = new TiendaEntidad
                {
                    Id = id,
                    Nombre = txtNombre.Text,
                    Administrador = administrador,
                    Direccion = txtDireccion.Text,
                    Telefono = txtTelefono.Text,
                    Activa = cmbActiva.SelectedIndex == 0 // 0: Sí, 1: No
                };

                // Guardar en el arreglo
                bool guardado = GuardarEnArreglo(tienda);

                if (guardado)
                {
                    MessageBox.Show("Tienda registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ExisteId(int id)
        {
            foreach (var tienda in Datos.Tiendas)
            {
                if (tienda != null && tienda.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        private bool GuardarEnArreglo(TiendaEntidad tienda)
        {
            for (int i = 0; i < Datos.Tiendas.Length; i++)
            {
                if (Datos.Tiendas[i] == null)
                {
                    Datos.Tiendas[i] = tienda;
                    return true; // Registro guardado exitosamente
                }
            }
            return false; // No hay espacio en el arreglo
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            cmbAdministrador.SelectedIndex = -1;
            txtDireccion.Clear();
            txtTelefono.Clear();
            cmbActiva.SelectedIndex = -1;
        }

    }
}