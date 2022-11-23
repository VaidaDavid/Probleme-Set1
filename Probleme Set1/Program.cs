using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_Set1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int x;
            Console.WriteLine("Introduceti un numar: ");
            a= int.Parse(Console.ReadLine()); 
            Console.WriteLine("Introduceti al doilea numar");
            b = int.Parse(Console.ReadLine());
             if (a !=0)
                {
                    x = -b / a;
                    Console.WriteLine("Solutia ecuatiei este " + x);

                }
                else if (b == 0)
                {
                     Console.WriteLine("Ecuatia are o infinitate de solutii");
                }
                else
                {
                Console.WriteLine("Ecuatia nu are solutii");

                }
            Console.ReadLine();


        }

    }
}
