using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace WinMediatheque1
{
    public partial class AjoutLivre : Form
    {
        string chaineConnexion;
        public string ChaineConnexion
        {
            get => chaineConnexion; set => chaineConnexion
= value;
        }
        public AjoutLivre()
        {
            InitializeComponent();
        }

        private void AjoutLivre_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dresult = MessageBox.Show("Etes vous sur ? ", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dresult == DialogResult.OK)
            {
                string etatLivre = "D";
                CURS cs = new CURS(ChaineConnexion);
                string requete = "insert into Livre values ('";
                requete += textBox1.Text;
                requete += "','";
                requete += textBox2.Text;
                requete += "','";
                requete += textBox3.Text;
                requete += "',";
                requete += Convert.ToInt32(textBox4.Text);
                requete += ",'";
                requete += etatLivre;
                requete += "');";
                cs.ReqAdmin(requete);
                cs.fermer();
            }
            else
            {
                RAZ();
            }
        }

        private void TitreAjoutLivre_Click(object sender, EventArgs e)
        {
            
        }
    }
}
