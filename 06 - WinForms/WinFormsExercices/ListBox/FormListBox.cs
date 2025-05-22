using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class FormListBox : Form
    {
        public FormListBox()
        {
            InitializeComponent();
        }

        private void buttonAjoutListe_Click(object sender, EventArgs e)
        {
            if(textBoxNouvelElement.Text != "")
            {
                if(!listBoxLstList.Items.Contains(textBoxNouvelElement.Text))
                {
                    listBoxLstList.Items.Add(textBoxNouvelElement.Text);
                    textBoxItemsCount.Text = listBoxLstList.Items.Count.ToString();
                    textBoxNouvelElement.Clear();
                    textBoxNouvelElement.Focus();
                }
                else
                {
                    MessageBox.Show("Cette valeur est déjà dans la liste.", "Erreur");
                }
            }
            else
            {
                MessageBox.Show("Veuillez saisir une valeur", "Erreur");
                textBoxNouvelElement.Focus();
            }
        }

        private void listBoxLstList_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSelectedIndex.Text = listBoxLstList.SelectedIndex.ToString();
            textBoxText.Text = listBoxLstList.Text.ToString();
        }

        private void buttonVider_Click(object sender, EventArgs e)
        {
            listBoxLstList.Items.Clear();
            textBoxItemsCount.Text = "";
            textBoxSelectedIndex.Text = "";
            textBoxText.Text = "";
        }

        private void buttonSelectionner_Click(object sender, EventArgs e)
        {
            int indexDemande;
            if (int.TryParse(textBoxIndexElement.Text, out indexDemande))
            {
                if(indexDemande >= 0 && indexDemande < listBoxLstList.Items.Count)
                {
                    listBoxLstList.SelectedIndex = indexDemande;
                }
                else
                {
                    MessageBox.Show("L'index demandé n'existe pas", "Erreur");
                    textBoxIndexElement.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Le format de l'Index est incorrect", "Erreur");
                textBoxIndexElement.Text = "";
            }


        }
    }
}
