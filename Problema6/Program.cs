using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti 3 numere: ");
            char[] chars = {' ',',',';'};
            string [] tokens=Console.ReadLine().Split(chars);
            int a = int.Parse(tokens[0]);
            int b = int.Parse(tokens[1]);
            int c = int.Parse(tokens[2]);
            if (( a < b + c) && ( b < a + c) && ( c < b + c) && ( a > 0) && ( b > 0) && ( c > 0))
            {
                Console.WriteLine("Numerele introduse pot forma un triunghi");
            }
            else
            {
                Console.WriteLine("Numerele introduse nu pot forma un triunghi");
            }
            Console.ReadLine();
        }
    }
}
