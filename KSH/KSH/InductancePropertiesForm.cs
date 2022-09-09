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
    public partial class InductancePropertiesForm : Form
    {
        public InductancePropertiesForm()
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

        private void btn_inductanceNext_Click(object sender, EventArgs e)
        {
            if (!checkCorrectInputDataDigit(txb_inductorNodeNPlus.Text))
            {
                dropMessage(txb_inductorNodeNPlus);
                return;
            }
            if (!checkCorrectInputDataDigit(txb_inductorNodeNMinus.Text))
            {
                dropMessage(txb_inductorNodeNMinus);
                return;
            }
            if (!checkCorrectInputDataFloat(txb_inductance.Text))
            {
                dropMessage(txb_inductance);
                return;
            }
            int inductorIterator                                    = Int32.Parse(txb_inductorCounter.Text);
            SchemaDimension.inductorN[inductorIterator - 1, 0]      = Int32.Parse(txb_inductorNodeNPlus.Text);
            SchemaDimension.inductorN[inductorIterator - 1, 1]      = Int32.Parse(txb_inductorNodeNMinus.Text);
            SchemaDimension.inductorValue[inductorIterator - 1]     = float.Parse(txb_inductance.Text.Replace('.',','));
            ++inductorIterator;
            txb_inductorCounter.Text = inductorIterator.ToString();

            if (inductorIterator <= SchemaDimension.inductances)
            {
                txb_inductorNodeNPlus.Text  = "0";
                txb_inductorNodeNMinus.Text = "0";
                txb_inductance.Text         = "0";
                txb_inductorNodeNPlus.Focus();
            }
            else
            {
                this.Close();
            }
        }

    }
}
