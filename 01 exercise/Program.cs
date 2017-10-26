using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mina olen kalkulaatori programm. Ma valin välja ühe suvalise numbri vahemikus [1 – 100]. Proovi see ära arvata");
            Console.WriteLine();
            Console.Write("Sinu number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            int magicNumber = 55;
            if (magicNumber > number)
            {
                Console.WriteLine("Sinu number on väiksem");
            }

            if (magicNumber < number)
            {
                Console.WriteLine("Sinu number on suurem");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
