using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Mina olen pikkuse spetsialist.");
            Console.WriteLine();

            float height;

            Console.WriteLine("Kirjuta mulle oma pikkus cm \n");

            height = int.Parse(Console.ReadLine());

            if (height < 150.0)

            Console.WriteLine("Päkapikk! \n");

            else if ((height >= 150.0) && (height <= 170.0))

            Console.WriteLine("Täitsa tavaline \n");

            else if ((height >= 170.0) && (height <= 195.0))

            Console.WriteLine("Täitsa pikk oled! \n");

            else
            Console.WriteLine("Einoh, ebanormaalselt pikk \n");

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
