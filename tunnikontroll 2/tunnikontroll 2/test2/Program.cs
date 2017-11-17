using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Taco Palenque");
            Console.WriteLine("1200 Main St");
            Console.WriteLine("--------------------------------------------");

            while (true)
                { 

                Console.Write("Enter price of food item [-1 to quite]: ");

                string input = Console.ReadLine();
                int price = int.Parse(input);
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                if (price == -1)
                    {
                         break;
                    }


            }
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine($"Subtotal: ");
            Console.WriteLine($"15% Gratuity: ");
            Console.WriteLine($"Total: ");
          
            Console.WriteLine();

        }
    }
}
