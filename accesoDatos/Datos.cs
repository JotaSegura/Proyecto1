using Proyecto1.Entidades;

namespace Proyecto1.AccesoDatos
{
    public static class Datos
    {
        // Arreglo para almacenar tipos de videojuegos (máximo 10 registros)
        public static TipoVideojuegoEntidad[] TiposVideojuegos = new TipoVideojuegoEntidad[10];
        public static VideojuegoEntidad[] Videojuegos = new VideojuegoEntidad[20];
        public static AdministradorEntidad[] Administradores = new AdministradorEntidad[20];
        public static TiendaEntidad[] Tiendas = new TiendaEntidad[5];
        public static ClienteEntidad[] Clientes = new ClienteEntidad[20];
        public static VideojuegosXTiendaEntidad[] Inventario = new VideojuegosXTiendaEntidad[100];
    }
}
