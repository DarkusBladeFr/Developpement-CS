using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    class Program
    {
        public static string EN_MAJUSCULE(string mot)
        {
            string Maj;
            Maj = mot.ToUpper(); //ToUpper permet d'écrire le string en majuscule.
            return Maj;
        }
        static void Main(string[] args)
        {
            string Mot, MotMaj;
            Console.WriteLine("Choisissez un mot à écrire en majuscule :");
            Mot = Console.ReadLine();
            MotMaj = EN_MAJUSCULE(Mot);
            Console.WriteLine("Voici le mot ci-dessous :");
            Console.WriteLine(MotMaj);
            Console.ReadLine();
        }
    }
}
