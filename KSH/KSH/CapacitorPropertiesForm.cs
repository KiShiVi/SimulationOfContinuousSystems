using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace KSH
{
    public partial class CapacitorPropertiesForm : Form
    {

        public CapacitorPropertiesForm()
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

        private void btn_capacitorNext_Click(object sender, EventArgs e)
        {
            if (!checkCorrectInputDataDigit(txb_capacitorNodeNPlus.Text))
            {
                dropMessage(txb_capacitorNodeNPlus);
                return;
            }
            if (!checkCorrectInputDataDigit(txb_capacitorNodeNMinus.Text))
            {
                dropMessage(txb_capacitorNodeNMinus);
                return;
            }
            if (!checkCorrectInputDataFloat(txb_capacitance.Text))
            {
                dropMessage(txb_capacitance);
                return;
            }
            int capacitorIterator = Int32.Parse(txb_capacitorCounter.Text);
            SchemaDimension.capacitorsN[capacitorIterator - 1, 0]   = Int32.Parse(txb_capacitorNodeNPlus.Text);
            SchemaDimension.capacitorsN[capacitorIterator - 1, 1]   = Int32.Parse(txb_capacitorNodeNMinus.Text);
            SchemaDimension.capacitorsValue[capacitorIterator - 1]  = float.Parse(txb_capacitance.Text.Replace('.',','));
            ++capacitorIterator;
            txb_capacitorCounter.Text = capacitorIterator.ToString();

            if (capacitorIterator <= SchemaDimension.capacitors)
            {
                txb_capacitorNodeNPlus.Text     = "0";
                txb_capacitorNodeNMinus.Text    = "0";
                txb_capacitance.Text            = "0";
                txb_capacitorNodeNPlus.Focus();
            }
            else
            {
                this.Close();
            }
        }
    }
}
