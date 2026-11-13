using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_FELADAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] homerseklet = { 12, 8, -1, 5, 14, 7, 2 };
            for (int i = 0; i < homerseklet.Length; i++)
            {
                Console.WriteLine(homerseklet[i]);
            }
            int maxhatlag = 0;
            int minhatlag = 0;
            for (int i = 0; i < homerseklet.Length; i++)
            {
                maxhatlag = Math.Max(maxhatlag, homerseklet[i]);
                minhatlag = Math.Min(minhatlag, homerseklet[i]);
            }
            Console.WriteLine($"A legnagyobb homerseklet: {maxhatlag}");
            Console.WriteLine($"A legkisebb homerseklet: {minhatlag}");
        }
    }
}
