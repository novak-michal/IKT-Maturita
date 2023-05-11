using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Určení maxima ze tří zadaných čísel");
            Console.WriteLine("Zadej číslo a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadej číslo b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadej číslo c:");
            int c = Convert.ToInt32(Console.ReadLine());
            
            if (a > b)
            {
                if (a>c)
                {
                    Console.WriteLine("Maximum je číslo " + a);
                }
                else
                    Console.WriteLine("Maximum je číslo " + c);
                
            }
            else if (c>b)
            {
                Console.WriteLine("Maximum je číslo " + c);
            }
            else
            {
                Console.WriteLine("Maximum je číslo " + b);
            }
            Console.ReadLine();

        }
    }
}
