// Delegates, sirven para pasar funciones como parametros
// Teoria: Los Delegates podria ser parecidos al polimorfismo
using System;
using System.Linq;
using App05;

var objeto = new ClassFuncion();
MiDelegate f = objeto.func1;
Console.WriteLine($"El resultado es {f(10, 100)}");
f = objeto.func2;
Console.WriteLine($"El resultado es {f(10, 100)}");

var objeto2 = new MiClase();
f = objeto2.InstanciaDeMetodo;
Console.WriteLine($"El resultado de la formula es: {f(10, 100)}");

// A los delegate a los cuales se les agrega la logica al momento de la creacion
// Se les conoce como delegates anonimos.
MiDelegado j = delegate (int i, string s)
{
    return i + 100;
};

int resultado = j(250, "Es Isaias Cordova");
Console.WriteLine(resultado);
// Delegates compuestos
static void funcion1(int arg1, int arg2)
{
    string resultado = (arg1 + arg2).ToString();
    Console.WriteLine(resultado);
}

static void funcion2(int arg1, int arg2)
{
    string resultado = (arg1 * arg2).ToString();
    Console.WriteLine($"{resultado}");
}

TercerDelegado efe1 = funcion1;
TercerDelegado efe2 = funcion2;

TercerDelegado f1f2 = efe1 + efe2;
int arg1 = 10;
int arg2 = 20;

Console.WriteLine("Se esta ejecutando el primer delegate");
funcion1(arg1, arg2);
Console.WriteLine("Se esta ejecutando el segundo delegate");
funcion2(arg1, arg2);

Console.WriteLine("Se estan ejecutando el primer y segundo delegate al mismo tiempo");
f1f2(arg1, arg2);
// Si solo quisieramos ejecutar el segundo delegat
//f1f2 = f1f2 - funcion2;

f1f2 -= funcion2;
Console.WriteLine("Ejecutando la concatenacion pero sin el f2");
f1f2(arg1, arg2);

MiClase clase = new MiClase();

clase.func3("Isa");

clase.numeroRandom(50);

// Delegate normal
public delegate string MiDelegate(int arg1, int arg2);

// Se uso para un delegate anonimo
public delegate int MiDelegado(int i, string s);

// Delegate compuesto
public delegate void TercerDelegado(int arg1, int arg2);


