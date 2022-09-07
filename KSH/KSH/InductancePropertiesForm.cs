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
    public partial class InductancePropertiesForm : Form
    {
        public InductancePropertiesForm()
        {
            InitializeComponent();
        }

        private void btn_inductanceNext_Click(object sender, EventArgs e)
        {
            int inductorIterator = Int32.Parse(txb_inductorCounter.Text);
            SchemaDimension.inductorN[inductorIterator - 1, 0]      = Int32.Parse(txb_inductorNodeNPlus.Text);
            SchemaDimension.inductorN[inductorIterator - 1, 1]     = Int32.Parse(txb_inductorNodeNMinus.Text);
            SchemaDimension.inductorValue[inductorIterator - 1]    = float.Parse(txb_inductance.Text);
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
