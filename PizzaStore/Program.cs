using System.Diagnostics.CodeAnalysis;
using System.Net.Security;

namespace PizzaStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til Big Mammas Pizzaria!");
            Console.WriteLine();
            Console.WriteLine("Du har nu 3 valgmuligheder:");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Se Menuen, tast 1");
            Console.WriteLine();
            Console.WriteLine("2. Opret en ny order, tast 2");
            Console.WriteLine();
            Console.WriteLine("3. Se udførte ordre, tast 3");
            Console.WriteLine();
            Console.WriteLine("__________________________________________");
            Console.Write("Indtast venligst hvad du vil gøre her : ");
            int tast = 0;
            tast = int.Parse(Console.ReadLine()!);

            

            if (tast == 1)
            {
                Console.Clear();
                MenuCard menu = new MenuCard();
                Console.WriteLine(menu.ToString());
                Console.WriteLine();
                Console.WriteLine("________________");
                Console.Write("Er du klar til at bestille? :   ");
                string bestil = Console.ReadLine();

                if ((bestil == "ja") || (bestil == "JA") || (bestil == "Ja") || (bestil == "jA"))
                {
                    Console.WriteLine();
                    Console.WriteLine("Hvad vil du gerne bestille?, Skriv venligst nummer");
                    Console.WriteLine();
                    int nummer;
                    nummer = int.Parse(Console.ReadLine()!);
                    
                    if (nummer == 1)
                    {
                        Console.WriteLine("Hvor mange vil du have? : ");
                        int antal;
                        antal = int.Parse(Console.ReadLine()!);
                        int i = 0;

                        while (i < antal)
                        {
                            i++;
                        }


                        Console.Write("Du har valgt :  ");
                        Console.WriteLine($"{ i } x Margherita");
                        Console.WriteLine();
                        Console.WriteLine("Tak for din bestilling, venligst vent 5 sekunder for din kvittering");

                        Thread.Sleep(5000);
                        Console.Clear();
                        Console.WriteLine("Her er din Kvittering : ");
                        Console.WriteLine();
                        Console.WriteLine();

                    }

                    else if (nummer == 2)
                    {
                        Console.WriteLine("Hvor mange vil du have? : ");
                        int antal;
                        antal = int.Parse(Console.ReadLine()!);
                        int i = 0;

                        while (i < antal)
                        {
                            i++;
                        }


                        Console.Write("Du har valgt :  ");
                        Console.WriteLine($"{i} x Vesuvio");
                        Console.WriteLine();
                        Console.WriteLine("Tak for din bestilling, venligst vent 5 sekunder for din kvittering");

                        Thread.Sleep(5000);
                        Console.Clear();


                    }
                    
                    else if (nummer == 3)
                    {
                        Console.WriteLine("Hvor mange vil du have? : ");
                        int antal;
                        antal = int.Parse(Console.ReadLine()!);
                        int i = 0;

                        while (i < antal)
                        {
                            i++;
                        }


                        Console.Write("Du har valgt :  ");
                        Console.WriteLine($"{i} x Capricciosa");
                        Console.WriteLine();
                        Console.WriteLine("Tak for din bestilling, venligst vent 5 sekunder for din kvittering");

                        Thread.Sleep(5000);
                        Console.Clear();
                    }

                    else if (nummer == 20)
                    {
                        Console.WriteLine("Hvor mange vil du have? : ");
                        int antal;
                        antal = int.Parse(Console.ReadLine()!);
                        int i = 0;

                        while (i < antal)
                        {
                            i++;
                        }


                        Console.Write("Du har valgt :  ");
                        Console.WriteLine($"{i} x Sodavand");
                        Console.WriteLine();
                        Console.WriteLine("Tak for din bestilling, venligst vent 5 sekunder for din kvittering");

                        Thread.Sleep(5000);
                        Console.Clear();
                    }

                    else if (nummer == 21)
                    {
                        Console.WriteLine("Hvor mange vil du have? : ");
                        int antal;
                        antal = int.Parse(Console.ReadLine()!);
                        int i = 0;

                        while (i < antal)
                        {
                            i++;
                        }


                        Console.Write("Du har valgt :  ");
                        Console.WriteLine($"{i} x Vand");
                        Console.WriteLine();
                        Console.WriteLine("Tak for din bestilling, venligst vent 5 sekunder for din kvittering");

                        Thread.Sleep(5000);
                        Console.Clear();
                    }


                }

            }
            
            else if (tast == 2)
            {
                Console.Clear();
                Console.WriteLine("Hvad vil du gerne bestille? ");
            }

            else if (tast == 3)
            {
                Console.Clear();
                Console.WriteLine("Coming Soon......");
            }

            else
            {
                Console.WriteLine("Venligst vælg en af mulighederne");
            }

            Console.ReadKey();
        }
    }
}
