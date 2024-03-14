using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDSalleCinema
{
    class Program
    {
        static void Main(string[] args)
            {
            Class1 Salle1 = new Class1("Sacré Graal", 60, 7.50);
            Class1 Salle2 = new Class1("Uncharted", 41, 15.35);
            Salle1.affiche();
            Salle2.affiche();
            Console.WriteLine("====================");
            Salle1.nbPlacesDisponibles();
            Salle2.nbPlacesDisponibles();
            Console.WriteLine("====================");
            Salle1.vendrePlaces(8, true);
            Salle2.vendrePlaces(11, true);
            Console.WriteLine("====================");
            Salle1.nbPlacesDisponibles();
            Salle2.nbPlacesDisponibles();
            Console.WriteLine("====================");
            Salle1.vendrePlaces(16, false);
            Salle2.vendrePlaces(9, true);
            Console.WriteLine("====================");
            Salle1.affiche();
            Salle2.affiche();
            Console.WriteLine("====================");
            Console.WriteLine("Le taux de remplissage de la salle est de : " + Salle1.tauxRemplissage() + "%");
            Console.WriteLine("Le chiffre d'affaires de la salle est de : " + Salle1.chiffreAffaires() + " euros.");
            Console.WriteLine("Le taux de remplissage de la salle est de : " + Salle2.tauxRemplissage() + " euros.");
            Console.WriteLine("Le chiffre d'affaires de la salle est de : " + Salle2.chiffreAffaires() + " euros.");
            Console.WriteLine("====================");
            Console.WriteLine(Salle1.compare(Salle1));
            Console.WriteLine(Salle1.compare(Salle2));
            Console.WriteLine(Salle2.compare(Salle1));
            Console.WriteLine(Salle2.compare(Salle2));
            Console.WriteLine("====================");
            Salle1.remiseAZero();
            Salle2.remiseAZero();
            Console.WriteLine("====================");
            Salle1.affiche();
            Salle2.affiche();
            Console.WriteLine("====================");
            Console.WriteLine("Le nombre de salle créée est de : " + Class1.nbRooms());
            Console.ReadLine();
            }
        }
    }
