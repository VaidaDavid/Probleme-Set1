using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema11
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
            //string lungime = Convert.ToString(nr);
            //int length = lungime.Length;
            //Console.Write("Numarul introdus invers este: ");
            //for (int i = 0; i < length; i++)
            //{
            //   z = nr % 10;
            //    nr = nr / 10;
            //    Console.Write(z);
            //}

            while (nr != 0)
            {
                ogl = ogl * 10 + nr % 10;
                nr = nr / 10;
            }
            Console.WriteLine("Numarul introdus invers este: " + ogl);     
            Console.ReadLine();
        }
    }
}
