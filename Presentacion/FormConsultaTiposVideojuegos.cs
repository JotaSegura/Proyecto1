using System;
using System.Windows.Forms;
using Proyecto1.AccesoDatos;

namespace Proyecto1.Presentacion
{
    public partial class FormConsultaTiposVideojuegos : Form
    {
        public FormConsultaTiposVideojuegos()
        {
            InitializeComponent();
        }

        private void FormConsultaTiposVideojuegos_Load(object sender, EventArgs e)
        {
            // Cargar los datos al abrir el formulario
            CargarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Actualizar los datos al hacer clic en el botón
            CargarDatos();
        }

        private void CargarDatos()
        {
            // Limpiar el DataGridView
            dgvTiposVideojuegos.Rows.Clear();

            // Recorrer el arreglo de tipos de videojuegos
            foreach (var tipoVideojuego in Datos.TiposVideojuegos)
            {
                if (tipoVideojuego != null) // Verificar que el registro no sea nulo
                {
                    // Agregar una fila al DataGridView con los datos del tipo de videojuego
                    dgvTiposVideojuegos.Rows.Add(
                        tipoVideojuego.Id,
                        tipoVideojuego.Nombre,
                        tipoVideojuego.Descripcion
                    );
                }
            }
        }
    }
}