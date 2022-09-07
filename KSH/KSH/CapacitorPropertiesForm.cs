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
    public partial class CapacitorPropertiesForm : Form
    {
        public CapacitorPropertiesForm()
        {
            InitializeComponent();
        }

        private void btn_capacitorNext_Click(object sender, EventArgs e)
        {
            int capacitorIterator = Int32.Parse(txb_capacitorCounter.Text);
            SchemaDimension.capacitorsN[capacitorIterator - 1, 0]   = Int32.Parse(txb_capacitorNodeNPlus.Text);
            SchemaDimension.capacitorsN[capacitorIterator - 1, 1]   = Int32.Parse(txb_capacitorNodeNMinus.Text);
            SchemaDimension.capacitorsValue[capacitorIterator - 1]  = float.Parse(txb_capacitance.Text);
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
