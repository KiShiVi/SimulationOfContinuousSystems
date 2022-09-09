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

namespace KSH
{
    public partial class ResistorPropertiesForm : Form
    {
        public ResistorPropertiesForm()
        {
            InitializeComponent();
        }

        private void dropMessage(TextBox textBox)
        {
            MessageBox.Show("Неверно введены данные",
                "Ошибка ввода данных",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            textBox.Focus();
        }

        private bool checkCorrectInputDataDigit(String text)
        {
            if (Regex.Match(text, @"^\d+$").Success)
                return true;
            return false;
        }

        private bool checkCorrectInputDataFloat(String text)
        {
            if (Regex.Match(text, @"^[0-9]+(?:[.,][0-9]+)?$").Success)
                return true;
            return false;
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (!checkCorrectInputDataDigit(txb_nodeNPlus.Text))
            {
                dropMessage(txb_nodeNPlus);
                return;
            }
            if (!checkCorrectInputDataDigit(txb_nodeNMinus.Text))
            {
                dropMessage(txb_nodeNMinus);
                return;
            }
            if (!checkCorrectInputDataFloat(txb_resist.Text))
            {
                dropMessage(txb_resist);
                return;
            }
            int resistorIterator = Int32.Parse(txb_resistorCounter.Text);
            SchemaDimension.resistorsN[resistorIterator - 1, 0]     = Int32.Parse(txb_nodeNPlus.Text);
            SchemaDimension.resistorsN[resistorIterator - 1, 1]     = Int32.Parse(txb_nodeNMinus.Text);
            SchemaDimension.resistorsValue[resistorIterator - 1]    = float.Parse(txb_resist.Text.Replace('.',','));
            ++resistorIterator;
            txb_resistorCounter.Text = resistorIterator.ToString();

            if (resistorIterator <= SchemaDimension.resistors)
            {
                txb_nodeNPlus.Text    = "0";
                txb_nodeNMinus.Text   = "0";
                txb_resist.Text       = "0";
                txb_nodeNPlus.Focus();
            }
            else
            {
                this.Close();
            }
        }
    }
}
