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
    public partial class EditingForm : Form
    {
        List<Label> labelList;
        List<TextBox> textBoxList;
        public EditingForm()
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
        
        private void dropMessage(ComboBox comboBox)
        {
            MessageBox.Show("Не выбран раздел",
                "Ошибка выбора данных",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            comboBox.Focus();
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

        private void hideAllTextBox()
        {
            for (int i = 0; i < labelList.Count; ++i)
            {
                labelList[i].Hide();
                textBoxList[i].Clear();
                textBoxList[i].Hide();
            }
        }

        private void showNParameters(int n)
        {
            if (n >= labelList.Count)
                throw new IndexOutOfRangeException("showNParameters(int n) error");
            for (int i = 0; i < n; ++i)
            {
                labelList[i].Show();
                textBoxList[i].Show();
            }
        }

        private void fillParameterLabels(List<String> nameList)
        {
            for (int i = 0; i < nameList.Count; ++i)
                labelList[i].Text = nameList[i];
        }

        private void typesOfComponents_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_componentNumber.Items.Clear();
            hideAllTextBox();
            switch (cmb_typesOfComponents.SelectedIndex)
            {
                case 0:
                    for (int i = 0;i < SchemaDimension.resistors; i++)
                    {
                        cmb_componentNumber.Items.Add((i + 1).ToString());
                    }
                    showNParameters(3);
                    fillParameterLabels(SchemaDimension.resistorParameters);
                    break;
                case 1:
                    for (int i = 0; i < SchemaDimension.capacitors; i++)
                    {
                        cmb_componentNumber.Items.Add((i + 1).ToString());
                    }
                    showNParameters(3);
                    fillParameterLabels(SchemaDimension.capacitorParameters);
                    break;
                case 2:
                    for (int i = 0; i < SchemaDimension.inductances; i++)
                    {
                        cmb_componentNumber.Items.Add((i + 1).ToString());
                    }
                    showNParameters(3);
                    fillParameterLabels(SchemaDimension.inductanceParameters);
                    break;

            }

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditingForm_Load(object sender, EventArgs e)
        {
            labelList = new List<Label>
            {
                label1,
                label2,
                label3,
                label4,
                label5,
                label6,
                label7,
                label8,
                label9,
                label10,
            };
            textBoxList = new List<TextBox>
            {
                txb_value1,
                txb_value2,
                txb_value3,
                txb_value4,
                txb_value5,
                txb_value6,
                txb_value7,
                txb_value8,
                txb_value9,
                txb_value10,
            };
            hideAllTextBox();
        }

        private void cmb_componentNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_typesOfComponents.SelectedIndex == -1)
            {
                dropMessage(cmb_typesOfComponents);
                return;
            }
            if (cmb_componentNumber.SelectedIndex == -1)
            {
                dropMessage(cmb_componentNumber);
                return;
            }
            switch (cmb_typesOfComponents.SelectedIndex)
            {
               
                case 0:
                    txb_value1.Text = SchemaDimension.resistorsN[cmb_componentNumber.SelectedIndex, 0].ToString();
                    txb_value2.Text = SchemaDimension.resistorsN[cmb_componentNumber.SelectedIndex, 1].ToString();
                    txb_value3.Text = SchemaDimension.resistorsValue[cmb_componentNumber.SelectedIndex].ToString();
                    break;
                case 1:
                    txb_value1.Text = SchemaDimension.capacitorsN[cmb_componentNumber.SelectedIndex, 0].ToString();
                    txb_value2.Text = SchemaDimension.capacitorsN[cmb_componentNumber.SelectedIndex, 1].ToString();
                    txb_value3.Text = SchemaDimension.capacitorsValue[cmb_componentNumber.SelectedIndex].ToString();
                    break;
                case 2:
                    txb_value1.Text = SchemaDimension.inductorN[cmb_componentNumber.SelectedIndex, 0].ToString();
                    txb_value2.Text = SchemaDimension.inductorN[cmb_componentNumber.SelectedIndex, 1].ToString();
                    txb_value3.Text = SchemaDimension.inductorValue[cmb_componentNumber.SelectedIndex].ToString();
                    break;

            }
        }

        private void btn_enteringDescription_Click(object sender, EventArgs e)
        {
            if (cmb_typesOfComponents.SelectedIndex == -1)
            {
                dropMessage(cmb_typesOfComponents);
                return;
            }
            if (cmb_componentNumber.SelectedIndex == -1)
            {
                dropMessage(cmb_componentNumber);
                return;
            }
            if (!checkCorrectInputDataDigit(txb_value1.Text))
            {
                dropMessage(txb_value1);
                return;
            }
            if (!checkCorrectInputDataDigit(txb_value2.Text))
            {
                dropMessage(txb_value2);
                return;
            }
            if (!checkCorrectInputDataFloat(txb_value3.Text))
            {
                dropMessage(txb_value3);
                return;
            }
            switch (cmb_typesOfComponents.SelectedIndex)
            {
                case 0:
                    SchemaDimension.resistorsN[cmb_componentNumber.SelectedIndex, 0]    = int.Parse( txb_value1.Text );
                    SchemaDimension.resistorsN[cmb_componentNumber.SelectedIndex, 1]    = int.Parse( txb_value2.Text );
                    SchemaDimension.resistorsValue[cmb_componentNumber.SelectedIndex]   = float.Parse( txb_value3.Text.Replace('.', ','));
                    break;
                case 1:
                    SchemaDimension.capacitorsN[cmb_componentNumber.SelectedIndex, 0]   = int.Parse(txb_value1.Text);
                    SchemaDimension.capacitorsN[cmb_componentNumber.SelectedIndex, 1]   = int.Parse(txb_value2.Text);
                    SchemaDimension.capacitorsValue[cmb_componentNumber.SelectedIndex]  = float.Parse(txb_value3.Text.Replace('.', ','));
                    break;
                case 2:
                    SchemaDimension.inductorN[cmb_componentNumber.SelectedIndex, 0]   = int.Parse(txb_value1.Text);
                    SchemaDimension.inductorN[cmb_componentNumber.SelectedIndex, 1]   = int.Parse(txb_value2.Text);
                    SchemaDimension.inductorValue[cmb_componentNumber.SelectedIndex]  = float.Parse(txb_value3.Text.Replace('.',','));
                    break;

            }
            MessageBox.Show("Данные успешно сохранены",
                "Успех!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
