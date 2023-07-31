
namespace App10
{       
    // Solo permiten crear metodos abstractos, mas no implementarlos.
    public interface IOperaciones
    {
        void Guardar();
        void Cargar();
        bool NecesitaGuardar();

    }
}
