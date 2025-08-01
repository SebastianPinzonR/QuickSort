using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class CNodo
    {
        //aqui colocamos el dato que se va a almacenar en el nodo si necesitamos una agenda
        //ponemes todos los datos que queramos        

        private double dato;

        //esta variable de referencia es usada para apuntar al siguiente nodo
        private CNodo siguiente = null;
        //las propiedades que usaremos
        //public int Dato { get; set; }
        public double Dato { get => dato; set => dato = value; }
        internal CNodo Siguiente { get => siguiente; set => siguiente = value; }

        //para su facil impresion se sobreescribe el metodo ToString
        public override string ToString()
        {
            return string.Format("[{0}]", dato);
        }
    }
}
