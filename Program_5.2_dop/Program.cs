using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_5._2_dop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] massiv = new int[15];
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                massiv[i] = random.Next(0, 50);
                Console.Write("{0} ", massiv[i]);
            }
            int max = massiv[0];
            int min = massiv[0];

            for (int i = 0; i < 15; i++)
            {
                if (min < massiv[i])
                    min = massiv[i];

                for (int j = 0; j < 15; j++)
                {
                    if (max > massiv[j])
                        max = massiv[j];
                }
            }
            int sum = max + min;
            Console.WriteLine();
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }




}
