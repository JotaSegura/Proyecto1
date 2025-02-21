using System;

namespace Proyecto1.Entidades
{
    public class AdministradorEntidad
    {
        public int Identificacion { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaContratacion { get; set; }
    }
}