using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App02
{
    // Para utilizar la herencia en C Sharp se utiliza ":"
    public class Revista : Publicacion
    {
        public string Periodista { get; set; }

        public Revista() { }
        public Revista(string? periodista, string nombre,int cantPaginas, decimal precio)
            :base(nombre,precio,cantPaginas)
        {
            Periodista = periodista;
        }
        public override string GetDescripcion() => $"Revista: {Nombre} escrito por el periodista: {Periodista}, paginas {NumeroPaginas}";

    }
}


