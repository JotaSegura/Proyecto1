using System;
using System.Windows.Forms;
using Proyecto1.AccesoDatos;

namespace Proyecto1.Presentacion
{
    public partial class FormConsultaClientes : Form
    {
        public FormConsultaClientes()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            dgvClientes.Rows.Clear();

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