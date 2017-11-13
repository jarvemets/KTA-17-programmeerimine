using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_parse_input_multiply_divide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mina olen kalkulaatori programm.");
            Console.WriteLine("Ütle mulle 2 numbrit ja ma ütlen Sulle nende korrutise ja jagatise");
            Console.WriteLine();

            Console.Write("Esimene number: ");
            string input1 = Console.ReadLine();

            Console.Write("Teine number: ");
            string input2 = Console.ReadLine();

            int number1 = int.Parse(input1);
            int number2 = int.Parse(input2);
            int tulemus1 = number1 * number2;
            int tulemus2 = number1 / number2;

            Console.WriteLine("Korrutades " + input1 + " ja " + input2 + " on tulemuseks: " + tulemus1);
            Console.WriteLine("Jagades " + input1 + " ja " + input2 + " on tulemuseks: " + tulemus2);
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
