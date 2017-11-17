using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nipid
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

                        static void Main(string[] args) //käivitub alati esimesena 

                        {

                            string name = "Anneli";

                            //parameetrid siin, static voidis PrintGreetings() argumendid.

                            //annan kaasa nuutuja name

                            PrintGreeting(name);



                            Console.WriteLine("Press Any Key to Continue");

                            Console.ReadKey();//jääb ootama kasutaja sisendit, nt üks täht või tühik, readline on mingi tekst ja enter.

                        }

                        //Meetod on jupp koodi, millel on nimi ja mida saab käivitada, hetkel reas 13 kutsutakse seda meetodit. 

                        //Static - Kõik meetodid peavad olema staatilised

                        //Void - tähendab, et meetod ei anna midagi tagasi. Ehk return'i ei ole.

                        //ootab muutujat name

                        static void PrintGreeting(string name) //1. Kui siin on 2 stringi PrintGreeting(string a1, string a2), siis peav üleval olema ka kaks stringi PrintGreeting("Kalle", "Malle") ja vastupidi; võib ka int'e jne olla

                        {

                            Console.WriteLine("Hallo world!");

                            Console.WriteLine($"Hey, {name}!");

                        }



                        static void DoSomething()

                        { }
                    }

                }
            }
        }
    }
}
