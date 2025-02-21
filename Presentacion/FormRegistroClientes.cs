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
    public partial class FormRegistroClientes : Form
    {
        public FormRegistroClientes()
        {
            InitializeComponent();
            btnGuardar.Click += new EventHandler(btnGuardar_Click);//Asociar el evento click al boton guardar
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos no estén vacíos
                if (string.IsNullOrEmpty(txtIdentificacion.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtPrimerApellido.Text) || string.IsNullOrEmpty(txtSegundoApellido.Text) || dtpFechaNacimiento.Value == null || cmbJugadorEnLinea.SelectedIndex == -1)
                {
                    MessageBox.Show("Todos los campos son requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar que la identificación no esté repetida
                int identificacion = int.Parse(txtIdentificacion.Text);
                if (ExisteIdentificacion(identificacion))
                {
                    MessageBox.Show("La identificación ya está registrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear el objeto ClienteEntidad
                ClienteEntidad cliente = new ClienteEntidad
                {
                    Identificacion = identificacion,
                    Nombre = txtNombre.Text,
                    PrimerApellido = txtPrimerApellido.Text,
                    SegundoApellido = txtSegundoApellido.Text,
                    FechaNacimiento = dtpFechaNacimiento.Value,
                    JugadorEnLinea = cmbJugadorEnLinea.SelectedIndex == 0 // 0: Sí, 1: No
                };

                // Guardar en el arreglo
                bool guardado = GuardarEnArreglo(cliente);

                if (guardado)
                {
                    MessageBox.Show("Cliente registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pueden ingresar más registros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("La identificación debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ExisteIdentificacion(int identificacion)
        {
            foreach (var cliente in Datos.Clientes)
            {
                if (cliente != null && cliente.Identificacion == identificacion)
                {
                    return true;
                }
            }
            return false;
        }

        private bool GuardarEnArreglo(ClienteEntidad cliente)
        {
            for (int i = 0; i < Datos.Clientes.Length; i++)
            {
                if (Datos.Clientes[i] == null)
                {
                    Datos.Clientes[i] = cliente;
                    return true; // Registro guardado exitosamente
                }
            }
            return false; // No hay espacio en el arreglo
        }
        //Limpiar campos despues de crear un registro
        private void LimpiarCampos()
        {
            txtIdentificacion.Clear();
            txtNombre.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            dtpFechaNacimiento.Value = DateTime.Now;
            cmbJugadorEnLinea.SelectedIndex = -1;
        }
    }
}