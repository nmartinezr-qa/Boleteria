
using Boleteria.Entidades;
using System.Numerics;

namespace Boleteria.AccesoDatos
{
    public class GestorLocalidades
    {
        public Localidad[] localidades;
        int localidadesRegistradas;
        int capacidadMaxima = 10;

        public GestorLocalidades()
        {
            localidades = new Localidad[capacidadMaxima];
            localidadesRegistradas = 0;
        }

        public String MostrarLocalidades()
        {
            String localidades = "";
            for (int i = 0; i < localidadesRegistradas; i++)
            {
                localidades += $"Id: {this.localidades[i].IdLocalidad}, " +
                    $"Nombre: {this.localidades[i].NombreLocalidad}, " +
                    $"Precio: {this.localidades[i].Precio}";
            }
            return localidades;
        }

        public bool AgregarLocalidad(Localidad nuevaLocalidad) {
            if (localidadesRegistradas >= capacidadMaxima)
            {
                return false;
            }

            localidades[localidadesRegistradas] = nuevaLocalidad;
            localidadesRegistradas++;

            return true;
        }

        public Localidad BuscarPorId(int idLocalidad)
        {
            for (int i = 0; i < localidadesRegistradas; i++)
            {
                if (localidades[i].IdLocalidad == idLocalidad)
                {
                    return localidades[i];
                }
            }

            return null;
        }

        public bool ExisteId(int idLocalidad)
        {
            return BuscarPorId(idLocalidad) != null;
        }

        public Localidad[] ObtenerLocalidades()
        {
            Localidad[] resultado = new Localidad[localidadesRegistradas];

            for (int i = 0; i < localidadesRegistradas; i++)
            {
                resultado[i] = localidades[i];
            }

            return resultado;
        }

        public bool HayEspacioDisponible()
        {
            return localidadesRegistradas < capacidadMaxima;
        }

        public Localidad[] BuscarPorNombre(string nombreLocalidad)
        {
            int cantidadCoincidencias = ContarCoincidenciasPorNombre(nombreLocalidad);
            Localidad[] resultado = new Localidad[cantidadCoincidencias];

            LlenarCoincidenciasPorNombre(nombreLocalidad, resultado);

            return resultado;
        }

        private int ContarCoincidenciasPorNombre(string nombreLocalidad)
        {
            int coincidencias = 0;

            for (int i = 0; i < localidadesRegistradas; i++)
            {
                if (CoincideNombre(localidades[i], nombreLocalidad))
                {
                    coincidencias++;
                }
            }

            return coincidencias;
        }

        private bool CoincideNombre(Localidad localidad, string nombreLocalidad)
        {
            if (localidad == null || string.IsNullOrWhiteSpace(nombreLocalidad))
            {
                return false;
            }

            return localidad.NombreLocalidad
                .ToUpper()
                .Contains(nombreLocalidad.ToUpper());
        }

        private void LlenarCoincidenciasPorNombre(string nombreLocalidad, Localidad[] resultado)
        {
            int indiceResultado = 0;

            for (int i = 0; i < localidadesRegistradas; i++)
            {
                if (CoincideNombre(localidades[i], nombreLocalidad))
                {
                    resultado[indiceResultado] = localidades[i];
                    indiceResultado++;
                }
            }
        }

    }
}
