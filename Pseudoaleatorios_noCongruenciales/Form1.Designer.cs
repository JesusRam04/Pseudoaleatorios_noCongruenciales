﻿namespace Pseudoaleatorios_noCongruenciales
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
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(239, 27);
            label1.Name = "label1";
            label1.Size = new Size(263, 28);
            label1.TabIndex = 0;
            label1.Text = "Metodo del Producto Medio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 156);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Semilla 1:";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(199, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(199, 205);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 205);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 3;
            label3.Text = "Semilla 2:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(330, 106);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 106);
            label4.Name = "label4";
            label4.Size = new Size(224, 20);
            label4.TabIndex = 5;
            label4.Text = "Numero de aleatorios a generar:";
            // 
            // button1
            // 
            button1.Location = new Point(104, 262);
            button1.Name = "button1";
            button1.Size = new Size(124, 69);
            button1.TabIndex = 7;
            button1.Text = "Generar Aleatorios";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(391, 286);
            label5.Name = "label5";
            label5.Size = new Size(220, 20);
            label5.TabIndex = 8;
            label5.Text = "Jose de Jesus Ramirez Mendieta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(391, 311);
            label6.Name = "label6";
            label6.Size = new Size(200, 20);
            label6.TabIndex = 9;
            label6.Text = "Ricardo Kaleb Flores Alfonso";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Button button1;
        private Label label5;
        private Label label6;
    }
}
