﻿using System;
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
    public partial class FormAccueil : Form
    {
        public FormAccueil()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextMDP_TextChanged(object sender, EventArgs e)
        {

        }

        private void OtherButton_Click(object sender, EventArgs e)
        {
            Application_FREDI form = new Application_FREDI();
            form.Show();
        }
    }
}
