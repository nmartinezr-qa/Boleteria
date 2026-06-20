using Boleteria.AccesoDatos;
using Boleteria.Entidades;
using Boleteria.LogicaNegocio.Mensajes;

namespace Boleteria.LogicaNegocio.Servicios
{
    public class ServicioVendedor
    {
        private GestorVendedores gestorVendedores;

        public ServicioVendedor()
        {
            gestorVendedores = DatosSistema.GestorVendedores;

        }

        public bool RegistrarVendedor(
            int idVendedor,
            string identificacion,
            string nombre,
            string apellido,
            DateTime fechaNacimiento,
            DateTime fechaIngreso)
        {
            ValidarVendedor(
                idVendedor,
                identificacion,
                nombre,
                apellido,
                fechaNacimiento,
                fechaIngreso);

            Vendedor nuevoVendedor = new Vendedor
            {
                Id = idVendedor,
                Identificacion = identificacion,
                Nombre = nombre,
                Apellido = apellido,
                FechaNacimiento = fechaNacimiento,
                FechaIngreso = fechaIngreso
            };

            return gestorVendedores.AgregarVendedor(nuevoVendedor);
        }

        public Vendedor[] ObtenerVendedores()
        {
            return gestorVendedores.ObtenerVendedores();
        }

        public Vendedor BuscarVendedorPorId(int idVendedor)
        {
            Vendedor vendedor = gestorVendedores.BuscarPorId(idVendedor);

            if (vendedor == null)
            {
                throw new Exception(MensajesError.VendedorNoEncontrado);
            }

            return vendedor;
        }

        public Vendedor BuscarVendedorPorIdentificacion(string identificacion)
        {
            Vendedor vendedor =
                gestorVendedores.BuscarPorIdentificacion(identificacion);

            if (vendedor == null)
            {
                throw new Exception(MensajesError.VendedorNoEncontrado);
            }

            return vendedor;
        }

        public Vendedor[] BuscarVendedoresPorNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new Exception(MensajesError.CamposObligatorios);
            }

            return gestorVendedores.BuscarPorNombre(nombre);
        }

        public bool EsMayorDeEdad(DateTime fechaNacimiento)
        {
            int edad = DateTime.Today.Year - fechaNacimiento.Year;

            if (fechaNacimiento.Date > DateTime.Today.AddYears(-edad))
            {
                edad--;
            }

            return edad >= 18;
        }

        private void ValidarVendedor(
            int idVendedor,
            string identificacion,
            string nombre,
            string apellido,
            DateTime fechaNacimiento,
            DateTime fechaIngreso)
        {
            if (!gestorVendedores.HayEspacioDisponible())
            {
                throw new Exception(MensajesError.SinEspacioDisponible);
            }

            if (gestorVendedores.ExisteId(idVendedor))
            {
                throw new Exception(MensajesError.VendedorIdDuplicado);
            }

            if (string.IsNullOrWhiteSpace(identificacion) ||
                string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido))
            {
                throw new Exception(MensajesError.CamposObligatorios);
            }

            if (!int.TryParse(identificacion, out int identificacionNumerica) ||
                identificacionNumerica <= 0)
            {
                throw new Exception(MensajesError.IdentificacionInvalida);
            }

            if (gestorVendedores.ExisteIdentificacion(identificacion))
            {
                throw new Exception(MensajesError.IdentificacionVendedorDuplicada);
            }

            if (fechaNacimiento.Date >= DateTime.Today)
            {
                throw new Exception(MensajesError.FechaNacimientoInvalida);
            }

            if (!EsMayorDeEdad(fechaNacimiento))
            {
                throw new Exception(MensajesError.VendedorMenorEdad);
            }

            if (fechaIngreso.Date < fechaNacimiento.Date ||
                fechaIngreso.Date > DateTime.Today)
            {
                throw new Exception(MensajesError.FechaIngresoInvalida);
            }
        }
    }
}