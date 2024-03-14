using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPAgence
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q6
            Biens TestBien1 = new Biens("76A","Adresse prévu",20,4,"A","AL",899.99);
            Biens TestBien2 = new Biens("76B", "Adresse prévu 2", 30, 5, "M", "L", 999.99);
            Biens TestBien3 = new Biens("77A", "Adresse prévu 3", 35, 6, "M", "L", 1399.99);
            Biens TestBien4 = new Biens("77B", "Adresse prévu 4", 15, 3, "A", "V", 499.99);
            //Q9
            Agence TestAgence = new Agence();
            List<Biens> MyHouse = new List<Biens>();
            List<Biens> MyAppart= new List<Biens>();
            /*Q8
            Console.WriteLine("Numéro de bien : " + TestBien1);
            Console.WriteLine("Adresse : " + TestBien1);
            Console.WriteLine("Surface : " + TestBien1 + "m²");
            Console.WriteLine("Nombre de pièces : " + TestBien1);
            Console.WriteLine("Type : " + TestBien1);
            Console.WriteLine("Statut : " + TestBien1);
            Console.WriteLine("Prix : " + TestBien1 + " euros");*/
            TestAgence.ajoute(TestBien1);
            TestAgence.ajoute(TestBien2);
            TestAgence.ajoute(TestBien3);
            TestAgence.ajoute(TestBien4);
            TestAgence.afficheTouslesBiens();
            Console.WriteLine();
            Console.WriteLine("Toutes les Maisons");
            MyHouse = TestAgence.DonneToutesLesMaisons();
            foreach (Biens House in MyHouse)
            {
                House.affiche();
                Console.WriteLine();
            }
            Console.WriteLine("Tous les Apparts");
            MyAppart = TestAgence.DonneTousLesApparts();
            foreach (Biens Appart in MyAppart)
            {
                Appart.affiche();
                Console.WriteLine();
            }
            //EstPresent
            Console.WriteLine("Saisissez le bien à chercher");
            string NumChercher = "";
            NumChercher = Console.ReadLine();
            if (TestAgence.Estpresent(NumChercher) == true)
            {
                Console.WriteLine("Ce numéro existe");
            }
            else
            {
                Console.WriteLine("Ce numéro n'existe pas");
            }
            //EstSupprimer
            Console.WriteLine("Saisissez le bien à supprimer");
            string NumSupp = "";
            NumSupp = Console.ReadLine();
            if (TestAgence.SupprimeBien(NumSupp) == true)
            {
                Console.WriteLine("Ce bien à bien été supprimé");
            }
            else
            {
                Console.WriteLine("Ce bien n'a pas été supprimé");
            }
            Console.WriteLine();
            Console.WriteLine("Vérifications en cours...");
            if (TestAgence.Estpresent(NumSupp) == true)
            {
                Console.WriteLine("Le bien n'appartient plus à la liste");
            }
            /*
            Console.WriteLine("Test 1:");
            TestBien1.affiche();
            Console.WriteLine();
            Console.WriteLine("Test 2:");
            TestBien2.affiche();
            Console.WriteLine();
            Console.WriteLine("Test 3:");
            TestBien3.affiche();
            Console.WriteLine();
            Console.WriteLine("Test 4:");
            TestBien4.affiche();*/
            Console.ReadLine();
        }
    }
}
