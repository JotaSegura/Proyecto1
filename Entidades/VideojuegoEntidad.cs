using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Entidades
{
    public class VideojuegoEntidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public TipoVideojuegoEntidad TipoVideojuego { get; set; }
        public string Desarrollador { get; set; }
        public int Lanzamiento { get; set; }
        public bool Fisico { get; set; }
    }
}