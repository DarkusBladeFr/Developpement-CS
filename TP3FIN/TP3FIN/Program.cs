using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3FIN
{
    class Program
    {
     public static void DonneMoyenne(int notea, int noteb,out double M)
        {
          M = (notea + noteb) / 2;
        }
        static void Main(string[] args)
        {
            int notea, noteb;
            Console.WriteLine("Saisissez la première note");
            notea = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Saissisez la deuxième note");
            noteb = Int32.Parse(Console.ReadLine());

            double M;
            DonneMoyenne(notea, noteb, out M);

            Console.WriteLine("La moyenne est de {0:####.##}/20.", M);
            Console.ReadLine();
        }
    }
}
