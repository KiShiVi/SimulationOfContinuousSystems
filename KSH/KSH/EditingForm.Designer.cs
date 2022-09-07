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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_enteringDescription = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_descriptionOutput = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_typesOfComponents = new System.Windows.Forms.ComboBox();
            this.cmb_componentNumber = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(126, 259);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Значение";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(159, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Значение";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(159, 148);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Значение";
            // 
            // btn_enteringDescription
            // 
            this.btn_enteringDescription.Location = new System.Drawing.Point(34, 197);
            this.btn_enteringDescription.Name = "btn_enteringDescription";
            this.btn_enteringDescription.Size = new System.Drawing.Size(100, 23);
            this.btn_enteringDescription.TabIndex = 22;
            this.btn_enteringDescription.Text = "Ввод описания";
            this.btn_enteringDescription.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(188, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Номер компонента";
            // 
            // btn_descriptionOutput
            // 
            this.btn_descriptionOutput.Location = new System.Drawing.Point(181, 197);
            this.btn_descriptionOutput.Name = "btn_descriptionOutput";
            this.btn_descriptionOutput.Size = new System.Drawing.Size(100, 23);
            this.btn_descriptionOutput.TabIndex = 25;
            this.btn_descriptionOutput.Text = "Вывод описания";
            this.btn_descriptionOutput.UseVisualStyleBackColor = true;
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
            this.cmb_componentNumber.Location = new System.Drawing.Point(181, 31);
            this.cmb_componentNumber.Name = "cmb_componentNumber";
            this.cmb_componentNumber.Size = new System.Drawing.Size(121, 21);
            this.cmb_componentNumber.TabIndex = 28;
            // 
            // EditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 314);
            this.Controls.Add(this.cmb_componentNumber);
            this.Controls.Add(this.cmb_typesOfComponents);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_descriptionOutput);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_enteringDescription);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ok);
            this.Name = "EditingForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_enteringDescription;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_descriptionOutput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmb_typesOfComponents;
        private System.Windows.Forms.ComboBox cmb_componentNumber;
    }
}