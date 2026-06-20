using Boleteria.Entidades;

namespace Boleteria.AccesoDatos
{
    public class GestorVentas
    {
        private Venta[] ventas;
        private int ventasRegistradas;
        private int capacidadMaxima = 200;

        public GestorVentas()
        {
            ventas = new Venta[capacidadMaxima];
            ventasRegistradas = 0;
        }

        public bool AgregarVenta(Venta nuevaVenta)
        {
            if (!HayEspacioDisponible())
            {
                return false;
            }

            ventas[ventasRegistradas] = nuevaVenta;
            ventasRegistradas++;

            return true;
        }

        public Venta BuscarPorId(int idVenta)
        {
            for (int i = 0; i < ventasRegistradas; i++)
            {
                if (ventas[i].IdVenta == idVenta)
                {
                    return ventas[i];
                }
            }

            return null;
        }

        public bool ExisteId(int idVenta)
        {
            return BuscarPorId(idVenta) != null;
        }

        public Venta[] ObtenerVentas()
        {
            Venta[] resultado = new Venta[ventasRegistradas];

            for (int i = 0; i < ventasRegistradas; i++)
            {
                resultado[i] = ventas[i];
            }

            return resultado;
        }

        public bool HayEspacioDisponible()
        {
            return ventasRegistradas < capacidadMaxima;
        }

        public Venta[] BuscarPorCliente(int idCliente)
        {
            int coincidencias = ContarVentasPorCliente(idCliente);
            Venta[] resultado = new Venta[coincidencias];

            LlenarVentasPorCliente(idCliente, resultado);

            return resultado;
        }

        public Venta[] BuscarPorPartido(int idPartido)
        {
            int coincidencias = ContarVentasPorPartido(idPartido);
            Venta[] resultado = new Venta[coincidencias];

            LlenarVentasPorPartido(idPartido, resultado);

            return resultado;
        }

        private int ContarVentasPorCliente(int idCliente)
        {
            int coincidencias = 0;

            for (int i = 0; i < ventasRegistradas; i++)
            {
                if (ventas[i].Cliente.Id == idCliente)
                {
                    coincidencias++;
                }
            }

            return coincidencias;
        }

        private void LlenarVentasPorCliente(int idCliente, Venta[] resultado)
        {
            int indiceResultado = 0;

            for (int i = 0; i < ventasRegistradas; i++)
            {
                if (ventas[i].Cliente.Id == idCliente)
                {
                    resultado[indiceResultado] = ventas[i];
                    indiceResultado++;
                }
            }
        }

        private int ContarVentasPorPartido(int idPartido)
        {
            int coincidencias = 0;

            for (int i = 0; i < ventasRegistradas; i++)
            {
                if (ventas[i].Partido.IdPartido == idPartido)
                {
                    coincidencias++;
                }
            }

            return coincidencias;
        }

        private void LlenarVentasPorPartido(int idPartido, Venta[] resultado)
        {
            int indiceResultado = 0;

            for (int i = 0; i < ventasRegistradas; i++)
            {
                if (ventas[i].Partido.IdPartido == idPartido)
                {
                    resultado[indiceResultado] = ventas[i];
                    indiceResultado++;
                }
            }
        }
    }
}