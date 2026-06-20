using Boleteria.AccesoDatos;
using Boleteria.Entidades;
using Boleteria.LogicaNegocio.Mensajes;

namespace Boleteria.LogicaNegocio.Servicios
{
    public class ServicioPartido
    {
        private GestorPartidos gestorPartidos;

        public ServicioPartido()
        {
            gestorPartidos = DatosSistema.GestorPartidos;
        }

        public bool RegistrarPartido(
            int idPartido,
            string rival,
            DateTime fecha,
            string hora,
            bool activo)
        {
            ValidarPartido(idPartido, rival, fecha, hora);

            Partido nuevoPartido = new Partido
            {
                IdPartido = idPartido,
                Rival = rival,
                Fecha = fecha,
                Hora = hora,
                Activo = activo
            };

            return gestorPartidos.AgregarPartido(nuevoPartido);
        }

        public Partido[] ObtenerPartidos()
        {
            return gestorPartidos.ObtenerPartidos();
        }

        public Partido BuscarPartidoPorId(int idPartido)
        {
            Partido partido = gestorPartidos.BuscarPorId(idPartido);

            if (partido == null)
            {
                throw new Exception(MensajesError.PartidoNoEncontrado);
            }

            return partido;
        }

        public Partido[] BuscarPartidosPorRival(string rival)
        {
            if (string.IsNullOrWhiteSpace(rival))
            {
                throw new Exception(MensajesError.RivalObligatorio);
            }

            return gestorPartidos.BuscarPorRival(rival);
        }

        private void ValidarPartido(
            int idPartido,
            string rival,
            DateTime fecha,
            string hora)
        {
            if (!gestorPartidos.HayEspacioDisponible())
            {
                throw new Exception(MensajesError.SinEspacioDisponible);
            }

            if (gestorPartidos.ExisteId(idPartido))
            {
                throw new Exception(MensajesError.PartidoIdDuplicado);
            }

            if (string.IsNullOrWhiteSpace(rival))
            {
                throw new Exception(MensajesError.RivalObligatorio);
            }

            if (string.IsNullOrWhiteSpace(hora))
            {
                throw new Exception(MensajesError.HoraObligatoria);
            }

            if (fecha.Date < DateTime.Today)
            {
                throw new Exception(MensajesError.PartidoPasado);
            }
        }
    }
}