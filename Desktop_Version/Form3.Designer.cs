﻿namespace trabalho
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.inicio = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "ALIVE THINGS AR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Selecione o modo de jogo";
            // 
            // inicio
            // 
            this.inicio.Location = new System.Drawing.Point(37, 190);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(353, 48);
            this.inicio.TabIndex = 7;
            this.inicio.Text = "Insetos";
            this.inicio.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(353, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Mamíferos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(353, 48);
            this.button2.TabIndex = 9;
            this.button2.Text = "Aves";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(37, 387);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(353, 48);
            this.button3.TabIndex = 10;
            this.button3.Text = "Anfíbios";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(37, 464);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(353, 48);
            this.voltar.TabIndex = 11;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(424, 524);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button inicio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button voltar;
    }
}