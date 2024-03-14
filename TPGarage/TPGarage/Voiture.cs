using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGarage
{
    class Voiture
    {
        private string _numero;
        private int _annee;
        private int _marque;
        private string _modele;
        private double _prix;
        //le constructeur de la classe
        public Voiture(string numero, int annee, int marque, string modele, double prix)
        {
            _numero = numero;
            _annee = annee;
            _marque = marque;
            _modele = modele;
            _prix = prix;
        }

        //Q9)
        public int getAnnee()
        {
            return _annee;
        }
        public int getMarque()
        {
            return _marque;
        }
        public string getModele()
        {
            return _modele;
        }
        // accesseur sur le numéro
        public string getNumero()
        {
            return _numero;
        }
        // accesseur sur le prix
        public double getPrix()
        {
            return _prix;
        }
        // modificateur du prix public void
        public void setPrix(double nouveauprix)
        {
            _prix = nouveauprix;
        }
        // methode calcul ancienneté voiture
        public int calculAge()
        {
            return (DateTime.Today.Year - _annee);
        }
        // méthode d'affichage public
        public void afficher()
        {
            Console.WriteLine(" l'immatriculation est " + _numero);
            Console.WriteLine("le modele est " + _modele);
            Console.WriteLine("le prix est " + _prix);
            Console.WriteLine("Il est sorti en " + _annee + ", soit " + (DateTime.Today.Year - _annee) + " année(s).");
            Console.WriteLine("Et appartient à la marque " + _marque);
            Console.WriteLine("");//pour créer un espace entre chaque véhicules pour plus de visibilié.
        }
    }
}
