namespace ARCA_DE_NOE.Models
{
    public class Propietario
    {
        public int    Id        { get; set; }
        public string Nombre    { get; set; } = "";
        public string Apellidos { get; set; } = "";
        public string Telefono  { get; set; } = "";
        public string Email     { get; set; } = "";
        public bool   Activo    { get; set; } = true;
    }
}
