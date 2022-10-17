using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veletlenű
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * keszitszunk egy fuggventy: 
             * neve: szamsorozat
             * visszateresi erteke nincs
             * paraméterei: also korlat: egesz, felsokorlat: egesz, darabszam: egesz
             * mukodese: megadott parameterek alapjan darabszamot irjon ki a kepernyore egymasmelle vesszovel 
             */

            Console.Write("Adjon meg a also hatart: ");
            int alsokorlat = Convert.ToInt32(Console.ReadLine());

            Console.Write("Adjon meg az felso hatart: ");
            int felsokorlat = Convert.ToInt32(Console.ReadLine());

            Console.Write("Adjon meg a darabszamot: ");
            int darabszam = Convert.ToInt32(Console.ReadLine());

            szamsorozat(alsokorlat,felsokorlat,darabszam);

            Console.ReadKey();
        }


        static void szamsorozat(int alsokorlat, int felsokorlat, int darabszam)
        {
            Random veletlen = new Random();
            for (int i = 0; i < darabszam; i++)
            {
                Console.Write($"{veletlen.Next(alsokorlat,felsokorlat+1)}, ");
            }
        }
    }
}
