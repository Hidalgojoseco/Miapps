using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MiApp.Models
{
    public class Categoria
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
         
        [NotNull]
        public string NombreCategoria { get; set; }

        public string Imagen { get; set; }
        
        [NotNull]
        public int? DepartamentoVentasId { get; set; } // Puede ser nulo si no pertenece a un Departamento de Ventas
    }
}
