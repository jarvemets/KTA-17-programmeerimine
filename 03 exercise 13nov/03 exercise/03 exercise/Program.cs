using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = 1;
            while (n < 6)
                //käivitub niikaua kuni see on tõene
            {
                Console.WriteLine("Current value of n i {0}", n);
                n++;
                //n++ on sisult sama mis n + 1 ehk lisab sinna otsa
                if (n == 5)
                {
                    n = 1;
                    // ära  muuda tingimust, mis while'i kontrollib, võib jääda lõputu loop
                    // do while'i pole vaja kasutada

                for (int i = 0; i < 10; i++)
                        // for töötab nii, et kontrollib töökäske järjest. kui lõpp kirja panemata, siis jääbki tööle 
                        // i += 2 - siis suurendab kahekaupa
                    {
                        if (i == 6)
                        {
                            break;
                            //kui paned siia continue, siis ta jätab selle 1 valesti ja jätkab, kus pooleli
                        }

                        Console.WriteLine($"Hello: {i}");
                    }
            
                }
            }
        }
    }
}
