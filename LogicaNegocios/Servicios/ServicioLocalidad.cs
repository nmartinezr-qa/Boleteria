using Boleteria.AccesoDatos;
using Boleteria.Entidades;
using Boleteria.LogicaNegocio.Mensajes;

namespace Boleteria.LogicaNegocio.Servicios
{
    public class ServicioLocalidad
    {
        private GestorLocalidades gestorLocalidades;

        public ServicioLocalidad()
        {
            gestorLocalidades = DatosSistema.GestorLocalidades;
        }

        public bool RegistrarLocalidad(
            int idLocalidad,
            string nombreLocalidad,
            decimal precio)
        {
            ValidarLocalidad(idLocalidad, nombreLocalidad, precio);

            Localidad nuevaLocalidad = new Localidad
            {
                IdLocalidad = idLocalidad,
                NombreLocalidad = nombreLocalidad,
                Precio = precio
            };

            return gestorLocalidades.AgregarLocalidad(nuevaLocalidad);
        }

        public Localidad[] ObtenerLocalidades()
        {
            return gestorLocalidades.ObtenerLocalidades();
        }

        public Localidad BuscarLocalidadPorId(int idLocalidad)
        {
            Localidad localidad = gestorLocalidades.BuscarPorId(idLocalidad);

            if (localidad == null)
            {
                throw new Exception(MensajesError.LocalidadNoEncontrada);
            }

            return localidad;
        }

        public Localidad[] BuscarLocalidadesPorNombre(string nombreLocalidad)
        {
            if (string.IsNullOrWhiteSpace(nombreLocalidad))
            {
                throw new Exception(MensajesError.NombreLocalidadObligatorio);
            }

            return gestorLocalidades.BuscarPorNombre(nombreLocalidad);
        }

        private void ValidarLocalidad(
            int idLocalidad,
            string nombreLocalidad,
            decimal precio)
        {
            if (!gestorLocalidades.HayEspacioDisponible())
            {
                throw new Exception(MensajesError.SinEspacioDisponible);
            }

            if (gestorLocalidades.ExisteId(idLocalidad))
            {
                throw new Exception(MensajesError.LocalidadIdDuplicado);
            }

            if (string.IsNullOrWhiteSpace(nombreLocalidad))
            {
                throw new Exception(MensajesError.NombreLocalidadObligatorio);
            }

            if (precio <= 0)
            {
                throw new Exception(MensajesError.PrecioInvalido);
            }
        }
    }
}