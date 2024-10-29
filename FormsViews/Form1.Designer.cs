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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(971, 566);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(159, 29);
            button1.TabIndex = 0;
            button1.Text = "Generate page";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(1262, 673);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "mainForm";
            Text = "La Biblioteca de Babel";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;

        #endregion

        //Custom Controls



    }
}

