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
    public partial class FormRegistroAdministradores : Form
    {
        public FormRegistroAdministradores()
        {
            InitializeComponent();
            btnGuardar.Click += new EventHandler(btnGuardar_Click);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos no estén vacíos
                if (string.IsNullOrEmpty(txtIdentificacion.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtPrimerApellido.Text) || string.IsNullOrEmpty(txtSegundoApellido.Text) || dtpFechaNacimiento.Value == null || dtpFechaContratacion.Value == null)
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

                // Validar que el administrador sea mayor de edad
                if (DateTime.Now.Year - dtpFechaNacimiento.Value.Year < 18)
                {
                    MessageBox.Show("El administrador debe ser mayor de edad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar que la fecha de contratación no sea mayor a la fecha actual
                if (dtpFechaContratacion.Value > DateTime.Now)
                {
                    MessageBox.Show("La fecha de contratación no puede ser mayor a la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear el objeto AdministradorEntidad
                AdministradorEntidad administrador = new AdministradorEntidad
                {
                    Identificacion = identificacion,
                    Nombre = txtNombre.Text,
                    PrimerApellido = txtPrimerApellido.Text,
                    SegundoApellido = txtSegundoApellido.Text,
                    FechaNacimiento = dtpFechaNacimiento.Value,
                    FechaContratacion = dtpFechaContratacion.Value
                };

                // Guardar en el arreglo
                bool guardado = GuardarEnArreglo(administrador);

                if (guardado)
                {
                    MessageBox.Show("Administrador registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            foreach (var admin in Datos.Administradores)
            {
                if (admin != null && admin.Identificacion == identificacion)
                {
                    return true;
                }
            }
            return false;
        }

        private bool GuardarEnArreglo(AdministradorEntidad administrador)
        {
            for (int i = 0; i < Datos.Administradores.Length; i++)
            {
                if (Datos.Administradores[i] == null)
                {
                    Datos.Administradores[i] = administrador;
                    return true;
                }
            }
            return false;
        }
        //Limpiar campos despues de crear un nuevo registro
        private void LimpiarCampos()
        {
            txtIdentificacion.Clear();
            txtNombre.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            dtpFechaNacimiento.Value = DateTime.Now;
            dtpFechaContratacion.Value = DateTime.Now;
        }
    }
}