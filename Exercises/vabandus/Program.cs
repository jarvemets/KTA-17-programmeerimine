using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vabandus
{
    class Program
    {
        static void Main(string[] args)
        {
            // prindi: vabanduste genereerimise programm
            // prindi: sisesta komadega eraldatud vabandused
            // < ja saa kastuaja sisend
            //masiiv = input.Split(',')
            //int random = new.Random().Next (0, massiiv.Lenght)?
            //prindi: Tänane vabandus on: {masiiv[random]}

            Console.WriteLine("Sisesta komadega eraldatud vabandused: ");
            Console.WriteLine();
            Console.Write("> ");
            string input = Console.ReadLine();
            string[] masiiv = input.Split(',');
            int random = new Random().Next(0, masiiv.Length);

            Console.WriteLine();

            Console.WriteLine($"Tänane vabandus on: { masiiv[random]}");

            Console.ReadLine();
        }
    }
}
