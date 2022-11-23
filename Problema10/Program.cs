using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b,c;
            b= 0;
            c= 0;
            Console.Write("Introduceti un numar: ");
            int a =int.Parse(Console.ReadLine());
            for (int i = 2; i < Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                    c = 1;
                else
                    b = 1;
            }
            if (c==1)
            {
                Console.WriteLine("Numarul nu este prim");
            }
            else if (b==1)
            {
                Console.WriteLine("Numarul introdus este prim");
            }
            Console.ReadLine();
        }
    }
}
