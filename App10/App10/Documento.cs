
using System.Collections.Specialized;
using System.ComponentModel;

namespace App10
{
    public class Documento : IOperaciones, IMensajeria, INotifyPropertyChanged
    {
        private string _nombre;
        public String DocumentoNombre
        {
            get { return _nombre; }
            set { _nombre = value;
                NotifyPropChanged("DocumentoNombre");
                 }
        }

        public Documento() { }

        public Documento(string nombre)
        {
            this._nombre = nombre;
        }

        // Interfaz construida por microsoft
        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropChanged(string propName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        // Implementamos los metodos de nuestra interfaz
        public void Cargar()
        {
            Console.WriteLine("Este metodo es para cargar un documento");

        }
        ///---------------------------------------------------------------------------
        // Implementando metodos de mensajeria 
        public void EnviarEmail()
        {
            Console.WriteLine("Enviar correo electronico por gmail");
        }

        public void EnviarMensajeTexto()
        {
            Console.WriteLine("Enviar mensaje de texto por iphone");
        }

        public void EnviarNotificacion()
        {
            Console.WriteLine("Enviar notificacion por login");
        }

        // -----------------------------------------------------------------------------
        // Metodos de IOperaciones
        public void Guardar()
        {
            Console.WriteLine("Este metodo es para guardar un documento");
        }

        public bool NecesitaGuardar()
        {
            Console.WriteLine("Invocando a necesito guardar");
            return false;  
        }
    }
}
