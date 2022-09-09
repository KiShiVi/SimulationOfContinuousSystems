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
            label1.Hide();
            label2.Hide();
            label5.Hide();
            label3.Hide();
            label4.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            txb_value1.Hide();
            txb_value2.Hide();
            txb_value3.Hide();
            txb_value4.Hide();
            txb_value5.Hide();
            txb_value6.Hide();
            txb_value7.Hide();
            txb_value8.Hide();
            txb_value9.Hide();
            txb_value10.Hide();
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
                    txb_value1.Show();
                    txb_value2.Show();
                    txb_value3.Show();
                    label1.Show();
                    label2.Show();
                    label3.Show();
                    //Спросить у Кирюхи про переименование label из другой формы.
                    break;
                case 1:
                    for (int i = 0; i < SchemaDimension.capacitors; i++)
                    {
                        cmb_componentNumber.Items.Add((i + 1).ToString());
                    }
                    txb_value1.Show();
                    txb_value2.Show();
                    txb_value3.Show();
                    label1.Show();
                    label2.Show();
                    label3.Show();
                    break;
                case 2:
                    for (int i = 0; i < SchemaDimension.inductances; i++)
                    {
                        cmb_componentNumber.Items.Add((i + 1).ToString());
                    }
                    txb_value1.Show();
                    txb_value2.Show();
                    txb_value3.Show();
                    label1.Show();
                    label2.Show();
                    label3.Show();
                    break;

            }

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditingForm_Load(object sender, EventArgs e)
        {
            hideAllTextBox();
        }

        private void btn_descriptionOutput_Click(object sender, EventArgs e)
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
        }
    }
}
