namespace Defilement
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
            this.labelRouge = new System.Windows.Forms.Label();
            this.hScrollBarRouge = new System.Windows.Forms.HScrollBar();
            this.numericUpDownRouge = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownVert = new System.Windows.Forms.NumericUpDown();
            this.hScrollBarVert = new System.Windows.Forms.HScrollBar();
            this.labelVert = new System.Windows.Forms.Label();
            this.numericUpDownBleu = new System.Windows.Forms.NumericUpDown();
            this.hScrollBarBleu = new System.Windows.Forms.HScrollBar();
            this.labelBleu = new System.Windows.Forms.Label();
            this.pictureBoxRouge = new System.Windows.Forms.PictureBox();
            this.pictureBoxVert = new System.Windows.Forms.PictureBox();
            this.pictureBoxBleu = new System.Windows.Forms.PictureBox();
            this.pictureBoxResultat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRouge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBleu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRouge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBleu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResultat)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRouge
            // 
            this.labelRouge.AutoSize = true;
            this.labelRouge.Location = new System.Drawing.Point(30, 45);
            this.labelRouge.Name = "labelRouge";
            this.labelRouge.Size = new System.Drawing.Size(39, 13);
            this.labelRouge.TabIndex = 0;
            this.labelRouge.Text = "Rouge";
            // 
            // hScrollBarRouge
            // 
            this.hScrollBarRouge.LargeChange = 1;
            this.hScrollBarRouge.Location = new System.Drawing.Point(82, 45);
            this.hScrollBarRouge.Maximum = 255;
            this.hScrollBarRouge.Name = "hScrollBarRouge";
            this.hScrollBarRouge.Size = new System.Drawing.Size(109, 17);
            this.hScrollBarRouge.TabIndex = 1;
            this.hScrollBarRouge.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_Scroll);
            // 
            // numericUpDownRouge
            // 
            this.numericUpDownRouge.Location = new System.Drawing.Point(207, 45);
            this.numericUpDownRouge.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRouge.Name = "numericUpDownRouge";
            this.numericUpDownRouge.Size = new System.Drawing.Size(67, 20);
            this.numericUpDownRouge.TabIndex = 2;
            this.numericUpDownRouge.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownVert
            // 
            this.numericUpDownVert.Location = new System.Drawing.Point(207, 78);
            this.numericUpDownVert.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownVert.Name = "numericUpDownVert";
            this.numericUpDownVert.Size = new System.Drawing.Size(67, 20);
            this.numericUpDownVert.TabIndex = 5;
            this.numericUpDownVert.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // hScrollBarVert
            // 
            this.hScrollBarVert.LargeChange = 1;
            this.hScrollBarVert.Location = new System.Drawing.Point(82, 78);
            this.hScrollBarVert.Maximum = 255;
            this.hScrollBarVert.Name = "hScrollBarVert";
            this.hScrollBarVert.Size = new System.Drawing.Size(109, 17);
            this.hScrollBarVert.TabIndex = 4;
            this.hScrollBarVert.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_Scroll);
            // 
            // labelVert
            // 
            this.labelVert.AutoSize = true;
            this.labelVert.Location = new System.Drawing.Point(30, 78);
            this.labelVert.Name = "labelVert";
            this.labelVert.Size = new System.Drawing.Size(26, 13);
            this.labelVert.TabIndex = 3;
            this.labelVert.Text = "Vert";
            // 
            // numericUpDownBleu
            // 
            this.numericUpDownBleu.Location = new System.Drawing.Point(207, 113);
            this.numericUpDownBleu.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBleu.Name = "numericUpDownBleu";
            this.numericUpDownBleu.Size = new System.Drawing.Size(67, 20);
            this.numericUpDownBleu.TabIndex = 8;
            this.numericUpDownBleu.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // hScrollBarBleu
            // 
            this.hScrollBarBleu.LargeChange = 1;
            this.hScrollBarBleu.Location = new System.Drawing.Point(82, 113);
            this.hScrollBarBleu.Maximum = 255;
            this.hScrollBarBleu.Name = "hScrollBarBleu";
            this.hScrollBarBleu.Size = new System.Drawing.Size(109, 17);
            this.hScrollBarBleu.TabIndex = 7;
            this.hScrollBarBleu.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_Scroll);
            // 
            // labelBleu
            // 
            this.labelBleu.AutoSize = true;
            this.labelBleu.Location = new System.Drawing.Point(30, 113);
            this.labelBleu.Name = "labelBleu";
            this.labelBleu.Size = new System.Drawing.Size(28, 13);
            this.labelBleu.TabIndex = 6;
            this.labelBleu.Text = "Bleu";
            // 
            // pictureBoxRouge
            // 
            this.pictureBoxRouge.BackColor = System.Drawing.Color.Red;
            this.pictureBoxRouge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxRouge.Location = new System.Drawing.Point(297, 45);
            this.pictureBoxRouge.Name = "pictureBoxRouge";
            this.pictureBoxRouge.Size = new System.Drawing.Size(67, 20);
            this.pictureBoxRouge.TabIndex = 9;
            this.pictureBoxRouge.TabStop = false;
            // 
            // pictureBoxVert
            // 
            this.pictureBoxVert.BackColor = System.Drawing.Color.Green;
            this.pictureBoxVert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxVert.Location = new System.Drawing.Point(297, 78);
            this.pictureBoxVert.Name = "pictureBoxVert";
            this.pictureBoxVert.Size = new System.Drawing.Size(67, 20);
            this.pictureBoxVert.TabIndex = 10;
            this.pictureBoxVert.TabStop = false;
            // 
            // pictureBoxBleu
            // 
            this.pictureBoxBleu.BackColor = System.Drawing.Color.Blue;
            this.pictureBoxBleu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxBleu.Location = new System.Drawing.Point(297, 113);
            this.pictureBoxBleu.Name = "pictureBoxBleu";
            this.pictureBoxBleu.Size = new System.Drawing.Size(67, 20);
            this.pictureBoxBleu.TabIndex = 11;
            this.pictureBoxBleu.TabStop = false;
            // 
            // pictureBoxResultat
            // 
            this.pictureBoxResultat.BackColor = System.Drawing.Color.Black;
            this.pictureBoxResultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxResultat.Location = new System.Drawing.Point(33, 163);
            this.pictureBoxResultat.Name = "pictureBoxResultat";
            this.pictureBoxResultat.Size = new System.Drawing.Size(331, 66);
            this.pictureBoxResultat.TabIndex = 12;
            this.pictureBoxResultat.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 245);
            this.Controls.Add(this.pictureBoxResultat);
            this.Controls.Add(this.pictureBoxBleu);
            this.Controls.Add(this.pictureBoxVert);
            this.Controls.Add(this.pictureBoxRouge);
            this.Controls.Add(this.numericUpDownBleu);
            this.Controls.Add(this.hScrollBarBleu);
            this.Controls.Add(this.labelBleu);
            this.Controls.Add(this.numericUpDownVert);
            this.Controls.Add(this.hScrollBarVert);
            this.Controls.Add(this.labelVert);
            this.Controls.Add(this.numericUpDownRouge);
            this.Controls.Add(this.hScrollBarRouge);
            this.Controls.Add(this.labelRouge);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRouge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBleu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRouge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBleu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResultat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRouge;
        private System.Windows.Forms.HScrollBar hScrollBarRouge;
        private System.Windows.Forms.NumericUpDown numericUpDownRouge;
        private System.Windows.Forms.NumericUpDown numericUpDownVert;
        private System.Windows.Forms.HScrollBar hScrollBarVert;
        private System.Windows.Forms.Label labelVert;
        private System.Windows.Forms.NumericUpDown numericUpDownBleu;
        private System.Windows.Forms.HScrollBar hScrollBarBleu;
        private System.Windows.Forms.Label labelBleu;
        private System.Windows.Forms.PictureBox pictureBoxRouge;
        private System.Windows.Forms.PictureBox pictureBoxVert;
        private System.Windows.Forms.PictureBox pictureBoxBleu;
        private System.Windows.Forms.PictureBox pictureBoxResultat;
    }
}

