namespace Emprunts
{
    partial class FormEmprunts
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
            this.components = new System.ComponentModel.Container();
            this.labelNom = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxCapitalEmprunte = new System.Windows.Forms.TextBox();
            this.labelCapitalEmprunte = new System.Windows.Forms.Label();
            this.labelDureeMoisRemboursement = new System.Windows.Forms.Label();
            this.hScrollBarDureeMoisRemboursement = new System.Windows.Forms.HScrollBar();
            this.labelDureeMoisRemoubrsementScroll = new System.Windows.Forms.Label();
            this.labelPeriodiciteRembourcement = new System.Windows.Forms.Label();
            this.listBoxPeriodiciteRemboursement = new System.Windows.Forms.ListBox();
            this.groupBoxTauxInteret = new System.Windows.Forms.GroupBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.labelRemboursement = new System.Windows.Forms.Label();
            this.labelMontantRemboursement = new System.Windows.Forms.Label();
            this.labelNbrMoisRembrousement = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxTauxInteret.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(27, 28);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(126, 25);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxNom.TabIndex = 1;
            // 
            // textBoxCapitalEmprunte
            // 
            this.textBoxCapitalEmprunte.Location = new System.Drawing.Point(126, 62);
            this.textBoxCapitalEmprunte.Name = "textBoxCapitalEmprunte";
            this.textBoxCapitalEmprunte.Size = new System.Drawing.Size(100, 20);
            this.textBoxCapitalEmprunte.TabIndex = 3;
            this.textBoxCapitalEmprunte.TextChanged += new System.EventHandler(this.textBoxCapitalEmprunte_TextChanged);
            // 
            // labelCapitalEmprunte
            // 
            this.labelCapitalEmprunte.AutoSize = true;
            this.labelCapitalEmprunte.Location = new System.Drawing.Point(27, 65);
            this.labelCapitalEmprunte.Name = "labelCapitalEmprunte";
            this.labelCapitalEmprunte.Size = new System.Drawing.Size(87, 13);
            this.labelCapitalEmprunte.TabIndex = 2;
            this.labelCapitalEmprunte.Text = "Capital Emprunté";
            // 
            // labelDureeMoisRemboursement
            // 
            this.labelDureeMoisRemboursement.AutoSize = true;
            this.labelDureeMoisRemboursement.Location = new System.Drawing.Point(27, 106);
            this.labelDureeMoisRemboursement.Name = "labelDureeMoisRemboursement";
            this.labelDureeMoisRemboursement.Size = new System.Drawing.Size(90, 26);
            this.labelDureeMoisRemboursement.TabIndex = 4;
            this.labelDureeMoisRemboursement.Text = "Durée en mois du\r\nremboursement";
            // 
            // hScrollBarDureeMoisRemboursement
            // 
            this.hScrollBarDureeMoisRemboursement.Cursor = System.Windows.Forms.Cursors.Default;
            this.hScrollBarDureeMoisRemboursement.Location = new System.Drawing.Point(211, 106);
            this.hScrollBarDureeMoisRemboursement.Maximum = 200;
            this.hScrollBarDureeMoisRemboursement.Name = "hScrollBarDureeMoisRemboursement";
            this.hScrollBarDureeMoisRemboursement.Size = new System.Drawing.Size(80, 17);
            this.hScrollBarDureeMoisRemboursement.TabIndex = 5;
            this.hScrollBarDureeMoisRemboursement.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarDureeMoisRemboursement_Scroll);
            // 
            // labelDureeMoisRemoubrsementScroll
            // 
            this.labelDureeMoisRemoubrsementScroll.AutoSize = true;
            this.labelDureeMoisRemoubrsementScroll.Location = new System.Drawing.Point(150, 110);
            this.labelDureeMoisRemoubrsementScroll.Name = "labelDureeMoisRemoubrsementScroll";
            this.labelDureeMoisRemoubrsementScroll.Size = new System.Drawing.Size(13, 13);
            this.labelDureeMoisRemoubrsementScroll.TabIndex = 6;
            this.labelDureeMoisRemoubrsementScroll.Text = "1";
            // 
            // labelPeriodiciteRembourcement
            // 
            this.labelPeriodiciteRembourcement.AutoSize = true;
            this.labelPeriodiciteRembourcement.Location = new System.Drawing.Point(27, 156);
            this.labelPeriodiciteRembourcement.Name = "labelPeriodiciteRembourcement";
            this.labelPeriodiciteRembourcement.Size = new System.Drawing.Size(146, 13);
            this.labelPeriodiciteRembourcement.TabIndex = 7;
            this.labelPeriodiciteRembourcement.Text = "Périodicité de remboursement";
            // 
            // listBoxPeriodiciteRemboursement
            // 
            this.listBoxPeriodiciteRemboursement.FormattingEnabled = true;
            this.listBoxPeriodiciteRemboursement.Location = new System.Drawing.Point(30, 175);
            this.listBoxPeriodiciteRemboursement.Name = "listBoxPeriodiciteRemboursement";
            this.listBoxPeriodiciteRemboursement.Size = new System.Drawing.Size(143, 95);
            this.listBoxPeriodiciteRemboursement.TabIndex = 8;
            // 
            // groupBoxTauxInteret
            // 
            this.groupBoxTauxInteret.Controls.Add(this.radioButton9);
            this.groupBoxTauxInteret.Controls.Add(this.radioButton8);
            this.groupBoxTauxInteret.Controls.Add(this.radioButton7);
            this.groupBoxTauxInteret.Location = new System.Drawing.Point(335, 25);
            this.groupBoxTauxInteret.Name = "groupBoxTauxInteret";
            this.groupBoxTauxInteret.Size = new System.Drawing.Size(91, 133);
            this.groupBoxTauxInteret.TabIndex = 9;
            this.groupBoxTauxInteret.TabStop = false;
            this.groupBoxTauxInteret.Text = "Taux d\'intérêt";
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(26, 96);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(42, 17);
            this.radioButton9.TabIndex = 2;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "9 %";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(26, 58);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(42, 17);
            this.radioButton8.TabIndex = 1;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "8 %";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(26, 22);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(42, 17);
            this.radioButton7.TabIndex = 0;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "7 %";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(452, 41);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(95, 23);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(452, 83);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(95, 23);
            this.buttonAnnuler.TabIndex = 11;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // labelRemboursement
            // 
            this.labelRemboursement.AutoSize = true;
            this.labelRemboursement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemboursement.Location = new System.Drawing.Point(382, 186);
            this.labelRemboursement.Name = "labelRemboursement";
            this.labelRemboursement.Size = new System.Drawing.Size(133, 17);
            this.labelRemboursement.TabIndex = 12;
            this.labelRemboursement.Text = "Remboursements";
            // 
            // labelMontantRemboursement
            // 
            this.labelMontantRemboursement.AutoSize = true;
            this.labelMontantRemboursement.ForeColor = System.Drawing.Color.Red;
            this.labelMontantRemboursement.Location = new System.Drawing.Point(429, 224);
            this.labelMontantRemboursement.Name = "labelMontantRemboursement";
            this.labelMontantRemboursement.Size = new System.Drawing.Size(13, 13);
            this.labelMontantRemboursement.TabIndex = 13;
            this.labelMontantRemboursement.Text = "0";
            // 
            // labelNbrMoisRembrousement
            // 
            this.labelNbrMoisRembrousement.AutoSize = true;
            this.labelNbrMoisRembrousement.ForeColor = System.Drawing.Color.Red;
            this.labelNbrMoisRembrousement.Location = new System.Drawing.Point(342, 188);
            this.labelNbrMoisRembrousement.Name = "labelNbrMoisRembrousement";
            this.labelNbrMoisRembrousement.Size = new System.Drawing.Size(13, 13);
            this.labelNbrMoisRembrousement.TabIndex = 14;
            this.labelNbrMoisRembrousement.Text = "0";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormEmprunts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 318);
            this.Controls.Add(this.labelNbrMoisRembrousement);
            this.Controls.Add(this.labelMontantRemboursement);
            this.Controls.Add(this.labelRemboursement);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxTauxInteret);
            this.Controls.Add(this.listBoxPeriodiciteRemboursement);
            this.Controls.Add(this.labelPeriodiciteRembourcement);
            this.Controls.Add(this.labelDureeMoisRemoubrsementScroll);
            this.Controls.Add(this.hScrollBarDureeMoisRemboursement);
            this.Controls.Add(this.labelDureeMoisRemboursement);
            this.Controls.Add(this.textBoxCapitalEmprunte);
            this.Controls.Add(this.labelCapitalEmprunte);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelNom);
            this.Name = "FormEmprunts";
            this.Text = "Emprunts";
            this.Load += new System.EventHandler(this.FormEmprunts_Load);
            this.groupBoxTauxInteret.ResumeLayout(false);
            this.groupBoxTauxInteret.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxCapitalEmprunte;
        private System.Windows.Forms.Label labelCapitalEmprunte;
        private System.Windows.Forms.Label labelDureeMoisRemboursement;
        private System.Windows.Forms.HScrollBar hScrollBarDureeMoisRemboursement;
        private System.Windows.Forms.Label labelDureeMoisRemoubrsementScroll;
        private System.Windows.Forms.Label labelPeriodiciteRembourcement;
        private System.Windows.Forms.ListBox listBoxPeriodiciteRemboursement;
        private System.Windows.Forms.GroupBox groupBoxTauxInteret;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Label labelRemboursement;
        private System.Windows.Forms.Label labelMontantRemboursement;
        private System.Windows.Forms.Label labelNbrMoisRembrousement;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

