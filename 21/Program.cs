
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int rnd= rd.Next(1, 1024);
            int n;
            bool ghicit = true;
            Console.WriteLine("Ghiciti ");
            while (ghicit=true)
            {

                n = Convert.ToInt32(Console.ReadLine());
                if (rnd>n)
                { 
            
                    Console.WriteLine("Mai mare decat "+n);
                }
                else if (rnd<n)
                {
                    Console.WriteLine("Mai mic decat "+n);
                }
                else if (n==rnd)
                {
                    Console.WriteLine("L-ati ghicit!");
                    Console.ReadLine();
                    ghicit = false;
                }
                Console.WriteLine("Ghiciti ");


            }
        }
    }
}
