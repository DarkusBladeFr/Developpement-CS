
namespace maWinList
{
    partial class FrmListe
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
            this.Ibx_Liste = new System.Windows.Forms.ListBox();
            this.tbx_Saisie = new System.Windows.Forms.TextBox();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ibx_Liste
            // 
            this.Ibx_Liste.FormattingEnabled = true;
            this.Ibx_Liste.ItemHeight = 16;
            this.Ibx_Liste.Location = new System.Drawing.Point(24, 23);
            this.Ibx_Liste.Name = "Ibx_Liste";
            this.Ibx_Liste.Size = new System.Drawing.Size(265, 180);
            this.Ibx_Liste.TabIndex = 0;
            // 
            // tbx_Saisie
            // 
            this.tbx_Saisie.Location = new System.Drawing.Point(24, 226);
            this.tbx_Saisie.Name = "tbx_Saisie";
            this.tbx_Saisie.Size = new System.Drawing.Size(265, 22);
            this.tbx_Saisie.TabIndex = 1;
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Location = new System.Drawing.Point(24, 274);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(133, 23);
            this.btn_Ajouter.TabIndex = 2;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Location = new System.Drawing.Point(163, 274);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(125, 23);
            this.btn_Supprimer.TabIndex = 3;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // FrmListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.tbx_Saisie);
            this.Controls.Add(this.Ibx_Liste);
            this.Name = "FrmListe";
            this.Text = "Ma Super Liste";
            this.Load += new System.EventHandler(this.FrmListe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Ibx_Liste;
        private System.Windows.Forms.TextBox tbx_Saisie;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Button btn_Supprimer;
    }
}

