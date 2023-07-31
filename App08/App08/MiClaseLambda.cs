

namespace App08
{
    public class MiClaseLambda
    {
        private string theVal;
        public event miEventoHandler valueChanged;

        public string Val
        {
            set
            {
                this.theVal = value;
                this.valueChanged(theVal);
            }
        }
    }
}
