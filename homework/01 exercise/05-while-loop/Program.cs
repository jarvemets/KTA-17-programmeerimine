﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_automaatne
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int magicNumber = random.Next(1, 100);
            int guess = 0;
            bool guessedCorrect = false;

            Console.WriteLine("Mina olen kalkulaatori programm. Ma valin välja ühe suvalise numbri vahemikus [1 – 100]. Proovi see ära arvata");
            Console.WriteLine();

            while (true)
            {
                
                Console.Write("Sinu number: ");
                string input = Console.ReadLine();
                int number = int.Parse(input);

                if (!int.TryParse(input, out guess))

                {
                    guessedCorrect = true;
                }

                if (magicNumber > number)
                {
                    Console.WriteLine("Sinu number on väiksem");
                }

                if (magicNumber < number)
                {
                    Console.WriteLine("Sinu number on suurem");
                }

                if (magicNumber == number)
                {
                    Console.WriteLine("Arvasid ära!");
                    break;
                }

            }
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
