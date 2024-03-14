using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace essaiMysql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string vnumero, vmodele;
            int vcodemarque, vannee;
            double vprix;
            string ChaineConnexion =
            "server=localhost;user=root;password=;database=parcvehicule";
            string requete = "Select * from vehicule;";
            CURS cs = new CURS(ChaineConnexion);
            lst_Vehicule.Items.Clear();
            cs.ReqSelect(requete);
            while (!cs.Fin())
            {
                vnumero = cs.champ("numero").ToString();
                vcodemarque = Convert.ToInt32(cs.champ("codemarque"));
                vmodele = cs.champ("modele").ToString();
                vprix = Convert.ToDouble(cs.champ("prix"));
                vannee = Convert.ToInt32(cs.champ("annee"));
                lst_Vehicule.Items.Add(vnumero + " " + vcodemarque + " " + vmodele + " " + vprix + " " + vannee);
                cs.suivant();
            }
            cs.fermer();
        }
    }
}
