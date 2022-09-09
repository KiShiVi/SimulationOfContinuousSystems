
namespace KSH
{
    partial class SchemaDimensionForm
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
            this.btn_apply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_resistors = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_capacitors = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_inductances = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_ITUN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_INUN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_ITUT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_id_transformers = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txb_id_oper_boosters = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txb_transformers = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txb_oper_boosters = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txb_UP_transistors = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txb_BP_transistors = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txb_INUT = new System.Windows.Forms.TextBox();
            this.txb_countOfNodes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(132, 217);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(254, 23);
            this.btn_apply.TabIndex = 15;
            this.btn_apply.Text = "Принять";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Число узлов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Резисторы";
            // 
            // txb_resistors
            // 
            this.txb_resistors.Location = new System.Drawing.Point(12, 38);
            this.txb_resistors.Name = "txb_resistors";
            this.txb_resistors.Size = new System.Drawing.Size(100, 20);
            this.txb_resistors.TabIndex = 2;
            this.txb_resistors.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Конденсаторы";
            // 
            // txb_capacitors
            // 
            this.txb_capacitors.Location = new System.Drawing.Point(12, 64);
            this.txb_capacitors.Name = "txb_capacitors";
            this.txb_capacitors.Size = new System.Drawing.Size(100, 20);
            this.txb_capacitors.TabIndex = 3;
            this.txb_capacitors.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Индуктивности";
            // 
            // txb_inductances
            // 
            this.txb_inductances.Location = new System.Drawing.Point(12, 90);
            this.txb_inductances.Name = "txb_inductances";
            this.txb_inductances.Size = new System.Drawing.Size(100, 20);
            this.txb_inductances.TabIndex = 4;
            this.txb_inductances.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ИТУН";
            // 
            // txb_ITUN
            // 
            this.txb_ITUN.Location = new System.Drawing.Point(12, 116);
            this.txb_ITUN.Name = "txb_ITUN";
            this.txb_ITUN.Size = new System.Drawing.Size(100, 20);
            this.txb_ITUN.TabIndex = 5;
            this.txb_ITUN.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ИНУН";
            // 
            // txb_INUN
            // 
            this.txb_INUN.Location = new System.Drawing.Point(12, 142);
            this.txb_INUN.Name = "txb_INUN";
            this.txb_INUN.Size = new System.Drawing.Size(100, 20);
            this.txb_INUN.TabIndex = 6;
            this.txb_INUN.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "ИТУТ";
            // 
            // txb_ITUT
            // 
            this.txb_ITUT.Location = new System.Drawing.Point(12, 168);
            this.txb_ITUT.Name = "txb_ITUT";
            this.txb_ITUT.Size = new System.Drawing.Size(100, 20);
            this.txb_ITUT.TabIndex = 7;
            this.txb_ITUT.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(401, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Ид. трансформаторы";
            // 
            // txb_id_transformers
            // 
            this.txb_id_transformers.Location = new System.Drawing.Point(295, 168);
            this.txb_id_transformers.Name = "txb_id_transformers";
            this.txb_id_transformers.Size = new System.Drawing.Size(100, 20);
            this.txb_id_transformers.TabIndex = 14;
            this.txb_id_transformers.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(401, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Ид. опер. усилители";
            // 
            // txb_id_oper_boosters
            // 
            this.txb_id_oper_boosters.Location = new System.Drawing.Point(295, 142);
            this.txb_id_oper_boosters.Name = "txb_id_oper_boosters";
            this.txb_id_oper_boosters.Size = new System.Drawing.Size(100, 20);
            this.txb_id_oper_boosters.TabIndex = 13;
            this.txb_id_oper_boosters.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(401, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Трансформаторы";
            // 
            // txb_transformers
            // 
            this.txb_transformers.Location = new System.Drawing.Point(295, 116);
            this.txb_transformers.Name = "txb_transformers";
            this.txb_transformers.Size = new System.Drawing.Size(100, 20);
            this.txb_transformers.TabIndex = 12;
            this.txb_transformers.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(401, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Опер. усилители";
            // 
            // txb_oper_boosters
            // 
            this.txb_oper_boosters.Location = new System.Drawing.Point(295, 90);
            this.txb_oper_boosters.Name = "txb_oper_boosters";
            this.txb_oper_boosters.Size = new System.Drawing.Size(100, 20);
            this.txb_oper_boosters.TabIndex = 11;
            this.txb_oper_boosters.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(401, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "У/п транзисторы";
            // 
            // txb_UP_transistors
            // 
            this.txb_UP_transistors.Location = new System.Drawing.Point(295, 64);
            this.txb_UP_transistors.Name = "txb_UP_transistors";
            this.txb_UP_transistors.Size = new System.Drawing.Size(100, 20);
            this.txb_UP_transistors.TabIndex = 10;
            this.txb_UP_transistors.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(401, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Б/п транзисторы";
            // 
            // txb_BP_transistors
            // 
            this.txb_BP_transistors.Location = new System.Drawing.Point(295, 38);
            this.txb_BP_transistors.Name = "txb_BP_transistors";
            this.txb_BP_transistors.Size = new System.Drawing.Size(100, 20);
            this.txb_BP_transistors.TabIndex = 9;
            this.txb_BP_transistors.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(401, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "ИНУТ";
            // 
            // txb_INUT
            // 
            this.txb_INUT.Location = new System.Drawing.Point(295, 12);
            this.txb_INUT.Name = "txb_INUT";
            this.txb_INUT.Size = new System.Drawing.Size(100, 20);
            this.txb_INUT.TabIndex = 8;
            this.txb_INUT.Text = "0";
            // 
            // txb_countOfNodes
            // 
            this.txb_countOfNodes.Location = new System.Drawing.Point(12, 12);
            this.txb_countOfNodes.Name = "txb_countOfNodes";
            this.txb_countOfNodes.Size = new System.Drawing.Size(100, 20);
            this.txb_countOfNodes.TabIndex = 1;
            this.txb_countOfNodes.Text = "0";
            // 
            // SchemaDimensionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 264);
            this.Controls.Add(this.txb_countOfNodes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txb_id_transformers);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txb_id_oper_boosters);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txb_transformers);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txb_oper_boosters);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txb_UP_transistors);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txb_BP_transistors);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txb_INUT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txb_ITUT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txb_INUN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_ITUN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_inductances);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_capacitors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_resistors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_apply);
            this.Name = "SchemaDimensionForm";
            this.Text = "Размерность схемы";
            this.Load += new System.EventHandler(this.SchemaDimensionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_resistors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_capacitors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_inductances;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_ITUN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_INUN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_ITUT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_id_transformers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txb_id_oper_boosters;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txb_transformers;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txb_oper_boosters;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txb_UP_transistors;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txb_BP_transistors;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txb_INUT;
        private System.Windows.Forms.TextBox txb_countOfNodes;
    }
}