namespace KSH
{
    partial class BuiltInBrowser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wbr_internet = new System.Windows.Forms.WebBrowser();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_forward = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_address = new System.Windows.Forms.ComboBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.prb_progress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // wbr_internet
            // 
            this.wbr_internet.Location = new System.Drawing.Point(12, 86);
            this.wbr_internet.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbr_internet.Name = "wbr_internet";
            this.wbr_internet.Size = new System.Drawing.Size(776, 390);
            this.wbr_internet.TabIndex = 0;
            this.wbr_internet.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.wbr_internet_Navigated);
            this.wbr_internet.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.wbr_internet_Navigating);
            this.wbr_internet.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.wbr_internet_ProgressChanged);
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(355, 24);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(75, 23);
            this.btn_enter.TabIndex = 1;
            this.btn_enter.Text = "Ввод";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(457, 24);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "Назад";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_forward
            // 
            this.btn_forward.Location = new System.Drawing.Point(563, 24);
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.Size = new System.Drawing.Size(75, 23);
            this.btn_forward.TabIndex = 3;
            this.btn_forward.Text = "Вперед";
            this.btn_forward.UseVisualStyleBackColor = true;
            this.btn_forward.Click += new System.EventHandler(this.btn_forward_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(677, 24);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 4;
            this.btn_stop.Text = "Стоп";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Адрес";
            // 
            // cmb_address
            // 
            this.cmb_address.FormattingEnabled = true;
            this.cmb_address.Items.AddRange(new object[] {
            "http://localhost/MF/beg.html",
            "http://127.0.0.1/MF/Int3d.htm",
            "http://127.0.0.1/MF/ParamComp.html"});
            this.cmb_address.Location = new System.Drawing.Point(53, 26);
            this.cmb_address.Name = "cmb_address";
            this.cmb_address.Size = new System.Drawing.Size(266, 21);
            this.cmb_address.TabIndex = 6;
            this.cmb_address.Text = "http://localhost/MF/beg.html";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(713, 498);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "Закрыть";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // prb_progress
            // 
            this.prb_progress.Location = new System.Drawing.Point(12, 498);
            this.prb_progress.Name = "prb_progress";
            this.prb_progress.Size = new System.Drawing.Size(695, 23);
            this.prb_progress.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.prb_progress);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.cmb_address);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_forward);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.wbr_internet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbr_internet;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_forward;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_address;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ProgressBar prb_progress;
    }
}