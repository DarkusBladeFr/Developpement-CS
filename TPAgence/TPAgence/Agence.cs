using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPAgence
{
    class Agence
    {
        private List<Biens> _lesBiens;

        public Agence()
        {
            _lesBiens = new List<Biens>();
        }
        public void ajoute(Biens b)
        {
            _lesBiens.Add(b);
        }
        public void afficheTouslesBiens()
        {
            foreach(Biens leBien in _lesBiens)
            {
                leBien.affiche();
                Console.WriteLine();
            }
        }
        public List<Biens> DonneToutesLesMaisons()
        {
            List<Biens> MyHouse = new List<Biens>();
            foreach (Biens leBien in _lesBiens)
            {
                if (leBien.getType() == "M")
                    MyHouse.Add(leBien);
            }
            return MyHouse;
        }
        public List<Biens> DonneTousLesApparts()
        {
            List<Biens> MyAppart = new List<Biens>();
            foreach (Biens leBien in _lesBiens)
            {
                if (leBien.getType() == "A")
                    MyAppart.Add(leBien);
            }
            return MyAppart;
        }
        public bool Estpresent(string numBien)
        {
            bool Test=false;
            foreach (Biens leBien in _lesBiens)
            {
                if (numBien == leBien.getNumBien())
                    Test = true;
                else
                    Test = false;
            }
            return Test;
        }
        public bool SupprimeBien(string numBien)
        {
            int i=-1;
            bool TestSupp = false;
            foreach(Biens leBien in _lesBiens)
            {
                if (numBien == leBien.getNumBien())
                    i = _lesBiens.IndexOf(leBien);
            }
            if(i != -1)
            {
                Console.WriteLine("Ce bien a été supprimé avec succès.");
                _lesBiens.RemoveAt(i);
                TestSupp = true;
            }
            else
                Console.WriteLine("Ce bien n'existe pas.");
            return TestSupp;
        }
    }
}
