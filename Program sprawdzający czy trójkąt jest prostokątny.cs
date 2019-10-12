using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nProgram sprawdzający czy trójkąt jest prostokątny\n\n");
            double a, b, c;
            Console.Write("Podaj długość 1 boku: ");
            a = Double.Parse(Console.ReadLine());
            Console.Write("Podaj długość 2 boku: ");
            b = Double.Parse(Console.ReadLine());
            Console.Write("Podaj długość 3 boku: ");
            c = Double.Parse(Console.ReadLine());
            if (a > 0 && b > 0 && c > 0)
            {
                if (a + b > c && a + c > b && b + c > a)
                {
                    if (a * a + b * b == c * c || a * a + c * c == b * b || c * c + b * b == a * a) Console.WriteLine("\nTo jest trójkąt prostokątny");
                    else Console.WriteLine("\nTo nie jest trójkąt prostokątny");
                }
                else Console.WriteLine("\nTo nie jest trójkąt!!!");
            }
            else Console.WriteLine("\nDługości boków muszą być dodatnie!!!");
            Console.Write("\nNaciśnij dowolny klawisz aby zakończyć program ... ");
            Console.ReadKey();
        }
    }
}
