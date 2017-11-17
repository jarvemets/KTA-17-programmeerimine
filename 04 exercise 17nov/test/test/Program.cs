using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kordame");

            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine();
                Console.Write(i + "\t");


                for (int j = 1; j < 7; j++)
                {
                    Console.Write(i * j + "\t");

                }


            }

            Console.WriteLine();
            Console.WriteLine("........................................");

        }
    }
}
