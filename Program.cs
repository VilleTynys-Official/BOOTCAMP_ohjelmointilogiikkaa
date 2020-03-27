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
            int rand_num = rand.Next(1,20);
            Console.WriteLine(rand_num);





















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
