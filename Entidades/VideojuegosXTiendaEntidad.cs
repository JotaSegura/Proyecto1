using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Entidades
{
    public class VideojuegosXTiendaEntidad
    {
        public TiendaEntidad Tienda { get; set; }
        public VideojuegoEntidad Videojuego { get; set; }
        public int Existencias { get; set; }
    }
}