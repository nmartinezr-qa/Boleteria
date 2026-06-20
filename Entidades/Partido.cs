namespace Boleteria.Entidades
{
    public class Partido
    {
        public int IdPartido { get; set; }
        public string Rival { get; set; }
        public string Descripcion
        {
            get
            {
                return $"{IdPartido} - {Rival}";
            }
        }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public bool Activo { get; set; }
        public override string ToString()
        {
            return $"\nId Partido: {IdPartido}\nRival: {Rival}\nFecha: {Fecha}\nHora: {Hora}\nActivo: {Activo}";
        }
    }
}
