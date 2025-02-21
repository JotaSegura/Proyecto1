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
    public partial class FormConsultaInventario : Form
    {
        public FormConsultaInventario()
        {
            InitializeComponent();
            CargarDatos();
        }
        //metodo para cargar los datos en el data grid view
        private void CargarDatos()
        {
            dgvInventario.Rows.Clear();
            //Recorremos el arreglo de inventario y agregamos los datos al data grid view
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