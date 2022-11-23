using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, d, cont,a;
            Console.Write("Introduceti un numar: ");
            n = int.Parse(Console.ReadLine());
            d = 2;
            a = n;
            while (n>1)
            {
                a = n;
                cont = 0;
                while (n % d == 0)
                {
                    cont++;
                    n = n / d;
                }
               if (a!=n)
                {
                    Console.Write(d + " ^" + cont + " ");
                    d++;
                }
                else
                {
                    d++;
                }

                if (n > 1 && d * d > n)
                {
                    d = n;
                }


            }
            Console.ReadLine(); 
        }
    }
}
