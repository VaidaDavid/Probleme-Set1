using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            cmmdc();
            cmmmc();

        }

        private static void cmmmc()
        {
            int a, b;
            Console.Write("Introduceti un numar: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar: ");
            b = int.Parse(Console.ReadLine());
            int m, n;
            n = a;
            m = b;
            while (n!=m)
            {
                if (n < m)
                    n = n + a;
                else if (n > m)
                    m=m + b;
               
            }
            Console.WriteLine("Cel mai mare multiplu comun este: " + n);
            Console.ReadLine();

        }

        public static void cmmdc()
        {
            int a, b, r;
            Console.Write("Introduceti un numar: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar: ");
            b = int.Parse(Console.ReadLine());

            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;

            }
            Console.WriteLine("Cel mai mic divizor comun este: " + a);
            Console.ReadLine();
        }
    }
}
