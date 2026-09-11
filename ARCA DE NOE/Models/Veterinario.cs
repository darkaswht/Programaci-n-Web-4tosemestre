namespace ARCA_DE_NOE.Models
{
    /// <summary>Médico veterinario de la clínica.</summary>
    public class Veterinario
    {
        public int    Id           { get; set; }          // PK — INT IDENTITY
        public string Nombre       { get; set; } = "";    // NVARCHAR(100)
        public string Apellidos    { get; set; } = "";    // NVARCHAR(150)
        public string Especialidad { get; set; } = "";    // NVARCHAR(100)
        public string Telefono     { get; set; } = "";    // NVARCHAR(20)
        public bool   Activo       { get; set; } = true;  // BIT
    }
}
