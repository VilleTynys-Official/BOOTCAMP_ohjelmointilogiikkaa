﻿using System;

namespace Ohjelmointilogiikkaa
{
    class Program
    {
        
        static void Main(string[] args)                 //main rutiini aloittaa ohjelman
        {

            //HARJOITUS: Koodaa peli nimeltä Arvaa luku.Pelissä kone arpoo luvun 1-20,
            //ja tämän jälkeen kysyy käyttäjältä arvausta luvusta.Jos arvattu luku on suurempi tai pienempi kuin oikea luku,
            //näytetään tästä tieto käyttäjälle.Jos käyttäjä arvasi oikein, peli päättyy.Arvauskertoja on enintään 5 kpl.


            //JANIN VERSIO
            //päivitys 1.1 lisätty Tryparse.
            //Lisätty const muuttujat (hyödyntävät koodin muokkauksessa)
            //eli "Magic numberit" poistettu.
            //template stringsiä hyödynnetty tuloksen arvon tulostuksessa.



            //pelivakiot

            const int SuurinLuku = 20;
            const int ArvauskertojenMaksimiMäärä = 5;

            //aloitetaan peli ja arvotaan oikea numero
            Console.WriteLine("Arvaa luku -peli alkaa.");
            Random satunnaisluku = new Random();
            int oikea = satunnaisluku.Next(1, SuurinLuku + 1);
            

            //aloitetaan silmukka jossa kysytään pelaajan arvaukset
            for (int arvauskerrat = 1; arvauskerrat <= ArvauskertojenMaksimiMäärä; arvauskerrat++)
            {
                //kysytään numeerista syötettä niin kauan kun syöte on numero
                int arvaus;                    
                bool numeerinen;
                do
                {                  
                    Console.WriteLine($"Anna arvauksesi välillä 1-{SuurinLuku}:");      //käytetään string templatea..
                    string syöte = Console.ReadLine();
                    numeerinen = int.TryParse(syöte, out arvaus);           //testaa onnistuiko ja jos onnistui tallentaa tiedon arvaus muuttujaan.

                }
                while (!numeerinen);     //(numeerinen == false);        //jatkuu kunnes käyttäjä syötää integerin.



                //tarkistetaan arvasiko pelaaja oikein.
                if (arvaus < oikea)
                {
                    Console.WriteLine("Oikea luku on suurempi.");
                }
                else if (arvaus > oikea)
                {
                    Console.WriteLine("Oikea luku on pienempi.");
                }
                else
                {
                    Console.WriteLine("Arvasit oikein!");
                    break;
                }
            }

            Console.WriteLine("Peli on päättynyt.");


        }














                ////OMA VERSIONI: Huom. arpoo aina eri random numeron (eli vähän eri toimintamekaniikka kuin Janilla mut ei kuitenkaan tehtävän
                ////annon vastainen..)

                ////import random
                //var rand = new Random();





                ////loop arvauskerroille:
                //for (int arvauskerrat = 0; arvauskerrat < 5; arvauskerrat++)
                //{

                //    int rand_num = rand.Next(1,21);             //arvotaan luku

                //    //kysytään luku ja testataan ovatko samat
                //    Console.WriteLine("Anna joku kokonaisluku välillä 1-20:");

                //    int arvaus = int.Parse(Console.ReadLine());
                //    Console.WriteLine("Arvasit: " + arvaus +
                //        "\nKoneen arpoma numero oli: " + rand_num);
                //    if (arvaus == rand_num)
                //    {
                //        Console.WriteLine("Arvasit siis oikein!");
                //        break;
                //    }

                //    else
                //    {
                //        Console.WriteLine("Kokeileppa uudestaan.. arvauskertoja käytetty: {0} ", arvauskerrat+1);
                //    }

                //}

















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
