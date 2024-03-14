using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP5SLAMS2
{
    public partial class Application_FREDI : Form
    {
        public Application_FREDI()
        {
            InitializeComponent();
        }
        private void NomBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PrenomBox_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void LogBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void MdpBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ObtLog_Click(object sender, EventArgs e)
        {
            string genererMDP;
            bool test_mail;
            if (Outils.IsValidEmail(AdrBox.Text) == false)
            {
                MessageBox.Show("Votre adresse n'a pas été reconnue", "Alerte", MessageBoxButtons.OKCancel);
                test_mail = true;
            }
            else
            {
                if (AdrBox.Text == "" || NomBox.Text == "" || PrenomBox.Text == "" || test_mail ==true)
                {
                    MessageBox.Show("remplissez correctement les cases !!!", "Alerte", MessageBoxButtons.OKCancel);
                }
                else
                {
                    genererMDP = Outils.GeneratePassword(8);
                    MdpBox.Text = genererMDP;
                    LogBox.Text = AdrBox.Text;
                }
            }
        }
        private void RAZ_Click(object sender, EventArgs e)
        {
            PrenomBox.Text = "";
            NomBox.Text = "";
            AdrBox.Text = "";
        }
    }
}
