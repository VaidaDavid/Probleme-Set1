using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema5
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int nr, k ,z ;
            z = 0;
            Console.WriteLine("Introduceti un numar");
            nr =int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti pozitia cifrei pe care o doriti extras. (Numerotarea de la dreapta la stanga)");
            k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                z = nr % 10;
                nr = nr / 10;
                    
            }
           
            
            Console.WriteLine("Cifra dorita este: " + z);
            Console.ReadLine();
        }
    }
}
