using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
    public class LibroAutor
    {
        public string NombreAutor { get; set; } = null;
        public string NombreLibro { get; set; } = null;
        public int Chapters { get; set; }

        public int Pages { get; set; }

        public int Price { get; set; }
    }
}
