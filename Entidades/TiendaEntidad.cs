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
    public class TiendaEntidad
    {
        //Getters y Setters de la clase TiendaEntidad
        public int Id { get; set; }
        public string Nombre { get; set; }
        public AdministradorEntidad Administrador { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public bool Activa { get; set; }
    }
}