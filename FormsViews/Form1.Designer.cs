using Babylon.src;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Babylon {
    partial class mainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            button1 = new Button();
            testBox = new TextBox();
            page1 = new Page();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(341, 505);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(159, 29);
            button1.TabIndex = 0;
            button1.Text = "Generate page";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // testBox
            // 
            testBox.Location = new System.Drawing.Point(421, 108);
            testBox.Multiline = true;
            testBox.Name = "testBox";
            testBox.ReadOnly = true;
            testBox.Size = new System.Drawing.Size(253, 261);
            testBox.TabIndex = 1;
            testBox.Text = "5sa\r\nasd\r\na5d\r\nas5das5d\r\nas5d5ada";
            // 
            // page1
            // 
            page1.Location = new System.Drawing.Point(129, 119);
            page1.Name = "page1";
            page1.Size = new System.Drawing.Size(125, 27);
            page1.TabIndex = 2;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 562);
            Controls.Add(page1);
            Controls.Add(testBox);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "mainForm";
            Text = "La Biblioteca de Babel";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button button1;
        private TextBox testBox;
        private Page page1;

        #endregion

        //Custom Controls



    }
}

