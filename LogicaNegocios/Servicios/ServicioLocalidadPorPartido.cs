using Boleteria.AccesoDatos;
using Boleteria.Entidades;
using Boleteria.LogicaNegocio.Mensajes;

namespace Boleteria.LogicaNegocio.Servicios
{
    public class ServicioLocalidadPorPartido
    {
        private GestorLocalidadesPorPartido gestorLocalidadesPorPartido;
        private GestorPartidos gestorPartidos;
        private GestorLocalidades gestorLocalidades;

        public ServicioLocalidadPorPartido()
        {
            gestorLocalidadesPorPartido = DatosSistema.GestorLocalidadesPorPartido;
            gestorPartidos = DatosSistema.GestorPartidos;
            gestorLocalidades = DatosSistema.GestorLocalidades;
        }

        public bool RegistrarLocalidadPorPartido(
            int idPartido,
            int idLocalidad,
            int cantidadDisponible)
        {
            ValidarLocalidadPorPartido(
                idPartido,
                idLocalidad,
                cantidadDisponible);

            Partido partido = gestorPartidos.BuscarPorId(idPartido);
            Localidad localidad = gestorLocalidades.BuscarPorId(idLocalidad);

            LocalidadPorPartido nuevaLocalidadPorPartido =
                new LocalidadPorPartido
                {
                    Partido = partido,
                    Localidad = localidad,
                    CantidadDisponible = cantidadDisponible
                };

            return gestorLocalidadesPorPartido
                .AgregarLocalidadPorPartido(nuevaLocalidadPorPartido);
        }

        public LocalidadPorPartido[] ObtenerLocalidadesPorPartido()
        {
            return gestorLocalidadesPorPartido.ObtenerLocalidadesPorPartido();
        }

        public LocalidadPorPartido BuscarPorPartidoYLocalidad(
            int idPartido,
            int idLocalidad)
        {
            LocalidadPorPartido localidadPorPartido =
                gestorLocalidadesPorPartido.BuscarPorPartidoYLocalidad(
                    idPartido,
                    idLocalidad);

            if (localidadPorPartido == null)
            {
                throw new Exception(MensajesError.LocalidadNoAsociada);
            }

            return localidadPorPartido;
        }

        public bool ExisteLocalidadParaPartido(
            int idPartido,
            int idLocalidad)
        {
            return gestorLocalidadesPorPartido.ExisteLocalidadParaPartido(
                idPartido,
                idLocalidad);
        }

        private void ValidarLocalidadPorPartido(
            int idPartido,
            int idLocalidad,
            int cantidadDisponible)
        {
            if (!gestorLocalidadesPorPartido.HayEspacioDisponible())
            {
                throw new Exception(MensajesError.SinEspacioDisponible);
            }

            Partido partido = gestorPartidos.BuscarPorId(idPartido);

            if (partido == null)
            {
                throw new Exception(MensajesError.PartidoNoEncontrado);
            }

            if (!partido.Activo)
            {
                throw new Exception(MensajesError.PartidoInactivo);
            }

            Localidad localidad = gestorLocalidades.BuscarPorId(idLocalidad);

            if (localidad == null)
            {
                throw new Exception(MensajesError.LocalidadNoEncontrada);
            }

            if (gestorLocalidadesPorPartido.ExisteLocalidadParaPartido(
                idPartido,
                idLocalidad))
            {
                throw new Exception(MensajesError.AsociacionDuplicada);
            }

            if (cantidadDisponible <= 0)
            {
                throw new Exception(MensajesError.CantidadDisponibleInvalida);
            }
        }
    }
}