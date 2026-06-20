using System;

namespace Boleteria.Entidades
{
    public class LocalidadPorPartido
    {
        public Partido Partido { get; set; }
        public Localidad Localidad { get; set; }
        public int CantidadDisponible { get; set; }

        public override string ToString()
        {
            return $"\nPartido: {Partido}\n\nLocalidad: {Localidad}\nCantidad Disponible: {CantidadDisponible}\n******************************";
        }
    }
}
