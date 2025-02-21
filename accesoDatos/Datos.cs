using Proyecto1.Entidades;
/**
 *UNED Primer Cuatrimestre 2025
 *Proyecto 1: Gestion de Tiendas de Videojuegos
 *Estudiante: Jaroth Segura Valverde
 * Fecha de entrega: 23 de febrero 2025
 */
namespace Proyecto1.AccesoDatos
{
    public static class Datos
    {
        // Arreglo para almacenar tipos de videojuegos (máximo 10 registros)
        public static TipoVideojuegoEntidad[] TiposVideojuegos = new TipoVideojuegoEntidad[10];
        // Arreglo para almacenar videojuegos (máximo 20 registros)
        public static VideojuegoEntidad[] Videojuegos = new VideojuegoEntidad[20];
        //Arreglo para almacenar administradores (máximo 20 registros)
        public static AdministradorEntidad[] Administradores = new AdministradorEntidad[20];
        //Arreglo para almacenar tiendas (máximo 5 registros)
        public static TiendaEntidad[] Tiendas = new TiendaEntidad[5];
        //Arreglo para almacenar clientes (máximo 20 registros)
        public static ClienteEntidad[] Clientes = new ClienteEntidad[20];
        //Arreglo para almacenar videojuegos por tienda (máximo 100 registros)
        public static VideojuegosXTiendaEntidad[] Inventario = new VideojuegosXTiendaEntidad[100];
    }
}
