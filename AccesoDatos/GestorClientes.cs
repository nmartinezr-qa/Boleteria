using Boleteria.Entidades;

namespace Boleteria.AccesoDatos
{
    public class GestorClientes
    {
        private Cliente[] clientes;
        private int clientesRegistrados;
        private int capacidadMaxima = 50;

        public GestorClientes()
        {
            clientes = new Cliente[capacidadMaxima];
            clientesRegistrados = 0;
        }

        public bool AgregarCliente(Cliente nuevoCliente)
        {
            if (!HayEspacioDisponible())
            {
                return false;
            }

            clientes[clientesRegistrados] = nuevoCliente;
            clientesRegistrados++;

            return true;
        }

        public Cliente BuscarPorId(int idCliente)
        {
            for (int i = 0; i < clientesRegistrados; i++)
            {
                if (clientes[i].Id == idCliente)
                {
                    return clientes[i];
                }
            }

            return null;
        }

        public Cliente BuscarPorIdentificacion(string identificacion)
        {
            for (int i = 0; i < clientesRegistrados; i++)
            {
                if (clientes[i].Identificacion == identificacion)
                {
                    return clientes[i];
                }
            }

            return null;
        }

        public bool ExisteId(int idCliente)
        {
            return BuscarPorId(idCliente) != null;
        }

        public bool ExisteIdentificacion(string identificacion)
        {
            return BuscarPorIdentificacion(identificacion) != null;
        }

        public Cliente[] ObtenerClientes()
        {
            Cliente[] resultado = new Cliente[clientesRegistrados];

            for (int i = 0; i < clientesRegistrados; i++)
            {
                resultado[i] = clientes[i];
            }

            return resultado;
        }

        public bool HayEspacioDisponible()
        {
            return clientesRegistrados < capacidadMaxima;
        }

        public Cliente[] BuscarPorNombre(string nombre)
        {
            int coincidencias = ContarCoincidenciasPorNombre(nombre);
            Cliente[] resultado = new Cliente[coincidencias];

            LlenarCoincidenciasPorNombre(nombre, resultado);

            return resultado;
        }

        private int ContarCoincidenciasPorNombre(string nombre)
        {
            int coincidencias = 0;

            for (int i = 0; i < clientesRegistrados; i++)
            {
                if (CoincideNombre(clientes[i], nombre))
                {
                    coincidencias++;
                }
            }

            return coincidencias;
        }

        private void LlenarCoincidenciasPorNombre(string nombre, Cliente[] resultado)
        {
            int indiceResultado = 0;

            for (int i = 0; i < clientesRegistrados; i++)
            {
                if (CoincideNombre(clientes[i], nombre))
                {
                    resultado[indiceResultado] = clientes[i];
                    indiceResultado++;
                }
            }
        }

        private bool CoincideNombre(Cliente cliente, string nombre)
        {
            if (cliente == null || string.IsNullOrWhiteSpace(nombre))
            {
                return false;
            }

            return cliente.Nombre.ToUpper().Contains(nombre.ToUpper());
        }
    }
}