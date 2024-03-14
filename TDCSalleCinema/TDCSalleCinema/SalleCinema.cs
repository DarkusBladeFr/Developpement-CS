using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDCSalleCinema
{
    class SalleCinema
    {
        private string _titreFilm;
        private int _nbSiege;
        private double _prixTarif;
        private int _nbVenteNormal;
        private int _nbVenteReduit;
        //Constructeur
        public SalleCinema(string titreDuFilm, int nombreSiege, double prixTarifNormal)
        {
            _titreFilm = titreDuFilm;
            _nbSiege = nombreSiege;
            _prixTarif = prixTarifNormal;
            _nbVenteNormal = 0;
            _nbVenteReduit = 0;
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
        //Mutateur (setter)
        public void setPrixTarif(double prixTarifNormal)
        {
            _prixTarif = prixTarifNormal;
        }
        //Afficher
        public void affiche(string titreDuFilm, int nombreSiege, double prixTarifNormal, int nombreVenteNormal, int nombreVenteReduit)
        {
            Console.WriteLine("Film joué : " + titreDuFilm);
            Console.WriteLine("Nombre de places : " + nombreSiege);
            Console.WriteLine("Prix d'une place {0:0.00},", prixTarifNormal);
            Console.WriteLine(nombreVenteNormal + " places vendues au tarif normal,");
            Console.WriteLine(nombreVenteReduit + " places vendues au tarif réduit.");
        }
    }
}
