// Eventos y metodos en Lambda


using App08;

var miClaseLambda = new MiClaseLambda();
miClaseLambda.valueChanged += (x) =>
{
    Console.WriteLine($"El valor de la propiedad cambio: {x}");
};

string str;

do
{
    str = Console.ReadLine();
    if(!str.Equals("salir")) {

        miClaseLambda.Val = str;
    }

} while (!str.Equals("salir"));

Console.WriteLine("Salio del bucle");
public delegate void miEventoHandler(string value);