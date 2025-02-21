using System;
using System.Windows.Forms;
using Proyecto1.AccesoDatos;

namespace Proyecto1.Presentacion
{
    public partial class FormConsultaAdministradores : Form
    {
        public FormConsultaAdministradores()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            dgvAdministradores.Rows.Clear();

            foreach (var admin in Datos.Administradores)
            {
                if (admin != null)
                {
                    dgvAdministradores.Rows.Add(
                        admin.Identificacion,
                        admin.Nombre,
                        admin.PrimerApellido,
                        admin.SegundoApellido,
                        admin.FechaNacimiento.ToShortDateString(),
                        admin.FechaContratacion.ToShortDateString()
                    );
                }
            }
        }
    }
}