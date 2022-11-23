using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti doua numere: ");
            char[] chars = { ' ',';',',' };
            string [] token=Console.ReadLine().Split(chars);
            int a = int.Parse(token[0]);
            int b = int.Parse(token[1]);
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Numere introduse inversate sunt: " + a + " " + b);
            Console.ReadLine();
        }
    }
}
