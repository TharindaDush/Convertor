namespace _1st
{
    partial class Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_bx = new System.Windows.Forms.TextBox();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_B = new System.Windows.Forms.TextBox();
            this.txt_D = new System.Windows.Forms.TextBox();
            this.txt_H = new System.Windows.Forms.TextBox();
            this.txt_O = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(28, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_bx
            // 
            this.txt_bx.BackColor = System.Drawing.SystemColors.Info;
            this.txt_bx.Location = new System.Drawing.Point(156, 100);
            this.txt_bx.Name = "txt_bx";
            this.txt_bx.Size = new System.Drawing.Size(218, 22);
            this.txt_bx.TabIndex = 9;
            // 
            // Exit_Button
            // 
            this.Exit_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Exit_Button.Location = new System.Drawing.Point(366, 308);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(115, 46);
            this.Exit_Button.TabIndex = 18;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = false;
            this.Exit_Button.Click += new System.EventHandler(this.button13_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Binary";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Decimal";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Hexadecimal";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Octal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(242, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Conversion System";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(90, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 46);
            this.button1.TabIndex = 24;
            this.button1.Text = "Converter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Location = new System.Drawing.Point(222, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 46);
            this.button2.TabIndex = 25;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_B
            // 
            this.txt_B.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_B.Location = new System.Drawing.Point(31, 194);
            this.txt_B.Name = "txt_B";
            this.txt_B.Size = new System.Drawing.Size(100, 22);
            this.txt_B.TabIndex = 26;
            // 
            // txt_D
            // 
            this.txt_D.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_D.Location = new System.Drawing.Point(156, 194);
            this.txt_D.Name = "txt_D";
            this.txt_D.Size = new System.Drawing.Size(100, 22);
            this.txt_D.TabIndex = 27;
            // 
            // txt_H
            // 
            this.txt_H.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_H.Location = new System.Drawing.Point(285, 194);
            this.txt_H.Name = "txt_H";
            this.txt_H.Size = new System.Drawing.Size(100, 22);
            this.txt_H.TabIndex = 28;
            // 
            // txt_O
            // 
            this.txt_O.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_O.Location = new System.Drawing.Point(412, 194);
            this.txt_O.Name = "txt_O";
            this.txt_O.Size = new System.Drawing.Size(100, 22);
            this.txt_O.TabIndex = 29;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 376);
            this.Controls.Add(this.txt_O);
            this.Controls.Add(this.txt_H);
            this.Controls.Add(this.txt_D);
            this.Controls.Add(this.txt_B);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.txt_bx);
            this.Controls.Add(this.label1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_bx;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_B;
        private System.Windows.Forms.TextBox txt_D;
        private System.Windows.Forms.TextBox txt_H;
        private System.Windows.Forms.TextBox txt_O;
    }
}

