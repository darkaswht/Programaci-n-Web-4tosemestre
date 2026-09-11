namespace ARCA_DE_NOE.Models
{
    /// <summary>Mascota / paciente de la clínica.</summary>
    public class Mascota
    {
        public int      Id               { get; set; }          // PK — INT IDENTITY
        public int      PropietarioId    { get; set; }          // FK → Propietario.Id — INT
        public string   NombrePropietario{ get; set; } = "";    // NVARCHAR(260) — campo de visualización
        public string   Nombre           { get; set; } = "";    // NVARCHAR(100)
        public string   Especie          { get; set; } = "";    // NVARCHAR(50)
        public string   Raza             { get; set; } = "";    // NVARCHAR(100)
        public DateOnly FechaNacimiento  { get; set; }          // DATE
        public string   Color            { get; set; } = "";    // NVARCHAR(80)
        public bool     Activo           { get; set; } = true;  // BIT
    }
}
