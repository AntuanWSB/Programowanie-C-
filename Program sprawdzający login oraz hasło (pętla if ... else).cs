using System;

namespace Program_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nProgram sprawdzający login oraz hasło (pętla if ... else)\n\n");
            string nazwa, haslo;
            Console.Write("Podaj nazwę użytkownika: ");
            nazwa = Console.ReadLine();
            Console.Write("\nPodaj hasło użytkownika: ");
            haslo = Console.ReadLine();
            if (nazwa == "WSB")
            {
                if (haslo == "Informatyka") Console.WriteLine("\n\nZostałeś zalogowany jako " + nazwa);
                else Console.WriteLine("\n\nBłędne hasło użytkownika");
            }
            else Console.WriteLine("\n\nBłędna nazwa użytkownika");
            Console.Write("\n\nNaciśnij dowolny klawisz aby zakończyć program ... ");
            Console.ReadKey();
        }
    }
}
