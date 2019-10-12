using System;

namespace Program_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nProgram przeliczający kwotę podaną w PLN na kwotę w EUR oraz USD\n\n");
            Console.Write("Podaj kwote w PLN: ");
            double kwota = Double.Parse(Console.ReadLine());
            Console.WriteLine("\nPodałeś kwotę: " + kwota + " PLN");
            double euro, dolar;
            euro = kwota / 4.3097;
            dolar = kwota / 3.9145;
            Console.WriteLine("{0} PLN to jest {1} EUR", kwota, Math.Round(euro, 2));
            Console.WriteLine("{0} PLN to jest {1} USD", kwota, Math.Round(dolar, 2));
            Console.Write("\nNaciśnij dowolny klawisz aby zakończyć program ... ");
            Console.ReadKey();
        }
    }
}
