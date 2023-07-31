using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App11
{
    // Esta interfaz es para practicar el uso de Interfaces genericas
    // Representacion de un componente generico
    public interface IRepository<T> where T :Persona, IComparable<T>
    {
        IEnumerable<T> List();
        IEnumerable<T> OrdenarList();
    }
}
