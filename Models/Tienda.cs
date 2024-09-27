using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MiApp.Models
{
    public class Tienda
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [NotNull]
        public string NombreTienda { get; set; }
        [NotNull]
        public string Direccion { get; set; }
    }
}
