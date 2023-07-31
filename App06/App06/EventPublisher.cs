using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App06
{
    public class EventPublisher
    {
        public string theVal;

        public event miEventoHandler valueChanged;

        public event EventHandler<MiEventoArgs> miEvento;

        public string Val
        {
            set
            {
                this.theVal = value;
                this.valueChanged(theVal);
                this.miEvento(this, new MiEventoArgs { data = theVal });
            }
        }
    }
}
