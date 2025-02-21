using System;
using System.Windows.Forms;
using Proyecto1.AccesoDatos;

namespace Proyecto1.Presentacion
{
    public partial class FormConsultaVideojuegos : Form
    {
        public FormConsultaVideojuegos()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            dgvVideojuegos.Rows.Clear();

            foreach (var videojuego in Datos.Videojuegos)
            {
                if (videojuego != null)
                {
                    dgvVideojuegos.Rows.Add(
                        videojuego.Id,
                        videojuego.Nombre,
                        videojuego.TipoVideojuego.Nombre,
                        videojuego.Desarrollador,
                        videojuego.Lanzamiento,
                        videojuego.Fisico ? "Físico" : "Virtual"
                    );
                }
            }
        }
    }
}