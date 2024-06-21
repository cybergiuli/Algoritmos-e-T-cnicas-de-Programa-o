using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, var;
            double[] temp = new double[31];
           

            for (i = 0; i < temp.Length; i++)
            {
                Console.WriteLine("escreva uma temperatura:");
                temp[i] = double.Parse(Console.ReadLine());

            }

            Console.WriteLine("Escolha uma temperatura");
            var = int.Parse(Console.ReadLine());

            for (i = 0; i < temp.Length; i++)
            {
                if (var == temp[i])
                {
                    Console.WriteLine($"O dia é:{i + 1}");
                }
                
            }

            Console.Read();

        }
    }
}
