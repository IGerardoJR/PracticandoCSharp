// Array
using System.Reflection.Metadata.Ecma335;

string[] personas = { "Juan", "Felipe", "Maria", "Jose" };

Console.WriteLine(personas[2]);
Console.WriteLine($"El tamaño del arreglo es de : {personas.Length}");

// Creacion de una lista
// List<TipoDeDato> nombVariable = new List<TipoDeDato>();
List<string> stringList = new List<string>();


// Agregar data al List desde un array string[]
//stringList.Add(personas[0]); // con .Add solo agrega un elemento a la vez

// Con .AddRange podemos agregar un array entero.
stringList.AddRange(personas);

stringList.Add("Isaias");

// Vemos la longitud de nuestra lista
Console.WriteLine($"La longitud de nuestra lista hasta ahora es de: {stringList.Count}");

// Consultar un elemento de la lista
Console.WriteLine(stringList[0]);


// Crear metodo para imprimir todos los elementos de una lista
static void imprimirLista(List<string> lista)
{
    for (int i = 0; i < lista.Count; i++)
    {
        Console.WriteLine($"Elemento de la lista: {lista[i]}");
    }

}
imprimirLista(stringList);
Console.WriteLine("Aqui termina la impresion de la lista");
// Eliminar un elemento de la lista.
stringList.Remove(stringList[2]);
// Imprimimos de nuevo la lista
imprimirLista(stringList);

// Usando contains para verificar si existe un elemento o no en la lista

var resultadoTernario = (stringList.Contains("Nancy") ? "Existe en la lista" : "El elemento solicitado no existe o fue eliminado");

Console.WriteLine(resultadoTernario);

stringList.Add("Juan Manuel Garcia");
// Busque aquellos nombres en la lista que tengan mas de 10 caracteres
var resultadoExist = stringList.Exists(x => x.Length > 10);


// Imprmimos el resultado
Console.WriteLine($"Existe un nombre de mas de 10 caracteres : {resultadoExist}");


// Busque un nombre que comienze con la letra V

stringList.Add("Veronica");
// La diferencia entre Find y Exists, es que Find devuelve el valor y Exists devuelve un booleano
var elementoConV = stringList.Find(x => x.StartsWith("V"));

Console.WriteLine($"El elemento que comienza con la letra V es : {elementoConV}");