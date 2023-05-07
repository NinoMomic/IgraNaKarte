using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgraNaKarte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rezultat = 0;
            int upis;

            do
            {
                try
                {
                    Console.WriteLine("Upisite vrijednost karte (1 - 13).");
                    upis = Convert.ToInt32(Console.ReadLine());

                    if (upis >= 1 && upis <= 13) rezultat = rezultat + upis;
                    else Console.WriteLine("Krivi upis, pokusajte ponovo.");

                }
                catch (FormatException ex) { Console.WriteLine(ex.Message); }

            } while (rezultat < 31);


            if (rezultat == 31 || rezultat > 31) Console.WriteLine("Pobjedili ste");
            else Console.WriteLine("Izgubili ste");


            Console.ReadKey();
        }
    }
}
