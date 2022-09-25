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
    public partial class InputAndOutputNodes : Form
    {
        public InputAndOutputNodes()
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

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (!checkCorrectInputDataDigit(txb_lPluse.Text))
            {
                dropMessage(txb_lPluse);
                return;
            }
            
            if (!checkCorrectInputDataDigit(txb_kPluse.Text))
            {
                dropMessage(txb_kPluse);
                return;
            }
            
            if (!checkCorrectInputDataDigit(txb_kMinus.Text))
            {
                dropMessage(txb_kMinus);
                return;
            }
            
            if (!checkCorrectInputDataDigit(txb_lMinus.Text))
            {
                dropMessage(txb_lMinus);
                return;
            }

            SchemaDimension.lPluse = Int32.Parse(txb_lPluse.Text);
            SchemaDimension.lMinus = Int32.Parse(txb_lMinus.Text);
            SchemaDimension.kPluse = Int32.Parse(txb_kPluse.Text);
            SchemaDimension.kMinus = Int32.Parse(txb_kMinus.Text);
            this.Close();
        }
    }
}
