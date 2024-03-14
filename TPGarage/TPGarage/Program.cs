using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, annee, marque, anneeVoit3;
            string modele, immatriculation;
            double prixVoit3;
            List<Voiture> monGarage = new List<Voiture>();

            //Q10)
            Console.WriteLine("Entrez l'immatriculation du véhicule :");
            immatriculation = Console.ReadLine();
            Console.WriteLine("Entrez l'année de mise en circulation du véhicule :");
            anneeVoit3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez le code de la marque du véhicule :");
            marque = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez le modèle du véhicule :");
            modele = Console.ReadLine();
            Console.WriteLine("Entrez le prix du véhicule :");
            prixVoit3 = double.Parse(Console.ReadLine());

            Voiture voit1 = new Voiture("123ZER567", 2001, 1, "Saxo", 2345.00);
            Voiture voit2 = new Voiture("765REZ321", 2003, 2, "Twingo", 2600.00);
            Voiture voit3 = new Voiture(immatriculation, anneeVoit3, marque, modele, prixVoit3);
            monGarage.Add(voit1);
            monGarage.Add(voit2);
            monGarage.Add(voit3);

            //Supression
            Boolean trouve = false;
            string cherche, plaqueSupp;
            int compte = -1;
            Console.WriteLine("Quel plaque d'immatriculation voulez-vous supprimer ?");
            plaqueSupp = Console.ReadLine();
            foreach (Voiture voit in monGarage)
            {
                cherche = voit.getNumero();
                if (plaqueSupp == cherche)
                {
                    trouve = true;
                    Console.WriteLine("Cette plaque existe, suppression en cours.");
                    compte = monGarage.IndexOf(voit);
                }
            }
            if (trouve == false)
                Console.WriteLine("Cette plaque n'existe pas.");
            else
                monGarage.RemoveAt(compte);

            for (i = 0; i < monGarage.Count; i++)
            {
                monGarage[i].afficher();
                annee = monGarage[i].getAnnee();
                marque = monGarage[i].getMarque();
                modele = monGarage[i].getModele();
            }
            Console.ReadLine();
        }
    }
}
