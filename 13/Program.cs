using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Introduceti 2 ani: ");
            char[] chars = { ' ', ',', ';' };
            string[] tokens = Console.ReadLine().Split(chars);
            int a = int.Parse(tokens[0]);
            int b = int.Parse(tokens[1]);
            int cont = 0;
            for (int i = a; i <= b; i++)
            {
                int an = i;
                if (an % 400 == 0 || an % 4 == 0 && an % 100 != 0)
                    cont++;

            }
            Console.WriteLine("Intr anii: "+a+" si "+b+" sunt "+cont+" ani bisecti.");
            Console.ReadLine();

        }
        

    }
}


