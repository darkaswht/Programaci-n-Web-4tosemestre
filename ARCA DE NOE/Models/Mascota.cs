namespace ARCA_DE_NOE.Models
{
    public class Mascota
    {
        public int      Id                { get; set; }
        public int      PropietarioId     { get; set; }
        public string   NombrePropietario { get; set; } = "";
        public string   Nombre            { get; set; } = "";
        public string   Especie           { get; set; } = "";
        public string   Raza              { get; set; } = "";
        public DateOnly FechaNacimiento   { get; set; }
        public string   Color             { get; set; } = "";
        public bool     Activo            { get; set; } = true;
    }
}
