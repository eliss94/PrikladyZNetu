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
                bool prvniKelimek = pozice[tah[0]];
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
        public static string PoleNasobku(int cislo, int delkaPole)
        {
            string poleNasobku = "";
            int[] pole = new int[delkaPole];
            pole[0] = cislo;
            for (int i = 2; i <= delkaPole; i++)
            {
                pole[i - 1] = i*cislo;
            }
            foreach(int x in pole)
            {
                poleNasobku += x + " ";
            }
            return poleNasobku;
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
        //Create a function that accepts a string of space separated numbers
        //and returns the highest and lowest number (as a string).
        public static string NejmensiANejvetsi(string zadani)
        {
            
            string[] rozdelenaCisla = zadani.Split(' ');
            List<int> listCisel = new List<int>();
            int minHodnota;
            int maxHodnota;
            foreach(string stringCislo in rozdelenaCisla)
            {
                listCisel.Add(int.Parse(stringCislo));
            }
            minHodnota = listCisel.Min();
            maxHodnota = listCisel.Max();
            string vysledek = minHodnota.ToString() + ' ' + maxHodnota.ToString();
            return vysledek;
        }
        //Create a function that takes a strings characters as ASCII
        //and returns each characters hexadecimal value as a string.
        //ConvertToHex("hello world") ➞ "68 65 6C 6C 6F 20 77 6F 72 6C 64"
        public static string ConvertToHex(string zadani)
        {
            string hexadecimalValue = "";
            foreach(char znak in zadani)
            {

                int value = Convert.ToInt32(znak);
                hexadecimalValue += String.Format("{0:X}", value) + ' ';
            }
            return hexadecimalValue;
        }
        //Given a positive number x, if all the positive divisors of x (excluding x) add up to x,
        //then x is said to be a perfect number.
        //For example, the set of positive divisors of 6 excluding 6 itself is (1, 2, 3).
        //The sum of this set is 6. Therefore, 6 is a perfect number.
        //Given a positive number x, if all the positive divisors of x add up to a second number y,
        //and all the positive divisors of y add up to x, then x and y are said to be a pair of amicable numbers.
        //Create a function that takes a number and returns "Perfect" if the number is perfect,
        //"Amicable" if the number is part of an amicable pair, or "Neither".
        public static string PerfektniSpratelenaCisla(int cislo)
        {
            int soucet = 0;
            int soucetSouctu = 0;
            for(int i = cislo-1; i > 0; i--)
            {
                if(cislo % i == 0)
                {
                    soucet += i;
                }
            }
            if(soucet == cislo)
            {
                return "Perfect";
            }
            else
            {
                for(int j = soucet-1; j>0; j--)
                {
                    if(soucet%j == 0)
                    {
                        soucetSouctu += j;
                    }
                }
                if (soucetSouctu == cislo)
                    return "Amicable";
                else
                    return "Neither";
            }
        }
        //A string is an almost-palindrome if, by changing only one character, you can make it a palindrome.
        //Create a function that returns true if a string is an almost-palindrome and false otherwise.
        public static bool AlmostPalindrome(string zadani)
        {
            int pocetZmen = 0;
            for (int i = 0; i < zadani.Length / 2; i++)
                if (zadani[i] != zadani[zadani.Length - 1 - i])
                {
                    pocetZmen++;
                    if (pocetZmen > 1)
                        return false;
                }
            
                return true; 
        }
        //This is a reverse coding challenge. Normally you're given explicit directions with how to create a function.
        //Here, you must generate your own function to satisfy the relationship between the inputs and outputs.
        //Your task is to create a function that, when fed the inputs below, produce the sample outputs shown.
        //"A4B5C2" ➞ "AAAABBBBBCC"
        public static string CodingChallange(string zadani)
        {
            string vysledek = "";
            int pocetOpakovani;
            char znakNaPridani = ' ';
            for(int i = 1; i<= zadani.Length; i++)
            {
                if(i%2 != 0)
                {
                    znakNaPridani = zadani[i - 1];
                    vysledek += znakNaPridani.ToString();
                }
                else
                {
                    pocetOpakovani = int.Parse(zadani[i-1].ToString());
                    for(int j = 0; j< pocetOpakovani -1; j++)
                    {
                        vysledek += znakNaPridani;
                    }
                }
            }
            return vysledek;
        }
        //Write a function that takes an integer n, reverses the binary representation of that integer,
        //and returns the new integer from the reversed binary.
        //reversedBinaryInteger(10) ➞ 5
        // 10 = 1010 -> 0101 = 5
        public static int ReverseBinary(int zadani)
        {
            string cisloString = Convert.ToString(zadani, 2);
            string obracenyBinarKod = "";
            for(int i = cisloString.Length -1 ; i >= 0; i--)
            {
                obracenyBinarKod += cisloString[i];
            }
            int vysledek = Convert.ToInt32(obracenyBinarKod, 2);
            return vysledek;
        }
        //Your task is to create a function that, when fed the inputs below, produce the sample outputs shown.
        //832 ➞ 594 51 ➞ 36 7977 ➞ 198 1 ➞ 0 665 ➞ 99 149 ➞ 0

        public static int OdcitacSerazenehoCisla(int zadani)
        {
            string zadaniString = zadani.ToString();
            List<int> zadaniInt = new List<int>();
            foreach(char cislicko in zadaniString)
            {
                zadaniInt.Add((int)char.GetNumericValue(cislicko));
            }
            zadaniInt.Sort();
            string serazeneCislo = "";
            foreach (var polozka in zadaniInt)
                serazeneCislo += polozka;
            int naOdecteni = int.Parse(serazeneCislo);
            return zadani - naOdecteni;
        }
        //Create a function that takes a string and returns the number of alphanumeric characters that occur more than once.
        public static int PocetOpakujicichSeZnaku(string zadani)
        {
            Dictionary<char, int> zadaniSlovnik = new Dictionary<char, int>();
            int pocetOpakujicichSe = 0;
            foreach(char znak in zadani)
            {
                if (!zadaniSlovnik.TryAdd(znak, 1))
                {
                    zadaniSlovnik[znak]++;
                }
                
            }
            foreach(var polozka in zadaniSlovnik)
            {
                if (polozka.Value > 1)
                    pocetOpakujicichSe++;
            }
            return pocetOpakujicichSe;
        }
        //In recreational mathematics, a square array of numbers, usually positive integers,
        //is called a magic square if the sums of the numbers in each row, each column,
        //and both main diagonals are the same.
        //Create a function that takes a square 2D array as an argument
        //and returns a Boolean(if it is: true, if it isn't: false).

        public static bool MagicSquare(int[][]zadani)
        {
            int[] soucty = new int[zadani.Length + zadani.Length +2];
            int i = 0;
            foreach (int[] radek in zadani)
            {
                soucty[i] = radek.Sum();
                i++;
            }
            for (int p = 0; p < zadani.Length; p++)
            {
                int pomocnaPromenna = 0;
                for(int q = 0; q < zadani.Length; q++)
                {
                    pomocnaPromenna += zadani[q][p];
                }
                soucty[i] = pomocnaPromenna;
                i++;
            }
            int soucetDiagonaly = 0;
            int soucetDruheDiagonaly = 0;
            for (int u = 0; u< zadani.Length; u++)
            {
                soucetDiagonaly += zadani[u][u];
            }
            soucty[i] = soucetDiagonaly;
            i++;
            for (int u = zadani.Length - 1; u>=0; u--)
            {
                soucetDruheDiagonaly += zadani[u][u];
            }
            soucty[i] = soucetDruheDiagonaly;
            for (int j = 1; j < soucty.Length; j++)
            {
                if (soucty[j] != soucty[0])
                    return false;
            }
            return true;
        }
        public static bool MagicSquareDva(int[][] zadani)
        {
            int[] soucty = new int[zadani.Length + zadani.Length + 2];
            int i = 0;
            for (int p = 0; p < zadani.Length; p++)
            {
                int pomocnaPromenna = 0;
                int pomocnaPromennaDva = 0;
                for (int q = 0; q < zadani.Length; q++)
                {
                    pomocnaPromenna += zadani[q][p];
                    pomocnaPromennaDva += zadani[p][q];
                }
                soucty[i] = pomocnaPromenna;
                i++;
                soucty[i] = pomocnaPromennaDva;
                i++;
            }
            int soucetDiagonaly = 0;
            int soucetDruheDiagonaly = 0;
            for (int u = 0; u < zadani.Length; u++)
            {
                soucetDiagonaly += zadani[u][u];
            }
            soucty[i] = soucetDiagonaly;
            i++;
            int v = 0;
            for (int u = zadani.Length - 1; u >= 0; u--)
            {
                soucetDruheDiagonaly += zadani[u][v];
                v++;
            }
            soucty[i] = soucetDruheDiagonaly;
            for (int j = 1; j < soucty.Length; j++)
            {
                if (soucty[j] != soucty[0])
                    return false;
            }
            return true;
        }
        //Create a function that takes two times of day (hours, minutes, seconds) and returns
        //the number of occurences of palindrome timestamps within that range, inclusive.
        //A palindrome timestamp should be read the same hours : minutes : seconds as seconds : minutes : hours,
        //keeping in mind the seconds and hours digits will reverse.For example, 02 : 11 : 20 is a palindrome timestamp.
        public static int TimeSteps(int hodina1, int minuta1, int sekunda1, int hodina2, int minuta2, int sekunda2)
        {
            int palindromStepu = 0;
            DateTime prvniCas = new DateTime(1, 1, 1, hodina1, minuta1, sekunda1);
            DateTime druhyCas = new DateTime(1, 1, 1, hodina2, minuta2, sekunda2);
            //while((prvniCas.Hour != druhyCas.Hour)||(prvniCas.Minute != druhyCas.Minute)||(prvniCas.Second != druhyCas.Second))
            while (!IsEqualTime(prvniCas, druhyCas))
            {
                if (IsPalindrom(prvniCas))
                {
                    palindromStepu++;
                }
                prvniCas = prvniCas.AddSeconds(1);
            }
            return palindromStepu;
        }
        private static bool IsPalindrom(DateTime prvniCas)
        {
            string cas = "";
            if (prvniCas.Hour < 10)
            {
                cas += "0" + prvniCas.Hour.ToString();
            }
            else
            {
                cas += prvniCas.Hour.ToString();
            }
            if(prvniCas.Minute <10)
            {
                cas += "0" + prvniCas.Minute.ToString();
            }
            else
            {
                cas += prvniCas.Minute.ToString();
            }
            if(prvniCas.Second < 10 )
            {
                cas += "0" + prvniCas.Second.ToString();
            }
            else
            {
                cas += prvniCas.Second.ToString();
            }
            for(int i = 0; i < cas.Length/2; i++)
            {
                if (cas[i] != cas[cas.Length -1 -i])
                {
                    return false;
                }
            }
            return true;
        }
        private static bool IsEqualTime(DateTime prvniCas, DateTime druhyCas)
        {
            if (prvniCas.Hour != druhyCas.Hour)
                return false;
            else if (prvniCas.Minute != druhyCas.Minute)
                return false;
            else if (prvniCas.Second != prvniCas.Second)
                return false;
            else
                return true;
        }

    }
}
