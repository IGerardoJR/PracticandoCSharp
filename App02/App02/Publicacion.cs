using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App02
{
    public class Publicacion
    {
        public string? Nombre { get; set; }
        public decimal Precio { get; set; }
        public int NumeroPaginas { get; set; }

        public Publicacion() { }

        public Publicacion(string nombre, decimal precio, int numPaginas)
        {
            Nombre = nombre;
            Precio = precio;
            NumeroPaginas = numPaginas;
        }
        // Agregando la palabra reservada "virtual" hace que la logica del metodo sea sobrescrito por los hijos
        // o subclases
        public virtual string GetDescripcion() => $"{Nombre} precio {Precio}";

    }
}
