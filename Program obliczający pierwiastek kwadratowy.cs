using System;

namespace Program_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nProgram obliczający pierwiastek kwadratowy\n");
            int liczba;
            Console.Write("\npodaj liczbę całkowitą: ");
            liczba = int.Parse(Console.ReadLine());
            Console.WriteLine("\nPierwiastek kwadratowy z {0} wynosi {1}", liczba, Math.Sqrt(liczba));
            Console.Write("\n\nNaciśnij dowolny klawisz aby zakończyć program ... ");
            Console.ReadKey();
        }
    }
}
