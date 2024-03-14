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
    public partial class FrmMenu : Form
    {
        string chaineConnexion;
        public string ChaineConnexion
        {
            get { return chaineConnexion; }
            set { chaineConnexion = value; }
        }
        public FrmMenu()
        {
            ChaineConnexion = "server = 127.0.0.1; user id = admincdi;password= secret;database = cdi";
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ajoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutLivre f = new AjoutLivre();
            f.ChaineConnexion = this.chaineConnexion;
            f.Show();
        }
    }
}
