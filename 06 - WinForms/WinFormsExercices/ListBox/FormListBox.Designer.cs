namespace ListBox
{
    partial class FormListBox
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
            this.labelNouvelElement = new System.Windows.Forms.Label();
            this.textBoxNouvelElement = new System.Windows.Forms.TextBox();
            this.buttonAjoutListe = new System.Windows.Forms.Button();
            this.labelLstListe = new System.Windows.Forms.Label();
            this.listBoxLstList = new System.Windows.Forms.ListBox();
            this.labelIndexElement = new System.Windows.Forms.Label();
            this.textBoxIndexElement = new System.Windows.Forms.TextBox();
            this.buttonSelectionner = new System.Windows.Forms.Button();
            this.buttonVider = new System.Windows.Forms.Button();
            this.labelProprietes = new System.Windows.Forms.Label();
            this.labelItemsCount = new System.Windows.Forms.Label();
            this.textBoxItemsCount = new System.Windows.Forms.TextBox();
            this.labelSelectedIndex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNouvelElement
            // 
            this.labelNouvelElement.AutoSize = true;
            this.labelNouvelElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNouvelElement.Location = new System.Drawing.Point(12, 9);
            this.labelNouvelElement.Name = "labelNouvelElement";
            this.labelNouvelElement.Size = new System.Drawing.Size(96, 13);
            this.labelNouvelElement.TabIndex = 0;
            this.labelNouvelElement.Text = "Nouvel Elément";
            // 
            // textBoxNouvelElement
            // 
            this.textBoxNouvelElement.Location = new System.Drawing.Point(15, 34);
            this.textBoxNouvelElement.Name = "textBoxNouvelElement";
            this.textBoxNouvelElement.Size = new System.Drawing.Size(127, 20);
            this.textBoxNouvelElement.TabIndex = 1;
            // 
            // buttonAjoutListe
            // 
            this.buttonAjoutListe.Location = new System.Drawing.Point(15, 62);
            this.buttonAjoutListe.Name = "buttonAjoutListe";
            this.buttonAjoutListe.Size = new System.Drawing.Size(127, 23);
            this.buttonAjoutListe.TabIndex = 2;
            this.buttonAjoutListe.Text = "Ajout Liste";
            this.buttonAjoutListe.UseVisualStyleBackColor = true;
            // 
            // labelLstListe
            // 
            this.labelLstListe.AutoSize = true;
            this.labelLstListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLstListe.Location = new System.Drawing.Point(9, 164);
            this.labelLstListe.Name = "labelLstListe";
            this.labelLstListe.Size = new System.Drawing.Size(51, 13);
            this.labelLstListe.TabIndex = 3;
            this.labelLstListe.Text = "LstListe";
            // 
            // listBoxLstList
            // 
            this.listBoxLstList.FormattingEnabled = true;
            this.listBoxLstList.Location = new System.Drawing.Point(12, 190);
            this.listBoxLstList.Name = "listBoxLstList";
            this.listBoxLstList.Size = new System.Drawing.Size(127, 108);
            this.listBoxLstList.TabIndex = 4;
            // 
            // labelIndexElement
            // 
            this.labelIndexElement.AutoSize = true;
            this.labelIndexElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndexElement.Location = new System.Drawing.Point(246, 9);
            this.labelIndexElement.Name = "labelIndexElement";
            this.labelIndexElement.Size = new System.Drawing.Size(87, 13);
            this.labelIndexElement.TabIndex = 5;
            this.labelIndexElement.Text = "Index Elément";
            // 
            // textBoxIndexElement
            // 
            this.textBoxIndexElement.Location = new System.Drawing.Point(249, 34);
            this.textBoxIndexElement.Name = "textBoxIndexElement";
            this.textBoxIndexElement.Size = new System.Drawing.Size(39, 20);
            this.textBoxIndexElement.TabIndex = 6;
            // 
            // buttonSelectionner
            // 
            this.buttonSelectionner.Location = new System.Drawing.Point(294, 32);
            this.buttonSelectionner.Name = "buttonSelectionner";
            this.buttonSelectionner.Size = new System.Drawing.Size(106, 23);
            this.buttonSelectionner.TabIndex = 7;
            this.buttonSelectionner.Text = "Sélectionner";
            this.buttonSelectionner.UseVisualStyleBackColor = true;
            // 
            // buttonVider
            // 
            this.buttonVider.Location = new System.Drawing.Point(294, 62);
            this.buttonVider.Name = "buttonVider";
            this.buttonVider.Size = new System.Drawing.Size(106, 23);
            this.buttonVider.TabIndex = 8;
            this.buttonVider.Text = "Vider la Liste";
            this.buttonVider.UseVisualStyleBackColor = true;
            // 
            // labelProprietes
            // 
            this.labelProprietes.AutoSize = true;
            this.labelProprietes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProprietes.Location = new System.Drawing.Point(246, 164);
            this.labelProprietes.Name = "labelProprietes";
            this.labelProprietes.Size = new System.Drawing.Size(64, 13);
            this.labelProprietes.TabIndex = 9;
            this.labelProprietes.Text = "Propriétés";
            // 
            // labelItemsCount
            // 
            this.labelItemsCount.AutoSize = true;
            this.labelItemsCount.Location = new System.Drawing.Point(246, 190);
            this.labelItemsCount.Name = "labelItemsCount";
            this.labelItemsCount.Size = new System.Drawing.Size(63, 13);
            this.labelItemsCount.TabIndex = 10;
            this.labelItemsCount.Text = "Items.Count";
            // 
            // textBoxItemsCount
            // 
            this.textBoxItemsCount.Location = new System.Drawing.Point(337, 187);
            this.textBoxItemsCount.Name = "textBoxItemsCount";
            this.textBoxItemsCount.Size = new System.Drawing.Size(38, 20);
            this.textBoxItemsCount.TabIndex = 11;
            // 
            // labelSelectedIndex
            // 
            this.labelSelectedIndex.AutoSize = true;
            this.labelSelectedIndex.Location = new System.Drawing.Point(246, 222);
            this.labelSelectedIndex.Name = "labelSelectedIndex";
            this.labelSelectedIndex.Size = new System.Drawing.Size(75, 13);
            this.labelSelectedIndex.TabIndex = 12;
            this.labelSelectedIndex.Text = "SelectedIndex";
            // 
            // FormListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 310);
            this.Controls.Add(this.labelSelectedIndex);
            this.Controls.Add(this.textBoxItemsCount);
            this.Controls.Add(this.labelItemsCount);
            this.Controls.Add(this.labelProprietes);
            this.Controls.Add(this.buttonVider);
            this.Controls.Add(this.buttonSelectionner);
            this.Controls.Add(this.textBoxIndexElement);
            this.Controls.Add(this.labelIndexElement);
            this.Controls.Add(this.listBoxLstList);
            this.Controls.Add(this.labelLstListe);
            this.Controls.Add(this.buttonAjoutListe);
            this.Controls.Add(this.textBoxNouvelElement);
            this.Controls.Add(this.labelNouvelElement);
            this.Name = "FormListBox";
            this.Text = "Les listes et leurs propriétés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNouvelElement;
        private System.Windows.Forms.TextBox textBoxNouvelElement;
        private System.Windows.Forms.Button buttonAjoutListe;
        private System.Windows.Forms.Label labelLstListe;
        private System.Windows.Forms.ListBox listBoxLstList;
        private System.Windows.Forms.Label labelIndexElement;
        private System.Windows.Forms.TextBox textBoxIndexElement;
        private System.Windows.Forms.Button buttonSelectionner;
        private System.Windows.Forms.Button buttonVider;
        private System.Windows.Forms.Label labelProprietes;
        private System.Windows.Forms.Label labelItemsCount;
        private System.Windows.Forms.TextBox textBoxItemsCount;
        private System.Windows.Forms.Label labelSelectedIndex;
    }
}

