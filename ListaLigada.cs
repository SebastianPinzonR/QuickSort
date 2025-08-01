using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    internal class ListaLigada
    {
        //es el ancla on encabezado de la lista o el inicio de la lista ligada
        private CNodo ancla;

        //esta variable de referencia nos ayuda a trabajar con la lista
        //las variables de trabajo van estar referenciandise a diferentes nodos de la lista ligada
        //estas variables indican en cual nodo estamos trabajando la variable trabajo tambien sirve
        //para buscar el nodo ya sea que el nodo este atras o adelante
        private CNodo trabajo;
        //esta variable de referencia apoya en ciertas operaciones de la lista
        private CNodo trabajo2;
        //este es el constructor de la lista ligada
        //el constructor crea el nodo de ancla, y en este constructor tenemos ancla.siguiente,
        //pero como no hay nodos a los cuales conectarnos entonces le esta conectando a null a ancla.siguiente
        public ListaLigada()
        {
            //iniciamos el ancla
            ancla = new CNodo();
            //como en una lista vacia su siguiente es null
            ancla.Siguiente = null;
        }
        //la tranversa recorre cada uno de los nodos de forma secuencial y cada una de la estructura de datos tiene
        //sus propias reglas para recorrer la lista
        //null->3->1->5->7->null
        //Recorre la lista y muestra los nodos
        public void Transversa()
        {
            //trabajo al inicio nos apoyamos en trabajo que se va a ir referenciandose en cada uno de los nodos
            //al principio trabajo es igual a ancla que es igual a null
            trabajo = ancla;
            //recorremos hasta encontrar el final
            //mientras trabajo.Siguiente no sea null entonces hacemos la accion siguiente
            while (trabajo.Siguiente != null)
            {
                //avanzamos al siguiente nodo
                trabajo = trabajo.Siguiente;
                //obtenemos el dato
                double d = trabajo.Dato;
                //imprimimos el dato
                Console.Write("{0}, ", d);
            }
            //bajamos de linea
            Console.WriteLine();
        }
        //adiciona un nuevo elemento
        //la adicion siempre va al final
        public void Adicionar(double pDato)
        {
            //trabajo al inicio
            trabajo = ancla;
            //recorremos hasta encontrar el final
            //tenemos que mover trabajo hasta el final de la lista
            //mientras trabajo.Siguiente no sea null entonces hacemos la accion siguiente
            while (trabajo.Siguiente != null)
            {
                //avanzamos al siguiente nodo
                trabajo = trabajo.Siguiente;
            }
            //salimos del while cuando trabajo.Siguiente es null
            //creamos el nuevo nodo
            CNodo temp = new CNodo();
            //insertamos el dato
            temp.Dato = pDato;
            //finalizamos correctamente // //ancla->1->2->3->5->null despues
            //el nuevo dato se conecta con el null ancla->1->2->3->5->null,  7->null
            temp.Siguiente = null;
            //ligamos el ultimo nodo encontrado con el recien creado
            //trabajo.Siguiente estaba referenciando a null ahora esta referenciando a temp
            //osea a 7 ancla->1->2->3->5->7->null
            trabajo.Siguiente = temp;

        }
        public void Adicionar(double pDato1, double pDato2)
        {
            // Referencia temporal para trabajar con la lista
            trabajo = ancla;

            // Recorremos hasta llegar al último nodo
            while (trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
            }

            // Crear el primer nuevo nodo
            CNodo temp1 = new CNodo();
            temp1.Dato = pDato1;


            // Enlazamos el primer nuevo nodo al final de la lista
            trabajo.Siguiente = temp1;

            // Crear el segundo nuevo nodo
            CNodo temp2 = new CNodo();
            temp2.Dato = pDato2;


            // Enlazamos el segundo nuevo nodo al primero
            temp1.Siguiente = temp2;
        }
        public void Adicionar(double pDato1, double pDato2, double pDato3)
        {
            // Referencia temporal para trabajar con la lista
            trabajo = ancla;

            // Recorremos hasta el último nodo
            while (trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
            }

            // Crear el primer nodo
            CNodo temp1 = new CNodo();
            temp1.Dato = pDato1;

            // Crear el segundo nodo
            CNodo temp2 = new CNodo();
            temp2.Dato = pDato2;

            // Crear el tercer nodo
            CNodo temp3 = new CNodo();
            temp3.Dato = pDato3;


            // Enlazar los nodos en secuencia
            temp1.Siguiente = temp2;
            temp2.Siguiente = temp3;

            // Enlazar el primer nuevo nodo al final de la lista
            trabajo.Siguiente = temp1;
        }



        //metodo que vacia la lista
        public void Vaciar()
        {
            ancla.Siguiente = null;
            //en lenguajes no administrados hay que liberar la memoria adecuadamente
            //aqui aprovechamos el recolector de basura
        }
        //metodo que indica si la lista esta vacia
        public bool EstaVacio()
        {
            if (ancla.Siguiente == null)
            {
                //la lista esta vacia
                return true;
            }
            else
            {
                //la lista no esta vacia
                return false;
            }
        }
        //metodo para buscar determinado dato
        public CNodo Buscar(double pDato)
        {
            //si el nodo ancla.Siguiente es null entonces la lista esta vacia
            if (EstaVacio() == true)
                return null;
            trabajo2 = ancla;
            //recorremos para ver si lo encontramos hasta que el siguiente nodo sea null
            while (trabajo2.Siguiente != null)
            {
                //este sirve para avarzar al siguiente nodo
                trabajo2 = trabajo2.Siguiente;
                //al encontrar lo regresamos osea si el datos es igual al parametro o al dato que pusimos
                //en la instanciacion del metodo este lo devolvera
                if (trabajo2.Dato == pDato)
                    return trabajo2;
            }
            //no se encontro, regresamos null
            return null;
        }
        //Busca el indice donde se encuentra la primera ocurrencia del dato
        public double BuscarTodosLosIndices(double pDato)
        {
            // n es -1 porque trabajo esta iniciando en el ancla
            //el ancla esta antes que el primer nodo que tiene datos
            //y el primer nodo que tiene datos tiene el indice cero
            //estamos poniedo al ancla com -1
            double n = -1;
            trabajo = ancla;
            while (trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
                n++;

                if (trabajo.Dato == pDato)
                {
                    //si lo encontramos regresamos el indice
                    Console.WriteLine(n);
                }
            }
            return -1;
        }
        public double BuscarIndice(double pDato)
        {
            // n es -1 porque trabajo esta iniciando en el ancla
            //el ancla esta antes que el primer nodo que tiene datos
            //y el primer nodo que tiene datos tiene el indice cero
            //estamos poniedo al ancla com -1
            double n = -1;
            trabajo = ancla;
            while (trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
                n++;

                if (trabajo.Dato == pDato)
                {
                    //si lo encontramos regresamos el indice
                    return n;
                }
            }
            return -1;
        }

        //encuentra el nodo anterior
        //si esta en el primer nodo se regresa el ancla
        //si el dato no existe se regresa el ultimo nodo
        public CNodo BuscarAnterior(double pDato)
        {
            trabajo2 = ancla;
            //se va a cumplir cuando trabajo2.Siguiente sea diferente de null
            //si hay alguien conectado a trabajo2.Siguiente puede avanzar el null
            //por otro lado tambien valida si el nodo siguiente del cual yo estoy
            //tiene el dato o no tiene el dato
            //trabajo2.Siguiente.Dato se esta leyendo el dato del nodo siguiente del trabajo2, si el
            //dato del nodo siguiente no es igual a dato puedo avanzar al nodo siguiente
            while (trabajo2.Siguiente != null && trabajo2.Siguiente.Dato != pDato)
            {
                trabajo2 = trabajo2.Siguiente;
            }
            return trabajo2;
        }

        public void Borrar(double pDato)
        {
            //verificamos que se tengan datos
            if (EstaVacio() == true)
                return;
            //buscamos los nodos con los que trabajaremos
            CNodo anterior = BuscarAnterior(pDato);
            CNodo encontrado = Buscar(pDato);
            //si no hay nodo a borrar, salimos
            if (encontrado == null)
                return;
            //brincamos el nodo osea se conecta el nodo anterior con el nodo encontrado
            //y ese nodo encontrado se conecta con el siguiente nodo de esa forma se conecta el anterior
            //con el siguiente y se brinca el nodo encontrado osea brincamos el nodo encontrado
            anterior.Siguiente = encontrado.Siguiente;
            //quitamos el nodo de la lista aunque esto no es quitar 
            //lo que hace es referenciar al siguiente nodo a un null
            encontrado.Siguiente = null;
        }

        //inserta el dato pValor despues la primera ocurrencia del dato pasado a pdonde
        public void Insertar(double pDonde, double pValor)
        {
            //encontramos la posicion donde vamos a insertar
            trabajo = Buscar(pDonde);
            //verificamos que exista donde vamos a insertar
            if (trabajo == null)
                return;
            //creamos el nodo temporal a insertar
            CNodo temp = new CNodo();
            temp.Dato = pValor;
            //conectamos el temporal a la lista
            temp.Siguiente = trabajo.Siguiente;
            //conectamos trabajo a temporal
            trabajo.Siguiente = temp;
        }

        public void InsertarInicio(double pValor)
        {
            //creamos el nodo temporal
            CNodo temp = new CNodo();
            temp.Dato = pValor;
            // se conecta a la parte derecha
            temp.Siguiente = ancla.Siguiente;
            //se conecta a la parte izquierda o en este caso al ancla
            ancla.Siguiente = temp;
        }

        //obtenemos la referencia al nodo dado el indice
        public CNodo ObtenPorIndice(double pIndice)
        {
            CNodo trabajo2 = null;
            double indice = -1;
            trabajo = ancla;
            while (trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
                indice++;

                if (indice == pIndice)
                    trabajo2 = trabajo;
            }
            return trabajo2;
        }

        //creamos un indexer
        public double this[double pIndice]
        {
            //esto puede crear un excepcion si trabajo es igual a null
            //colocar codigo de seguridad o usar int?
            get
            {
                trabajo = ObtenPorIndice(pIndice);
                return trabajo.Dato;
            }
            set
            {
                trabajo = ObtenPorIndice(pIndice);
                if (trabajo != null)
                {
                    trabajo.Dato = value;
                }
            }
        }

        //cuenta la cantidad de elementos en la lista
        public double Cantidad()
        {
            trabajo = ancla;
            double n = 0;

            while (trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
                n++;
            }

            return n;
        }
    }
}
