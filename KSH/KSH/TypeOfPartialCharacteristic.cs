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
    public partial class TypeOfPartialCharacteristic : Form
    {
        public TypeOfPartialCharacteristic()
        {
            InitializeComponent();
        }

        int mode;

        private void dropMessage(TextBox textBox)
        {
            MessageBox.Show("Неверно введены данные",
                "Ошибка ввода данных",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            textBox.Focus();
        }

        private bool checkCorrectInputDataFloat(String text)
        {
            if (Regex.Match(text, @"^[0-9]+(?:[.,][0-9]+)?$").Success)
                return true;
            return false;
        }

        private void rbt_singleFrequencyPoint_CheckedChanged(object sender, EventArgs e)
        {
            mode = 0;
            updateInputField(mode);
        }

        private void rbt_linearLawOfFrequencyChange_CheckedChanged(object sender, EventArgs e)
        {
            mode = 1;
            updateInputField(mode);
        }

        private void rbt_cbx_logarithmicLawOfFrequencyChange_CheckedChanged(object sender, EventArgs e)
        {
            mode = 2;
            updateInputField(mode);
        }

        void updateInputField(int mode)
        {
            txb_positionTwo.Show();
            txb_positionThree.Show();
            txb_value2.Show();
            txb_value3.Show();
            switch (mode)
            {
                case 0:
                    txb_positionTwo.Hide();
                    txb_positionThree.Hide();
                    txb_value2.Hide();
                    txb_value3.Hide();
                    txb_positionOne.Text    = "Значение частоты (кгц)";
                    break;
                case 1:
                    txb_positionOne.Text    = "Минимальная частота (кгц)";
                    txb_positionTwo.Text    = "Максимальная частота (кгц)";
                    txb_positionThree.Text  = "Шаг изменения частоты (кгц)";
                    break;
                case 2:
                    txb_positionOne.Text    = "Минимальная частота (кгц)";
                    txb_positionTwo.Text    = "Максимальная частота (кгц)";
                    txb_positionThree.Text  = "Отношение соседних частот";
                    break;
            }
        }

        private void btn_putOfCharacteristics_Click(object sender, EventArgs e)
        {
            float maxFrequency, frequencyChangeStep, frequencies;
            int iter = 0;
            switch (mode)
            {
                case 0:
                    if (!checkCorrectInputDataFloat(txb_value1.Text))
                    {
                        dropMessage(txb_value1);
                        return;
                    }
                    SchemaDimension.numberOfFrequencies = 1;
                    SchemaDimension.updateArrays();
                    SchemaDimension.frequencies[0]      = Single.Parse(txb_value1.Text);
                    break;
                case 1:
                    if (!checkCorrectInputDataFloat(txb_value1.Text))
                    {
                        dropMessage(txb_value1);
                        return;
                    }
                    if (!checkCorrectInputDataFloat(txb_value2.Text))
                    {
                        dropMessage(txb_value2);
                        return;
                    }
                    if (!checkCorrectInputDataFloat(txb_value3.Text))
                    {
                        dropMessage(txb_value3);
                        return;
                    }
                    SchemaDimension.numberOfFrequencies = 1;
                    SchemaDimension.updateArrays();
                    SchemaDimension.frequencies[0]      = Single.Parse(txb_value1.Text);
                    maxFrequency                        = Single.Parse(txb_value2.Text);
                    frequencyChangeStep                 = Single.Parse(txb_value3.Text);
                    iter = SchemaDimension.numberOfFrequencies - 1;
                    while (SchemaDimension.frequencies[iter] < maxFrequency)
                    {
                        SchemaDimension.numberOfFrequencies++;
                        SchemaDimension.updateArrays();
                        SchemaDimension.frequencies[iter + 1] = SchemaDimension.frequencies[iter] + frequencyChangeStep;
                        iter++;
                    }
                    break;
                case 2:
                    if (!checkCorrectInputDataFloat(txb_value1.Text))
                    {
                        dropMessage(txb_value1);
                        return;
                    }
                    if (!checkCorrectInputDataFloat(txb_value2.Text))
                    {
                        dropMessage(txb_value2);
                        return;
                    }
                    if (!checkCorrectInputDataFloat(txb_value3.Text))
                    {
                        dropMessage(txb_value3);
                        return;
                    }
                    SchemaDimension.numberOfFrequencies = 1;
                    SchemaDimension.updateArrays();
                    SchemaDimension.frequencies[0]      = Single.Parse(txb_value1.Text);
                    maxFrequency                        = Single.Parse(txb_value2.Text);
                    frequencies                         = Single.Parse(txb_value3.Text);
                    iter = SchemaDimension.numberOfFrequencies - 1;
                    while (SchemaDimension.frequencies[iter] < maxFrequency)
                    {
                        SchemaDimension.numberOfFrequencies++;
                        SchemaDimension.updateArrays();
                        SchemaDimension.frequencies[iter + 1]   = frequencies * SchemaDimension.frequencies[iter];
                        iter++;
                    }
                    break;
            }
            this.Close();

        }

        private void TypeOfPartialCharacteristic_Load(object sender, EventArgs e)
        {
            txb_positionTwo.Hide();
            txb_positionThree.Hide();
            txb_value2.Hide();
            txb_value3.Hide();
            txb_positionOne.Text = "Значение частоты (кгц)";
        }
    }
}
