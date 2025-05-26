using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryRemboursement;

namespace Emprunts
{
    public partial class FormEmprunts : Form
    {
        public FormEmprunts()
        {
            InitializeComponent();
        }

        private void FormEmprunts_Load(object sender, EventArgs e)
        {
            listBoxPeriodiciteRemboursement.Items.Add("Mensuelle");
            listBoxPeriodiciteRemboursement.Items.Add("Bimestrielle");
            listBoxPeriodiciteRemboursement.Items.Add("Trimestrielle");
            listBoxPeriodiciteRemboursement.Items.Add("Semestrielle");
            listBoxPeriodiciteRemboursement.Items.Add("Annuelle");

            textBoxNom.Focus();
            radioButton7.Checked = true;
            hScrollBarDureeMoisRemboursement.Value = 1;
            listBoxPeriodiciteRemboursement.SelectedIndex = 0;
        }

        private void hScrollBarDureeMoisRemboursement_Scroll(object sender, ScrollEventArgs e)
        {
            labelDureeMoisRemoubrsementScroll.Text = hScrollBarDureeMoisRemboursement.Value.ToString();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(textBoxCapitalEmprunte.Text == "")
            {
                MessageBox.Show("Veuillez saisir un montant à emprunter", "Erreur");
            }
            int capitalEmprunte = int.Parse(textBoxCapitalEmprunte.Text);
            int dureeRemboursement = hScrollBarDureeMoisRemboursement.Value;
            int tauxInteret = 0;
            int periodicite = 1;

            if (radioButton7.Checked) tauxInteret = 7;
            if (radioButton8.Checked) tauxInteret = 8;
            if (radioButton9.Checked) tauxInteret = 9;

            if (listBoxPeriodiciteRemboursement.SelectedIndex == 0) periodicite = 1;
            if (listBoxPeriodiciteRemboursement.SelectedIndex == 1) periodicite = 2;
            if (listBoxPeriodiciteRemboursement.SelectedIndex == 2) periodicite = 3;
            if (listBoxPeriodiciteRemboursement.SelectedIndex == 3) periodicite = 6;
            if (listBoxPeriodiciteRemboursement.SelectedIndex == 4) periodicite = 12;


            Remboursement nouveauRemboursement = new Remboursement(capitalEmprunte, tauxInteret, dureeRemboursement, periodicite);

            labelNbrMoisRembrousement.Text = nouveauRemboursement.CalculNombreMoisRemboursement().ToString();
            labelMontantRemboursement.Text = nouveauRemboursement.CalculRemboursement().ToString() + " €";
        }

        private void textBoxCapitalEmprunte_TextChanged(object sender, EventArgs e)
        {
            int capital;
            if (int.TryParse(textBoxCapitalEmprunte.Text, out capital) || capital <= 0)
            {
                this.errorProvider1.SetError(this.textBoxCapitalEmprunte, "Entrez un montant valide");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
