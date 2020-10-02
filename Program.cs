using System;

namespace Binary_search
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Inserta un numero del 1 al 20: ");
      try
      {
        string input = Console.ReadLine();
        int valorInsertado = int.Parse(input);
        int min = 0;
        int max = 20;
        int[] binary_search = new int[valorInsertado];
        Random numRand = new Random();

        for (int i = 0; i < valorInsertado; i++)
        {
          binary_search[i] = numRand.Next(min, max);
          Console.Write("  " + binary_search[i]);
        }

        Console.WriteLine("");
        Console.WriteLine("");
        Console.Write("Inserte un numero de esta matriz para empezar la busqueda: ");

        string busqueda = Console.ReadLine();
        int valorDbusqueda = int.Parse(busqueda);

        Array.Sort(binary_search);
        Console.WriteLine("");
        Console.WriteLine("Aquí está la matriz con los valores enteros en orden según lo requiera la búsqueda binaria: ");
        Console.WriteLine("");

        for (int i = 0; i < valorInsertado; i++)
        {
          Console.Write("  " + binary_search[i]);
        }

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Buscar valor entero ...");

        int get_middle = 0;
        int low = 0;
        int high = (binary_search.Length) - 1;
        int mid = (low + high) / 2;
        int track_middle = 0;
        while (low <= high)
        {
          mid = (low + high) / 2;
          get_middle = binary_search[mid];
          if (get_middle == valorDbusqueda)
          {
            Console.WriteLine("");
            Console.WriteLine("Numero encontrado: " + valorDbusqueda);
            break;
          }
          if (get_middle > valorDbusqueda && get_middle != track_middle)
          {
            high = mid + 1;
            Console.WriteLine("");
            Console.WriteLine("Se encontro este numero: " + get_middle + " pero no es");
            track_middle = get_middle;
          }
          else
          {
            low = mid + 1;
            Console.WriteLine("");
            Console.WriteLine("Se encontro este numero: " + get_middle + " pero no es");
          }
        }

        if (low > high)
        {
          Console.WriteLine("");
          Console.WriteLine("No se encontro tu numero en la busqueda ");
        }

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Presiona cualquier tecla para continuar ...");
        Console.ReadKey(true);
      }
      catch
      {
        Console.WriteLine("Inserte un numero y vuelva a intentarlo ...");
        Console.ReadKey(true);
      } 

    }
  }
}
