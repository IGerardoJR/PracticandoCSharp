
namespace App11
{
    public class EstudiantePrinterService
    {
       // private readonly IEstudianteRepository _estudianteRepository;
        private readonly IPersonaRepository<Estudiante> _estudianteRepository;
        public EstudiantePrinterService(IPersonaRepository<Estudiante> estudianteRepository)
        {
            _estudianteRepository = estudianteRepository;
        }

     

        public void PrintEstudiantes(int max=100)
        {

            // var estudiantes = _estudianteRepository.List().Take(max);/*.ToArray();*/
            //Array.Sort(estudiantes);
            //Console.WriteLine("Imprimiendo la lista de Estudiantes desde el metodo PrintEstudiantes");
            //for (int i = 0; i < estudiantes.Length && i < max; i++)
            //{
            //    Console.WriteLine(estudiantes[i]);
            //}
            var estudiantes = _estudianteRepository.OrdenarList().Take(max).ToArray();
            PrintEstudiantesConsola(estudiantes);

            var estudiantesBuscados = _estudianteRepository.Buscar("Cordova");
            PrintEstudiantesBuscados(estudiantesBuscados);

        }
        private void PrintEstudiantesConsola(IEnumerable<Estudiante> estudiantes)
        {
            Console.WriteLine("Estudiantes: ");
            foreach (var item in estudiantes)
            {
                Console.WriteLine(item);
            }
        }

        private void PrintEstudiantesBuscados(IEnumerable<Estudiante> estudiantes)
        {
            Console.WriteLine("Estudiantes buscados: ");
            foreach(var item in estudiantes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
