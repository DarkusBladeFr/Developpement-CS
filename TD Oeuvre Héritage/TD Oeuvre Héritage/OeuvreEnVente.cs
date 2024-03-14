using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_Oeuvre_Héritage
{
    class OeuvreEnVente:Oeuvre
    {
        private char _etat;
        private double _prixOeuvre;
        public OeuvreEnVente(int unNumero, string unTitre, double unPrix)
        :base(unNumero, unTitre)
        {
            _prixOeuvre = unPrix;
        }
        public char getEtat()
        {
            return _etat;
        }
        public double getPrix()
        {
            return _prixOeuvre;
        }
        public void setLibre()
        {
            _etat = 'L';
        }
        public void setReserve()
        {
            _etat = 'R';
        }
        public void afficheOeuvre()
        {
            base.affiche();
            if (_etat == 'L')
                Console.WriteLine("L'oeuvre est libre");
            else
                Console.WriteLine("L'oeuvre est réservé");
            Console.WriteLine("Le prix de l'oeuvre est de " + _prixOeuvre + " euros");
        }
    }
}
