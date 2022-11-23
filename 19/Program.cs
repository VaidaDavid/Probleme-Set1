using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, d1, d2, d3, cont;
                Console.WriteLine("Introduceti un numar");
            n = int.Parse(Console.ReadLine());
            d1 = n % 10;
            d3 = -1;
            int count = 0; 
            bool da = true;
            n = n / 10;
            while (n > 0)
            {
                d2 = n % 10;
                if (d1 != d2 && d2 != d3)
                {
                    d3 = d1;
                    d1 = d2;
                    count++;
                }
                if (count > 1)
                {
                    da = false;
                    break;
                }
                n = n / 10;
            }
            if (da == true)
            {
                Console.WriteLine("da");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("nu");
                Console.ReadLine();
            }
        }
    }
    
}
