using System;

namespace CSharp
{
    class Program
    {
        static void Main() {
            string syöte;
            int vastaus;

            Random rd = new Random();
            int generatednumber = rd.Next(1,21);

            Console.WriteLine("Tervetuloa Arvaa Luku -peliin!");
            Console.WriteLine("Arvaa lukujen 1-20 väliltä, sinulla on kolme arvausta:");

            syöte = Console.ReadLine();
            vastaus = Convert.ToInt32(syöte);

            if (vastaus < generatednumber) {
                Console.WriteLine("Oikea vastaus on suurempi kuin vastauksesi.");
            }
            else if (vastaus > generatednumber) {
                Console.WriteLine("Oikea vastaus on pienempi kuin arvauksesi.");
            }
            else {
                Console.WriteLine("Arvasit oikein!");
                System.Environment.Exit(1);
            }

            Console.WriteLine("Arvaa toisen kerran:");

            if (vastaus < generatednumber) {
                Console.WriteLine("Oikea vastaus on suurempi kuin vastauksesi.");
            }
            else if (vastaus > generatednumber) {
                Console.WriteLine("Oikea vastaus on pienempi kuin arvauksesi.");
            }
            else {
                Console.WriteLine("Arvasit oikein!");
                System.Environment.Exit(1);
            }

            Console.WriteLine("Arvaa viimeisen kerran:");

            if (vastaus < generatednumber) {
                Console.WriteLine("Oikea vastaus on suurempi kuin vastauksesi.");
            }
            else if (vastaus > generatednumber) {
                Console.WriteLine("Oikea vastaus on pienempi kuin arvauksesi.");
            }
            else {
                Console.WriteLine("Arvasit oikein!");
                System.Environment.Exit(1);
            }
            
            Console.WriteLine("Oikea vastaus on " + generatednumber + ".");
            Console.WriteLine("Peli ohi!");

        System.Environment.Exit(1);
        }
    }
}
