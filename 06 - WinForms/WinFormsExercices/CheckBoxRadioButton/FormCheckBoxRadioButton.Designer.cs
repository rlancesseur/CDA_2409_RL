namespace CheckBoxRadioButton
{
    partial class FormCheckBoxRadioButton
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
            this.labelTaperTexte = new System.Windows.Forms.Label();
            this.textBoxTexteUtilisateur = new System.Windows.Forms.TextBox();
            this.groupBoxCheckBox = new System.Windows.Forms.GroupBox();
            this.checkBoxCouleurFond = new System.Windows.Forms.CheckBox();
            this.checkBoxCouleurCaracteres = new System.Windows.Forms.CheckBox();
            this.checkBoxCasse = new System.Windows.Forms.CheckBox();
            this.labelTexteAffichee = new System.Windows.Forms.Label();
            this.groupBoxFond = new System.Windows.Forms.GroupBox();
            this.radioButtonFondRouge = new System.Windows.Forms.RadioButton();
            this.radioButtonFondVert = new System.Windows.Forms.RadioButton();
            this.radioButtonFondBleu = new System.Windows.Forms.RadioButton();
            this.groupBoxCaracteres = new System.Windows.Forms.GroupBox();
            this.radioButtonCaraNoir = new System.Windows.Forms.RadioButton();
            this.radioButtonCaraBlanc = new System.Windows.Forms.RadioButton();
            this.radioButtonCaraRouge = new System.Windows.Forms.RadioButton();
            this.groupBoxCasse = new System.Windows.Forms.GroupBox();
            this.radioButtonMinuscules = new System.Windows.Forms.RadioButton();
            this.radioButtonMajuscules = new System.Windows.Forms.RadioButton();
            this.groupBoxCheckBox.SuspendLayout();
            this.groupBoxFond.SuspendLayout();
            this.groupBoxCaracteres.SuspendLayout();
            this.groupBoxCasse.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTaperTexte
            // 
            this.labelTaperTexte.AutoSize = true;
            this.labelTaperTexte.Location = new System.Drawing.Point(12, 9);
            this.labelTaperTexte.Name = "labelTaperTexte";
            this.labelTaperTexte.Size = new System.Drawing.Size(90, 13);
            this.labelTaperTexte.TabIndex = 0;
            this.labelTaperTexte.Text = "Tapez votre texte";
            // 
            // textBoxTexteUtilisateur
            // 
            this.textBoxTexteUtilisateur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTexteUtilisateur.Location = new System.Drawing.Point(15, 34);
            this.textBoxTexteUtilisateur.Name = "textBoxTexteUtilisateur";
            this.textBoxTexteUtilisateur.Size = new System.Drawing.Size(248, 20);
            this.textBoxTexteUtilisateur.TabIndex = 1;
            this.textBoxTexteUtilisateur.TextChanged += new System.EventHandler(this.textBoxTexteUtilisateur_TextChanged);
            // 
            // groupBoxCheckBox
            // 
            this.groupBoxCheckBox.Controls.Add(this.checkBoxCasse);
            this.groupBoxCheckBox.Controls.Add(this.checkBoxCouleurCaracteres);
            this.groupBoxCheckBox.Controls.Add(this.checkBoxCouleurFond);
            this.groupBoxCheckBox.Enabled = false;
            this.groupBoxCheckBox.Location = new System.Drawing.Point(281, 12);
            this.groupBoxCheckBox.Name = "groupBoxCheckBox";
            this.groupBoxCheckBox.Size = new System.Drawing.Size(200, 95);
            this.groupBoxCheckBox.TabIndex = 2;
            this.groupBoxCheckBox.TabStop = false;
            this.groupBoxCheckBox.Text = "Choix";
            // 
            // checkBoxCouleurFond
            // 
            this.checkBoxCouleurFond.AutoSize = true;
            this.checkBoxCouleurFond.Location = new System.Drawing.Point(7, 20);
            this.checkBoxCouleurFond.Name = "checkBoxCouleurFond";
            this.checkBoxCouleurFond.Size = new System.Drawing.Size(101, 17);
            this.checkBoxCouleurFond.TabIndex = 0;
            this.checkBoxCouleurFond.Text = "Couleur du fond";
            this.checkBoxCouleurFond.UseVisualStyleBackColor = true;
            this.checkBoxCouleurFond.CheckedChanged += new System.EventHandler(this.checkBoxCouleurFond_CheckedChanged);
            // 
            // checkBoxCouleurCaracteres
            // 
            this.checkBoxCouleurCaracteres.AutoSize = true;
            this.checkBoxCouleurCaracteres.Location = new System.Drawing.Point(7, 44);
            this.checkBoxCouleurCaracteres.Name = "checkBoxCouleurCaracteres";
            this.checkBoxCouleurCaracteres.Size = new System.Drawing.Size(135, 17);
            this.checkBoxCouleurCaracteres.TabIndex = 1;
            this.checkBoxCouleurCaracteres.Text = "Couleur des caractères";
            this.checkBoxCouleurCaracteres.UseVisualStyleBackColor = true;
            this.checkBoxCouleurCaracteres.CheckedChanged += new System.EventHandler(this.checkBoxCouleurCaracteres_CheckedChanged);
            // 
            // checkBoxCasse
            // 
            this.checkBoxCasse.AutoSize = true;
            this.checkBoxCasse.Location = new System.Drawing.Point(7, 68);
            this.checkBoxCasse.Name = "checkBoxCasse";
            this.checkBoxCasse.Size = new System.Drawing.Size(55, 17);
            this.checkBoxCasse.TabIndex = 2;
            this.checkBoxCasse.Text = "Casse";
            this.checkBoxCasse.UseVisualStyleBackColor = true;
            this.checkBoxCasse.CheckedChanged += new System.EventHandler(this.checkBoxCasse_CheckedChanged);
            // 
            // labelTexteAffichee
            // 
            this.labelTexteAffichee.AutoSize = true;
            this.labelTexteAffichee.Location = new System.Drawing.Point(12, 94);
            this.labelTexteAffichee.Name = "labelTexteAffichee";
            this.labelTexteAffichee.Size = new System.Drawing.Size(0, 13);
            this.labelTexteAffichee.TabIndex = 3;
            // 
            // groupBoxFond
            // 
            this.groupBoxFond.Controls.Add(this.radioButtonFondBleu);
            this.groupBoxFond.Controls.Add(this.radioButtonFondVert);
            this.groupBoxFond.Controls.Add(this.radioButtonFondRouge);
            this.groupBoxFond.Location = new System.Drawing.Point(15, 178);
            this.groupBoxFond.Name = "groupBoxFond";
            this.groupBoxFond.Size = new System.Drawing.Size(77, 97);
            this.groupBoxFond.TabIndex = 4;
            this.groupBoxFond.TabStop = false;
            this.groupBoxFond.Text = "Fond";
            this.groupBoxFond.Visible = false;
            // 
            // radioButtonFondRouge
            // 
            this.radioButtonFondRouge.AutoSize = true;
            this.radioButtonFondRouge.Location = new System.Drawing.Point(6, 19);
            this.radioButtonFondRouge.Name = "radioButtonFondRouge";
            this.radioButtonFondRouge.Size = new System.Drawing.Size(57, 17);
            this.radioButtonFondRouge.TabIndex = 0;
            this.radioButtonFondRouge.TabStop = true;
            this.radioButtonFondRouge.Text = "Rouge";
            this.radioButtonFondRouge.UseVisualStyleBackColor = true;
            this.radioButtonFondRouge.CheckedChanged += new System.EventHandler(this.radioButtonFondChecked);
            // 
            // radioButtonFondVert
            // 
            this.radioButtonFondVert.AutoSize = true;
            this.radioButtonFondVert.Location = new System.Drawing.Point(6, 42);
            this.radioButtonFondVert.Name = "radioButtonFondVert";
            this.radioButtonFondVert.Size = new System.Drawing.Size(44, 17);
            this.radioButtonFondVert.TabIndex = 1;
            this.radioButtonFondVert.TabStop = true;
            this.radioButtonFondVert.Text = "Vert";
            this.radioButtonFondVert.UseVisualStyleBackColor = true;
            this.radioButtonFondVert.CheckedChanged += new System.EventHandler(this.radioButtonFondChecked);
            // 
            // radioButtonFondBleu
            // 
            this.radioButtonFondBleu.AutoSize = true;
            this.radioButtonFondBleu.Location = new System.Drawing.Point(6, 65);
            this.radioButtonFondBleu.Name = "radioButtonFondBleu";
            this.radioButtonFondBleu.Size = new System.Drawing.Size(46, 17);
            this.radioButtonFondBleu.TabIndex = 2;
            this.radioButtonFondBleu.TabStop = true;
            this.radioButtonFondBleu.Text = "Bleu";
            this.radioButtonFondBleu.UseVisualStyleBackColor = true;
            this.radioButtonFondBleu.CheckedChanged += new System.EventHandler(this.radioButtonFondChecked);
            // 
            // groupBoxCaracteres
            // 
            this.groupBoxCaracteres.Controls.Add(this.radioButtonCaraNoir);
            this.groupBoxCaracteres.Controls.Add(this.radioButtonCaraBlanc);
            this.groupBoxCaracteres.Controls.Add(this.radioButtonCaraRouge);
            this.groupBoxCaracteres.Location = new System.Drawing.Point(98, 178);
            this.groupBoxCaracteres.Name = "groupBoxCaracteres";
            this.groupBoxCaracteres.Size = new System.Drawing.Size(77, 97);
            this.groupBoxCaracteres.TabIndex = 5;
            this.groupBoxCaracteres.TabStop = false;
            this.groupBoxCaracteres.Text = "Caractères";
            this.groupBoxCaracteres.Visible = false;
            // 
            // radioButtonCaraNoir
            // 
            this.radioButtonCaraNoir.AutoSize = true;
            this.radioButtonCaraNoir.Location = new System.Drawing.Point(6, 65);
            this.radioButtonCaraNoir.Name = "radioButtonCaraNoir";
            this.radioButtonCaraNoir.Size = new System.Drawing.Size(44, 17);
            this.radioButtonCaraNoir.TabIndex = 2;
            this.radioButtonCaraNoir.TabStop = true;
            this.radioButtonCaraNoir.Text = "Noir";
            this.radioButtonCaraNoir.UseVisualStyleBackColor = true;
            this.radioButtonCaraNoir.CheckedChanged += new System.EventHandler(this.radioButtonCaraChecked);
            // 
            // radioButtonCaraBlanc
            // 
            this.radioButtonCaraBlanc.AutoSize = true;
            this.radioButtonCaraBlanc.Location = new System.Drawing.Point(6, 42);
            this.radioButtonCaraBlanc.Name = "radioButtonCaraBlanc";
            this.radioButtonCaraBlanc.Size = new System.Drawing.Size(52, 17);
            this.radioButtonCaraBlanc.TabIndex = 1;
            this.radioButtonCaraBlanc.TabStop = true;
            this.radioButtonCaraBlanc.Text = "Blanc";
            this.radioButtonCaraBlanc.UseVisualStyleBackColor = true;
            this.radioButtonCaraBlanc.CheckedChanged += new System.EventHandler(this.radioButtonCaraChecked);
            // 
            // radioButtonCaraRouge
            // 
            this.radioButtonCaraRouge.AutoSize = true;
            this.radioButtonCaraRouge.Location = new System.Drawing.Point(6, 19);
            this.radioButtonCaraRouge.Name = "radioButtonCaraRouge";
            this.radioButtonCaraRouge.Size = new System.Drawing.Size(57, 17);
            this.radioButtonCaraRouge.TabIndex = 0;
            this.radioButtonCaraRouge.TabStop = true;
            this.radioButtonCaraRouge.Text = "Rouge";
            this.radioButtonCaraRouge.UseVisualStyleBackColor = true;
            this.radioButtonCaraRouge.CheckedChanged += new System.EventHandler(this.radioButtonCaraChecked);
            // 
            // groupBoxCasse
            // 
            this.groupBoxCasse.Controls.Add(this.radioButtonMajuscules);
            this.groupBoxCasse.Controls.Add(this.radioButtonMinuscules);
            this.groupBoxCasse.Location = new System.Drawing.Point(181, 212);
            this.groupBoxCasse.Name = "groupBoxCasse";
            this.groupBoxCasse.Size = new System.Drawing.Size(114, 63);
            this.groupBoxCasse.TabIndex = 6;
            this.groupBoxCasse.TabStop = false;
            this.groupBoxCasse.Text = "Casse";
            this.groupBoxCasse.Visible = false;
            // 
            // radioButtonMinuscules
            // 
            this.radioButtonMinuscules.AutoSize = true;
            this.radioButtonMinuscules.Location = new System.Drawing.Point(6, 19);
            this.radioButtonMinuscules.Name = "radioButtonMinuscules";
            this.radioButtonMinuscules.Size = new System.Drawing.Size(78, 17);
            this.radioButtonMinuscules.TabIndex = 0;
            this.radioButtonMinuscules.TabStop = true;
            this.radioButtonMinuscules.Text = "Minuscules";
            this.radioButtonMinuscules.UseVisualStyleBackColor = true;
            this.radioButtonMinuscules.CheckedChanged += new System.EventHandler(this.radioButtonCasseChecked);
            // 
            // radioButtonMajuscules
            // 
            this.radioButtonMajuscules.AutoSize = true;
            this.radioButtonMajuscules.Location = new System.Drawing.Point(6, 42);
            this.radioButtonMajuscules.Name = "radioButtonMajuscules";
            this.radioButtonMajuscules.Size = new System.Drawing.Size(78, 17);
            this.radioButtonMajuscules.TabIndex = 1;
            this.radioButtonMajuscules.TabStop = true;
            this.radioButtonMajuscules.Text = "Majuscules";
            this.radioButtonMajuscules.UseVisualStyleBackColor = true;
            this.radioButtonMajuscules.CheckedChanged += new System.EventHandler(this.radioButtonCasseChecked);
            // 
            // FormCheckBoxRadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 283);
            this.Controls.Add(this.groupBoxCasse);
            this.Controls.Add(this.groupBoxCaracteres);
            this.Controls.Add(this.groupBoxFond);
            this.Controls.Add(this.labelTexteAffichee);
            this.Controls.Add(this.groupBoxCheckBox);
            this.Controls.Add(this.textBoxTexteUtilisateur);
            this.Controls.Add(this.labelTaperTexte);
            this.Name = "FormCheckBoxRadioButton";
            this.Text = "CheckBox et RadioButton";
            this.groupBoxCheckBox.ResumeLayout(false);
            this.groupBoxCheckBox.PerformLayout();
            this.groupBoxFond.ResumeLayout(false);
            this.groupBoxFond.PerformLayout();
            this.groupBoxCaracteres.ResumeLayout(false);
            this.groupBoxCaracteres.PerformLayout();
            this.groupBoxCasse.ResumeLayout(false);
            this.groupBoxCasse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTaperTexte;
        private System.Windows.Forms.TextBox textBoxTexteUtilisateur;
        private System.Windows.Forms.GroupBox groupBoxCheckBox;
        private System.Windows.Forms.CheckBox checkBoxCouleurFond;
        private System.Windows.Forms.CheckBox checkBoxCasse;
        private System.Windows.Forms.CheckBox checkBoxCouleurCaracteres;
        private System.Windows.Forms.Label labelTexteAffichee;
        private System.Windows.Forms.GroupBox groupBoxFond;
        private System.Windows.Forms.RadioButton radioButtonFondBleu;
        private System.Windows.Forms.RadioButton radioButtonFondVert;
        private System.Windows.Forms.RadioButton radioButtonFondRouge;
        private System.Windows.Forms.GroupBox groupBoxCaracteres;
        private System.Windows.Forms.RadioButton radioButtonCaraNoir;
        private System.Windows.Forms.RadioButton radioButtonCaraBlanc;
        private System.Windows.Forms.RadioButton radioButtonCaraRouge;
        private System.Windows.Forms.GroupBox groupBoxCasse;
        private System.Windows.Forms.RadioButton radioButtonMajuscules;
        private System.Windows.Forms.RadioButton radioButtonMinuscules;
    }
}

