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
    public partial class BuiltInBrowser : Form
    {
        public BuiltInBrowser()
        {
            InitializeComponent();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            String str = cmb_address.Text;
            wbr_internet.Navigate(str);

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            wbr_internet.GoBack();
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            wbr_internet.GoForward();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            wbr_internet.Stop();
            prb_progress.Value = 0;

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void wbr_internet_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            prb_progress.Value = 0;
        }

        private void wbr_internet_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            prb_progress.Minimum = 0;
            prb_progress.Maximum = 100;
            prb_progress.Step = 0;
            prb_progress.Value = 0;

        }

        private void wbr_internet_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if (e.MaximumProgress != 0)
                prb_progress.Value = (int)(e.CurrentProgress * 100 / e.MaximumProgress);

        }
    }
}
