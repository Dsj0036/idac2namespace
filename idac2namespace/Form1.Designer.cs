﻿namespace idac2namespace
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
            richTextBox1 = new RichTextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 41);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(262, 135);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 182);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(262, 23);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 2;
            label1.Text = "IDAC";
            // 
            // button1
            // 
            button1.Location = new Point(199, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Generate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += GenerateButtonClicked;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 211);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(125, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Use typedef int ret;";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += UseDefChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 284);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "idac2namespace";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
        private CheckBox checkBox1;
    }
}
