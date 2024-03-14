
namespace AP5SLAMS2
{
    partial class FormAccueil
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
            this.Title2 = new System.Windows.Forms.Label();
            this.Title1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextLogin = new System.Windows.Forms.TextBox();
            this.TextMDP = new System.Windows.Forms.TextBox();
            this.ValidButton = new System.Windows.Forms.Button();
            this.ForgetMDP = new System.Windows.Forms.Button();
            this.OtherButton = new System.Windows.Forms.Button();
            this.CreerCompte = new System.Windows.Forms.GroupBox();
            this.CompteExistant = new System.Windows.Forms.GroupBox();
            this.CreerCompte.SuspendLayout();
            this.CompteExistant.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title2
            // 
            this.Title2.AutoSize = true;
            this.Title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title2.ForeColor = System.Drawing.Color.Tomato;
            this.Title2.Location = new System.Drawing.Point(469, 31);
            this.Title2.Name = "Title2";
            this.Title2.Size = new System.Drawing.Size(201, 25);
            this.Title2.TabIndex = 0;
            this.Title2.Text = "Vous avez un compte";
            // 
            // Title1
            // 
            this.Title1.AutoSize = true;
            this.Title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title1.ForeColor = System.Drawing.Color.Tomato;
            this.Title1.Location = new System.Drawing.Point(69, 31);
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(253, 25);
            this.Title1.TabIndex = 1;
            this.Title1.Text = "Vous n\'avez pas de compte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mot de passe";
            // 
            // TextLogin
            // 
            this.TextLogin.Location = new System.Drawing.Point(170, 64);
            this.TextLogin.Name = "TextLogin";
            this.TextLogin.Size = new System.Drawing.Size(158, 22);
            this.TextLogin.TabIndex = 4;
            this.TextLogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TextMDP
            // 
            this.TextMDP.Location = new System.Drawing.Point(170, 119);
            this.TextMDP.Name = "TextMDP";
            this.TextMDP.Size = new System.Drawing.Size(158, 22);
            this.TextMDP.TabIndex = 5;
            this.TextMDP.TextChanged += new System.EventHandler(this.TextMDP_TextChanged);
            // 
            // ValidButton
            // 
            this.ValidButton.Location = new System.Drawing.Point(23, 172);
            this.ValidButton.Name = "ValidButton";
            this.ValidButton.Size = new System.Drawing.Size(75, 23);
            this.ValidButton.TabIndex = 6;
            this.ValidButton.Text = "Valider";
            this.ValidButton.UseVisualStyleBackColor = true;
            // 
            // ForgetMDP
            // 
            this.ForgetMDP.Location = new System.Drawing.Point(163, 172);
            this.ForgetMDP.Name = "ForgetMDP";
            this.ForgetMDP.Size = new System.Drawing.Size(214, 23);
            this.ForgetMDP.TabIndex = 7;
            this.ForgetMDP.Text = "j\'ai oublié mon mot de passe";
            this.ForgetMDP.UseVisualStyleBackColor = true;
            // 
            // OtherButton
            // 
            this.OtherButton.Location = new System.Drawing.Point(69, 64);
            this.OtherButton.Name = "OtherButton";
            this.OtherButton.Size = new System.Drawing.Size(154, 60);
            this.OtherButton.TabIndex = 8;
            this.OtherButton.Text = "S\'inscrire en tant que demandeur";
            this.OtherButton.UseVisualStyleBackColor = true;
            this.OtherButton.Click += new System.EventHandler(this.OtherButton_Click);
            // 
            // CreerCompte
            // 
            this.CreerCompte.Controls.Add(this.OtherButton);
            this.CreerCompte.Location = new System.Drawing.Point(22, 88);
            this.CreerCompte.Name = "CreerCompte";
            this.CreerCompte.Size = new System.Drawing.Size(317, 214);
            this.CreerCompte.TabIndex = 9;
            this.CreerCompte.TabStop = false;
            this.CreerCompte.Text = "CreerCompte";
            // 
            // CompteExistant
            // 
            this.CompteExistant.Controls.Add(this.ForgetMDP);
            this.CompteExistant.Controls.Add(this.TextMDP);
            this.CompteExistant.Controls.Add(this.ValidButton);
            this.CompteExistant.Controls.Add(this.TextLogin);
            this.CompteExistant.Controls.Add(this.label3);
            this.CompteExistant.Controls.Add(this.label4);
            this.CompteExistant.Location = new System.Drawing.Point(364, 88);
            this.CompteExistant.Name = "CompteExistant";
            this.CompteExistant.Size = new System.Drawing.Size(388, 214);
            this.CompteExistant.TabIndex = 10;
            this.CompteExistant.TabStop = false;
            this.CompteExistant.Text = "CompteExistant";
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 502);
            this.Controls.Add(this.CompteExistant);
            this.Controls.Add(this.CreerCompte);
            this.Controls.Add(this.Title1);
            this.Controls.Add(this.Title2);
            this.Name = "FormAccueil";
            this.Text = "FormAccueil";
            this.CreerCompte.ResumeLayout(false);
            this.CompteExistant.ResumeLayout(false);
            this.CompteExistant.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title2;
        private System.Windows.Forms.Label Title1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextLogin;
        private System.Windows.Forms.TextBox TextMDP;
        private System.Windows.Forms.Button ValidButton;
        private System.Windows.Forms.Button ForgetMDP;
        private System.Windows.Forms.Button OtherButton;
        private System.Windows.Forms.GroupBox CreerCompte;
        private System.Windows.Forms.GroupBox CompteExistant;
    }
}

