using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HConduite
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1;
            while(i<=10000)
            {
                Console.WriteLine("Lorsque je m'arrête, je suis en deuxième, lorsque je redémarre, je dois être en première.");
                Console.WriteLine("Nous en sommes à " + i + " fois, il nous reste donc " + (10000-i));
                i = i + 1;
            }
            Console.WriteLine("C'est bon, sa fait 10000 fois.");
            Console.ReadLine();
        }
    }
}
