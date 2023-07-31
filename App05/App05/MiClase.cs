using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App05
{
    public class MiClase : ClassFuncion
    {
        public string InstanciaDeMetodo(int a, int b)
        {
            return ((a + b) * a).ToString();
        }

        public override string func3(string cad)
        {
            Console.WriteLine($"He sobrescrito esta funcion: {func3}");
            return cad;
        }
    }
}
