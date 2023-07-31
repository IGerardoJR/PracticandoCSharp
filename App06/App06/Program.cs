// Eventos / Events

using App06;

var obj = new EventPublisher();
obj.valueChanged += delegate (string value)
{
    Console.WriteLine($"Se esta disparando el evento handler 1 {value}");
};

obj.valueChanged += new miEventoHandler(obj_valueChanged1);
obj.valueChanged += new miEventoHandler(obj_valueChanged2);

obj.miEvento += delegate (object sender, MiEventoArgs e)
{
    Console.WriteLine($" {sender.GetType} La propiedad valor que cambio es {e.data}");
};

void obj_valueChanged1(string value)
{
    // Logica
    Console.WriteLine($"Se esta disparando el evento handler 2 {value}");
}


void obj_valueChanged2(string value)
{
    Console.WriteLine($"Se esta disparando el evento handler 3 {value}");
}
string str;

do
{
    Console.WriteLine("Ingrese un valor: ");
    str = Console.ReadLine();
    str = str!.ToLower();
    if(!str.Equals("salir"))
    {
        obj.Val = str;
    }

} while (!str.Equals("salir"));

Console.WriteLine("Culmino el programa porque escribio salir");

public delegate void miEventoHandler(string value);