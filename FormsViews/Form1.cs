﻿using Babylon.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Babylon {
    public partial class mainForm : Form {
        //constructor
        private Page pagL = new Page("pageL");
        public mainForm() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            this.Controls.Add(pagL);
            
        }

        private void button1_Click(object sender, EventArgs e) {
            this.pagL.fillPage();
        }
    }
}
