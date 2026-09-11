namespace ARCA_DE_NOE.Models
{
    /// <summary>Propietario de una o más mascotas.</summary>
    public class Propietario
    {
        public int    Id        { get; set; }           // PK — INT IDENTITY
        public string Nombre    { get; set; } = "";     // NVARCHAR(100)
        public string Apellidos { get; set; } = "";     // NVARCHAR(150)
        public string Telefono  { get; set; } = "";     // NVARCHAR(20)
        public string Email     { get; set; } = "";     // NVARCHAR(200)
        public bool   Activo    { get; set; } = true;   // BIT
    }
}
