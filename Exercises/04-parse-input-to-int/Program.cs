using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_parse_input_to_int
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mina olen kalkulaatori programm. Ütle mulle 2 numbrit ja ma ütlen Sulle nende summa");
            Console.WriteLine();

            Console.Write("Esimene number: ");
            string input1 = Console.ReadLine();

            Console.Write("Teine number: ");
            string input2 = Console.ReadLine();

            int number1 = int.Parse(input1);
            int number2 = int.Parse(input2);
            int tulemus = number1 + number2;

            Console.WriteLine("Tulemuseks on: " + tulemus);
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
