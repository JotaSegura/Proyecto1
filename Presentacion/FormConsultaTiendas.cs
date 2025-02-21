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
    public partial class FormConsultaTiendas : Form
    {
        public FormConsultaTiendas()
        {
            InitializeComponent();
            CargarDatos();
        }
        //Metodo para cargar los datos de las tiendas
        private void CargarDatos()
        {
            //Se limpia el datagridview
            dgvTiendas.Rows.Clear();
            //Se recorre la lista de tiendas y se agregan en el datagridview
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