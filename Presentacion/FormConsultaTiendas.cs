using System;
using System.Windows.Forms;
using Proyecto1.AccesoDatos;

namespace Proyecto1.Presentacion
{
    public partial class FormConsultaTiendas : Form
    {
        public FormConsultaTiendas()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            dgvTiendas.Rows.Clear();

            foreach (var tienda in Datos.Tiendas)
            {
                if (tienda != null)
                {
                    dgvTiendas.Rows.Add(
                        tienda.Id,
                        tienda.Nombre,
                        $"{tienda.Administrador.Nombre} {tienda.Administrador.PrimerApellido} {tienda.Administrador.SegundoApellido}",
                        tienda.Direccion,
                        tienda.Telefono,
                        tienda.Activa ? "Sí" : "No"
                    );
                }
            }
        }
    }
}