using System;
using System.Collections.Generic;
using System.Linq;
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

        //There are three cups on a table, at positions A, B, and C. At the start, there is a ball hidden under the cup at position B.
        //However, I perform several swaps on the cups, which is notated as two letters.
        //For example, if I swap the cups at positions A and B, I could notate this as AB or BA.
        //Create a function that returns the letter position that the ball is at, once I finish swapping the cups.
        //The swaps will be given to you as an array.
        public static string PosouvaniKelimku(string[] tahy)
        {
            Dictionary<char, bool> pozice = new Dictionary<char, bool>();
            pozice.Add('A', false);
            pozice.Add('B', true);
            pozice.Add('C', false);
            char vyslednaPozice = 'B';

            foreach (string tah in tahy)
            {
                var prvniKelimek = pozice[tah[0]];
                var druhyKelimek = pozice[tah[1]];
                if (prvniKelimek || druhyKelimek)
                {
                    pozice[tah[0]] = !prvniKelimek;
                    pozice[tah[1]] = !druhyKelimek;
                }
            }
            vyslednaPozice = pozice.SingleOrDefault(x => x.Value).Key;
            return vyslednaPozice.ToString();
            }
        
        public static void VymenaPromennych(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
        //Create a function that takes two numbers as arguments(num, length)
        //and returns an array of multiples of num until the array length reaches length.
        public static int[] PoleNasobku(int cislo, int delkaPole)
        {
            int[] pole = new int[delkaPole];
            pole[0] = cislo;
            for(int i = 2; i <= delkaPole; i++)
            {
                pole[i-1] = i;
            }
            return pole;
        }
        //Vytvoř funkci, která spočítá faktoriál n
        //n! = n*(n-1)*(n-2)*...*1
        public static float Faktorial(float cislo)
        {
            if (cislo == 0)
                return 1;
            else
            {
                for (float i = cislo - 1; i >= 1; i--)
                    cislo *= i;
                return cislo;
            }
        }
        //Given a string, create a function to reverse the case.
        //All lower-cased letters should be upper-cased, and vice versa.
        //ReverseCase("Happy Birthday") ➞ "hAPPY bIRTHDAY"
        public static string MenicVelikostiPismen(string zadani)
        {
            string reseni = "";
            foreach (char pismeno in zadani)
            {
                if (pismeno >= 'a' && pismeno <= 'z')
                {
                    reseni += pismeno.ToString().ToUpper();
                }
                else if(pismeno >= 'A' && pismeno <= 'Z')
                {
                    reseni += pismeno.ToString().ToLower();
                }
                else
                {
                    reseni += pismeno;
                }
            }
            return reseni;
        }

        //Create a function that finds the word "bomb" in the given string (not case sensitive).
        //If found, return "Duck!!!", otherwise, return "There is no bomb, relax.".
    }
}
