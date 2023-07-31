
namespace App11
{
    public class AutorPrinterService
    {
        //private readonly IAutorRepository _repository;
        private readonly IRepository<Autor> _repository;
        public AutorPrinterService(IRepository<Autor> repository)
        {
            _repository = repository;
        }

        public void PrintAutores()
        {
            var autores = _repository.List().ToArray();
            Array.Sort(autores);
            Console.WriteLine("Imprimiendo autores desde el metodo PrintAutores");
            for(int j = 0; j<autores.Length; j++)
            {
                Console.WriteLine(autores[j]);
            }
        }
    }
}
