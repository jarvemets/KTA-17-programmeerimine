using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6x6tabel
{
    class Program
    {
        static void Main(string[] args)
        {
            //6x6 korrutustabel

            
            Console.WriteLine("----------------------------------------------------------");

            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine();
                Console.Write(i + "\t");
                //see \t tähendab tab'i et lükkab edasi


                for (int j = 1; j < 7; j++)
                {
                    Console.Write(i*j + "\t");
                    
                }



            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------");


        }
    }
}
