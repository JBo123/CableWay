using System;
namespace ukoly_replit;
class Program {
    static void Main(string[] args)
    {
        newLanovka lanovka = new newLanovka(10, 22222);

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(lanovka.Nastup(new Clovek("Adam", 10))); 
            lanovka.Jed();
            Console.WriteLine(lanovka.Vystup().Jmeno);  
        }

        Console.ReadLine();

    }
}
