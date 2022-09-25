namespace KSH
{
    partial class TypeOfPartialCharacteristic
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
            this.btn_putOfCharacteristics = new System.Windows.Forms.Button();
            this.txb_positionOne = new System.Windows.Forms.TextBox();
            this.txb_positionTwo = new System.Windows.Forms.TextBox();
            this.txb_positionThree = new System.Windows.Forms.TextBox();
            this.txb_value1 = new System.Windows.Forms.TextBox();
            this.txb_value2 = new System.Windows.Forms.TextBox();
            this.txb_value3 = new System.Windows.Forms.TextBox();
            this.rbt_singleFrequencyPoint = new System.Windows.Forms.RadioButton();
            this.rbt_linearLawOfFrequencyChange = new System.Windows.Forms.RadioButton();
            this.rbt_cbx_logarithmicLawOfFrequencyChange = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn_putOfCharacteristics
            // 
            this.btn_putOfCharacteristics.Location = new System.Drawing.Point(140, 228);
            this.btn_putOfCharacteristics.Name = "btn_putOfCharacteristics";
            this.btn_putOfCharacteristics.Size = new System.Drawing.Size(75, 23);
            this.btn_putOfCharacteristics.TabIndex = 3;
            this.btn_putOfCharacteristics.Text = "Ок";
            this.btn_putOfCharacteristics.UseVisualStyleBackColor = true;
            this.btn_putOfCharacteristics.Click += new System.EventHandler(this.btn_putOfCharacteristics_Click);
            // 
            // txb_positionOne
            // 
            this.txb_positionOne.Location = new System.Drawing.Point(12, 129);
            this.txb_positionOne.Name = "txb_positionOne";
            this.txb_positionOne.ReadOnly = true;
            this.txb_positionOne.Size = new System.Drawing.Size(214, 20);
            this.txb_positionOne.TabIndex = 4;
            // 
            // txb_positionTwo
            // 
            this.txb_positionTwo.Location = new System.Drawing.Point(12, 155);
            this.txb_positionTwo.Name = "txb_positionTwo";
            this.txb_positionTwo.ReadOnly = true;
            this.txb_positionTwo.Size = new System.Drawing.Size(214, 20);
            this.txb_positionTwo.TabIndex = 5;
            // 
            // txb_positionThree
            // 
            this.txb_positionThree.Location = new System.Drawing.Point(12, 181);
            this.txb_positionThree.Name = "txb_positionThree";
            this.txb_positionThree.ReadOnly = true;
            this.txb_positionThree.Size = new System.Drawing.Size(214, 20);
            this.txb_positionThree.TabIndex = 6;
            // 
            // txb_value1
            // 
            this.txb_value1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txb_value1.Location = new System.Drawing.Point(242, 129);
            this.txb_value1.Name = "txb_value1";
            this.txb_value1.Size = new System.Drawing.Size(100, 20);
            this.txb_value1.TabIndex = 7;
            // 
            // txb_value2
            // 
            this.txb_value2.Location = new System.Drawing.Point(242, 155);
            this.txb_value2.Name = "txb_value2";
            this.txb_value2.Size = new System.Drawing.Size(100, 20);
            this.txb_value2.TabIndex = 8;
            // 
            // txb_value3
            // 
            this.txb_value3.Location = new System.Drawing.Point(242, 181);
            this.txb_value3.Name = "txb_value3";
            this.txb_value3.Size = new System.Drawing.Size(100, 20);
            this.txb_value3.TabIndex = 9;
            // 
            // rbt_singleFrequencyPoint
            // 
            this.rbt_singleFrequencyPoint.AutoSize = true;
            this.rbt_singleFrequencyPoint.Checked = true;
            this.rbt_singleFrequencyPoint.Location = new System.Drawing.Point(60, 35);
            this.rbt_singleFrequencyPoint.Name = "rbt_singleFrequencyPoint";
            this.rbt_singleFrequencyPoint.Size = new System.Drawing.Size(182, 17);
            this.rbt_singleFrequencyPoint.TabIndex = 10;
            this.rbt_singleFrequencyPoint.TabStop = true;
            this.rbt_singleFrequencyPoint.Text = "Единственная частотная точка";
            this.rbt_singleFrequencyPoint.UseVisualStyleBackColor = true;
            this.rbt_singleFrequencyPoint.CheckedChanged += new System.EventHandler(this.rbt_singleFrequencyPoint_CheckedChanged);
            // 
            // rbt_linearLawOfFrequencyChange
            // 
            this.rbt_linearLawOfFrequencyChange.AutoSize = true;
            this.rbt_linearLawOfFrequencyChange.Location = new System.Drawing.Point(60, 58);
            this.rbt_linearLawOfFrequencyChange.Name = "rbt_linearLawOfFrequencyChange";
            this.rbt_linearLawOfFrequencyChange.Size = new System.Drawing.Size(213, 17);
            this.rbt_linearLawOfFrequencyChange.TabIndex = 11;
            this.rbt_linearLawOfFrequencyChange.Text = "Линейный закон изменения частоты";
            this.rbt_linearLawOfFrequencyChange.UseVisualStyleBackColor = true;
            this.rbt_linearLawOfFrequencyChange.CheckedChanged += new System.EventHandler(this.rbt_linearLawOfFrequencyChange_CheckedChanged);
            // 
            // rbt_cbx_logarithmicLawOfFrequencyChange
            // 
            this.rbt_cbx_logarithmicLawOfFrequencyChange.AutoSize = true;
            this.rbt_cbx_logarithmicLawOfFrequencyChange.Location = new System.Drawing.Point(60, 85);
            this.rbt_cbx_logarithmicLawOfFrequencyChange.Name = "rbt_cbx_logarithmicLawOfFrequencyChange";
            this.rbt_cbx_logarithmicLawOfFrequencyChange.Size = new System.Drawing.Size(255, 17);
            this.rbt_cbx_logarithmicLawOfFrequencyChange.TabIndex = 12;
            this.rbt_cbx_logarithmicLawOfFrequencyChange.Text = "Логарифмический закон изменения частоты";
            this.rbt_cbx_logarithmicLawOfFrequencyChange.UseVisualStyleBackColor = true;
            this.rbt_cbx_logarithmicLawOfFrequencyChange.CheckedChanged += new System.EventHandler(this.rbt_cbx_logarithmicLawOfFrequencyChange_CheckedChanged);
            // 
            // TypeOfPartialCharacteristic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 293);
            this.Controls.Add(this.rbt_cbx_logarithmicLawOfFrequencyChange);
            this.Controls.Add(this.rbt_linearLawOfFrequencyChange);
            this.Controls.Add(this.rbt_singleFrequencyPoint);
            this.Controls.Add(this.txb_value3);
            this.Controls.Add(this.txb_value2);
            this.Controls.Add(this.txb_value1);
            this.Controls.Add(this.txb_positionThree);
            this.Controls.Add(this.txb_positionTwo);
            this.Controls.Add(this.txb_positionOne);
            this.Controls.Add(this.btn_putOfCharacteristics);
            this.Name = "TypeOfPartialCharacteristic";
            this.Text = "Вид частотной характеристики";
            this.Load += new System.EventHandler(this.TypeOfPartialCharacteristic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_putOfCharacteristics;
        private System.Windows.Forms.TextBox txb_positionOne;
        private System.Windows.Forms.TextBox txb_positionTwo;
        private System.Windows.Forms.TextBox txb_positionThree;
        private System.Windows.Forms.TextBox txb_value1;
        private System.Windows.Forms.TextBox txb_value2;
        private System.Windows.Forms.TextBox txb_value3;
        private System.Windows.Forms.RadioButton rbt_singleFrequencyPoint;
        private System.Windows.Forms.RadioButton rbt_linearLawOfFrequencyChange;
        private System.Windows.Forms.RadioButton rbt_cbx_logarithmicLawOfFrequencyChange;
    }
}