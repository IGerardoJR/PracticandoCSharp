// Lambda functions



// Primer delegado
using System.Numerics;
/// Las lamba functions son otra manera de implementar delegates
///  anonimos o funciones anonimas
///  Se definen usando el operador => 
MiDelegado d1 = (x) => x * x;
Console.WriteLine($"El resultado es {d1(5)}");

d1 = (x) => x * 10;
Console.WriteLine($"El resultado de multiplicar 7 por 10 es : {d1(7)}");

// Mi delegado dos
MiDelegadoDos d2 = (x, y) =>
{
    Console.WriteLine($"Valor de X : {x} \n Valor de Y: {y}");
};

BooleanoDelegado d3 = (x) => x > 10;

Console.WriteLine($"Delegado booleano devolvio : {d3(11)}");

public delegate int MiDelegado(int x);
public delegate void MiDelegadoDos(int x, string s);
public delegate bool BooleanoDelegado(int x);