namespace Boleteria.AccesoDatos
{
    public static class DatosSistema
    {
        public static GestorLocalidades GestorLocalidades = new GestorLocalidades();

        public static GestorPartidos GestorPartidos = new GestorPartidos();

        public static GestorClientes GestorClientes = new GestorClientes();

        public static GestorVendedores GestorVendedores = new GestorVendedores();

        public static GestorLocalidadesPorPartido GestorLocalidadesPorPartido =
            new GestorLocalidadesPorPartido();

        public static GestorVentas GestorVentas = new GestorVentas();
    }
}