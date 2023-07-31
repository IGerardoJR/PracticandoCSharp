// Listas enlazadas.

string[] canciones =
{
    "Imagine",
    "One",
    "Billie Jean",
    "Hey Jude",
    "Prayer of refugee",
    "The show must go on",
    "Born to Run",
    "Creep",
    "Yesterday",
    "My generation",
    "Pinball Wizzard",
    "Knights of Cydonia"
};

// Creando un Linked List
//          tipoDato    objeto                                  lista/array
LinkedList<string> cancionesLinkedList  = new LinkedList<string>(canciones);

// Agregando elementos al inicio y al final de la lista.
cancionesLinkedList.AddFirst("Painkiller");

// Agregando una cancion al final.
cancionesLinkedList.AddLast("Constant Motion");


static void imprimirLinkedList(LinkedList<string> listaEnlazada)
{
    // Imprimiendo nuestra lista enlazada.
    foreach (string i in listaEnlazada)
    {
        Console.WriteLine($"Elemento de la lista enlazada(LinkedList) : {i}");
    }

}

imprimirLinkedList(cancionesLinkedList);
// Buscamos el primer y ultimo elemento de la lista.

LinkedListNode<string> primeraCancion = cancionesLinkedList.First!;
LinkedListNode<string> ultimaCancion = cancionesLinkedList.Last!;


// Primera cancion
Console.WriteLine("Primera cancion : ",primeraCancion.Value);
// Ultima cancion
Console.WriteLine("Ultima cancion : ",ultimaCancion.Value);

// Los elementos pueden ser agregados o removidos dependiendo de un item existente
cancionesLinkedList.AddAfter(primeraCancion,"mi segunda cancion");
Console.WriteLine("Lista de canciones con mi segunda cancion");
imprimirLinkedList(cancionesLinkedList);

// Buscar elementos utilizando el metodo Contains                      true/false     
Console.WriteLine($"Buscando la cancion Imagine: {cancionesLinkedList.Contains("Imagine")}");

// Acceder a la data utilizando los metodos siguiente(Next) y Anterior (Previous)
Console.WriteLine($"La cancion que continua despues de la primera cancion: {primeraCancion.Next!.Value}");

// Anterior a la ultima
Console.WriteLine($"La cancion anterior a la ultima cancion : {ultimaCancion.Previous!.Value}");



// Diccionarios
Dictionary<string, string> miDiccionario = new Dictionary<string, string>();

// Agregar elementos a un diccionario
miDiccionario.Add(".doc","Documentos de Word");
miDiccionario.Add(".txt", "Bloc de notas");
miDiccionario.Add(".html", "Paginas web");
miDiccionario.Add(".jpg", "Archivo de imagen");

//// Agregando un elemento con un key repetido
///             TryAdd
//miDiccionario.Add(".html", "Archivo Web"); // must throw an error
// Imprimir elementos del diccionario
foreach( KeyValuePair<string,string> elemento in   miDiccionario)
{
    Console.WriteLine($"Imprime el elemento: {elemento.Key} - {elemento.Value}");
}

// Actualizar el valor de un elemento del diccionario
miDiccionario[".txt"] = "Este es el nuevo valor del documento .txt";

// Buscar elementos de un diccionario por la key y por el valor
Console.WriteLine($"Buscando un key bpm: {miDiccionario.ContainsKey(".txt")}");
Console.WriteLine($"Buscando un value html: {miDiccionario.ContainsValue("Paginas web")}");

// Eliminar un diccionario
miDiccionario.Remove(".jpg");


foreach (KeyValuePair<string, string> elemento in miDiccionario)
{
    Console.WriteLine($"Imprime el elemento: {elemento.Key} - {elemento.Value}");
}
