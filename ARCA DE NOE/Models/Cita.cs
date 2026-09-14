namespace ARCA_DE_NOE.Models
{
    public enum EstadoCita
    {
        Pendiente  = 0,
        Completada = 1,
        Cancelada  = 2
    }

    public class Cita
    {
        public int        Id                { get; set; }
        public int        MascotaId         { get; set; }
        public string     NombreMascota     { get; set; } = "";
        public int        VeterinarioId     { get; set; }
        public string     NombreVeterinario { get; set; } = "";
        public DateTime   FechaHora         { get; set; }
        public string     Motivo            { get; set; } = "";
        public EstadoCita Estado            { get; set; } = EstadoCita.Pendiente;
        public string     Diagnostico       { get; set; } = "";
    }
}
