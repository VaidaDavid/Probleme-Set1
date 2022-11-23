using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nr, z, ogl;
            z = 0;
            ogl = 0;
            Console.Write("Introduceti un numar: ");
            nr = int.Parse(Console.ReadLine());
            nr = z;
            while (nr != 0)
            {
                ogl = ogl * 10 + nr % 10;
                nr = nr / 10;
            }
            if (z == ogl)
                Console.WriteLine("Numarul este un palindrom");
            else
                Console.WriteLine("Numarul nu este un palindrom");
            Console.ReadLine();
        }
    }
}
