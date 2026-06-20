using Boleteria.AccesoDatos;
using Boleteria.Entidades;
using Boleteria.LogicaNegocio.Mensajes;

namespace Boleteria.LogicaNegocio.Servicios
{
    public class ServicioCliente
    {
        private GestorClientes gestorClientes;

        public ServicioCliente()
        {
            gestorClientes = DatosSistema.GestorClientes;
        }

        public bool RegistrarCliente(
            int idCliente,
            string identificacion,
            string nombre,
            string apellido,
            DateTime fechaNacimiento,
            DateTime fechaRegistro,
            bool activo)
        {
            ValidarCliente(
                idCliente,
                identificacion,
                nombre,
                apellido,
                fechaNacimiento,
                fechaRegistro);

            Cliente nuevoCliente = new Cliente
            {
                Id = idCliente,
                Identificacion = identificacion,
                Nombre = nombre,
                Apellido = apellido,
                FechaNacimiento = fechaNacimiento,
                FechaRegistro = fechaRegistro,
                Activo = activo
            };

            return gestorClientes.AgregarCliente(nuevoCliente);
        }

        public Cliente[] ObtenerClientes()
        {
            return gestorClientes.ObtenerClientes();
        }

        public Cliente BuscarClientePorId(int idCliente)
        {
            Cliente cliente = gestorClientes.BuscarPorId(idCliente);

            if (cliente == null)
            {
                throw new Exception(MensajesError.ClienteNoEncontrado);
            }

            return cliente;
        }

        public Cliente BuscarClientePorIdentificacion(string identificacion)
        {
            Cliente cliente = gestorClientes.BuscarPorIdentificacion(identificacion);

            if (cliente == null)
            {
                throw new Exception(MensajesError.ClienteNoEncontrado);
            }

            return cliente;
        }

        public Cliente[] BuscarClientesPorNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new Exception(MensajesError.CamposObligatorios);
            }

            return gestorClientes.BuscarPorNombre(nombre);
        }

        public bool ClienteEstaActivo(int idCliente)
        {
            Cliente cliente = BuscarClientePorId(idCliente);

            return cliente.Activo;
        }

        private void ValidarCliente(
            int idCliente,
            string identificacion,
            string nombre,
            string apellido,
            DateTime fechaNacimiento,
            DateTime fechaRegistro)
        {
            if (!gestorClientes.HayEspacioDisponible())
            {
                throw new Exception(MensajesError.SinEspacioDisponible);
            }

            if (gestorClientes.ExisteId(idCliente))
            {
                throw new Exception(MensajesError.ClienteIdDuplicado);
            }

            if (string.IsNullOrWhiteSpace(identificacion) ||
                string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido))
            {
                throw new Exception(MensajesError.CamposObligatorios);
            }

            if (gestorClientes.ExisteIdentificacion(identificacion))
            {
                throw new Exception(MensajesError.IdentificacionClienteDuplicada);
            }

            if (fechaNacimiento.Date >= DateTime.Today)
            {
                throw new Exception(MensajesError.FechaNacimientoInvalida);
            }

            if (fechaRegistro.Date > DateTime.Today)
            {
                throw new Exception(MensajesError.FechaRegistroInvalida);
            }
        }
    }
}