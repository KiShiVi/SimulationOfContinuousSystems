namespace KSH
{
    partial class CapacitorPropertiesForm
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
            this.btn_capacitorNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_capacitorCounter = new System.Windows.Forms.TextBox();
            this.txb_capacitorNodeNPlus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_capacitorNodeNMinus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_capacitance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_capacitorNext
            // 
            this.btn_capacitorNext.Location = new System.Drawing.Point(110, 149);
            this.btn_capacitorNext.Name = "btn_capacitorNext";
            this.btn_capacitorNext.Size = new System.Drawing.Size(75, 23);
            this.btn_capacitorNext.TabIndex = 0;
            this.btn_capacitorNext.Text = "Следующий";
            this.btn_capacitorNext.UseVisualStyleBackColor = true;
            this.btn_capacitorNext.Click += new System.EventHandler(this.btn_capacitorNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Конденсатор C";
            // 
            // txb_capacitorCounter
            // 
            this.txb_capacitorCounter.Location = new System.Drawing.Point(96, 26);
            this.txb_capacitorCounter.Name = "txb_capacitorCounter";
            this.txb_capacitorCounter.ReadOnly = true;
            this.txb_capacitorCounter.Size = new System.Drawing.Size(100, 20);
            this.txb_capacitorCounter.TabIndex = 2;
            this.txb_capacitorCounter.Text = "1";
            // 
            // txb_capacitorNodeNPlus
            // 
            this.txb_capacitorNodeNPlus.Location = new System.Drawing.Point(96, 52);
            this.txb_capacitorNodeNPlus.Name = "txb_capacitorNodeNPlus";
            this.txb_capacitorNodeNPlus.Size = new System.Drawing.Size(100, 20);
            this.txb_capacitorNodeNPlus.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Узел n+";
            // 
            // txb_capacitorNodeNMinus
            // 
            this.txb_capacitorNodeNMinus.Location = new System.Drawing.Point(96, 78);
            this.txb_capacitorNodeNMinus.Name = "txb_capacitorNodeNMinus";
            this.txb_capacitorNodeNMinus.Size = new System.Drawing.Size(100, 20);
            this.txb_capacitorNodeNMinus.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Узел n-";
            // 
            // txb_capacitance
            // 
            this.txb_capacitance.Location = new System.Drawing.Point(96, 104);
            this.txb_capacitance.Name = "txb_capacitance";
            this.txb_capacitance.Size = new System.Drawing.Size(100, 20);
            this.txb_capacitance.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Емкость(Ф)";
            // 
            // CapacitorPropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 184);
            this.Controls.Add(this.txb_capacitance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_capacitorNodeNMinus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_capacitorNodeNPlus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_capacitorCounter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_capacitorNext);
            this.Name = "CapacitorPropertiesForm";
            this.Text = "Конденсатор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_capacitorNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_capacitorCounter;
        private System.Windows.Forms.TextBox txb_capacitorNodeNPlus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_capacitorNodeNMinus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_capacitance;
        private System.Windows.Forms.Label label4;
    }
}