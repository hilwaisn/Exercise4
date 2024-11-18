using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inputan(args, 0);
        }
        static void Inputan(string[] args, int angka)
        {
            Console.Write("Masukkan banyak angka : ");
            int banyak1 = Convert.ToInt32(Console.ReadLine());
            int[] banyak = new int[banyak1];

            for (int a= 0; a < banyak.Length; a++)
            {
                Console.Write("Angka ke-" + (a+1) + " : ");
                banyak[a] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(banyak);
            Array.Reverse(banyak);
            Console.Write("");
            foreach(int i in banyak)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
