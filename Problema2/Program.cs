using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, x, y;
                Console.WriteLine("Introduceti primul numar");
            a = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduceti al doilea numar");
            b = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduceti al treilea numar");
            c = int.Parse(Console.ReadLine());
            d = b*b - 4 * a * c;
            if (d > 0)
            {
                Console.WriteLine("Ecuatia are doua solutii:");
                
                    x = (int)(-b + Math.Sqrt(d)) / 2 * a;
                    y = (int)(-b - Math.Sqrt(d)) / 2 * a;
                Console.WriteLine("Aceste solutii sunt: " + x +" respectiv " + y);
            }
            else if (d == 0)
            {
                Console.WriteLine("Ecuatia are o singura solutie");
                    x = (int)(-b + Math.Sqrt(d)) / 2 * a;
                Console.WriteLine("Acesta solutie este:" + x);
            }
            else
            {
                Console.WriteLine("Ecuatia nu are solutii in multimea numerelor reale");
            }
            Console.ReadLine();
        }
    }
}
