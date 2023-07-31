//// Invocamos a la clase
//using App02;

//Libro libro = new Libro();

//libro.SetNombre("El libro vaquero");

//Console.WriteLine(libro.GetNombre());


//Libro miLibro = new Libro("Don Quijote de la mancha", "Quijote", 5000);

//var resultado = miLibro.GetDescripcion();

//Console.WriteLine(resultado);
//// Accessor

//    public - Puede ser accesible desde cualquier recurso
//    protected - Se aplica para metodos o clases que solo puede ser accesibles por codigo de 
//                la misma clase o subclase.
//    private - El metodo o clase miembro solo puede ser accesible por el codigo dentro de la clase donde se definio la variable o propiedad.
// */

//// Ahora que hemos cambiado su modificador de acceso a public, ahora si nos permite trabajar con el.
////miLibro._nombre = "Quijote parte 2";

////Console.WriteLine(miLibro._nombre);

//// Si el metodo es privado se puede acceder al atributo con un setter
//miLibro.SetCantPaginas(50);

//Console.WriteLine(miLibro.GetCantPaginas());


//Libro donQuijote = new Libro();
//donQuijote.Nombre = "Don Quijote X Parte 3";

//donQuijote.Autor = "Mario Blass";
//donQuijote.CantPaginas = 900;


using App02;
///*
Libro donQuijote = new Libro("Don Quijote", "Miguel de Cervantes", 5000, 20.58m);

var libroResultado = donQuijote.GetDescripcion();

Console.WriteLine(libroResultado);

Revista revistaTimes = new Revista("Maria Lopez", "Times", 50, 10.10m);
var revistaResultado = revistaTimes.GetDescripcion();
Console.WriteLine(revistaResultado);







