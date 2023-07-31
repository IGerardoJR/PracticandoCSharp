
namespace App11
{
    public class Estudiante : Persona, IComparable<Estudiante>
    {
        // La clase abstracta ya la definio, por eso se comento estas dos lineas

        //public string? Nombre { get; set; }
        //public string? Apellido { get; set; }

        //public static int EstudianteCount = 0;

        public Estudiante() { }

        public Estudiante(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
            //EstudianteCount += 1;
        }

        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }

        public int CompareTo(Estudiante? est)
        {
            //if( object == null)
            //{
            //    return 1;
            //}

            //if(obj is Estudiante estudiante)
            //{
            if (est?.Apellido == this.Apellido)
            {
                return this.Nombre!.CompareTo(est?.Nombre);
            }
            return this.Apellido.CompareTo(est?.Apellido);
            //}
            //    throw new ArgumentException("No es un objeto de tipo estudiante", nameof(obj));
            //}
        }
    }


    // Nos permite almacenar una coleccion de datos, similar a una clase, pero con un poco menor de funcionlidades
    public record NombreCompleto(string PrimerNombre, string Apellido);
}
