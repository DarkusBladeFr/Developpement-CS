using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCalculette
{
    public partial class FrmCalculette : Form
    {
        public FrmCalculette()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Calculer_Click(object sender, EventArgs e)
        {
            double nb1, nb2;
            double resultat = 0; // initialisation obligatoire pour la compilation
            string operateur;
            nb1 = Convert.ToDouble(txb_Nombre1.Text);
            nb2 = Convert.ToDouble(txb_Nombre2.Text);
            operateur = cbx_Operateur.Text;
            switch (operateur)
            {
                case "":
                    lbl_Message.Text = "Il faut choisir un opérateur !!!";
                    tbx_Resultat.Text = "ERR!!!";
                    break;
                case "+":
                    if(txb_Nombre2.Text=="")
                    {
                        tbx_Resultat.Text = "ERR!!!";
                        lbl_Message.Text = "Il faut saisir un nombre pour Nombre2 !!!";
                    }
                    else
                        resultat = nb1 + nb2;
                    break;
                case "-":
                    if (txb_Nombre2.Text == "")
                    {
                        tbx_Resultat.Text = "ERR!!!";
                        lbl_Message.Text = "Il faut saisir un nombre pour Nombre2 !!!";
                    }
                    else
                        resultat = nb1 - nb2;
                    break;
                case "*":
                    if (txb_Nombre2.Text == "")
                    {
                        tbx_Resultat.Text = "ERR!!!";
                        lbl_Message.Text = "Il faut saisir un nombre pour Nombre2 !!!";
                    }
                    else
                        resultat = nb1 * nb2;
                    break;
                case "/":
                    {
                        if (txb_Nombre2.Text == "")
                        {
                            tbx_Resultat.Text = "ERR!!!";
                            lbl_Message.Text = "Il faut saisir un nombre pour Nombre2 !!!";
                        }
                        else
                        if (txb_Nombre2.Text == "0")
                        {
                            lbl_Message.Text = "Un nombre ne peut être divisé par 0, simple règle Mathématique !!!";
                            tbx_Resultat.Text = "ERR!!!";
                        }
                        else
                            resultat = nb1 / nb2;
                    }
                        break;
            }
            tbx_Resultat.Text = resultat.ToString();
        }
    }
}
