using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int an;
            Console.Write("Introduceti un an: ");
            an =int.Parse(Console.ReadLine());
            if (an % 400 == 0 || an % 4 == 0 && an % 100 != 0)
                Console.WriteLine("Anul introdus este bisect");
            else
                Console.WriteLine("Anul introdus nu este bisect");

            Console.ReadLine();
        }
    }
}
