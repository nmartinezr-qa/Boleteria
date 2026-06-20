using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boleteria.Entidades
{
    public class Persona
    {
        public int Id { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Descripcion
        {
            get
            {
                return $"{Id} - {Nombre} {Apellido}";
            }
        }
        public DateTime FechaNacimiento { get; set; }

        public override string ToString()
        {
            return $"Id Persona: {Id}\nIdentificacion: {Identificacion}\nNombre: {Nombre}\nApellido: {Apellido}\nFecha de Nacimiento: {FechaNacimiento}";
        }
    }
}
