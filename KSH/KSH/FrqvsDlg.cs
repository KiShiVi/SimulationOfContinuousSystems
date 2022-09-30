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
    public partial class FrqvsDlg : Form
    {
        public FrqvsDlg()
        {
            InitializeComponent();
        }

        private void ID_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ID_CONS_Click(object sender, EventArgs e)
        {
            InputAndOutputNodes inputAndOutputNodes = new InputAndOutputNodes();
            SchemaDimensionForm schemaDimensionForm = new SchemaDimensionForm();
            schemaDimensionForm.ShowDialog(this);
            schemaDimensionForm.Dispose();
            inputAndOutputNodes.ShowDialog(this);
            inputAndOutputNodes.Dispose();
        }

        private void ID_RED_Click(object sender, EventArgs e)
        {
            EditingForm editingForm = new EditingForm();
            editingForm.ShowDialog(this);
            editingForm.Dispose();
        }

        private void ID_FILE_Click(object sender, EventArgs e)
        {
            InputAndOutputNodes inputAndOutputNodes = new InputAndOutputNodes();
            ComponentDescriptions componentDescriptions = new ComponentDescriptions(false);
            componentDescriptions.ShowDialog(this);
            componentDescriptions.Dispose();
            inputAndOutputNodes.ShowDialog(this);
            inputAndOutputNodes.Dispose();
        }

        private void ID_F_Click(object sender, EventArgs e)
        {
            TypeOfPartialCharacteristic typeOfPartialCharacteristic = new TypeOfPartialCharacteristic();
            InputAndOutputNodes inputAndOutputNodes = new InputAndOutputNodes();
            typeOfPartialCharacteristic.ShowDialog(this);
            typeOfPartialCharacteristic.Dispose();
            inputAndOutputNodes.ShowDialog(this);
            inputAndOutputNodes.Dispose();
        }

        private void ID_IO_Click(object sender, EventArgs e)
        {
            InputAndOutputNodes inputAndOutputNodes = new InputAndOutputNodes();
            inputAndOutputNodes.ShowDialog(this);
            inputAndOutputNodes.Dispose();
        }

        private void ID_INTERNET_Click(object sender, EventArgs e)
        {
            BuiltInBrowser builtInBrowser = new BuiltInBrowser();
            builtInBrowser.ShowDialog(this);
            builtInBrowser.Dispose();
        }
    }
}
