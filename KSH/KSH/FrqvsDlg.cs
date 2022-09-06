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
            SchemaDimensionForm schemaDimensionForm = new SchemaDimensionForm();
            schemaDimensionForm.ShowDialog(this);
            schemaDimensionForm.Dispose();
        }
    }
}
