using ClassLibraryWinFormsExercices;
using ClassLibTransaction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidationSaisie
{
    public partial class FormValidationSaisie : Form
    {
        public FormValidationSaisie()
        {
            InitializeComponent();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (!ControleRegex.VerifierNom(textBoxNom.Text))
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Nom invalide.", "Erreur");
                textBoxNom.Focus();
                return;
            }
            string nomUtilisateur = textBoxNom.Text;

            if (!VerificationValidite.VerifierFormatDate(textBoxDate.Text))
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Date invalide.", "Erreur");
                textBoxDate.Focus();
                return;
            }
            DateTime dateUtilisateur = DateTime.Parse(textBoxDate.Text);

            if (!ControleRegex.VerifierMontant(textBoxMontant.Text))
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Montant invalide.", "Erreur");
                textBoxMontant.Focus();
                return;
            }
            decimal montantUtilisateur = decimal.Parse(textBoxMontant.Text);

            if (!ControleRegex.VerifierCodePostal(textBoxCodePostal.Text))
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Code Postal invalide.", "Erreur");
                textBoxCodePostal.Focus();
                return;
            }
            int codePostalUtilisateur = int.Parse(textBoxCodePostal.Text);

            Transaction nouvelleTransaction = new Transaction(nomUtilisateur, dateUtilisateur,
                montantUtilisateur, codePostalUtilisateur);

            MessageBox.Show(nouvelleTransaction.ToString(), "Validation effectuée");
        }

        private void buttonEffacer_Click(object sender, EventArgs e)
        {
            textBoxNom.Text = "";
            textBoxDate.Text = "";
            textBoxMontant.Text = "";
            textBoxCodePostal.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Fin de l'application",
                                                "FIN",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Annule la fermeture
            }
        }

        private void VerifierChamps()
        {
            if(ControleRegex.VerifierNom(textBoxNom.Text) &&
                (ControleRegex.VerifierDate(textBoxDate.Text)) &&
                (ControleRegex.VerifierMontant(textBoxMontant.Text)) &&
                ControleRegex.VerifierCodePostal(textBoxCodePostal.Text))
            {
                buttonValider.Enabled = true;
            }
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            if (!ControleRegex.VerifierNom(textBoxNom.Text))
            {
                this.errorProvider1.SetError(this.textBoxNom, "Format du nom incorrect");
            }
            else
            {
                errorProvider1.Clear();
            }
            VerifierChamps();
        }

        private void textBoxDate_TextChanged(object sender, EventArgs e)
        {
            if (!VerificationValidite.VerifierFormatDate(textBoxDate.Text))
            {
                this.errorProvider1.SetError(this.textBoxDate, "Format de la date incorrect");
            }
            else
            {
                errorProvider1.Clear();
            }
            VerifierChamps();
        }

        private void textBoxMontant_TextChanged(object sender, EventArgs e)
        {
            if (!ControleRegex.VerifierMontant(textBoxMontant.Text))
            {
                this.errorProvider1.SetError(this.textBoxMontant, "Format du montant incorrect");
            }
            else
            {
                errorProvider1.Clear();
            }
            VerifierChamps();
        }

        private void textBoxCodePostal_TextChanged(object sender, EventArgs e)
        {
            if (!ControleRegex.VerifierCodePostal(textBoxCodePostal.Text))
            {
                this.errorProvider1.SetError(this.textBoxCodePostal, "Format du Code Postal incorrect");
            }
            else
            {
                errorProvider1.Clear();
            }
            VerifierChamps();
        }
    }
}
