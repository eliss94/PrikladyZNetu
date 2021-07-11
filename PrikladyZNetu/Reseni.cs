using System;
using System.Collections.Generic;
using System.Linq;

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
            string cisloString = cislo.ToString();
            string vystup = "";
            List<char> cisloList = new List<char>();
            foreach(char cislicko in cisloString)
            {
                cisloList.Add(cislicko);
            }
            cisloList.Reverse();
            foreach(char cislicko in cisloList)
            {
                vystup += cislicko;
            }
            return vystup + cisloString;
        }

        //Create a function that determines whether a string is a valid hex code.
        //A hex code must begin with a pound key # and is exactly 6 characters in length.
        //Each character must be a digit from 0-9 or an alphabetic character from A-F.
        //All alphabetic characters may be uppercase or lowercase.
        public static bool Hexcode(string kod)
        {
            kod = kod.ToLower();
            if (!kod.StartsWith('#') && kod.Length != 7)
                return false;
            else
                kod = kod.Remove(0, 1);
            foreach (int znak in kod)
            {
                if (!(znak >= '0' && znak <= '9' || znak >= 'a' && znak <= 'f'))
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
            Dictionary<char, bool> pozice = new Dictionary<char, bool>
            {
                { 'A', false },
                { 'B', true },
                { 'C', false }
            };
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
            for (int i = 2; i <= delkaPole; i++)
            {
                pole[i - 1] = i*cislo;
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
        public static float RekurzniFaktorial(float cislo)
        {
            if (cislo == 0)
                return 1;
            else
            {
                float vysledek = cislo * (RekurzniFaktorial(cislo - 1));
                return vysledek;
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
                else if (pismeno >= 'A' && pismeno <= 'Z')
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
        public static string Bomb(string zadani)
        {
            string bomb = "Duck!";
            string nobomb = "There is no bomb, relax.";
            zadani = zadani.ToLower();
            if (zadani.Contains("bomb"))
            {
                return bomb;
            }
            else
            {
                return nobomb;
            }
        }

        //Create a function that takes an array of arrays with numbers.
        //Return a new (single) array with the largest numbers of each.
        public static int[] NajdiNejvetsi(int[][] pole)
        {
            int[] vysledek = new int[pole.Count()];
            int i = 0;
            foreach (int[] radek in pole)
            {
                vysledek[i] = radek.Max();
                i++;
            }

            return vysledek;
        }
        //Create a function that takes a single character as an argument
        //and returns the char code of its lowercased / uppercased counterpart.
        public static int HodnotaOpacnehoPismene(char pismeno)
        {
            string opacnePismeno;
            int vysledek;
            char[] cislo;

            if ('a' <= pismeno && pismeno >= 'z')
            {
                opacnePismeno = pismeno.ToString().ToUpper();
                cislo = opacnePismeno.ToCharArray();
                vysledek = cislo[0];
                return vysledek;
            }
            else if ('A' <= pismeno && pismeno >= 'Z')
            {
                opacnePismeno = pismeno.ToString().ToLower();
                cislo = opacnePismeno.ToCharArray();
                vysledek = cislo[0];
                return vysledek;
            }
            else
            {
                vysledek = pismeno;
                return vysledek;
            }
        }
        //In this challenge, you must verify the equality of two different values given the parameters a and b.
        //Both the value and type of the parameters need to be equal.The possible types of the given parameters are:
        //Numbers String Booleans(false or true)
        //CheckEquality(1, true) ➞ false
        // A number and a boolean: the value and type are different.
        public static bool KontrolaTypu(object a, object b)
        {
            return (a.GetType() == b.GetType());
                
        }
        //Given the month and year as numbers, return whether that month contains a Friday 13th.
        //HasFriday13th(3, 2020) ➞ True
        public static bool PatekTrinacteho(int mesic, int rok)
        {
            DateTime datum = new DateTime(rok, mesic, 13);
            if (datum.DayOfWeek == DayOfWeek.Friday)
            {
                return true;
            }
            else
                return false;
        }
        //Create a function that takes a string and returns the middle character(s).
        //If the word's length is odd, return the middle character.
        //If the word's length is even, return the middle two characters.
        //GetMiddle("test") ➞ "es"
        public static string ProstredniZnaky(string zadani)
        {
            string prostredniZnaky = "";
            if (zadani.Length % 2 == 0)
            {
                int prostredni = (zadani.Length / 2)-1;
                prostredniZnaky += zadani[prostredni];
                prostredniZnaky += zadani[prostredni + 1];
                return prostredniZnaky;
            }
            else
            {
                int prostredni = (zadani.Length / 2);
                prostredniZnaky += zadani[prostredni];
                return prostredniZnaky;
            }
        }
       
        //An isogram is a word that has no duplicate letters.
        //Create a function that takes a string and returns either true or false
        //depending on whether or not it's an "isogram".
        public static bool Isogram(string zadani)
        {
            zadani = zadani.ToLower();
            HashSet<char> pismena = new HashSet<char>();
            foreach (char pismeno in zadani)
            {
                if (!pismena.Add(pismeno))
                    return false;
            }
            return true;
        }
        //Create a function that takes a number as an argument and returns true or false
        //depending on whether the number is symmetrical or not.
        //A number is symmetrical when it is the same as its reverse.
        public static bool PalindromCislo(int cisloZadani)
        {
            string cisloString = cisloZadani.ToString();
            string cisloPrevracene = "";
            for(int i = cisloString.Length-1; i > -1; i--)
            {
                cisloPrevracene += cisloString[i];
            }
            for (int i = 0; i < cisloString.Length; i++)
            {
                if (cisloString[i] != cisloPrevracene[i])
                    return false;
            }
            return true;
        }
        //ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot
        //contain anything but exactly 4 digits or exactly 6 digits.
        //Your task is to create a function that takes a string and returns
        //true if the PIN is valid and false if it's not.
        public static bool Pin(string zadani)
        {
            if (zadani.Length != 4 && zadani.Length != 6)
                return false;
            else
            {
                return Int32.TryParse(zadani, out int pin);
            }
        }
        //Create a function that takes an array of numbers and returns the sum of the two lowest positive numbers.
        public static int SoucetDvouNejmensich(int[] zadani)
        {
            Array.Sort(zadani);
            return (zadani[0] + zadani[1]);
        }


    }
}
