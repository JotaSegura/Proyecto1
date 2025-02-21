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
    public class VideojuegoEntidad
    {
        //Getters y Setters de la clase VideojuegoEntidad
        public int Id { get; set; }
        public string Nombre { get; set; }
        public TipoVideojuegoEntidad TipoVideojuego { get; set; }
        public string Desarrollador { get; set; }
        public int Lanzamiento { get; set; }
        public bool Fisico { get; set; }
    }
}