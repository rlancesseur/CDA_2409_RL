using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class FormComboBox : Form
    {
        public FormComboBox()
        {
            InitializeComponent();
        }

        private void FormComboBox_Load(object sender, EventArgs e)
        {
            comboBoxSource.Items.Add("France");
            comboBoxSource.Items.Add("Belgique");
            comboBoxSource.Items.Add("Allemagne");
            comboBoxSource.Items.Add("Japon");
            comboBoxSource.Items.Add("Portugal");
            comboBoxSource.Items.Add("Grece");
        }

        private void buttonOneToCible_Click(object sender, EventArgs e)
        {
            if(comboBoxSource.SelectedItem != null)
            {
                listBoxCible.Items.Add(comboBoxSource.SelectedItem);
                comboBoxSource.Items.Remove(comboBoxSource.SelectedItem);
                comboBoxSource.Text = "";
            }
            else if(comboBoxSource.Text != "")
            {
                listBoxCible.Items.Add(comboBoxSource.Text);
                comboBoxSource.Text = "";
            }

            buttonOneToCible.Enabled = false;
            buttonAllToSource.Enabled = true;
        }

        private void buttonAllToCible_Click(object sender, EventArgs e)
        {
            foreach(var item in comboBoxSource.Items)
            {
                listBoxCible.Items.Add(item);
            }
            
            comboBoxSource.Items.Clear();
            comboBoxSource.Text = "";
            buttonAllToCible.Enabled = false;
            buttonAllToSource.Enabled = true;
        }

        private void buttonOneToSource_Click(object sender, EventArgs e)
        {
            if(listBoxCible.SelectedIndex != -1)
            {
                comboBoxSource.Items.Add(listBoxCible.SelectedItem);
                listBoxCible.Items.Remove(listBoxCible.SelectedItem);
            }
            buttonOneToSource.Enabled = false;
            buttonAllToCible.Enabled = true;
            buttonToUp.Enabled = false;
            buttonToDown.Enabled = false;
        }

        private void buttonAllToSource_Click(object sender, EventArgs e)
        {
            foreach(var item in listBoxCible.Items)
            {
                comboBoxSource.Items.Add(item);
            }
            listBoxCible.Items.Clear();
            buttonAllToSource.Enabled = false;
            buttonAllToCible.Enabled = true;
            buttonToUp.Enabled = false;
            buttonToDown.Enabled = false;
        }

        private void comboBoxSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonOneToCible.Enabled = true;
        }

        private void listBoxCible_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonOneToSource.Enabled = true;
            buttonToUp.Enabled = true;
            buttonToDown.Enabled = true;
        }

        private void buttonToUp_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxCible.SelectedIndex;

            if (selectedIndex > 0)
            {
                listBoxCible.Items.Insert(selectedIndex - 1, listBoxCible.SelectedItem);
                listBoxCible.Items.RemoveAt(selectedIndex + 1);
                listBoxCible.SelectedIndex = selectedIndex - 1;
                listBoxCible.Focus();
            }
        }

        private void buttonToDown_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxCible.SelectedIndex;

            if (selectedIndex < listBoxCible.Items.Count - 1)
            {
                listBoxCible.Items.Insert(selectedIndex + 2, listBoxCible.SelectedItem);
                listBoxCible.Items.RemoveAt(selectedIndex);
                listBoxCible.SelectedIndex = selectedIndex + 1;
                listBoxCible.Focus();
            }
        }

        private void comboBoxSource_TextUpdate(object sender, EventArgs e)
        {
            buttonOneToCible.Enabled = true;
        }
    }
}
