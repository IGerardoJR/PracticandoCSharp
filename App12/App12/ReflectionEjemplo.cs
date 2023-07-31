using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace App12
{
    public class ReflectionEjemplo
    {
        // Imprimir en la consola el conjunto de tipos con su determinada descripcion.
        private static void ListTypeDetails(List<Type> types)
        {
            Console.WriteLine("Type Nombre".PadRight(20) + "|" + "Is generic type?".PadRight(20)
                + "|" + "Is generic definition?".PadRight(20) + "|" + "Generic Arguments"
                );

            foreach (var type in types)
            {
                string output = type.Name.PadRight(20) + "|";
                output += type.IsGenericType.ToString().PadRight(20) + "|";
                output += type.IsGenericTypeDefinition.ToString() + "|";
                output += type.GetGenericArguments().Count();

                // Llamando al metodo
                // ListGenericMethods(type);


                Console.WriteLine($"{output}");
                ListParameterDetails(type);



            }
        }

        // Metodo ListParameterDetails
        private static void ListParameterDetails(Type type)
        {
            //throw new NotImplementedException();
            var parameters = type.GetGenericArguments();
                foreach(var parameter in parameters)
            {
                
                if (parameter.IsGenericParameter)
                {
                    DisplayGenericParameter(parameter);
                }
                else
                {
                    DisplayTypeArgument(parameter);
                }
            }
        }

        private static void DisplayGenericParameter(Type parameter)
        {
            var constraints = parameter.GetGenericParameterConstraints();
            Console.WriteLine($"Type parameter position: {parameter.GenericParameterPosition} +     " +
                $"Nombre: {parameter.Name} + " +
                $"contraints: {constraints.Length} +    " +
                $"attributeMask: {parameter.GenericParameterAttributes}");

            if(constraints.Any())
            {
                Console.WriteLine(" Nombre  |   Interface?  |   Class?  |   Enum?   ");
                foreach(var contraint in constraints)
                {
                    Console.WriteLine(" " + contraint.Name.PadRight(16) + "|" +
                        contraint.IsInterface.ToString().PadRight(11) + "|" +
                        contraint.IsClass.ToString().PadRight(7) + "|" +
                        contraint.IsEnum.ToString().PadRight(16));
                }
            }


            
            
        }

        private static void DisplayTypeArgument(Type parameter)
        {
            Console.WriteLine($"Type Argument: {parameter.Name}");
        }

        private static void ListGenericMethods(Type type)
        {
            var metodos = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                .Where(m => m.DeclaringType!.Name != "Object");

            Console.WriteLine($"Metodos del tipo {type.Name}");
            Console.WriteLine("Nombre       | isGeneric         | isGenericDef      | ContainsGenParam");
            int colWidth = 12;
            foreach(var metod in metodos)
            {
                int maxNombreLen = Math.Min(metod.Name.Length,colWidth);
                Console.WriteLine(metod.Name.Substring(0, maxNombreLen).PadRight(colWidth));
                Console.Write("|");
                Console.Write(metod.IsGenericMethod.ToString().PadRight(colWidth));
                Console.Write("|");
                Console.Write(metod.IsGenericMethodDefinition.ToString().PadRight(colWidth));
                Console.WriteLine(metod.ContainsGenericParameters.ToString().PadRight(colWidth));
                
                // Condicion logica
                if(metod.IsGenericMethod)
                {
                    Console.WriteLine("Ejecutando un metodo generico...");
                    var parametros = metod.GetGenericArguments();
                    foreach(var parametro in parametros)
                    {
                        if(parametro.IsGenericParameter)
                        {
                            Console.WriteLine($"Parametro generico: {parametro.GenericParameterPosition} {parametro.Name}");
                        }
                    }
                    // Ejecucion del metodo
                    MethodInfo genericMethod = metod.MakeGenericMethod(typeof(Cliente));
                  
                    // ? Para que acepte valores nulos.
                    object? instancia = null;
                    // Si el metodo no es statico
                    if(!genericMethod.IsStatic)
                    {
                        instancia = Activator.CreateInstance(type)!; // Crea instancias de objetos pasandole como parametro el tipo de dato generico
                    }
                    genericMethod.Invoke(instancia, new[] { new Cliente("Isaias", "Cordova") });
                }
               
            }



        }
        public static void execute()
        {
            var types = new List<Type>
            {
                //typeof(IProcessor<>), // Generico
                //typeof(IProcessor<Cliente>), // Implementando a Cliente
                //typeof(Processor<>), // Clase
                //typeof(Processor<Cliente>), // Clase generica
                //typeof(ClienteProcessor)


                // Comentamos lo anterior porque queremos ver el efecto de los Generic Types
                // Cuando se tiene dos o mas argumentos se antepone una "," antes de cerrar el bracket
                typeof(IPipeline<,>)
            };

            ListTypeDetails(types);

            Type[] typeArguments = { typeof(Request), typeof(Response) };

            var specificType = typeof(Pipeline<,>).MakeGenericType(typeArguments);

            var crearInstancia = Activator.CreateInstance(specificType);

            ListTypeDetails(new List<Type> { crearInstancia!.GetType() });

            // Parseandolo a un tipo dinamico
            ((dynamic)crearInstancia).EjecutarTarea(new Request());

 
             


            var openInterface = typeof(IProcessor<>);
            Console.WriteLine($"El IProcessor<> es generico? {openInterface.IsGenericType}"); // true
            Console.WriteLine($"El IProcessor<> su definicion es generica? {openInterface.IsGenericTypeDefinition}"); // true

            var closeInterface = typeof(IProcessor<Cliente>);
            Console.WriteLine($"El IProccesor<Cliente> es generico? {closeInterface.IsGenericType}"); // true
            Console.WriteLine($"El IProccesor<Cliente> su definicion es generica? {closeInterface.IsGenericTypeDefinition}"); // false ;

            var definition = closeInterface.GetGenericTypeDefinition();
            var resultado = definition == openInterface;
            Console.WriteLine($"El resultado de las definiciones es: {resultado}");
        }
    }
}
