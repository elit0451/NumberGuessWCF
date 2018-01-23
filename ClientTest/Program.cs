using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }

        private void Run()
        {
            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Guess a number between 1 and 10");
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(service.GuessNumber(number));
                Console.WriteLine();
            }
            Console.ReadKey();

            
        }
    }
}
