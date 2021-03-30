using System;

namespace CSharp
{
    class Program
    {
        static void Main() {
            string vastaus1, vastaus2, vastaus3;
            int res1, res2, res3;

            Random rd = new Random();
            int generatednumber = rd.Next(1,20);

            Console.WriteLine("Arvaa lukujen 1-20 väliltä, sinulla on kolme arvausta:");

            vastaus1 = Console.ReadLine();
            
            res1 = Convert.ToInt32(vastaus1);

            if (res1 == generatednumber) {
                Console.WriteLine("Arvasit oikein!");
                System.Environment.Exit(1);
            }
            else if (res1 > generatednumber) {
                Console.WriteLine("Oikea vastaus on pienenpi kuin arvauksesi.");
            }
            else {
                Console.WriteLine("Oikea vastaus on suurempi kuin vastauksesi.");
            }

            Console.WriteLine("Arvaa toisen kerran:");

            vastaus2 = Console.ReadLine();
            
            res2 = Convert.ToInt32(vastaus2);

            if (res2 == generatednumber) {
                Console.WriteLine("Arvasit oikein!");
                System.Environment.Exit(1);
            }
            else if (res2 > generatednumber) {
                Console.WriteLine("Oikea vastaus on pienempi kuin arvauksesi.");
            }
            else {
                Console.WriteLine("Oikea vastaus on suurempi kuin vastauksesi.");
            }

            Console.WriteLine("Arvaa viimeisen kerran:");

            vastaus3 = Console.ReadLine();
            
            res3 = Convert.ToInt32(vastaus3);

            if (res3 == generatednumber) {
                Console.WriteLine("Arvasit oikein!");
                System.Environment.Exit(1);
            }
            else if (res3 > generatednumber) {
                Console.WriteLine("Oikea vastaus on pienempi kuin arvauksesi.");
            }
            else {
                Console.WriteLine("Oikea vastaus on suurempi kuin vastauksesi.");
            }
            Console.WriteLine("Peli ohi!");
        System.Environment.Exit(1);
        }
    }
}
