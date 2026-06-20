
using Boleteria.Entidades;

namespace Boleteria.AccesoDatos
{
    public class GestorPartidos
    {
        public Partido[] partidos;
        int partidosRegistrados;
        int capacidadMaxima = 30;

        public GestorPartidos()
        {
            partidos = new Partido[capacidadMaxima];
            partidosRegistrados = 0;
        }

        public bool AgregarPartido(Partido nuevoPartido)
        {
            if (!HayEspacioDisponible())
            {
                return false;
            }

            partidos[partidosRegistrados] = nuevoPartido;
            partidosRegistrados++;

            return true;
        }
        public bool HayEspacioDisponible()
        {
            return partidosRegistrados < capacidadMaxima;
        }

        public Partido BuscarPorId(int idPartido)
        {
            for (int i = 0; i < partidosRegistrados; i++)
            {
                if (partidos[i].IdPartido == idPartido)
                {
                    return partidos[i];
                }
            }

            return null;
        }
        public bool ExisteId(int idPartido)
        {
            return BuscarPorId(idPartido) != null;
        }
        public Partido[] ObtenerPartidos()
        {
            Partido[] resultado = new Partido[partidosRegistrados];

            for (int i = 0; i < partidosRegistrados; i++)
            {
                resultado[i] = partidos[i];
            }

            return resultado;
        }

        public Partido[] BuscarPorRival(string rival)
        {
            int coincidencias = ContarCoincidenciasPorRival(rival);

            Partido[] resultado = new Partido[coincidencias];

            LlenarCoincidenciasPorRival(rival, resultado);

            return resultado;
        }
        private int ContarCoincidenciasPorRival(string rival)
        {
            int coincidencias = 0;

            for (int i = 0; i < partidosRegistrados; i++)
            {
                if (CoincideRival(partidos[i], rival))
                {
                    coincidencias++;
                }
            }

            return coincidencias;
        }

        private void LlenarCoincidenciasPorRival(string rival, Partido[] resultado)
        {
            int indiceResultado = 0;

            for (int i = 0; i < partidosRegistrados; i++)
            {
                if (CoincideRival(partidos[i], rival))
                {
                    resultado[indiceResultado] = partidos[i];
                    indiceResultado++;
                }
            }
        }
        private bool CoincideRival(Partido partido, string rival)
        {
            if (partido == null || string.IsNullOrWhiteSpace(rival))
            {
                return false;
            }

            return partido.Rival
                .ToUpper()
                .Contains(rival.ToUpper());
        }


    }
}
