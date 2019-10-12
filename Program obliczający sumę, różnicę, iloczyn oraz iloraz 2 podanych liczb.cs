using System;

namespace Program_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nProgram obliczający sumę, różnicę, iloczyn oraz iloraz 2 podanych liczb\n\n");
            double a, b;
            Console.Write("Podaj liczbę a: ");
            a = Double.Parse(Console.ReadLine());
            Console.Write("\nPodaj liczbę b: ");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("\n\nPodałeś a=" + a + " oraz b=" + b);
            Console.WriteLine("\na={0} b={1}", a, b);
            double suma, roznica, iloczyn, iloraz;
            suma = a + b;
            roznica = a - b;
            iloczyn = a * b;
            iloraz = a / b;
            Console.WriteLine("\n\nSuma a+b=" + suma);
            Console.WriteLine("\nRóżnica a-b=" + roznica);
            Console.WriteLine("\nIloczyn a*b=" + iloczyn);
            Console.WriteLine("\nIloraz a/b=" + iloraz + "\n");
            Console.Write("\nNaciśnij dowolny klawisz aby zakończyć program ... ");
            Console.ReadKey();
        }
    }
}
