using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App11
{
    public class Autor : Persona, IComparable<Autor>
    {
      // Se removieron las propiedades de Nombre y Apellido porque vienen heredadas de persona.

        public Autor(string? nombre, string? apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }


        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }

        public int CompareTo(Autor? aut)
        {
            return this.ToString().CompareTo(aut?.ToString());
            //return 1;
        }
        //public int CompareTo(object? obj)
        //{
        //    if(obj is null ) { return 1; }

        //    if(obj is Autor miAutor)
        //    {
        //        return this.ToString().CompareTo(miAutor.ToString());
        //    }
        //    throw new ArgumentException("No es un tipo Autor", nameof(obj));
        //}

      
    }
}
