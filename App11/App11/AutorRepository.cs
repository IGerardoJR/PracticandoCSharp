
namespace App11
{
    public class AutorRepository : IRepository<Autor>
    {
        public IEnumerable<Autor>  List()
        {
            var autores = new Autor[10];

            autores[0] = new Autor("Isaias", "Cordova");
            autores[1] = new Autor("Hola", "Mundo");
            autores[2] = new Autor("Joaquin", "Guzman");
            autores[3] = new Autor("Lola", "Vazquez");
            autores[4] = new Autor("Gabriela", "Lopez");

            return autores;
        }

        public IEnumerable<Autor> OrdenarList()
        {
            throw new NotImplementedException();
        }
    }
}
