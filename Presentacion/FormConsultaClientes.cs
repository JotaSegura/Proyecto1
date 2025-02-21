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
    public partial class FormConsultaClientes : Form
    {
        public FormConsultaClientes()
        {
            InitializeComponent();
            CargarDatos();
        }
        //Metodo para cargar los datos de los clientes en el DataGridView
        private void CargarDatos()
        {
            dgvClientes.Rows.Clear();
            //Se recorre la lista de clientes del arreglo y se agregan al DataGridView
            foreach (var cliente in Datos.Clientes)
            {
                if (cliente != null)
                {
                    dgvClientes.Rows.Add(
                        cliente.Identificacion,
                        cliente.Nombre,
                        cliente.PrimerApellido,
                        cliente.SegundoApellido,
                        cliente.FechaNacimiento.ToShortDateString(),
                        cliente.JugadorEnLinea ? "Sí" : "No"
                    );
                }
            }
        }
    }
}