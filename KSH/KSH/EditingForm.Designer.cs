namespace KSH
{
    partial class EditingForm
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.txb_value1 = new System.Windows.Forms.TextBox();
            this.txb_value2 = new System.Windows.Forms.TextBox();
            this.txb_value3 = new System.Windows.Forms.TextBox();
            this.btn_enteringDescription = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_descriptionOutput = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_typesOfComponents = new System.Windows.Forms.ComboBox();
            this.cmb_componentNumber = new System.Windows.Forms.ComboBox();
            this.txb_value5 = new System.Windows.Forms.TextBox();
            this.txb_value4 = new System.Windows.Forms.TextBox();
            this.txb_value10 = new System.Windows.Forms.TextBox();
            this.txb_value9 = new System.Windows.Forms.TextBox();
            this.txb_value8 = new System.Windows.Forms.TextBox();
            this.txb_value7 = new System.Windows.Forms.TextBox();
            this.txb_value6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(178, 341);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // txb_value1
            // 
            this.txb_value1.Location = new System.Drawing.Point(280, 76);
            this.txb_value1.Name = "txb_value1";
            this.txb_value1.Size = new System.Drawing.Size(100, 20);
            this.txb_value1.TabIndex = 3;
            // 
            // txb_value2
            // 
            this.txb_value2.Location = new System.Drawing.Point(280, 110);
            this.txb_value2.Name = "txb_value2";
            this.txb_value2.Size = new System.Drawing.Size(100, 20);
            this.txb_value2.TabIndex = 5;
            // 
            // txb_value3
            // 
            this.txb_value3.Location = new System.Drawing.Point(280, 143);
            this.txb_value3.Name = "txb_value3";
            this.txb_value3.Size = new System.Drawing.Size(100, 20);
            this.txb_value3.TabIndex = 7;
            // 
            // btn_enteringDescription
            // 
            this.btn_enteringDescription.Location = new System.Drawing.Point(25, 280);
            this.btn_enteringDescription.Name = "btn_enteringDescription";
            this.btn_enteringDescription.Size = new System.Drawing.Size(100, 23);
            this.btn_enteringDescription.TabIndex = 22;
            this.btn_enteringDescription.Text = "Ввод описания";
            this.btn_enteringDescription.UseVisualStyleBackColor = true;
            this.btn_enteringDescription.Click += new System.EventHandler(this.btn_enteringDescription_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(275, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Номер компонента";
            // 
            // btn_descriptionOutput
            // 
            this.btn_descriptionOutput.Location = new System.Drawing.Point(280, 280);
            this.btn_descriptionOutput.Name = "btn_descriptionOutput";
            this.btn_descriptionOutput.Size = new System.Drawing.Size(100, 23);
            this.btn_descriptionOutput.TabIndex = 25;
            this.btn_descriptionOutput.Text = "Вывод описания";
            this.btn_descriptionOutput.UseVisualStyleBackColor = true;
            this.btn_descriptionOutput.Click += new System.EventHandler(this.btn_descriptionOutput_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Тип компонента";
            // 
            // cmb_typesOfComponents
            // 
            this.cmb_typesOfComponents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_typesOfComponents.FormattingEnabled = true;
            this.cmb_typesOfComponents.Items.AddRange(new object[] {
            "Резистор",
            "Конденсатор",
            "Индуктивность"});
            this.cmb_typesOfComponents.Location = new System.Drawing.Point(12, 31);
            this.cmb_typesOfComponents.Name = "cmb_typesOfComponents";
            this.cmb_typesOfComponents.Size = new System.Drawing.Size(121, 21);
            this.cmb_typesOfComponents.TabIndex = 27;
            this.cmb_typesOfComponents.SelectedIndexChanged += new System.EventHandler(this.typesOfComponents_SelectedIndexChanged);
            // 
            // cmb_componentNumber
            // 
            this.cmb_componentNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_componentNumber.FormattingEnabled = true;
            this.cmb_componentNumber.Items.AddRange(new object[] {
            "Резистор",
            "Конденсатор",
            "Индуктивность"});
            this.cmb_componentNumber.Location = new System.Drawing.Point(268, 34);
            this.cmb_componentNumber.Name = "cmb_componentNumber";
            this.cmb_componentNumber.Size = new System.Drawing.Size(121, 21);
            this.cmb_componentNumber.TabIndex = 28;
            // 
            // txb_value5
            // 
            this.txb_value5.Location = new System.Drawing.Point(280, 212);
            this.txb_value5.Name = "txb_value5";
            this.txb_value5.Size = new System.Drawing.Size(100, 20);
            this.txb_value5.TabIndex = 32;
            // 
            // txb_value4
            // 
            this.txb_value4.Location = new System.Drawing.Point(280, 179);
            this.txb_value4.Name = "txb_value4";
            this.txb_value4.Size = new System.Drawing.Size(100, 20);
            this.txb_value4.TabIndex = 30;
            // 
            // txb_value10
            // 
            this.txb_value10.Location = new System.Drawing.Point(92, 212);
            this.txb_value10.Name = "txb_value10";
            this.txb_value10.Size = new System.Drawing.Size(100, 20);
            this.txb_value10.TabIndex = 42;
            // 
            // txb_value9
            // 
            this.txb_value9.Location = new System.Drawing.Point(92, 179);
            this.txb_value9.Name = "txb_value9";
            this.txb_value9.Size = new System.Drawing.Size(100, 20);
            this.txb_value9.TabIndex = 40;
            // 
            // txb_value8
            // 
            this.txb_value8.Location = new System.Drawing.Point(92, 143);
            this.txb_value8.Name = "txb_value8";
            this.txb_value8.Size = new System.Drawing.Size(100, 20);
            this.txb_value8.TabIndex = 38;
            // 
            // txb_value7
            // 
            this.txb_value7.Location = new System.Drawing.Point(92, 110);
            this.txb_value7.Name = "txb_value7";
            this.txb_value7.Size = new System.Drawing.Size(100, 20);
            this.txb_value7.TabIndex = 36;
            // 
            // txb_value6
            // 
            this.txb_value6.Location = new System.Drawing.Point(92, 76);
            this.txb_value6.Name = "txb_value6";
            this.txb_value6.Size = new System.Drawing.Size(100, 20);
            this.txb_value6.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Значение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Значение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Значение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Значение";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Значение";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Значение";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Значение";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Значение";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Значение";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Значение";
            // 
            // EditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 378);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_value10);
            this.Controls.Add(this.txb_value9);
            this.Controls.Add(this.txb_value8);
            this.Controls.Add(this.txb_value7);
            this.Controls.Add(this.txb_value6);
            this.Controls.Add(this.txb_value5);
            this.Controls.Add(this.txb_value4);
            this.Controls.Add(this.cmb_componentNumber);
            this.Controls.Add(this.cmb_typesOfComponents);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_descriptionOutput);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_enteringDescription);
            this.Controls.Add(this.txb_value3);
            this.Controls.Add(this.txb_value2);
            this.Controls.Add(this.txb_value1);
            this.Controls.Add(this.btn_ok);
            this.Name = "EditingForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EditingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TextBox txb_value1;
        private System.Windows.Forms.TextBox txb_value2;
        private System.Windows.Forms.TextBox txb_value3;
        private System.Windows.Forms.Button btn_enteringDescription;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_descriptionOutput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmb_typesOfComponents;
        private System.Windows.Forms.ComboBox cmb_componentNumber;
        private System.Windows.Forms.TextBox txb_value5;
        private System.Windows.Forms.TextBox txb_value4;
        private System.Windows.Forms.TextBox txb_value10;
        private System.Windows.Forms.TextBox txb_value9;
        private System.Windows.Forms.TextBox txb_value8;
        private System.Windows.Forms.TextBox txb_value7;
        private System.Windows.Forms.TextBox txb_value6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}