using System;

namespace CSharp
{
    class Program
    {
        static void Main() {
            string syöte;
            int vastaus;

            // Kone arpoo pelin oikean vastauksen
            Random rd = new Random();
            int generatednumber = rd.Next(1,21);

            Console.WriteLine("Tervetuloa Arvaa Luku -peliin!");

            // Määritetään arvauskertojen määrä
            for (int arvauskerta = 0; arvauskerta < 3; arvauskerta++)
            {
                Console.WriteLine("Arvaa lukujen 1-20 väliltä, sinulla on kolme arvausta:");
               
                // Pyydetään syöte ja muutetaan string int-muotoon
                syöte = Console.ReadLine();
                vastaus = Convert.ToInt32(syöte);

                // Määritetään onko tulos oikea ja tällöin lopettaa pelin. Jos ei, kone pyytää arvaamaan uudestaan tai lopettaa pelin viimeiseen kysymykseen.
                if (vastaus < generatednumber) {
                    Console.WriteLine("Oikea vastaus on suurempi kuin vastauksesi.");
                }
                else if (vastaus > generatednumber) {
                    Console.WriteLine("Oikea vastaus on pienempi kuin arvauksesi.");
                }
                else {
                    Console.WriteLine("Arvasit oikein!");
                    break;
                }
            }
            // Peli kertoo oikean vastauksen ja ilmoittaa pelin lopusta.
            Console.WriteLine("Oikea vastaus on " + generatednumber + ".");
            Console.WriteLine("Peli ohi.");
        }
    }
}
