using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nProgram sprawdzający czy podana liczba całkowita jest liczbą parzystą i składa się z 3 cyfr\n\n");
            int a;
            Console.Write("Podaj liczbę całkowitą a: ");
            a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("\nLiczba parzysta");
                if (a <= 100)
                {
                    if (a <= 999) Console.WriteLine("\nLiczba jest 3-cyfrowa");
                    else Console.WriteLine("\nLiczba nie jest 3-cyfrowa");
                }
                else Console.WriteLine("\nLiczba nie jest 3-cyfrowa");
            }
            else
            {
                Console.WriteLine("\nLiczba nieparzysta");
                if (a >= 100)
                {
                    if (a <= 999) Console.WriteLine("\nLiczba jest 3-cyfrowa");
                    else Console.WriteLine("\nLiczba nie jest 3-cyfrowa");
                }
                else Console.WriteLine("\nLiczba nie jest 3-cyfrowa");
            }
            Console.Write("\n\nNaciśnij dowolny klawisz aby zakończyć program ... ");
            Console.ReadKey();
        }
    }
}
