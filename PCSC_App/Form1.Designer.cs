namespace PCSC_App
{
    partial class Form1
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
            this.btnTrouverLecteur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tBxLecteur = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTrouverLecteur
            // 
            this.btnTrouverLecteur.AutoSize = true;
            this.btnTrouverLecteur.Location = new System.Drawing.Point(12, 12);
            this.btnTrouverLecteur.Name = "btnTrouverLecteur";
            this.btnTrouverLecteur.Size = new System.Drawing.Size(89, 23);
            this.btnTrouverLecteur.TabIndex = 0;
            this.btnTrouverLecteur.Text = "Trouver lecteur";
            this.btnTrouverLecteur.UseVisualStyleBackColor = true;
            this.btnTrouverLecteur.Click += new System.EventHandler(this.btnTrouverLecteur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lecteur:";
            // 
            // tBxLecteur
            // 
            this.tBxLecteur.Location = new System.Drawing.Point(159, 15);
            this.tBxLecteur.Name = "tBxLecteur";
            this.tBxLecteur.Size = new System.Drawing.Size(161, 20);
            this.tBxLecteur.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 262);
            this.Controls.Add(this.tBxLecteur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTrouverLecteur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrouverLecteur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBxLecteur;
    }
}

