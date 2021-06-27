using System;
using System.Collections.Generic;
using System.Text;

namespace PrikladyZNetu
{
    static public class Reseni
    {
        public static int Obsah(int zakladna, int vyska)
            {
            return ((zakladna * vyska) / 2);
            }

        public static string MensiCislo(string n1, string n2)
        {
            //Zadani: na vstupu dve cisla jako string, metoda vrati mensi z obou jako string
            int prvni = int.Parse(n1);
            int druhe = int.Parse(n2);
            if (prvni >= druhe)
                return n2;
            else
                return n1;
        }
        //Write a function that takes an integer i and returns a string with the integer backwards followed by the original integer.
        //Example: input = 123, output = 321123
        public static string ObracecAPridavac(int cislo)
        {
            List<char> cisloList = new List<char>();
            string cisloText = cislo.ToString();
            foreach(char znak in cisloText)
            {
                cisloList.Add(znak);
            }
            cisloList.Reverse();
            string vysledek = "";
            foreach (char znak in cisloList)
            {
                vysledek += znak; 
            }

            return vysledek + cisloText;
        }

        //Create a function that determines whether a string is a valid hex code.
        //A hex code must begin with a pound key # and is exactly 6 characters in length.
        //Each character must be a digit from 0-9 or an alphabetic character from A-F.
        //All alphabetic characters may be uppercase or lowercase.
        public static bool Hexcode(string kod)
        {
            List<int> kodList = new List<int>();
            kod = kod.ToLower();
            if (!kod.StartsWith('#') && kod.Length != 7)
                return false;
            else
                kod = kod.Remove(0, 1);
                foreach(char znak in kod)
                { 
                    kodList.Add(znak);
                }
                foreach(int polozka in kodList)
                {
                if (polozka >= '0' && polozka <= '9' || polozka >= 'a' && polozka <= 'f')
                { }
                else
                    return false;
                }
                return true;
        }

    }
}
