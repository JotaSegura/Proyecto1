using System;
using System.Windows.Forms;
using Proyecto1.AccesoDatos;

namespace Proyecto1.Presentacion
{
    public partial class FormConsultaInventario : Form
    {
        public FormConsultaInventario()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            dgvInventario.Rows.Clear();

            foreach (var inv in Datos.Inventario)
            {
                if (inv != null)
                {
                    dgvInventario.Rows.Add(
                        inv.Tienda.Id,
                        inv.Tienda.Nombre,
                        inv.Tienda.Direccion,
                        inv.Videojuego.Id,
                        inv.Videojuego.Nombre,
                        inv.Videojuego.TipoVideojuego.Nombre,
                        inv.Existencias
                    );
                }
            }
        }
    }
}