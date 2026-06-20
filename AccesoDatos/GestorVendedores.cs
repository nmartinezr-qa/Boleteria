using Boleteria.Entidades;

namespace Boleteria.AccesoDatos
{
    public class GestorVendedores
    {
        private Vendedor[] vendedores;
        private int vendedoresRegistrados;
        private int capacidadMaxima = 15;

        public GestorVendedores()
        {
            vendedores = new Vendedor[capacidadMaxima];
            vendedoresRegistrados = 0;
        }

        public bool AgregarVendedor(Vendedor nuevoVendedor)
        {
            if (!HayEspacioDisponible())
            {
                return false;
            }

            vendedores[vendedoresRegistrados] = nuevoVendedor;
            vendedoresRegistrados++;

            return true;
        }

        public Vendedor BuscarPorId(int idVendedor)
        {
            for (int i = 0; i < vendedoresRegistrados; i++)
            {
                if (vendedores[i].Id == idVendedor)
                {
                    return vendedores[i];
                }
            }

            return null;
        }

        public Vendedor BuscarPorIdentificacion(string identificacion)
        {
            for (int i = 0; i < vendedoresRegistrados; i++)
            {
                if (vendedores[i].Identificacion == identificacion)
                {
                    return vendedores[i];
                }
            }

            return null;
        }

        public bool ExisteId(int idVendedor)
        {
            return BuscarPorId(idVendedor) != null;
        }

        public bool ExisteIdentificacion(string identificacion)
        {
            return BuscarPorIdentificacion(identificacion) != null;
        }

        public Vendedor[] ObtenerVendedores()
        {
            Vendedor[] resultado = new Vendedor[vendedoresRegistrados];

            for (int i = 0; i < vendedoresRegistrados; i++)
            {
                resultado[i] = vendedores[i];
            }

            return resultado;
        }

        public bool HayEspacioDisponible()
        {
            return vendedoresRegistrados < capacidadMaxima;
        }

        public Vendedor[] BuscarPorNombre(string nombre)
        {
            int coincidencias = ContarCoincidenciasPorNombre(nombre);
            Vendedor[] resultado = new Vendedor[coincidencias];

            LlenarCoincidenciasPorNombre(nombre, resultado);

            return resultado;
        }

        private int ContarCoincidenciasPorNombre(string nombre)
        {
            int coincidencias = 0;

            for (int i = 0; i < vendedoresRegistrados; i++)
            {
                if (CoincideNombre(vendedores[i], nombre))
                {
                    coincidencias++;
                }
            }

            return coincidencias;
        }

        private void LlenarCoincidenciasPorNombre(string nombre, Vendedor[] resultado)
        {
            int indiceResultado = 0;

            for (int i = 0; i < vendedoresRegistrados; i++)
            {
                if (CoincideNombre(vendedores[i], nombre))
                {
                    resultado[indiceResultado] = vendedores[i];
                    indiceResultado++;
                }
            }
        }

        private bool CoincideNombre(Vendedor vendedor, string nombre)
        {
            if (vendedor == null || string.IsNullOrWhiteSpace(nombre))
            {
                return false;
            }

            return vendedor.Nombre.ToUpper().Contains(nombre.ToUpper());
        }
    }
}