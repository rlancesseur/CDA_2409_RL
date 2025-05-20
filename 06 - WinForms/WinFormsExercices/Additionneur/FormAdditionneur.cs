using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Additionneur
{
    public partial class FormAdditionneur : Form
    {
        int result = 0;

        public FormAdditionneur()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int value = int.Parse(btn.Text);
            additionneurTextBox.Text += value + "+";
            result += value;
        }

        private void buttonCalculer_Click(object sender, EventArgs e)
        {
            additionneurTextBox.Text += " = " + result + "+";
        }

        private void buttonVider_Click(object sender, EventArgs e)
        {
            additionneurTextBox.Clear();
            result = 0;
        }
    }
}
