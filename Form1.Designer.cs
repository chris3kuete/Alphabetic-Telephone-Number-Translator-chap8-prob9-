﻿namespace Alphabetic_Telephone_Number_Translator_chap8_prob9_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            phoneNumtb = new TextBox();
            button1 = new Button();
            button2 = new Button();
            formatedNumlbl = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 132);
            label1.Name = "label1";
            label1.Size = new Size(158, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter a Phone Number";
            // 
            // phoneNumtb
            // 
            phoneNumtb.Location = new Point(216, 125);
            phoneNumtb.Name = "phoneNumtb";
            phoneNumtb.Size = new Size(357, 27);
            phoneNumtb.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(479, 349);
            button1.Name = "button1";
            button1.Size = new Size(94, 44);
            button1.TabIndex = 2;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(167, 330);
            button2.Name = "button2";
            button2.Size = new Size(162, 63);
            button2.TabIndex = 3;
            button2.Text = "Convert";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // formatedNumlbl
            // 
            formatedNumlbl.BorderStyle = BorderStyle.FixedSingle;
            formatedNumlbl.Location = new Point(167, 207);
            formatedNumlbl.Name = "formatedNumlbl";
            formatedNumlbl.Size = new Size(406, 53);
            formatedNumlbl.TabIndex = 4;
            formatedNumlbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 457);
            Controls.Add(formatedNumlbl);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(phoneNumtb);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox phoneNumtb;
        private Button button1;
        private Button button2;
        private Label formatedNumlbl;
    }
}
