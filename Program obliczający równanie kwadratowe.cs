using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nProgram obliczający równanie kwadratowe\n\n");
            double a, b, c, delta, x1, x2;
            Console.Write("Podaj współczynnik a: ");
            a = Double.Parse(Console.ReadLine());
            Console.Write("Podaj współczynnik b: ");
            b = Double.Parse(Console.ReadLine());
            Console.Write("Podaj współczynnik c: ");
            c = Double.Parse(Console.ReadLine());
            if (a == 0) Console.WriteLine("To nie jest równanie kwadratowe!!!");
            else
            {
                Console.WriteLine("\nPostać równania: {0}x^2+{1}x+{2}=0", a, b, c);
                delta = b * b - 4 * a * c;
                Console.WriteLine("\nDelta wynosi:{0}", delta);
                if (delta < 0) Console.WriteLine("\nRównanie nie ma rozwiązań");
                else
                {
                    if (delta == 0)
                    {
                        x1 = -b / (2 * a);
                        Console.WriteLine("\nRównanie ma 1 rozwiązanie x={0}", x1);
                    }
                    else
                    {
                        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                        Console.WriteLine("\nRównanie ma 2 rozwiązanie x={0} x={1}", x1, x2);
                    }
                }
            }
            Console.Write("\nNaciśnij dowolny klawisz aby zakończyć program ... ");
            Console.ReadKey();
        }

    }
}
