using System;
using System.Windows.Forms;
using Proyecto1.AccesoDatos;
/**
 *UNED Primer Cuatrimestre 2025
 *Proyecto 1: Gestion de Tiendas de Videojuegos
 *Estudiante: Jaroth Segura Valverde
 * Fecha de entrega: 23 de febrero 2025
 */
namespace Proyecto1.Presentacion
{
    public partial class FormConsultaAdministradores : Form
    {
        public FormConsultaAdministradores()
        {
            InitializeComponent();
            CargarDatos();
        }
        //Metodo para cargar los datos de los administradores desde el arreglo
        private void CargarDatos()
        {
            dgvAdministradores.Rows.Clear();
            //Recorrer el arreglo de administradores y cargar los datos en el DataGridView
            foreach (var admin in Datos.Administradores)
            {
                if (admin != null)
                {
                    dgvAdministradores.Rows.Add(
                        admin.Identificacion,
                        admin.Nombre,
                        admin.PrimerApellido,
                        admin.SegundoApellido,
                        admin.FechaNacimiento.ToShortDateString(),
                        admin.FechaContratacion.ToShortDateString()
                    );
                }
            }
        }
    }
}