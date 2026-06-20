namespace Boleteria.Entidades
{
    public class Localidad
    {
        public int IdLocalidad { get; set; }
        public string NombreLocalidad { get; set; }
        public string Descripcion
        {
            get
            {
                return $"{IdLocalidad} - {NombreLocalidad}";
            }
        }
        public decimal Precio { get; set; }

        public override string ToString()
        {
            return $"\nId Localidad: {IdLocalidad}\nNombre: {NombreLocalidad}\nPrecio: {Precio}";
        }
    }
}
