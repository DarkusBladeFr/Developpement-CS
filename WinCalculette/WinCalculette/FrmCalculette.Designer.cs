
namespace WinCalculette
{
    partial class FrmCalculette
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbx_Operateur = new System.Windows.Forms.ComboBox();
            this.txb_Nombre2 = new System.Windows.Forms.TextBox();
            this.txb_Nombre1 = new System.Windows.Forms.TextBox();
            this.btn_Calculer = new System.Windows.Forms.Button();
            this.tbx_Resultat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbx_Operateur
            // 
            this.cbx_Operateur.FormattingEnabled = true;
            this.cbx_Operateur.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbx_Operateur.Location = new System.Drawing.Point(153, 164);
            this.cbx_Operateur.Name = "cbx_Operateur";
            this.cbx_Operateur.Size = new System.Drawing.Size(94, 24);
            this.cbx_Operateur.TabIndex = 0;
            this.cbx_Operateur.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txb_Nombre2
            // 
            this.txb_Nombre2.Location = new System.Drawing.Point(126, 212);
            this.txb_Nombre2.Name = "txb_Nombre2";
            this.txb_Nombre2.Size = new System.Drawing.Size(121, 22);
            this.txb_Nombre2.TabIndex = 1;
            // 
            // txb_Nombre1
            // 
            this.txb_Nombre1.Location = new System.Drawing.Point(126, 114);
            this.txb_Nombre1.Name = "txb_Nombre1";
            this.txb_Nombre1.Size = new System.Drawing.Size(121, 22);
            this.txb_Nombre1.TabIndex = 2;
            // 
            // btn_Calculer
            // 
            this.btn_Calculer.Location = new System.Drawing.Point(305, 164);
            this.btn_Calculer.Name = "btn_Calculer";
            this.btn_Calculer.Size = new System.Drawing.Size(88, 23);
            this.btn_Calculer.TabIndex = 3;
            this.btn_Calculer.Text = "Calculer";
            this.btn_Calculer.UseVisualStyleBackColor = true;
            this.btn_Calculer.Click += new System.EventHandler(this.btn_Calculer_Click);
            // 
            // tbx_Resultat
            // 
            this.tbx_Resultat.Location = new System.Drawing.Point(460, 164);
            this.tbx_Resultat.Name = "tbx_Resultat";
            this.tbx_Resultat.Size = new System.Drawing.Size(126, 22);
            this.tbx_Resultat.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Opérateur";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(460, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Résultat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(251, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(268, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ma Petite Calculatrice";
            // 
            // lbl_Message
            // 
            this.lbl_Message.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Message.Location = new System.Drawing.Point(22, 254);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(757, 187);
            this.lbl_Message.TabIndex = 10;
            // 
            // FrmCalculette
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Message);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_Resultat);
            this.Controls.Add(this.btn_Calculer);
            this.Controls.Add(this.txb_Nombre1);
            this.Controls.Add(this.txb_Nombre2);
            this.Controls.Add(this.cbx_Operateur);
            this.Name = "FrmCalculette";
            this.Text = "WinCalculette";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_Operateur;
        private System.Windows.Forms.TextBox txb_Nombre2;
        private System.Windows.Forms.TextBox txb_Nombre1;
        private System.Windows.Forms.Button btn_Calculer;
        private System.Windows.Forms.TextBox tbx_Resultat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Message;
    }
}

