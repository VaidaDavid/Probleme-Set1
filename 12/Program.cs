using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            Console.Write("Introduceti 2 numere: ");
            char[] chars = { ' ', ',', ';' };
            string[] tokens = Console.ReadLine().Split(chars);
            int a = int.Parse(tokens[0]);
            int b = int.Parse(tokens[1]);
            Console.Write("Introduceti numarul n ");
            int n = int.Parse(Console.ReadLine());
            for (int i = a; i <=b; i++)
            {
                if (i % n == 0)
                    cont=cont+1;

            }

            Console.WriteLine("In intervalul " + a +" si "+ b + " numerele intregi divizibile cu " + n +" sunt " + cont);
            Console.ReadLine();
        }
    }
}

