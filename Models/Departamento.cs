using SQLite;

namespace MiApp.Models
{
    public class Departamento
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [NotNull]
        public string NombreDepartamento { get; set; }
        [Ignore]
        public List<Provincia> Provincias { get; set; }
    }
}
