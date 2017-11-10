using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_exercise
{
    class Program
    {
        static void Main()
        {
            // Mitu küsimust ja vastust aja teemal. Hoolimata mida inimene vastab, programm jätkab küsimist :)
            DateTime now = DateTime.Now;

            Console.WriteLine("Kas tead mis kuupäev täna on?");
            string input = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Tänane kuupäev on: {0}", now.ToString("dd/MM/yyyy"));

            Console.WriteLine();

            Console.WriteLine("Kas tead mis kuu praegu on?");
            string input2 = Console.ReadLine();

            Console.WriteLine("Jah, praegu on {0}\n", now.ToString("MMMM"));

            Console.WriteLine("Kas tead mis kell praegu on?");
            string input3 = Console.ReadLine();

            Console.WriteLine("Jah, praegu on {0}\n", now.ToString("h:mm:ss"));

            Console.WriteLine("Kas tead mitu kuud aastas on?");
            string input4 = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Aastas on 12 kuud:");
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(" {0}", now.ToString("MMMM"));
                now = now.AddMonths(1);
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
