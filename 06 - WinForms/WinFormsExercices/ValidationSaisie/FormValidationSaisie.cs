using ClassLibraryWinFormsExercices;
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
            if (!ControleRegex.VerifierDate(textBoxDate.Text) ||
                !VerificationValidite.DatePosterieur(textBoxDate.Text))
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Date invalide.", "Erreur");
                textBoxDate.Focus();
                return;
            }
            if (!ControleRegex.VerifierMontant(textBoxMontant.Text))
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Montant invalide.", "Erreur");
                textBoxMontant.Focus();
                return;
            }
            if (!ControleRegex.VerifierCodePostal(textBoxCodePostal.Text))
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Code Postal invalide.", "Erreur");
                textBoxCodePostal.Focus();
                return;
            }

            MessageBox.Show("Nom : " + textBoxNom.Text + "\n" +
                            "Date : " + textBoxDate.Text + "\n" +
                            "Montant : " + textBoxMontant.Text + "\n" +
                            "Code Postal : " + textBoxCodePostal.Text,
                            "Validation effectuée");
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
                (ControleRegex.VerifierDate(textBoxDate.Text) && VerificationValidite.DatePosterieur(textBoxDate.Text)) &&
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
            if (!ControleRegex.VerifierDate(textBoxDate.Text) ||
                !VerificationValidite.DatePosterieur(textBoxDate.Text))
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
