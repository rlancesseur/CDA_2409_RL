using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Defilement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            HScrollBar scrollBar = sender as HScrollBar;

            if (scrollBar.Name == "hScrollBarRouge")
            {
                numericUpDownRouge.Value = scrollBar.Value;
                pictureBoxRouge.BackColor = Color.FromArgb(scrollBar.Value, 0, 0);
            }
            if (scrollBar.Name == "hScrollBarVert")
            {
                numericUpDownVert.Value = scrollBar.Value;
                pictureBoxVert.BackColor = Color.FromArgb(0, scrollBar.Value, 0);
            }
            if (scrollBar.Name == "hScrollBarBleu")
            {
                numericUpDownBleu.Value = scrollBar.Value;
                pictureBoxBleu.BackColor = Color.FromArgb(0, 0, scrollBar.Value);
            }

            pictureBoxResultat.BackColor = Color.FromArgb(hScrollBarRouge.Value, hScrollBarVert.Value, hScrollBarBleu.Value);
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown upDown = sender as NumericUpDown;
            if(upDown.Name == "numericUpDownRouge")
            {
                hScrollBarRouge.Value = (int)upDown.Value;
                pictureBoxRouge.BackColor = Color.FromArgb((int)upDown.Value, 0, 0);
            }
            if (upDown.Name == "numericUpDownVert")
            {
                hScrollBarVert.Value = (int)upDown.Value;
                pictureBoxVert.BackColor = Color.FromArgb(0, (int)upDown.Value, 0);
            }
            if (upDown.Name == "numericUpDownBleu")
            {
                hScrollBarBleu.Value = (int)upDown.Value;
                pictureBoxBleu.BackColor = Color.FromArgb(0, 0, (int)upDown.Value);
            }

            pictureBoxResultat.BackColor = Color.FromArgb((int)numericUpDownRouge.Value, (int)numericUpDownVert.Value, (int)numericUpDownBleu.Value);

        }


    }
}
