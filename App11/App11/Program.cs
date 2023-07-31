
//using App11;

//var Estudiantes = new Estudiante[10];

//Estudiantes[0] = new Estudiante("Isaias","Cordova");
//Estudiantes[1] = new Estudiante("Hola", "Mundo");
//Estudiantes[2] = new Estudiante("Joaquin", "Guzman");
//Estudiantes[3] = new Estudiante("Lola", "Vazquez");
//Estudiantes[4] = new Estudiante("Gabriela", "Lopez");


//Array.Sort(Estudiantes);

//foreach(var item in Estudiantes)
//{
//    Console.WriteLine(item);

//}





//var autores = new Autor[10];
//for(int i = 5; i<Estudiantes.Length; i++)
//{
//    autores[i] = new Autor(Estudiantes?[i].Nombre, Estudiantes?[i].Apellido);
//}

//Console.WriteLine($"Esta es la lista de autores:");

//for(int i = 0 ; i < autores.Length; i++)
//{
//    Console.WriteLine(autores[i]);
//}

//Console.WriteLine("Linea separadora");
//var estudianteService = new EstudiantePrinterService(new EstudianteRepository());
//estudianteService.PrintEstudiantes(5);

//Console.WriteLine("Linea separadora");
//var autorService = new AutorPrinterService(new AutorRepository());
//autorService.PrintAutores();


//Console.WriteLine($"Total de estudiantes {Estudiante.EstudianteCount}");

using App11;

var estudianteService = new EstudiantePrinterService(new EstudianteRepository());
estudianteService.PrintEstudiantes(5);