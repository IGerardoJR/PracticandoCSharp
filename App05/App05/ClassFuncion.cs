using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App05
{
    public class ClassFuncion
    {

        
        public string func1( int a, int b)
        {
            return (a + b).ToString();
        }

        public string func2(int a, int b)
        {
            return (a*b).ToString();
        }

        public virtual string func3(string cad)
        {
            return cad;
        }
        
        public virtual int numeroRandom(int num)
        {
            Random ran = new Random(num);
            var resultado = ran.Next(0, num);
            Console.WriteLine($"El numero random que obtuviste fue : {resultado}");
            return resultado;
        }

        
    }
}
