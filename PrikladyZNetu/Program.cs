using System;
using System.Collections.Generic;
using System.Linq;

namespace PrikladyZNetu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zadani = { 5, 6, 2, 8, 9, 1 };
            Console.WriteLine(Reseni.SoucetDvouNejmensich(zadani));
        }
    }
}
