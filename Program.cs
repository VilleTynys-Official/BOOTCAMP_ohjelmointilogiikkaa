using System;

namespace Ohjelmointilogiikkaa
{
    class Program
    {
        static void Main(string[] args)                 //main rutiini aloittaa ohjelman
        {
            int i = 100;
            int j = 200;
            string s = "ABC";

            if (i > 100)                //perus if
            {
                Console.WriteLine("i:n arvo on isompi kuin sata!");
            }
            else
            {
                Console.WriteLine("i:n arvo on pienempi kuin sata!");
            }

            for (int laskuri = 0; laskuri < 10; laskuri++)
            {
                Console.WriteLine("moikka");
            }

         
        }
    }
}
