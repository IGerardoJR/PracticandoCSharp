// Viendo los efectos de Covariance y Contravariance

Base x = new Base();
// Asignando los valores de un objeto more-derivated a un less-derivated
Base y = new Derivated();

x.EjecutarEnBase();
y.EjecutarEnBase();

//y.EjecutarEnDerivada(); // Error, toma valor tipo base y base no reconoce este metodo.

Console.WriteLine("--------------------------------------------------");
Derivated z = new Derivated();
z.EjecutarEnDerivada();
z.EjecutarEnBase();

IProducer<Base> prodBase = null;
Base bs = prodBase.Produce();

//Derivated bz = prodBase.Produce(); // => ERROR => La definicion de un IProducer como un covariant se hizo con la clase implementacion base


IProducer<Derivated> prodDerivated = null!;
Derivated ds = prodDerivated.Produce();
Base bs1 = prodDerivated.Produce();


// Contravariant 
IConsumer<Base> consBase = null!;
consBase.Consume(new Base());
consBase.Consume(new Derivated());


IConsumer<Derivated> consDerivated = null!;
consDerivated.Consume(new Derivated());
//consDerivated.Consume(new Base()); // => ERROR => Solo acepta desde more-derivated hacia less-derivated


// out: Es un indicativo que senala que se trata de un covariant type.
interface IProducer<out T>
{
    T Produce();
}

// in: significa que un objeto esta ingresando al objeto interface | contravariant
interface IConsumer<in T>
{
    void Consume(T obj);
}


// Less derivated
class Base
{
    public void EjecutarEnBase() => Console.WriteLine($"Ejecutando desde {GetType().Name}");
}

// More derivated
class Derivated : Base
{
    public void EjecutarEnDerivada() => Console.WriteLine($"Ejecutando derivada: {GetType().Name}");

}



// Variance : Representa el proceso de asignar o sustituir el valor de un objeto por otro
