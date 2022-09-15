using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in ett heltal:");

            bool primtal = true;
            int talSomKontrolleras = int.Parse(Console.ReadLine());
            for (int i = 2; i < talSomKontrolleras; i++)
            {
                if (talSomKontrolleras % i == 0)
                {
                    primtal = false;
                    Console.WriteLine($"Talet {i} är en primtalsfaktor");
                    //textBox.Text += ($"Talet {i} är en primtalsfaktor");
                    //Console.WriteLine("Talet " + i  + " är en primtalsfaktor"); //alternativt sätt att skriva
                }
            }
            if (primtal)
            {
                Console.WriteLine("Talet är ett primtal");
            }
            else
            {
                Console.WriteLine("Talet är inte ett primtal");
            }

            Console.ReadLine();
        }
    }
}
