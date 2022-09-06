using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSH
{
    public partial class SchemaDimensionForm : Form
    {
        public SchemaDimensionForm()
        {
            InitializeComponent();
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
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

        }
    }
}
