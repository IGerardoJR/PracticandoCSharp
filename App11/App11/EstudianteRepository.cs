using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App11
{
    public class EstudianteRepository : IPersonaRepository<Estudiante>    // IRepository<Estudiante>
    {
        private NombreCompleto[] _nombres = new NombreCompleto[5];

        public EstudianteRepository()
        {
            //             Al ser record no necesita una definicion de clase Estudiante
            _nombres[0] = new ("Isaias", "Cordova");
            _nombres[1] = new ("Hola", "Mundo");
            _nombres[2] = new ("Joaquin", "Guzman");
            _nombres[3] = new ("Lola", "Vazquez");
            _nombres[4] = new ("Gabriela", "Lopez");
        }

        public IEnumerable<Estudiante> Buscar(string nombre)
        {
            return List().Where(estudiante => estudiante.Nombre!.Contains(nombre) || 
                                    estudiante.Apellido!.Contains(nombre));
        }

        public Estudiante Crear(NombreCompleto nombre)
        {
            return new Estudiante(nombre.PrimerNombre, nombre.Apellido);
        }

        public Estudiante CrearPorDefecto()
        {
            return new Estudiante();
        }

        public IEnumerable<Estudiante> List()
        {
            int index = 0;
            while(index < _nombres.Length)
            {
                // yield agrega los elementos que se estan generando de forma dinamica.
                 yield return new Estudiante(_nombres[index].PrimerNombre, _nombres[index].Apellido);
                index++;
            }
          
        }

        public IEnumerable<Estudiante> OrdenarList()
        {
            var estudiantes = List().ToList();
            estudiantes.Sort();
            return estudiantes;
        }
    }
}
