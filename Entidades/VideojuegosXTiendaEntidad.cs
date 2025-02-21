using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 *UNED Primer Cuatrimestre 2025
 *Proyecto 1: Gestion de Tiendas de Videojuegos
 *Estudiante: Jaroth Segura Valverde
 * Fecha de entrega: 23 de febrero 2025
 */
namespace Proyecto1.Entidades
{
    public class VideojuegosXTiendaEntidad
    {
        //Getters y Setters de la clase VideojuegosXTiendaEntidad
        public TiendaEntidad Tienda { get; set; }
        public VideojuegoEntidad Videojuego { get; set; }
        public int Existencias { get; set; }
    }
}