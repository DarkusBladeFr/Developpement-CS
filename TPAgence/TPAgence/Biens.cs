using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPAgence
{
    class Biens
    {
        private string _numBien;
        private string _adrBien;
        private int _surfaceHab;
        private int _nbPieces;
        private string _type;
        private string _statut;
        private double _prixBien;
        //Q2
        public Biens(string numBien, string adrBien, int surfaceHab, int nbPieces, string type, string statut, double prixBien)
        {
            _numBien = numBien;
            _adrBien = adrBien;
            _surfaceHab = surfaceHab;
            _nbPieces = nbPieces;
            _type = type;
            _statut = statut;
            _prixBien = prixBien;
        }
        //Q3
        public string NumBien {set => _numBien = value; }
        public string AdrBien { get => _adrBien; set => _adrBien = value; }
        public int SurfaceHab { get => _surfaceHab; set => _surfaceHab = value; }
        public int NbPieces { get => _nbPieces; set => _nbPieces = value; }
        public string Type {set => _type = value; }
        public string getNumBien()
        {
            return _numBien;
        }
        public string getType()
        {
            return _type;
        }
        public string Status { get => _statut; set => _statut = value; }
        public double PrixBien { get => _prixBien;}
        //Q7
        public void setPrixBien(double NewPrixBien)
        {
            _prixBien = NewPrixBien;
        }
        //Q4
        public void affiche()
        {
            Console.WriteLine("Numéro de bien : " + _numBien);
            Console.WriteLine("Adresse : " + _adrBien);
            Console.WriteLine("Surface : " + _surfaceHab + "m²");
            Console.WriteLine("Nombre de pièces : " + _nbPieces);
            Console.WriteLine("Type : " + _type);
            Console.WriteLine("Statut : " + _statut);
            Console.WriteLine("Prix : " + _prixBien + " euros");
        }
    }
}