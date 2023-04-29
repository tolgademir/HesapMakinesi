namespace HesapMakinesi
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            label4 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(61, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(444, 23);
            textBox1.TabIndex = 0;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(61, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(444, 23);
            textBox2.TabIndex = 4;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(12, 101);
            button1.Name = "button1";
            button1.Size = new Size(81, 46);
            button1.TabIndex = 6;
            button1.Text = "Topla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 7;
            label1.Text = "1. Sayı ;";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 8;
            label2.Text = "2. Sayı ;";
            // 
            // button2
            // 
            button2.Location = new Point(120, 101);
            button2.Name = "button2";
            button2.Size = new Size(81, 46);
            button2.TabIndex = 11;
            button2.Text = "Çıkar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(227, 101);
            button3.Name = "button3";
            button3.Size = new Size(81, 46);
            button3.TabIndex = 12;
            button3.Text = "Çarp";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(325, 101);
            button4.Name = "button4";
            button4.Size = new Size(81, 46);
            button4.TabIndex = 13;
            button4.Text = "Böl";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.Location = new Point(424, 101);
            button6.Name = "button6";
            button6.Size = new Size(81, 46);
            button6.TabIndex = 15;
            button6.Text = "Temizle";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 314);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 16;
            label4.Text = "İşlem Sonucu ;";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 315);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(517, 338);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Hesap Makinesi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button6;
        private Label label4;
        private Label label3;
    }
}