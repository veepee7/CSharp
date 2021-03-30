using System;

namespace CSharp
{
    class Program
    {
        static void Main() {
            string vastaus;
            int res;

            Random rd = new Random();
            int generatednumber = rd.Next(1,21);

            Console.WriteLine("Tervetuloa Arvaa Luku -peliin!");
            Console.WriteLine("Arvaa lukujen 1-20 väliltä, sinulla on kolme arvausta:");

            vastaus = Console.ReadLine();
            
            res = Convert.ToInt32(vastaus);

            if (res == generatednumber) {
                Console.WriteLine("Arvasit oikein!");
                System.Environment.Exit(1);
            }
            else if (res > generatednumber) {
                Console.WriteLine("Oikea vastaus on pienenpi kuin arvauksesi.");
            }
            else if (res < generatednumber) {
                Console.WriteLine("Oikea vastaus on suurempi kuin vastauksesi.");
            }

            Console.WriteLine("Arvaa toisen kerran:");

            vastaus = Console.ReadLine();
            
            res = Convert.ToInt32(vastaus);

            if (res == generatednumber) {
                Console.WriteLine("Arvasit oikein!");
                System.Environment.Exit(1);
            }
            else if (res > generatednumber) {
                Console.WriteLine("Oikea vastaus on pienempi kuin arvauksesi.");
            }
            else if (res < generatednumber) {
                Console.WriteLine("Oikea vastaus on suurempi kuin vastauksesi.");
            }

            Console.WriteLine("Arvaa viimeisen kerran:");

            vastaus = Console.ReadLine();
            
            res = Convert.ToInt32(vastaus);

            if (res == generatednumber) {
                Console.WriteLine("Arvasit oikein!");
                System.Environment.Exit(1);
            }
            else if (res > generatednumber) {
                Console.WriteLine("Oikea vastaus on pienempi kuin arvauksesi.");
            }
            else if (res < generatednumber) {
                Console.WriteLine("Oikea vastaus on suurempi kuin vastauksesi.");
            }
            
            Console.WriteLine("Oikea vastaus on " + generatednumber + ".");
            Console.WriteLine("Peli ohi!");

        System.Environment.Exit(1);
        }
    }
}
