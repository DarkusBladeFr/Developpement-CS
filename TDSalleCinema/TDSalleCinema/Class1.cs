using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDSalleCinema
{
    class Class1
    {
        private string _titreFilm;
        private int _nbSiege;
        private double _prixTarif;
        private int _nbVenteNormal;
        private int _nbVenteReduit;
        private static int _nbSalles;
        //Constructeur
        public Class1(string titreDuFilm, int nombreSiege, double prixTarifNormal)
        {
            _titreFilm = titreDuFilm;
            _nbSiege = nombreSiege;
            _prixTarif = prixTarifNormal;
            _nbVenteNormal = 0;
            _nbVenteReduit = 0;
            _nbSalles++;
        }
        //Accesseurs (getter)
        public string getTitreFilm()
        {
            return _titreFilm;
        }
        public int getNombreSiege()
        {
            return _nbSiege;
        }
        public double getTarifNormal()
        {
            return _prixTarif;
        }
        public int getVenteNormal()
        {
            return _nbVenteNormal;
        }
        public int getVenteReduit()
        {
            return _nbVenteReduit;
        }
        public static int nbRooms()
        {
            return _nbSalles;
        }
        //Mutateur (setter)
        public void setPrixTarif(double prixTarifNormal)
        {
            _prixTarif = prixTarifNormal;
        }
        //Exo2
        public int nbPlacesDisponibles()
        {
            int PlacesDisponible;
            PlacesDisponible = _nbSiege - (_nbVenteNormal + _nbVenteReduit);
            return PlacesDisponible;
        }
        public void vendrePlaces(int nbre, Boolean tarifReduit)
        {
            double BuyPrix;
            int nbPlacesDisponible = nbPlacesDisponibles();
            if (nbre > nbPlacesDisponible)
            {
                Console.WriteLine("La vente n'est pas possible");
            }
            else
            {
                if (tarifReduit == true)
                {
                    _nbVenteReduit = nbre;
                    BuyPrix = (_prixTarif * 0.80) * nbre;
                    Console.WriteLine("Le prix à payer est de {0:0.00} euros", BuyPrix);
                }
                else
                {
                    _nbVenteNormal = nbre;
                    BuyPrix = _prixTarif * nbre;
                    Console.WriteLine("Le prix à payer est de {0:0.00} euros", BuyPrix);
                }
            }
        }
        public void remiseAZero()
        {
            _nbVenteNormal = 0;
            _nbVenteReduit = 0;
            Console.WriteLine("Les places ont été réinitialisées");
        }
        public double chiffreAffaires()
        {
            double chiffreAffaire = 0;
            chiffreAffaire = (_nbVenteNormal * _prixTarif) + (_nbVenteReduit *(_prixTarif * 0.80));
            return chiffreAffaire;
        }
        public double tauxRemplissage()
        {
            double placesDisponibles = nbPlacesDisponibles();
            double tauxRemplissage;
            tauxRemplissage = (_nbSiege - placesDisponibles) / _nbSiege * 100;
            return tauxRemplissage;
        }
        //Exo3
        public double compare(Class1 Salle0)
        {
            double CA_Salle1 = chiffreAffaires();
            double CA_Salle2 = Salle0.chiffreAffaires();
            if (CA_Salle1 == CA_Salle2)
            {
                return 0;
            }
            else
            {
                if (CA_Salle1 > CA_Salle2)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }
        //Afficher
        public void affiche()
        {
            Console.WriteLine("Film joué : " + _titreFilm);
            Console.WriteLine("Nombre de places : " + _nbSiege);
            Console.WriteLine("Prix d'une place {0:0.00},", _prixTarif);
            Console.WriteLine(_nbVenteNormal + " places vendues au tarif normal,");
            Console.WriteLine(_nbVenteReduit + " places vendues au tarif réduit.");
        }
    }
}
