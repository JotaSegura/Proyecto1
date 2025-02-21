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
    public partial class FormConsultaVideojuegos : Form
    {
        public FormConsultaVideojuegos()
        {
            InitializeComponent();
            CargarDatos();
        }
        //Metodo para cargar los datos de los videojuegos en el DataGridView
        private void CargarDatos()
        {
            dgvVideojuegos.Rows.Clear();
            //Recorremos la lista de videojuegos y los agregamos al DataGridView desde el arreglo de videojuegos
            foreach (var videojuego in Datos.Videojuegos)
            {
                if (videojuego != null)//Verificamos que el videojuego no sea nulo
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