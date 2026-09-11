namespace ARCA_DE_NOE.Models
{
    /// <summary>Estado posible de una cita veterinaria.</summary>
    public enum EstadoCita
    {
        Pendiente  = 0,   // TINYINT
        Completada = 1,
        Cancelada  = 2
    }

    /// <summary>Cita / consulta veterinaria.</summary>
    public class Cita
    {
        public int        Id               { get; set; }         // PK — INT IDENTITY
        public int        MascotaId        { get; set; }         // FK → Mascota.Id — INT
        public string     NombreMascota    { get; set; } = "";   // NVARCHAR(100) — visualización
        public int        VeterinarioId    { get; set; }         // FK → Veterinario.Id — INT
        public string     NombreVeterinario{ get; set; } = "";   // NVARCHAR(260) — visualización
        public DateTime   FechaHora        { get; set; }         // DATETIME2
        public string     Motivo           { get; set; } = "";   // NVARCHAR(300)
        public EstadoCita Estado           { get; set; } = EstadoCita.Pendiente;  // TINYINT
        public string     Diagnostico      { get; set; } = "";   // NVARCHAR(MAX)
    }
}
