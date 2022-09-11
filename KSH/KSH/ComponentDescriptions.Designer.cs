namespace KSH
{
    partial class ComponentDescriptions
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
            this.btn_enterFileName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_fileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_enterFileName
            // 
            this.btn_enterFileName.Location = new System.Drawing.Point(128, 191);
            this.btn_enterFileName.Name = "btn_enterFileName";
            this.btn_enterFileName.Size = new System.Drawing.Size(75, 23);
            this.btn_enterFileName.TabIndex = 0;
            this.btn_enterFileName.Text = "Ввод";
            this.btn_enterFileName.UseVisualStyleBackColor = true;
            this.btn_enterFileName.Click += new System.EventHandler(this.btn_enterFileName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите название файла";
            // 
            // txb_fileName
            // 
            this.txb_fileName.Location = new System.Drawing.Point(144, 74);
            this.txb_fileName.Name = "txb_fileName";
            this.txb_fileName.Size = new System.Drawing.Size(163, 20);
            this.txb_fileName.TabIndex = 2;
            // 
            // ComponentDescriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 226);
            this.Controls.Add(this.txb_fileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_enterFileName);
            this.Name = "ComponentDescriptions";
            this.Text = "Имя файла";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_enterFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_fileName;
    }
}