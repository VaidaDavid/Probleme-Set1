using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti 5 numere: ");
            char[] chars = { ' ', ',', ';' };
            string[] tokens = Console.ReadLine().Split(chars);
                int a = int.Parse(tokens[0]);
                int b = int.Parse(tokens[1]);
                int c = int.Parse(tokens[2]);
                int d = int.Parse(tokens[3]);
                int e = int.Parse(tokens[4]);
            int[] v = { a, b, c, d, e,};
            bool switched;
            for (int i = 0; i < v.Length; i++)
            {
                int aux;
                for (int j = 0; j < v.Length-1; j++)
                {
                    if (v[j] > v[j+1])
                    {
                        aux=v[j+1]; v[j + 1] = v[j];v[j] = aux;
                    }
                }

            }
            for (int k = 0; k < v.Length; k++)
                Console.Write(v[k] + " ");

            Console.ReadKey();



        }
    }
}
