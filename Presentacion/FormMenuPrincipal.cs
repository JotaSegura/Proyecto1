using System;
using System.Windows.Forms;
/**
 *UNED Primer Cuatrimestre 2025
 *Proyecto 1: Gestion de Tiendas de Videojuegos
 *Estudiante: Jaroth Segura Valverde
 * Fecha de entrega: 23 de febrero 2025
 */
namespace Proyecto1.Presentacion
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            // Configuración inicial del formulario
            this.Text = "Menú Principal";
            this.Size = new System.Drawing.Size(500, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnRegistrarTiposVideojuegos_Click(object sender, EventArgs e)
        {
            // Abrir el formulario para registrar tipos de videojuegos
            FormRegistroTiposVideojuegos formRegistroTipos = new FormRegistroTiposVideojuegos();
            formRegistroTipos.ShowDialog();
        }

         private void btnRegistrarVideojuegos_Click(object sender, EventArgs e)
        {
            // Abrir el formulario para registrar videojuegos
            FormRegistroVideojuegos formRegistroVideojuegos = new FormRegistroVideojuegos();
            formRegistroVideojuegos.ShowDialog();
        }

        private void btnRegistrarAdministradores_Click(object sender, EventArgs e)
        {
            // Abrir el formulario para registrar administradores
            FormRegistroAdministradores formRegistroAdministradores = new FormRegistroAdministradores();
            formRegistroAdministradores.ShowDialog();
        }

        private void btnRegistrarTiendas_Click(object sender, EventArgs e)
        {
            // Abrir el formulario para registrar tiendas
            FormRegistroTiendas formRegistroTiendas = new FormRegistroTiendas();
            formRegistroTiendas.ShowDialog();
        }

        private void btnRegistrarClientes_Click(object sender, EventArgs e)
        {
            // Abrir el formulario para registrar clientes
            FormRegistroClientes formRegistroClientes = new FormRegistroClientes();
            formRegistroClientes.ShowDialog();
        }

        private void btnRegistrarInventario_Click(object sender, EventArgs e)
        {
            // Abrir el formulario para registrar inventario
            FormRegistroInventario formRegistroInventario = new FormRegistroInventario();
            formRegistroInventario.ShowDialog();
        }

        private void btnConsultarTiposVideojuegos_Click(object sender, EventArgs e)
        {
            // Abrir el formulario para consultar tipos de videojuegos
            FormConsultaTiposVideojuegos formConsultaTipos = new FormConsultaTiposVideojuegos();
            formConsultaTipos.ShowDialog();
        }

        private void btnConsultarVideojuegos_Click(object sender, EventArgs e)
        {
            // Abrir el formulario para consultar videojuegos
            FormConsultaVideojuegos formConsultaVideojuegos = new FormConsultaVideojuegos();
            formConsultaVideojuegos.ShowDialog();
        }

        private void btnConsultarAdministradores_Click(object sender, EventArgs e)
        {
            // Abrir el formulario para consultar administradores
            FormConsultaAdministradores formConsultaAdministradores = new FormConsultaAdministradores();
            formConsultaAdministradores.ShowDialog();
        }

        private void btnConsultarTiendas_Click(object sender, EventArgs e)
        {
            // Abrir el formulario para consultar tiendas
            FormConsultaTiendas formConsultaTiendas = new FormConsultaTiendas();
            formConsultaTiendas.ShowDialog();
        }

        private void btnConsultarClientes_Click(object sender, EventArgs e)
        {
            // Abrir el formulario para consultar clientes
            FormConsultaClientes formConsultaClientes = new FormConsultaClientes();
            formConsultaClientes.ShowDialog();
        }

        private void btnConsultarInventario_Click(object sender, EventArgs e)
        {
            // Abrir el formulario para consultar inventario
            FormConsultaInventario formConsultaInventario = new FormConsultaInventario();
            formConsultaInventario.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación
            this.Close();
        }

    }
}