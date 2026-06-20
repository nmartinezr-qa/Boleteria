namespace Boleteria.Entidades
{
    public class Vendedor : Persona
    {
        public DateTime FechaIngreso { get; set; }
        public override string ToString()
        {
            return $"Id Vendedor: {Id}\nIdentificacion: {Identificacion}\nNombre: {Nombre}\nApellido: {Apellido}\nFecha de nacimiento: {FechaNacimiento}\nFecha de Ingreso: {FechaIngreso}";
        }

    }
}
