using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulačka
{
    class Program
    {
        static void Main(string[] args)
        {
            bool pokračovat;
            do
            {
                try
                {
                    Console.WriteLine("Sčítačka");
                    Console.WriteLine("Zadej první číslo:");
                    string číslo1 = Console.ReadLine();

                    Console.WriteLine("Zadej druhé číslo:");
                    string číslo2 = Console.ReadLine();

                    //textové proměnné číslo1 a číslo2 převedeme na číslo:
                    int číslo1p = Convert.ToInt32(číslo1);
                    int číslo2p = Convert.ToInt32(číslo2);

                    //Výběr operace
                    Console.WriteLine("Zadej operaci (+, -, *, /, %):");
                    string operace = Console.ReadLine();

                    //připravíme proměnnou pro ukládání výsledku:
                    int výsledek;
                    //switch provede požadovanou operaci dle výběru (porovnává se hodnota proměnné operace)
                    switch (operace)
                    {
                        case "+":
                            výsledek = číslo1p + číslo2p;
                            Console.WriteLine("Součet je: " + výsledek);
                            break;
                        case "-":
                            výsledek = číslo1p - číslo2p;
                            Console.WriteLine("Rozdíl je: " + výsledek);
                            break;
                        case "*":
                            výsledek = číslo1p * číslo2p;
                            Console.WriteLine("Součin je: " + výsledek);
                            break;
                        case "/":
                            výsledek = číslo1p / číslo2p;
                            Console.WriteLine("Výsledek celočíselného dělení je: " + výsledek); break;
                        case "%":
                            výsledek = číslo1p % číslo2p;
                            Console.WriteLine("Zbytek po dělení je: " + výsledek);
                            break;
                        default:
                            Console.WriteLine("Zadals neplatnou operaci!");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Zadal jste nečíslo!");
                }
                Console.WriteLine("Chceš pokračovat (a/n)?");
                string odpověď = Console.ReadLine();
                pokračovat = (odpověď == "a");
            } while (pokračovat);
        }
    }
}
