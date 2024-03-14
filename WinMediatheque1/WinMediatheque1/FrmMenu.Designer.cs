
namespace WinMediatheque1
{
    partial class FrmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDesLivresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesMembresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesEmpruntsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesLivresToolStripMenuItem,
            this.gestionDesMembresToolStripMenuItem,
            this.gestionDesEmpruntsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // gestionDesLivresToolStripMenuItem
            // 
            this.gestionDesLivresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutToolStripMenuItem,
            this.modificationToolStripMenuItem,
            this.consultationToolStripMenuItem,
            this.suppressionToolStripMenuItem});
            this.gestionDesLivresToolStripMenuItem.Name = "gestionDesLivresToolStripMenuItem";
            this.gestionDesLivresToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.gestionDesLivresToolStripMenuItem.Text = "Gestion des Livres";
            // 
            // ajoutToolStripMenuItem
            // 
            this.ajoutToolStripMenuItem.Name = "ajoutToolStripMenuItem";
            this.ajoutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ajoutToolStripMenuItem.Text = "Ajout";
            this.ajoutToolStripMenuItem.Click += new System.EventHandler(this.ajoutToolStripMenuItem_Click);
            // 
            // modificationToolStripMenuItem
            // 
            this.modificationToolStripMenuItem.Name = "modificationToolStripMenuItem";
            this.modificationToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.modificationToolStripMenuItem.Text = "Modification";
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.consultationToolStripMenuItem.Text = "Consultation";
            // 
            // suppressionToolStripMenuItem
            // 
            this.suppressionToolStripMenuItem.Name = "suppressionToolStripMenuItem";
            this.suppressionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.suppressionToolStripMenuItem.Text = "Suppression";
            // 
            // gestionDesMembresToolStripMenuItem
            // 
            this.gestionDesMembresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutToolStripMenuItem1,
            this.modificationToolStripMenuItem1,
            this.consultationToolStripMenuItem1,
            this.suppressionToolStripMenuItem1});
            this.gestionDesMembresToolStripMenuItem.Name = "gestionDesMembresToolStripMenuItem";
            this.gestionDesMembresToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.gestionDesMembresToolStripMenuItem.Text = "Gestion des Membres";
            // 
            // ajoutToolStripMenuItem1
            // 
            this.ajoutToolStripMenuItem1.Name = "ajoutToolStripMenuItem1";
            this.ajoutToolStripMenuItem1.Size = new System.Drawing.Size(177, 26);
            this.ajoutToolStripMenuItem1.Text = "Ajout";
            // 
            // modificationToolStripMenuItem1
            // 
            this.modificationToolStripMenuItem1.Name = "modificationToolStripMenuItem1";
            this.modificationToolStripMenuItem1.Size = new System.Drawing.Size(177, 26);
            this.modificationToolStripMenuItem1.Text = "Modification";
            // 
            // consultationToolStripMenuItem1
            // 
            this.consultationToolStripMenuItem1.Name = "consultationToolStripMenuItem1";
            this.consultationToolStripMenuItem1.Size = new System.Drawing.Size(177, 26);
            this.consultationToolStripMenuItem1.Text = "Consultation";
            // 
            // suppressionToolStripMenuItem1
            // 
            this.suppressionToolStripMenuItem1.Name = "suppressionToolStripMenuItem1";
            this.suppressionToolStripMenuItem1.Size = new System.Drawing.Size(177, 26);
            this.suppressionToolStripMenuItem1.Text = "Suppression";
            // 
            // gestionDesEmpruntsToolStripMenuItem
            // 
            this.gestionDesEmpruntsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutToolStripMenuItem2,
            this.modificationToolStripMenuItem2,
            this.consultationToolStripMenuItem2,
            this.suppressionToolStripMenuItem2});
            this.gestionDesEmpruntsToolStripMenuItem.Name = "gestionDesEmpruntsToolStripMenuItem";
            this.gestionDesEmpruntsToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.gestionDesEmpruntsToolStripMenuItem.Text = "Gestion des Emprunts";
            // 
            // ajoutToolStripMenuItem2
            // 
            this.ajoutToolStripMenuItem2.Name = "ajoutToolStripMenuItem2";
            this.ajoutToolStripMenuItem2.Size = new System.Drawing.Size(177, 26);
            this.ajoutToolStripMenuItem2.Text = "Ajout";
            // 
            // modificationToolStripMenuItem2
            // 
            this.modificationToolStripMenuItem2.Name = "modificationToolStripMenuItem2";
            this.modificationToolStripMenuItem2.Size = new System.Drawing.Size(177, 26);
            this.modificationToolStripMenuItem2.Text = "Modification";
            // 
            // consultationToolStripMenuItem2
            // 
            this.consultationToolStripMenuItem2.Name = "consultationToolStripMenuItem2";
            this.consultationToolStripMenuItem2.Size = new System.Drawing.Size(177, 26);
            this.consultationToolStripMenuItem2.Text = "Consultation";
            // 
            // suppressionToolStripMenuItem2
            // 
            this.suppressionToolStripMenuItem2.Name = "suppressionToolStripMenuItem2";
            this.suppressionToolStripMenuItem2.Size = new System.Drawing.Size(177, 26);
            this.suppressionToolStripMenuItem2.Text = "Suppression";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Mediatheque Flaubert";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesLivresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesMembresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesEmpruntsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem suppressionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajoutToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem suppressionToolStripMenuItem2;
    }
}

