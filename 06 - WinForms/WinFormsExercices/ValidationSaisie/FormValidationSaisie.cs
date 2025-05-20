using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            MessageBox.Show("Nom : " + textBoxNom.Text + "\n" +
                            "Date : " + textBoxDate.Text + "\n" +
                            "Montant : " + textBoxMontant.Text + "\n" +
                            "Code Postal : " + textBoxCodePostal.Text,
                            "Validation effectuée");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Fin de l'application", "FIN", MessageBoxButtons.YesNo);

            // Si Non, annuler la fermeture
        }
    }
}
