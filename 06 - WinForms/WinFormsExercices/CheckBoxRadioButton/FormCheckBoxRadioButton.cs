using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxRadioButton
{
    public partial class FormCheckBoxRadioButton : Form
    {
        public FormCheckBoxRadioButton()
        {
            InitializeComponent();
        }

        private void textBoxTexteUtilisateur_TextChanged(object sender, EventArgs e)
        {
            labelTexteAffichee.Text = textBoxTexteUtilisateur.Text;

            if(textBoxTexteUtilisateur.Text.Length > 0)
            {
                groupBoxCheckBox.Enabled = true;
            }
            else
            {
                groupBoxCheckBox.Enabled = false;
                checkBoxCouleurFond.Checked = false;
                checkBoxCouleurCaracteres.Checked = false;
                checkBoxCasse.Checked = false;
            }
        }

        private void checkBoxCouleurFond_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxCouleurFond.Checked)
            {
                groupBoxFond.Visible = true;
            }
            else
            {
                groupBoxFond.Visible = false;
                radioButtonFondRouge.Checked = false;
                radioButtonFondVert.Checked = false;
                radioButtonFondBleu.Checked = false;
                labelTexteAffichee.BackColor = Color.Transparent;
            }
        }

        private void checkBoxCouleurCaracteres_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxCouleurCaracteres.Checked)
            {
                groupBoxCaracteres.Visible = true;
            }
            else
            {
                groupBoxCaracteres.Visible = false;
                radioButtonCaraRouge.Checked = false;
                radioButtonCaraBlanc.Checked = false;
                radioButtonCaraNoir.Checked = false;
                labelTexteAffichee.ForeColor = Color.Black;
            }
        }

        private void checkBoxCasse_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxCasse.Checked)
            {
                groupBoxCasse.Visible = true;
            }
            else
            {
                groupBoxCasse.Visible = false;
                radioButtonMinuscules.Checked = false;
                radioButtonMajuscules.Checked = false;
            }
            
        }

        private void radioButtonFondChecked(object sender, EventArgs e)
        {
            if (radioButtonFondRouge.Checked)
            {
                labelTexteAffichee.BackColor = Color.Red;
            }
            else if (radioButtonFondVert.Checked)
            {
                labelTexteAffichee.BackColor = Color.Green;
            }
            else if (radioButtonFondBleu.Checked)
            {
                labelTexteAffichee.BackColor = Color.Blue;
            }   
        }

        private void radioButtonCaraChecked(object sender, EventArgs e)
        {
            if (radioButtonCaraRouge.Checked)
            {
                labelTexteAffichee.ForeColor = Color.Red;
            }
            else if (radioButtonCaraBlanc.Checked)
            {
                labelTexteAffichee.ForeColor = Color.White;
            } 
            else if (radioButtonCaraNoir.Checked)
            {
                labelTexteAffichee.ForeColor = Color.Black;
            }
        }

        private void radioButtonCasseChecked(object sender, EventArgs e)
        {
            if(radioButtonMinuscules.Checked)
            {
                labelTexteAffichee.Text = labelTexteAffichee.Text.ToLower();
            }
            else if(radioButtonMajuscules.Checked)
            {
                labelTexteAffichee.Text = labelTexteAffichee.Text.ToUpper();
            }
        }
    }
}
