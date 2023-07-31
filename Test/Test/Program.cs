using System;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using Test;

var test1 = "[ERROR]: Invalid Operation";

//var logLine = new LogLine();
string concad = "";

// Implementamos un ciclo para que empieze a imprinir despues del caracter en blanco

// Espacio en blanco = 32
int contadorBlancos = 0;
foreach(var car in test1)
{
    var result = (car == 32) ? contadorBlancos++ : car;
    if(contadorBlancos>0)
    {
        concad += car;
    }
  
}

static string eliminacionEspacios(string cadena)
{
    string auxiliar = "";
    int contador = 0;
    foreach (var car in cadena)
    {

        var resultado = (car == 32) ? $"{contador++}" : "";
        if(contador >= 1)
        {
            auxiliar += car;
        }

    }
    Console.WriteLine(contador);
    return auxiliar;
}


// Imprimimos la cadena final
Console.WriteLine(concad);

Console.WriteLine(eliminacionEspacios("a lele pancha"));

