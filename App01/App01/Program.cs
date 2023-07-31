// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Simple output
Console.WriteLine("Escribiendo mis primeras lineas de codigo");

string variable = "Isaias";
string miSecond = "Gerardo";

Console.WriteLine("Hola {1}", variable,miSecond);

int miNumero = 100;

int negativoNumero = -100;

float miFloatNumero = 62.30f; // Cuando se utiliza float en c sharp se concatena al final la letra f

double miDobleNumero = 96.25;

decimal miDecimal = 487.567m; // cuando se utiliza decimal, necesita al final concatenar m

byte miNumeroPequeno = 255; // Valor entre 0 - 255

// booleano solo puede tener dos balores :  true | false

bool statusProducto = false;

string miCadena = "Esta es mi cadena de texto";

char miCaracter = 'B';

Console.WriteLine(miCaracter);

const int miConstante = 500; // Valor 

bool? miVariableNull = null; // ? 
int? miNumeroNull = null; // ?

string miCadenaNull = null; // Por defecto mi string si acepta valores null.


// Seccion 4: Estructuras de control lógico


/*
 Este algoritmo se encarga de realizar las operaciones basicas de dos numeros :
 */


static float Suma (float num1, float num2)
{
    float suma = num1 + num2;
    return suma;
}

static float Resta(float num1, float num2)
{
    float resta = num1 - num2;
    return resta;
}


Console.WriteLine("Porfavor, ingrese su primer numero");
var num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Porfavor, ingrese su segundo numero");
var num2 = int.Parse(Console.ReadLine());
// Imprimimos el resultado.
Console.WriteLine("La suma de los numeros es : {0}",Suma(num1, num2));

// Resta
Console.WriteLine($"El resultado de la resta es : {Resta(num1, num2)}");


Console.WriteLine("Operadores de asignacion");
var resultadoSuma = num1 + num2;
Console.WriteLine(resultadoSuma);

// El usuario ingresa el numero que representa cuantas veces se generara el valor aleatorio
// En el bucle generara un numero aleatorio entre 1 a 1000.
// Imprimir dentro del bucle este numero aleatorio previamente generado.

void imprimirNumeroAleatorio()
{
    Console.WriteLine("Ingrese el numero de veces a generar aleatorios");
    var numeroRango = int.Parse(Console.ReadLine()!);
    var ran = new Random();

    for(int i = 1; i<= numeroRango;i++)
    {
        var numeroAleatorio = ran.Next(1,100);
        Console.WriteLine($"El numero aleatorio fue : {numeroAleatorio}");
    }
}

imprimirNumeroAleatorio();

Suma(num2: 20, num1: 30);

// Tuplas
Console.WriteLine("Trabajando con tuplas");

(int a, string b, bool c) miTupla = (20,"Isaias",true);

var miTuplaValorA = miTupla.a;
Console.WriteLine($"Mi primer valor de tupla {miTuplaValorA}");


// Objetivo : Registrar un nuevo producto en una tienda

Console.WriteLine("Ingrese el nombre del producto");
var nombreProducto = Console.ReadLine();

Console.WriteLine("Ingrese el precio del producto");
var precioProducto = int.Parse(Console.ReadLine()!);

Console.WriteLine("Ingrese el stock del producto");
var stockProducto = int.Parse(Console.ReadLine()!);

(string, int, int) tuplaProducto = (nombreProducto, precioProducto, stockProducto);

(double,int,string) GetProducto(string nombreProducto, int precioProducto, int stock)
{
    var precioFinal = precioProducto + precioProducto * 0.2;
    return (precioFinal, stock, nombreProducto);
}

var tupla = GetProducto(nombreProducto!, precioProducto, stockProducto);

Console.WriteLine($"Datos del producto {tupla.Item1} \n\n Precio final : {tupla.Item2} \n\n " +
    $"Stock: {tupla.Item3}");



