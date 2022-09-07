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
    public partial class EditingForm : Form
    {
        public EditingForm()
        {
            InitializeComponent();
        }

        private void typesOfComponents_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_componentNumber.Items.Clear();
            switch (cmb_typesOfComponents.SelectedIndex)
            {
                case 0:
                    for (int i = 0;i < SchemaDimension.resistors; i++)
                    {
                        cmb_componentNumber.Items.Add((i + 1).ToString());
                    }
                    break;
                case 1:
                    for (int i = 0; i < SchemaDimension.capacitors; i++)
                    {
                        cmb_componentNumber.Items.Add((i + 1).ToString());
                    }
                    break;
                case 2:
                    for (int i = 0; i < SchemaDimension.inductances; i++)
                    {
                        cmb_componentNumber.Items.Add((i + 1).ToString());
                    }
                    break;

            }

        }
    }
}
