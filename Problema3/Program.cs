using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            Console.WriteLine("Introduceti un numar n");
            n =int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti un numar k");
            k = int.Parse(Console.ReadLine());
            if (n % k == 0)
                Console.WriteLine("Numarul introdus n se divide cu k");
            else
                Console.WriteLine("Numarul introdus n nu se divide cu k");
            Console.ReadLine();
        }
    }
}
