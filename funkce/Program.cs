using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funkce
{

    internal class Program
    {
        static double Soucet(double x, double y)
        {
            double z = 0;
            z = x + y;
            return z;

        }
        //odečítaní
        static double Odecitani(double x, double y)
        {
            return x - y;
        }
        //dělení
        static double Deleni(double x, double y)
        {
            return x / y;
        }

        //násobení
        static double Nasobeni(double x, double y)
        {
            return x * y;
        }
        //pokročilé funkce
        //mocnina
        static double mocnina(double x, double y)
        {
            return Math.Pow(x, y);
        }
        //odmocnina
        static double odmocnina(double x)
        {
            return Math.Sqrt(x);
        }
        // větší číslo
        static double vetsi(double x, double y)
        {
            if (x > y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
        //sude liche
        static string SudeLiche(double x)
        {

            if (x % 2 == 0)
            {
                return "sudé";
            }
            else
            {
                return "liché";
            }
        }

        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("zadejet první číslo");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Zadejete druhé číslo");
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine("Vyberte typ operace 1.Sčítaní , 2. Odčítání, 3. Dělení, 4. Násobení, 5. Mocnina, 6. Odmocnina, 7. zjištění většího čísla");
                int volba = int.Parse(Console.ReadLine());
                double vysledek = 0;
                switch (volba)
                {
                    case 1:
                        vysledek = Soucet(x, y);
                        break;
                    case 2:
                        vysledek = Odecitani(x, y);
                        break;
                    case 3:
                        vysledek = Deleni(x, y);
                        break;
                    case 4:
                        vysledek = Nasobeni(x, y);
                        break;
                    case 5:
                        vysledek = mocnina(x, y);
                        break;
                    case 6:
                        vysledek = odmocnina(x);
                        break;
                    case 7:
                        vysledek = vetsi(x, y);
                        break;

                    default:
                        break;
                }
                if ((volba > 0) && (volba < 8))
                {
                    Console.WriteLine("Výsledek: " + vysledek);
                }
            }
            Console.ReadKey();
        }
    }
}
