namespace KSH
{
    partial class InputAndOutputNodes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labe = new System.Windows.Forms.Label();
            this.la = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.txb_lPluse = new System.Windows.Forms.TextBox();
            this.txb_kMinus = new System.Windows.Forms.TextBox();
            this.txb_kPluse = new System.Windows.Forms.TextBox();
            this.txb_lMinus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Входные узлы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выходные узел";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "l+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "k+";
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.Location = new System.Drawing.Point(213, 80);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(16, 13);
            this.labe.TabIndex = 4;
            this.labe.Text = "k-";
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Location = new System.Drawing.Point(88, 77);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(12, 13);
            this.la.TabIndex = 5;
            this.la.Text = "l-";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(88, 122);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // txb_lPluse
            // 
            this.txb_lPluse.Location = new System.Drawing.Point(12, 51);
            this.txb_lPluse.Name = "txb_lPluse";
            this.txb_lPluse.Size = new System.Drawing.Size(67, 20);
            this.txb_lPluse.TabIndex = 7;
            // 
            // txb_kMinus
            // 
            this.txb_kMinus.Location = new System.Drawing.Point(140, 77);
            this.txb_kMinus.Name = "txb_kMinus";
            this.txb_kMinus.Size = new System.Drawing.Size(67, 20);
            this.txb_kMinus.TabIndex = 8;
            // 
            // txb_kPluse
            // 
            this.txb_kPluse.Location = new System.Drawing.Point(140, 51);
            this.txb_kPluse.Name = "txb_kPluse";
            this.txb_kPluse.Size = new System.Drawing.Size(67, 20);
            this.txb_kPluse.TabIndex = 9;
            // 
            // txb_lMinus
            // 
            this.txb_lMinus.Location = new System.Drawing.Point(12, 77);
            this.txb_lMinus.Name = "txb_lMinus";
            this.txb_lMinus.Size = new System.Drawing.Size(67, 20);
            this.txb_lMinus.TabIndex = 10;
            // 
            // InputAndOutputNodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 154);
            this.Controls.Add(this.txb_lMinus);
            this.Controls.Add(this.txb_kPluse);
            this.Controls.Add(this.txb_kMinus);
            this.Controls.Add(this.txb_lPluse);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.la);
            this.Controls.Add(this.labe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InputAndOutputNodes";
            this.Text = "Входные и выходные узлы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labe;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TextBox txb_lPluse;
        private System.Windows.Forms.TextBox txb_kMinus;
        private System.Windows.Forms.TextBox txb_kPluse;
        private System.Windows.Forms.TextBox txb_lMinus;
    }
}