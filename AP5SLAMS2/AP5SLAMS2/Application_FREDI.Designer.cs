
namespace AP5SLAMS2
{
    partial class Application_FREDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NomBox = new System.Windows.Forms.TextBox();
            this.PrenomBox = new System.Windows.Forms.TextBox();
            this.AdrBox = new System.Windows.Forms.TextBox();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.MdpBox = new System.Windows.Forms.TextBox();
            this.RAZ = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ObtLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adresse mail :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Votre login est :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Votre MDP :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Résultat de l\'envoi";
            // 
            // NomBox
            // 
            this.NomBox.Location = new System.Drawing.Point(115, 22);
            this.NomBox.Name = "NomBox";
            this.NomBox.Size = new System.Drawing.Size(141, 22);
            this.NomBox.TabIndex = 6;
            this.NomBox.TextChanged += new System.EventHandler(this.NomBox_TextChanged);
            // 
            // PrenomBox
            // 
            this.PrenomBox.Location = new System.Drawing.Point(115, 72);
            this.PrenomBox.Name = "PrenomBox";
            this.PrenomBox.Size = new System.Drawing.Size(141, 22);
            this.PrenomBox.TabIndex = 7;
            this.PrenomBox.TextChanged += new System.EventHandler(this.PrenomBox_TextChanged);
            // 
            // AdrBox
            // 
            this.AdrBox.Location = new System.Drawing.Point(115, 122);
            this.AdrBox.Name = "AdrBox";
            this.AdrBox.Size = new System.Drawing.Size(175, 22);
            this.AdrBox.TabIndex = 8;
            this.AdrBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(115, 229);
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(175, 22);
            this.LogBox.TabIndex = 9;
            this.LogBox.TextChanged += new System.EventHandler(this.LogBox_TextChanged);
            // 
            // MdpBox
            // 
            this.MdpBox.Location = new System.Drawing.Point(115, 274);
            this.MdpBox.Name = "MdpBox";
            this.MdpBox.Size = new System.Drawing.Size(141, 22);
            this.MdpBox.TabIndex = 10;
            this.MdpBox.TextChanged += new System.EventHandler(this.MdpBox_TextChanged);
            // 
            // RAZ
            // 
            this.RAZ.Location = new System.Drawing.Point(346, 356);
            this.RAZ.Name = "RAZ";
            this.RAZ.Size = new System.Drawing.Size(75, 23);
            this.RAZ.TabIndex = 11;
            this.RAZ.Text = "RAZ";
            this.RAZ.UseVisualStyleBackColor = true;
            this.RAZ.Click += new System.EventHandler(this.RAZ_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Imprimer PDF";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(34, 356);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Poursuivre avec votre inscription";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ObtLog
            // 
            this.ObtLog.Location = new System.Drawing.Point(115, 174);
            this.ObtLog.Name = "ObtLog";
            this.ObtLog.Size = new System.Drawing.Size(141, 28);
            this.ObtLog.TabIndex = 14;
            this.ObtLog.Text = "Obtenir votre Login";
            this.ObtLog.UseVisualStyleBackColor = true;
            this.ObtLog.Click += new System.EventHandler(this.ObtLog_Click);
            // 
            // Application_FREDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 448);
            this.Controls.Add(this.ObtLog);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RAZ);
            this.Controls.Add(this.MdpBox);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.AdrBox);
            this.Controls.Add(this.PrenomBox);
            this.Controls.Add(this.NomBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Application_FREDI";
            this.Text = "Application FREDI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NomBox;
        private System.Windows.Forms.TextBox PrenomBox;
        private System.Windows.Forms.TextBox AdrBox;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.TextBox MdpBox;
        private System.Windows.Forms.Button RAZ;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ObtLog;
    }
}