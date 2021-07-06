using System;
using System.Collections.Generic;
using System.Linq;

namespace PrikladyZNetu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Reseni.MensiCislo("88", "18"));
            //Console.WriteLine(Reseni.ObracecAPridavac(123456));
            //Console.WriteLine(Reseni.Hexcode("#fa0ca1"));
            //string[] tahy = { "AB", "AC", "CB", "CB" };
            //Console.WriteLine(Reseni.PosouvaniKelimku(tahy));
            //int a = 0;
            //int b = -5;
            //Reseni.VymenaPromennych(ref a, ref b);
            //Console.WriteLine($"{a} {b}");

            //int[] reseni = Reseni.PoleNasobku(5, 5);
            //foreach(var nasobek in reseni)
            //{
            //    Console.WriteLine(nasobek);
            //}
            //Console.WriteLine(Reseni.Faktorial(15));
            //Console.WriteLine(Reseni.MenicVelikostiPismen("aBBa!?"));
            //Console.WriteLine(Reseni.Bomb("Tehre is a bomb."));
            //Console.WriteLine(Reseni.Bomb("BOMB"));
            //Console.WriteLine(Reseni.Bomb("This goes boom!!"));
            //int[][] pole = new int[][] { new int[] { 4, 2, 7, 1 }, new int[] { 20, 70, 40, 90 }, new int[] { 1, 2, 0 } };
            //int[] vysledek = (Reseni.NajdiNejvetsi(pole));
            //foreach (int cislo in vysledek)
            //{
            //    Console.WriteLine(cislo);
            //}
            //Console.WriteLine(Reseni.HodnotaOpacnehoPismene('a'));
            //Console.WriteLine(Reseni.HodnotaOpacnehoPismene('A'));
            //Console.WriteLine(Reseni.HodnotaOpacnehoPismene('z'));
            //Console.WriteLine(Reseni.HodnotaOpacnehoPismene('Z'));
            //Console.WriteLine(Reseni.KontrolaTypu(5, "bla"));
            //Console.WriteLine(Reseni.KontrolaTypu(5, 3));
            //Console.WriteLine(Reseni.PatekTrinacteho(11, 2020));
            //Console.WriteLine(Reseni.PatekTrinacteho(3, 2021));
            //Console.WriteLine(Reseni.ProstredniZnaky("test"));
            //Console.WriteLine(Reseni.ProstredniZnaky("tomas"));
            //Console.WriteLine(Reseni.Isogram("tomas"));
            //Console.WriteLine(Reseni.Isogram("aragorn"));
            Console.WriteLine(Reseni.PalindromCislo(12321));
            string cisloString = "123";
            string cisloPrevracene = "";
            for (int i = cisloString.Length - 1; i > -1; i--)
            {
                cisloPrevracene += cisloString[i];
            }
            Console.WriteLine(cisloPrevracene);
            Console.WriteLine(cisloString);

        }
    }
}
