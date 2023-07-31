// Interfaces vs Clases

using App10;
using System.ComponentModel;

var documento = new Documento("miDocumento");

documento.Cargar();
documento.Guardar();
documento.NecesitaGuardar();


// Comparando si documento pertenece a IOperaciones.
if (documento is IOperaciones)
{
    documento.Guardar();
}
//                  casteando documento a un tipo de dato de la interface : IOperaciones
IOperaciones iop=documento as IOperaciones;
// NOTAS: si la transformacion es correcto, entonces IOperaciones sera diferente de nulo.
// Si no lo cumple, entonces vamos a tener un null/nulo.

if ( iop is not null)
{
    documento.Guardar();
}

// Usando los metodos o funcionalidades de IOperaciones en el mismo obj

documento.EnviarNotificacion();
documento.EnviarMensajeTexto();
documento.EnviarEmail();

IMensajeria imensajeria = documento as IMensajeria;

if (imensajeria is not null)
{
    documento.EnviarNotificacion();
}


documento.PropertyChanged += delegate (object sender, PropertyChangedEventArgs e)
{
    Console.WriteLine($"La propiedad del documento que cambio es: {e.PropertyName}");
};

documento.DocumentoNombre = "Quijote de la mancha";