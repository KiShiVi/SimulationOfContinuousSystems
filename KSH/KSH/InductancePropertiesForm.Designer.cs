namespace KSH
{
    partial class InductancePropertiesForm
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
            this.btn_inductanceNext = new System.Windows.Forms.Button();
            this.txb_inductorCounter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_inductorNodeNPlus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_inductorNodeNMinus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_inductance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_inductanceNext
            // 
            this.btn_inductanceNext.Location = new System.Drawing.Point(102, 169);
            this.btn_inductanceNext.Name = "btn_inductanceNext";
            this.btn_inductanceNext.Size = new System.Drawing.Size(75, 23);
            this.btn_inductanceNext.TabIndex = 0;
            this.btn_inductanceNext.Text = "Следующий";
            this.btn_inductanceNext.UseVisualStyleBackColor = true;
            this.btn_inductanceNext.Click += new System.EventHandler(this.btn_inductanceNext_Click);
            // 
            // txb_inductorCounter
            // 
            this.txb_inductorCounter.Location = new System.Drawing.Point(120, 28);
            this.txb_inductorCounter.Name = "txb_inductorCounter";
            this.txb_inductorCounter.ReadOnly = true;
            this.txb_inductorCounter.Size = new System.Drawing.Size(100, 20);
            this.txb_inductorCounter.TabIndex = 1;
            this.txb_inductorCounter.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Катушка Инд. L";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Узел n+";
            // 
            // txb_inductorNodeNPlus
            // 
            this.txb_inductorNodeNPlus.Location = new System.Drawing.Point(120, 57);
            this.txb_inductorNodeNPlus.Name = "txb_inductorNodeNPlus";
            this.txb_inductorNodeNPlus.Size = new System.Drawing.Size(100, 20);
            this.txb_inductorNodeNPlus.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Узел n-";
            // 
            // txb_inductorNodeNMinus
            // 
            this.txb_inductorNodeNMinus.Location = new System.Drawing.Point(120, 83);
            this.txb_inductorNodeNMinus.Name = "txb_inductorNodeNMinus";
            this.txb_inductorNodeNMinus.Size = new System.Drawing.Size(100, 20);
            this.txb_inductorNodeNMinus.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Индуктивность(Гн)";
            // 
            // txb_inductance
            // 
            this.txb_inductance.Location = new System.Drawing.Point(120, 106);
            this.txb_inductance.Name = "txb_inductance";
            this.txb_inductance.Size = new System.Drawing.Size(100, 20);
            this.txb_inductance.TabIndex = 7;
            // 
            // InductancePropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 217);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_inductance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_inductorNodeNMinus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_inductorNodeNPlus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_inductorCounter);
            this.Controls.Add(this.btn_inductanceNext);
            this.Name = "InductancePropertiesForm";
            this.Text = "Катушка индуктивности";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_inductanceNext;
        private System.Windows.Forms.TextBox txb_inductorCounter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_inductorNodeNPlus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_inductorNodeNMinus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_inductance;
    }
}