using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Introduceti primul numar");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al treilea numar");
            c = int.Parse(Console.ReadLine());
            int[] numere = { a, b, c };
            for (int i = 0; i < numere.Length; i++)
            {
                Console.Write(numere[i] + " ");

                
            }
            Console.ReadLine();
        }
    }
}
