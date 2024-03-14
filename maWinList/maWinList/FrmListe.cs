using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maWinList
{
    public partial class FrmListe : Form
    {
        public FrmListe()
        {
            InitializeComponent();
        }

        private void FrmListe_Load(object sender, EventArgs e)
        {

        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            if (tbx_Saisie.Text == "")
            {
                MessageBox.Show("Vous devez écrire dans la barre de sélection avant d'ajouter", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                // Ajouter le contenu du textbox à la liste
                Ibx_Liste.Items.Add(tbx_Saisie.Text);
                // Effacer le contenu du textbox
                tbx_Saisie.Text = "";
                // tb_Saisie.Clear() --> aurait la même fonction
                // Remettre le focus (le curseur) sur le texbox
                tbx_Saisie.Focus();
            }
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            if (Ibx_Liste.SelectedIndex == -1) // Si aucun item sélectionné
            {
                // Message d'avertissement – attention instruction sur une seule ligne
                    MessageBox.Show("Vous devez sélectionner un élément dans la liste", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
}
            else
            {
                // Suppression possible et effectuée
                Ibx_Liste.Items.RemoveAt(Ibx_Liste.SelectedIndex);
            }
        }
    }
}
