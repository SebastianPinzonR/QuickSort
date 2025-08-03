using QuickSort;

class Program
{
    private static ListaLigada miLista = new ListaLigada();
    static void Main(string[] args)
    {
        miLista.Adicionar(3);
        miLista.Adicionar(15);
        miLista.Adicionar(7);
        miLista.Adicionar(19);
        miLista.Adicionar(11);
        miLista.Adicionar(1);

        miLista.Transversa();

        QuickSort(0, miLista.Cantidad() - 1);

        miLista.Transversa();

    }

    private static void Swap(double indice1, double indice2)
    {
        double temp = miLista[indice1];
        miLista[indice1] = miLista[indice2];
        miLista[indice2] = temp;
    }
    //Implementacion inline o en linea
    public static double Particion(double parametroInicio, double parametroFin)
    {
        //Estes es el ultimo pivote
        double pivote = 0;
        //este es el pivote del principio que se encuentra estatico si no encuentra un valor menor
        double indicePivote = 0;
        //este es el pivote que va a estar recorriendo el arreglo o lista segun el caso
        double n = 0;

        //Seleccionamos el ultimo como pivote
        pivote = miLista[parametroFin];

        //Ponemos el indice de pivote con el indice del inicio
        indicePivote = parametroInicio;

        //Recorremos la lista en el fragmento indicado
        for (n = parametroInicio; n < parametroFin; n++)
        {
            //Si el elemento en el indice n es menor o igual al ultimo pivote
            if (miLista[n] <= pivote)
            {
                //Intercambiamos el elemento en n con el que se encuentre en el indice de pivote
                Swap(n, indicePivote);
                //Incrementamos el indice del pivote
                indicePivote++;
            }
        }

        //Hacemos el Swap final para colocar el pivote donde corresponde 
        Swap(indicePivote,parametroFin);
        //Regresamos el indice del pivote
        return indicePivote;
    }

    public static void QuickSort(double pInicio, double pFin)
    {
        double indicePivote = 0;
        //Caso base, un elemento o fragmento invalido
        if(pInicio >= pFin)
        {
            return;
        }
        //Obtenemos el indice del pivote para el fragmento con el que trabajamos
        indicePivote=Particion(pInicio, pFin);
        //Casos inductivos
        QuickSort(pInicio, indicePivote-1);
        QuickSort(indicePivote+1, pFin);
    }
}