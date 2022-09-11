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
    public partial class SchemaDimensionForm : Form
    {
        List<TextBox> listOfTextBoxes;
        public SchemaDimensionForm()
        {
            InitializeComponent();
        }

        private void dropDialog()
        {
            DialogResult dialogResult = MessageBox.Show("Вы хотите сохранить характеристики схемы в файл?",
                 "Вывод данных",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                ComponentDescriptions componentDescriptions = new ComponentDescriptions(true);
                componentDescriptions.ShowDialog();
                componentDescriptions.Dispose();
            }
                
        }

        private void dropMessage(TextBox textBox)
        {
            MessageBox.Show("Неверно введены данные",
                "Ошибка ввода данных",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            textBox.Focus();
        }
        private bool checkCorrectInputData(String text)
        {
            if (Regex.Match(text, @"^\d+$").Success)
                return true;
            return false;
        }
        private void btn_apply_Click(object sender, EventArgs e)
        {
            foreach (TextBox textBox in listOfTextBoxes)
            {
                if (!checkCorrectInputData(textBox.Text))
                {
                    dropMessage(textBox);
                    return;
                }
            }

            SchemaDimension.countOfNodes        = Int32.Parse(txb_countOfNodes      .Text);
            SchemaDimension.resistors           = Int32.Parse(txb_resistors         .Text);
            SchemaDimension.capacitors          = Int32.Parse(txb_capacitors        .Text);
            SchemaDimension.inductances         = Int32.Parse(txb_inductances       .Text);
            SchemaDimension.ITUN                = Int32.Parse(txb_ITUN              .Text);
            SchemaDimension.INUN                = Int32.Parse(txb_INUN              .Text);
            SchemaDimension.ITUT                = Int32.Parse(txb_ITUT              .Text);
            SchemaDimension.INUT                = Int32.Parse(txb_INUT              .Text);
            SchemaDimension.BP_transistors      = Int32.Parse(txb_BP_transistors    .Text);
            SchemaDimension.UP_transistors      = Int32.Parse(txb_UP_transistors    .Text);
            SchemaDimension.oper_boosters       = Int32.Parse(txb_oper_boosters     .Text);
            SchemaDimension.transformers        = Int32.Parse(txb_transformers      .Text);
            SchemaDimension.id_oper_boosters    = Int32.Parse(txb_id_oper_boosters  .Text);
            SchemaDimension.id_transformers     = Int32.Parse(txb_id_transformers   .Text);
            SchemaDimension.updateArrays();
            this.Close();

            if (SchemaDimension.resistors > 0)
            {
                ResistorPropertiesForm resistorPropertiesForm = new ResistorPropertiesForm();
                resistorPropertiesForm.ShowDialog(this);
                resistorPropertiesForm.Dispose();
            }

            if (SchemaDimension.capacitors > 0)
            {
                CapacitorPropertiesForm capacitorsPropertiesForm = new CapacitorPropertiesForm();
                capacitorsPropertiesForm.ShowDialog(this);
                capacitorsPropertiesForm.Dispose();
            }
            if (SchemaDimension.inductances > 0)
            {
                InductancePropertiesForm inductancePropertiesForm = new InductancePropertiesForm();
                inductancePropertiesForm.ShowDialog(this);
                inductancePropertiesForm.Dispose();
            }

            dropDialog();

        }

        private void SchemaDimensionForm_Load(object sender, EventArgs e)
        {
            listOfTextBoxes = new List<TextBox> { txb_countOfNodes,
                txb_resistors,
                txb_capacitors,
                txb_inductances,
                txb_ITUN,
                txb_INUN,
                txb_ITUT, txb_INUT,
                txb_BP_transistors,
                txb_UP_transistors,
                txb_oper_boosters,
                txb_transformers,
                txb_id_oper_boosters,
                txb_id_transformers
            };
        }
    }
}
