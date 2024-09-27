using SQLite;

namespace MiApp.Models
{
    public class Provincia
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [NotNull]
        public int DepartamentoId { get; set; }
        [NotNull]
        public string NombreProvincia { get; set; }
        [Ignore]
        public List<Distrito> Distritos { get; set; }
    }
}
