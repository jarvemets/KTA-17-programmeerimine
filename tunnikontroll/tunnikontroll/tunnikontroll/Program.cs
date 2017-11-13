using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tunnikontroll
{
    class Program
    {
        static void Main(string[] args)
        {
            //allahindluse programm tavaklient ja püsiklient

            Console.WriteLine("See on allahindluse arvutamise programm. Sisesta oma summa: ");
            Console.WriteLine("> ");
            string input = Console.ReadLine();
            int summa = int.Parse(input);

            Console.WriteLine($"Summa ");

            Console.WriteLine($"Allahindlus: {percent} % ");
        }
    }
}
