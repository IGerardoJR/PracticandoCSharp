using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App02
{
    // Internal = uso interno
    public class Libro : Publicacion
    {
        //public string _nombre;
        //protected string _autor;
        //private int _cantPaginas;


        //private string _nombre;

        //// No es un metodo, es una propiedad.
        //public string Nombre { get { return _nombre; } set { _nombre = value; } }
        
        private string _autor;
        // Propiedad
        public string Autor { get => _autor; set => _autor = value; }


        private int _cantPaginas;
        // Propiedad
        public int CantPaginas { get => _cantPaginas; set => _cantPaginas = value; }

        // Constructor por defecto
        // Los constructores permiten crear objetos dinamicamente


        // Ejemplo de la vida real.

        public string MiPropiedad { get; set; }
        public Libro() { }
        // Constructor parametrizado
        public Libro(string nombre, string autor, int cantPaginas, decimal precio):base(nombre,precio,cantPaginas)
        {
       
            _autor = autor;
      
        }

        //// Getters
        //public string GetNombre()
        //{
        //    return _nombre;
        //}
        //public string GetAutor()
        //{
        //    return _autor;
        //}
        //public int GetCantPaginas()
        //{
        //    return _cantPaginas;
        //}
        //// Setters 
        //public void SetNombre(string nombre) {
        //    _nombre = nombre;
      
        //}

        //public void SetAutor(string autor)
        //{
        //    _autor = autor;
        //}

        //public void SetCantPaginas(int cantPaginas)
        //{
        //    _cantPaginas = cantPaginas;
        //}

        //public string GetDescripcion()
        //{
        //    return $"El libro {_nombre} escrito por {_autor}, tiene {_cantPaginas} paginas";
        //}

        // Otra alternativa mas moderna

        // Escribimos el metodo con la palabra reservada "override"
        public override string GetDescripcion() => $"Libro : {Nombre} escrito por {Autor}, paginas {NumeroPaginas}";

    }
}
