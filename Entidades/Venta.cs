using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Boleteria.Entidades
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }
        public Partido Partido { get; set; }
        public Localidad Localidad { get; set; }
        public LocalidadPorPartido LocalidadPorPartido { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal Total { get; set; }

        public override string ToString()
        {
            return $"Id Venta: {IdVenta}\nCliente: {Cliente}\nVendedor: {Vendedor}\nPartido: {Partido}\nLocalidad: {Localidad}\nCantidad: {Cantidad}\nFecha de venta: {FechaVenta}\nTotal: {Total}";
        }
    }
}
