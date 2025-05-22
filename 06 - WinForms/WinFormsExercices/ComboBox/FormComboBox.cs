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
            listBoxCible.Items.Add(comboBoxSource.SelectedItem);
            comboBoxSource.Items.Remove(comboBoxSource.SelectedItem);
        }

        private void buttonAllToCible_Click(object sender, EventArgs e)
        {
            foreach(var item in comboBoxSource.Items)
            {
                listBoxCible.Items.Add(item);
            }
            
            comboBoxSource.Items.Clear();
        }

        private void buttonOneToSource_Click(object sender, EventArgs e)
        {
            comboBoxSource.Items.Add(listBoxCible.SelectedItem);
            listBoxCible.Items.Remove(listBoxCible.SelectedItem);
        }

        private void buttonAllToSource_Click(object sender, EventArgs e)
        {
            foreach(var item in listBoxCible.Items)
            {
                comboBoxSource.Items.Add(item);
            }
            listBoxCible.Items.Clear();
        }
    }
}
