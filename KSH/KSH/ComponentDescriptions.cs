﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KSH
{
    public partial class ComponentDescriptions : Form
    {
        public ComponentDescriptions(bool isWriting)
        {
            InitializeComponent();
            this.isWriting = isWriting;
        }

        private bool isWriting;

        private void btn_enterFileName_Click(object sender, EventArgs e)
        {
            //FileStream file ;
            switch (this.isWriting) {
                case true:
                    //file = new FileStream(Directory.GetCurrentDirectory() + txb_fileName.Text + ".txt", FileMode.Create);
                    SchemaDimension.fillParametersToFile(txb_fileName.Text);
                    //file.Close();
                    break;
                case false:
                    if(!File.Exists(Directory.GetCurrentDirectory() + "\\" + txb_fileName.Text + ".txt"))
                    {
                        MessageBox.Show("Файла по данному пути не существует\n" + Directory.GetCurrentDirectory() + "\\" + txb_fileName.Text + ".txt",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                    SchemaDimension.fillParametersFromFile(txb_fileName.Text);
                    //file = new FileStream(Directory.GetCurrentDirectory() + txb_fileName.Text + ".txt", FileMode.Open);
                    //file.Close();
                    break;
            }
            this.Close();
        }
    }
}
