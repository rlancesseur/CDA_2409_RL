namespace ComboBox
{
    partial class FormComboBox
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
            this.labelSource = new System.Windows.Forms.Label();
            this.comboBoxSource = new System.Windows.Forms.ComboBox();
            this.labelCible = new System.Windows.Forms.Label();
            this.listBoxCible = new System.Windows.Forms.ListBox();
            this.buttonOneToCible = new System.Windows.Forms.Button();
            this.buttonAllToCible = new System.Windows.Forms.Button();
            this.buttonOneToSource = new System.Windows.Forms.Button();
            this.buttonAllToSource = new System.Windows.Forms.Button();
            this.buttonToUp = new System.Windows.Forms.Button();
            this.buttonToDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Location = new System.Drawing.Point(64, 11);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(41, 13);
            this.labelSource.TabIndex = 0;
            this.labelSource.Text = "Source";
            // 
            // comboBoxSource
            // 
            this.comboBoxSource.FormattingEnabled = true;
            this.comboBoxSource.Location = new System.Drawing.Point(12, 35);
            this.comboBoxSource.Name = "comboBoxSource";
            this.comboBoxSource.Size = new System.Drawing.Size(134, 21);
            this.comboBoxSource.TabIndex = 1;
            this.comboBoxSource.SelectedIndexChanged += new System.EventHandler(this.comboBoxSource_SelectedIndexChanged);
            // 
            // labelCible
            // 
            this.labelCible.AutoSize = true;
            this.labelCible.Location = new System.Drawing.Point(260, 11);
            this.labelCible.Name = "labelCible";
            this.labelCible.Size = new System.Drawing.Size(30, 13);
            this.labelCible.TabIndex = 2;
            this.labelCible.Text = "Cible";
            // 
            // listBoxCible
            // 
            this.listBoxCible.FormattingEnabled = true;
            this.listBoxCible.Location = new System.Drawing.Point(217, 35);
            this.listBoxCible.Name = "listBoxCible";
            this.listBoxCible.Size = new System.Drawing.Size(120, 147);
            this.listBoxCible.TabIndex = 3;
            this.listBoxCible.SelectedIndexChanged += new System.EventHandler(this.listBoxCible_SelectedIndexChanged);
            // 
            // buttonOneToCible
            // 
            this.buttonOneToCible.Enabled = false;
            this.buttonOneToCible.Location = new System.Drawing.Point(158, 33);
            this.buttonOneToCible.Name = "buttonOneToCible";
            this.buttonOneToCible.Size = new System.Drawing.Size(43, 23);
            this.buttonOneToCible.TabIndex = 4;
            this.buttonOneToCible.Text = ">";
            this.buttonOneToCible.UseVisualStyleBackColor = true;
            this.buttonOneToCible.Click += new System.EventHandler(this.buttonOneToCible_Click);
            // 
            // buttonAllToCible
            // 
            this.buttonAllToCible.Location = new System.Drawing.Point(158, 62);
            this.buttonAllToCible.Name = "buttonAllToCible";
            this.buttonAllToCible.Size = new System.Drawing.Size(43, 23);
            this.buttonAllToCible.TabIndex = 5;
            this.buttonAllToCible.Text = ">>";
            this.buttonAllToCible.UseVisualStyleBackColor = true;
            this.buttonAllToCible.Click += new System.EventHandler(this.buttonAllToCible_Click);
            // 
            // buttonOneToSource
            // 
            this.buttonOneToSource.Enabled = false;
            this.buttonOneToSource.Location = new System.Drawing.Point(157, 130);
            this.buttonOneToSource.Name = "buttonOneToSource";
            this.buttonOneToSource.Size = new System.Drawing.Size(43, 23);
            this.buttonOneToSource.TabIndex = 6;
            this.buttonOneToSource.Text = "<";
            this.buttonOneToSource.UseVisualStyleBackColor = false;
            this.buttonOneToSource.Click += new System.EventHandler(this.buttonOneToSource_Click);
            // 
            // buttonAllToSource
            // 
            this.buttonAllToSource.Location = new System.Drawing.Point(157, 159);
            this.buttonAllToSource.Name = "buttonAllToSource";
            this.buttonAllToSource.Size = new System.Drawing.Size(43, 23);
            this.buttonAllToSource.TabIndex = 7;
            this.buttonAllToSource.Text = "<<";
            this.buttonAllToSource.UseVisualStyleBackColor = true;
            this.buttonAllToSource.Click += new System.EventHandler(this.buttonAllToSource_Click);
            // 
            // buttonToUp
            // 
            this.buttonToUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToUp.Location = new System.Drawing.Point(244, 193);
            this.buttonToUp.Name = "buttonToUp";
            this.buttonToUp.Size = new System.Drawing.Size(28, 28);
            this.buttonToUp.TabIndex = 8;
            this.buttonToUp.Text = "↑";
            this.buttonToUp.UseVisualStyleBackColor = true;
            this.buttonToUp.Click += new System.EventHandler(this.buttonToUp_Click);
            // 
            // buttonToDown
            // 
            this.buttonToDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToDown.Location = new System.Drawing.Point(278, 193);
            this.buttonToDown.Name = "buttonToDown";
            this.buttonToDown.Size = new System.Drawing.Size(28, 28);
            this.buttonToDown.TabIndex = 9;
            this.buttonToDown.Text = "↓";
            this.buttonToDown.UseVisualStyleBackColor = true;
            this.buttonToDown.Click += new System.EventHandler(this.buttonToDown_Click);
            // 
            // FormComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 232);
            this.Controls.Add(this.buttonToDown);
            this.Controls.Add(this.buttonToUp);
            this.Controls.Add(this.buttonAllToSource);
            this.Controls.Add(this.buttonOneToSource);
            this.Controls.Add(this.buttonAllToCible);
            this.Controls.Add(this.buttonOneToCible);
            this.Controls.Add(this.listBoxCible);
            this.Controls.Add(this.labelCible);
            this.Controls.Add(this.comboBoxSource);
            this.Controls.Add(this.labelSource);
            this.Name = "FormComboBox";
            this.Text = "Les listes";
            this.Load += new System.EventHandler(this.FormComboBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.ComboBox comboBoxSource;
        private System.Windows.Forms.Label labelCible;
        private System.Windows.Forms.ListBox listBoxCible;
        private System.Windows.Forms.Button buttonOneToCible;
        private System.Windows.Forms.Button buttonAllToCible;
        private System.Windows.Forms.Button buttonOneToSource;
        private System.Windows.Forms.Button buttonAllToSource;
        private System.Windows.Forms.Button buttonToUp;
        private System.Windows.Forms.Button buttonToDown;
    }
}

