using Boleteria.AccesoDatos;
using Boleteria.Entidades;
using Boleteria.LogicaNegocio.Mensajes;

namespace Boleteria.LogicaNegocio.Servicios
{
    public class ServicioVenta
    {
        private GestorVentas gestorVentas;
        private GestorClientes gestorClientes;
        private GestorVendedores gestorVendedores;
        private GestorPartidos gestorPartidos;
        private GestorLocalidades gestorLocalidades;
        private GestorLocalidadesPorPartido gestorLocalidadesPorPartido;

        public ServicioVenta()
        {
            gestorVentas = DatosSistema.GestorVentas;
            gestorClientes = DatosSistema.GestorClientes;
            gestorVendedores = DatosSistema.GestorVendedores;
            gestorPartidos = DatosSistema.GestorPartidos;
            gestorLocalidades = DatosSistema.GestorLocalidades;
            gestorLocalidadesPorPartido = DatosSistema.GestorLocalidadesPorPartido;
        }

        public bool RegistrarVenta(
            int idVenta,
            int idCliente,
            int idVendedor,
            int idPartido,
            int idLocalidad,
            int cantidad,
            DateTime fechaVenta)
        {
            ValidarVenta(
                idVenta,
                idCliente,
                idVendedor,
                idPartido,
                idLocalidad,
                cantidad,
                fechaVenta);

            Cliente cliente = gestorClientes.BuscarPorId(idCliente);
            Vendedor vendedor = gestorVendedores.BuscarPorId(idVendedor);
            Partido partido = gestorPartidos.BuscarPorId(idPartido);
            Localidad localidad = gestorLocalidades.BuscarPorId(idLocalidad);

            LocalidadPorPartido localidadPorPartido =
                gestorLocalidadesPorPartido.BuscarPorPartidoYLocalidad(
                    idPartido,
                    idLocalidad);

            Venta nuevaVenta = new Venta
            {
                IdVenta = idVenta,
                Cliente = cliente,
                Vendedor = vendedor,
                Partido = partido,
                Localidad = localidad,
                LocalidadPorPartido = localidadPorPartido,
                Cantidad = cantidad,
                FechaVenta = fechaVenta,
                Total = CalcularMontoTotal(cantidad, localidad.Precio)
            };

            if (!gestorVentas.AgregarVenta(nuevaVenta))
            {
                throw new Exception(MensajesError.SinEspacioDisponible);
            }

            gestorLocalidadesPorPartido.ActualizarCantidadDisponible(
                idPartido,
                idLocalidad,
                cantidad);

            return true;
        }

        public decimal CalcularMontoTotal(int cantidad, decimal precio)
        {
            return cantidad * precio;
        }

        public bool ValidarDisponibilidad(
            int idPartido,
            int idLocalidad,
            int cantidad)
        {
            LocalidadPorPartido localidadPorPartido =
                gestorLocalidadesPorPartido.BuscarPorPartidoYLocalidad(
                    idPartido,
                    idLocalidad);

            if (localidadPorPartido == null)
            {
                return false;
            }

            return localidadPorPartido.CantidadDisponible >= cantidad;
        }

        public Venta[] ObtenerVentas()
        {
            return gestorVentas.ObtenerVentas();
        }

        public Venta BuscarVentaPorId(int idVenta)
        {
            Venta venta = gestorVentas.BuscarPorId(idVenta);

            if (venta == null)
            {
                throw new Exception(MensajesError.VentaNoEncontrada);
            }

            return venta;
        }

        public Venta[] BuscarVentasPorCliente(int idCliente)
        {
            return gestorVentas.BuscarPorCliente(idCliente);
        }

        public Venta[] BuscarVentasPorPartido(int idPartido)
        {
            return gestorVentas.BuscarPorPartido(idPartido);
        }

        private void ValidarVenta(
            int idVenta,
            int idCliente,
            int idVendedor,
            int idPartido,
            int idLocalidad,
            int cantidad,
            DateTime fechaVenta)
        {
            if (!gestorVentas.HayEspacioDisponible())
            {
                throw new Exception(MensajesError.SinEspacioDisponible);
            }

            if (gestorVentas.ExisteId(idVenta))
            {
                throw new Exception(MensajesError.VentaIdDuplicado);
            }

            if (cantidad <= 0)
            {
                throw new Exception(MensajesError.CantidadVentaInvalida);
            }

            Cliente cliente = gestorClientes.BuscarPorId(idCliente);

            if (cliente == null)
            {
                throw new Exception(MensajesError.ClienteNoEncontrado);
            }

            if (!cliente.Activo)
            {
                throw new Exception(MensajesError.ClienteInactivo);
            }

            Vendedor vendedor = gestorVendedores.BuscarPorId(idVendedor);

            if (vendedor == null)
            {
                throw new Exception(MensajesError.VendedorNoEncontrado);
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

            if (partido.Fecha.Date < DateTime.Today)
            {
                throw new Exception(MensajesError.PartidoPasado);
            }

            Localidad localidad = gestorLocalidades.BuscarPorId(idLocalidad);

            if (localidad == null)
            {
                throw new Exception(MensajesError.LocalidadNoEncontrada);
            }

            LocalidadPorPartido localidadPorPartido =
                gestorLocalidadesPorPartido.BuscarPorPartidoYLocalidad(
                    idPartido,
                    idLocalidad);

            if (localidadPorPartido == null)
            {
                throw new Exception(MensajesError.LocalidadNoAsociada);
            }

            if (localidadPorPartido.CantidadDisponible < cantidad)
            {
                throw new Exception(MensajesError.SinDisponibilidad);
            }

            if (fechaVenta.Date > DateTime.Today)
            {
                throw new Exception(MensajesError.FechaMayorAHoy);
            }
        }
    }
}