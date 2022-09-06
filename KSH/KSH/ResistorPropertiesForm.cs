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
    public partial class ResistorPropertiesForm : Form
    {
        public ResistorPropertiesForm()
        {
            InitializeComponent();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            int resistorIterator = Int32.Parse(txb_resistorCounter.Text);
            SchemaDimension.resistorsN[resistorIterator - 1, 0]     = Int32.Parse(txb_nodeNPlus.Text);
            SchemaDimension.resistorsN[resistorIterator - 1, 1]     = Int32.Parse(txb_nodeNMinus.Text);
            SchemaDimension.resistorsValue[resistorIterator - 1]    = float.Parse(txb_resist.Text);
            ++resistorIterator;
            txb_resistorCounter.Text = resistorIterator.ToString();

            if (resistorIterator <= SchemaDimension.resistors)
            {
                txb_nodeNPlus.Text    = "0";
                txb_nodeNMinus.Text   = "0";
                txb_resist.Text       = "0";
                txb_nodeNPlus.Focus();
            }
            else
            {
                this.Close();
            }
        }
    }
}
