using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MiApp.Models
{
    public class Producto
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [NotNull]
        public int CategoriaId { get; set; }

        public String NombreProducto { get; set; }

        public string Descripcion { get; set; }
        
        public string Detalle{ get; set; }
        
        public string Imagen { get; set; }
        
        [NotNull]
        public double Precio { get; set; }

        [NotNull]
        public int Stock { get; set; }
    }
}
