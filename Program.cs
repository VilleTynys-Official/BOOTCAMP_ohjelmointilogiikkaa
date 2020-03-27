using System;

namespace Ohjelmointilogiikkaa
{
    class Program
    {
        static void Main(string[] args)                 //main rutiini aloittaa ohjelman
        {

            //HARJOITUS: Koodaa peli nimeltä Arvaa luku.Pelissä kone arpoo luvun 1-20,
            //ja tämän jälkeen kysyy käyttäjältä arvausta luvusta.Jos arvattu luku on suurempi tai pienempi kuin oikea luku,
            //näytetään tästä tieto käyttäjälle.Jos käyttäjä arvasi oikein, peli päättyy.Arvauskertoja on enintään 5 kpl.



            //import random
            var rand = new Random();
            


            //loopi arvauskerroille:
            for (int i = 0; i < 5; i++)
            {

                int rand_num = rand.Next(1, 20);             //arvotaan luku

                //kysytään luku ja testataan ovatko samat
                Console.WriteLine("Anna joku kokonaisluku välillä 1-20:");
                int arvaus = int.Parse(Console.ReadLine());
                Console.WriteLine("Arvasit: " + arvaus +
                    "\nKoneen arpoma numero oli: " + rand_num);
                if (arvaus == rand_num)
                {
                    Console.WriteLine("Arvasit siis oikein!");
                    break;
                }

                else
                {
                    Console.WriteLine("Kokeileppa uudestaan.. arvauskertoja käytetty: {0} ", i+1);
                }

            }

















            //int i = 100;
            //int j = 200;
            //string s = "ABC";

            //if (i > 100)                //perus if
            //{
            //    Console.WriteLine("i:n arvo on isompi kuin sata!");
            //}
            //else
            //{
            //    Console.WriteLine("i:n arvo on pienempi kuin sata!");
            //}

            //for (int laskuri = 0; laskuri < 10; laskuri++)
            //{
            //    Console.WriteLine("moikka");
            //}



        }
    }
}
