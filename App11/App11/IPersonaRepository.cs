

namespace App11
{
    // Implementando todos los metodos de IRepository dentro de esta interface.
    // IRepository da los metodos de List y OrdenarListo, se agregan al IPersonaRepository
    public interface IPersonaRepository<T> : IRepository<T> where T: Persona, IComparable<T>, new()
    {
        IEnumerable<T> Buscar(string nombre);
        T Crear(NombreCompleto nombre);
        T CrearPorDefecto();
    }

    //public interface IPersonaRepository
    //{
    //    IEnumerable<T> Buscar<T>(string nombre) where T : Persona;

    //    T Crear<T>(NombreCompleto nombre) where T : Persona;

    //    T CrearPorDefecto<T>() where T : Persona;
    //}
}
