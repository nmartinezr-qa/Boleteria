using Boleteria.Entidades;

namespace Boleteria.AccesoDatos
{
    public class GestorLocalidadesPorPartido
    {
        private LocalidadPorPartido[] localidadesPorPartido;
        private int localidadesPorPartidoRegistradas;
        private int capacidadMaxima = 200;

        public GestorLocalidadesPorPartido()
        {
            localidadesPorPartido = new LocalidadPorPartido[capacidadMaxima];
            localidadesPorPartidoRegistradas = 0;
        }

        public bool AgregarLocalidadPorPartido(LocalidadPorPartido nuevaLocalidadPorPartido)
        {
            if (!HayEspacioDisponible())
            {
                return false;
            }

            localidadesPorPartido[localidadesPorPartidoRegistradas] =
                nuevaLocalidadPorPartido;

            localidadesPorPartidoRegistradas++;

            return true;
        }

        public LocalidadPorPartido BuscarPorPartidoYLocalidad(
            int idPartido,
            int idLocalidad)
        {
            for (int i = 0; i < localidadesPorPartidoRegistradas; i++)
            {
                if (localidadesPorPartido[i].Partido.IdPartido == idPartido &&
                    localidadesPorPartido[i].Localidad.IdLocalidad == idLocalidad)
                {
                    return localidadesPorPartido[i];
                }
            }

            return null;
        }

        public bool ExisteLocalidadParaPartido(
            int idPartido,
            int idLocalidad)
        {
            return BuscarPorPartidoYLocalidad(
                idPartido,
                idLocalidad) != null;
        }

        public LocalidadPorPartido[] ObtenerLocalidadesPorPartido()
        {
            LocalidadPorPartido[] resultado =
                new LocalidadPorPartido[localidadesPorPartidoRegistradas];

            for (int i = 0; i < localidadesPorPartidoRegistradas; i++)
            {
                resultado[i] = localidadesPorPartido[i];
            }

            return resultado;
        }

        public bool ActualizarCantidadDisponible(
            int idPartido,
            int idLocalidad,
            int cantidadVendida)
        {
            LocalidadPorPartido registro =
                BuscarPorPartidoYLocalidad(
                    idPartido,
                    idLocalidad);

            if (registro == null)
            {
                return false;
            }

            if (registro.CantidadDisponible < cantidadVendida)
            {
                return false;
            }

            registro.CantidadDisponible -= cantidadVendida;

            return true;
        }

        public bool HayEspacioDisponible()
        {
            return localidadesPorPartidoRegistradas < capacidadMaxima;
        }
    }
}