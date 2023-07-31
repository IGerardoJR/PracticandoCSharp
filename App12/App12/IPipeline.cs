
namespace App12
{
    // Interface generica que recibira dos argumentos
    // TInput : Lo que da el usuario
    // TOutput : El valor que regresaremos
    public interface IPipeline<TInput, TOutput>
            where TInput : BaseRequest
            where TOutput : IDisposable, new()
    {
        TOutput EjecutarTarea(TInput request);
    }
}
