using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int div;
                Console.Write("Introduceti un numar: ");
            int a =int.Parse(Console.ReadLine());
                Console.WriteLine("Divizorii sunt: ");
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                    Console.Write(" " + i + " ");
               
            }

                Console.ReadLine();
        }
    }
}
