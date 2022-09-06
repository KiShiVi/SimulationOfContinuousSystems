
namespace KSH
{
    partial class ResistorPropertiesForm
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
            this.txb_resistorCounter = new System.Windows.Forms.TextBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.txb_nodeNPlus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_nodeNMinus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_resist = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Резистор R";
            // 
            // txb_resistorCounter
            // 
            this.txb_resistorCounter.Location = new System.Drawing.Point(147, 6);
            this.txb_resistorCounter.Name = "txb_resistorCounter";
            this.txb_resistorCounter.ReadOnly = true;
            this.txb_resistorCounter.Size = new System.Drawing.Size(100, 20);
            this.txb_resistorCounter.TabIndex = 1;
            this.txb_resistorCounter.Text = "1";
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(72, 126);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(107, 23);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = "Следующий";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // txb_nodeNPlus
            // 
            this.txb_nodeNPlus.Location = new System.Drawing.Point(147, 32);
            this.txb_nodeNPlus.Name = "txb_nodeNPlus";
            this.txb_nodeNPlus.Size = new System.Drawing.Size(100, 20);
            this.txb_nodeNPlus.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Узел n+";
            // 
            // txb_nodeNMinus
            // 
            this.txb_nodeNMinus.Location = new System.Drawing.Point(147, 58);
            this.txb_nodeNMinus.Name = "txb_nodeNMinus";
            this.txb_nodeNMinus.Size = new System.Drawing.Size(100, 20);
            this.txb_nodeNMinus.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Узел n-";
            // 
            // txb_resist
            // 
            this.txb_resist.Location = new System.Drawing.Point(147, 84);
            this.txb_resist.Name = "txb_resist";
            this.txb_resist.Size = new System.Drawing.Size(100, 20);
            this.txb_resist.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Сопротивление (КОм)";
            // 
            // ResistorPropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 176);
            this.Controls.Add(this.txb_resist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_nodeNMinus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_nodeNPlus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.txb_resistorCounter);
            this.Controls.Add(this.label1);
            this.Name = "ResistorPropertiesForm";
            this.Text = "Резистор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_resistorCounter;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.TextBox txb_nodeNPlus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_nodeNMinus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_resist;
        private System.Windows.Forms.Label label4;
    }
}