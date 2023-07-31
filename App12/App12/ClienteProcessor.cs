using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App12
{
    public class ClienteProcessor : IProcessor<Cliente>, ILogger
    {
        // Metodo no generico
        public void Process(Cliente input)
        {
            Console.WriteLine($"Processing Cliente: {input}");
        }

        // Metodo generico : estatico
        public static void GenericStaticProcess<TGeneric>(TGeneric input)
        {
            Console.WriteLine($"Ejecutando GenericStaticProcess {input}");
        }

        // Metodo de la interfaz ILogger
        public void Log<T>(T input)
        {
            Console.WriteLine($"Ejecutando el metodo generico void LOG: {input}");
        }
    }
}
