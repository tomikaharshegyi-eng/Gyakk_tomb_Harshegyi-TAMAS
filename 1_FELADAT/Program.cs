using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_FELADAT
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] szamok = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(1, 101);
            }
            Console.WriteLine(String.Join(" ", szamok));

            int parosdb = 0;
            int paratlandb = 0;
            foreach (int item in szamok)
            {
                if (item == 0)
                {
                    parosdb++;
                }
                else if (item == 1)
                {
                    paratlandb++;
                }
            }
            Console.WriteLine($"A paros szamok: {parosdb}");
            Console.WriteLine($"A paratlan szamok: {paratlandb}");
            Console.ReadLine();
        }
    }
}
