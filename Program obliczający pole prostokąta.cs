using System;

namespace Program_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nProgram obliczający pole prostokąta\n");
            double a, b, wynik;
            Console.Write("\nPodaj w cm długość boku a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("\nPodaj w cm długość boku b: ");
            b = double.Parse(Console.ReadLine());
            wynik = a * b;
            if (a>0 & b>0)
            {
                Console.WriteLine("\n\nPole prostokąta wynosi: {0} cm/kw", wynik);
            }
            else
            {
                Console.WriteLine("\n\nBłędne dane podane z klawiatury");
            }
            Console.Write("\n\nNaciśnij dowolny klawisz aby zakończyć program ... ");
            Console.ReadKey();
        }
    }
}
