namespace trabalho
{
    partial class Form2
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
            this.como_jogar = new System.Windows.Forms.Button();
            this.jogar = new System.Windows.Forms.Button();
            this.imprimir = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "ALIVE THINGS AR";
            // 
            // como_jogar
            // 
            this.como_jogar.Location = new System.Drawing.Point(27, 173);
            this.como_jogar.Name = "como_jogar";
            this.como_jogar.Size = new System.Drawing.Size(353, 48);
            this.como_jogar.TabIndex = 7;
            this.como_jogar.Text = "Como jogar";
            this.como_jogar.UseVisualStyleBackColor = true;
            this.como_jogar.Click += new System.EventHandler(this.como_jogar_Click);
            // 
            // jogar
            // 
            this.jogar.Location = new System.Drawing.Point(27, 244);
            this.jogar.Name = "jogar";
            this.jogar.Size = new System.Drawing.Size(353, 48);
            this.jogar.TabIndex = 8;
            this.jogar.Text = "Jogar";
            this.jogar.UseVisualStyleBackColor = true;
            // 
            // imprimir
            // 
            this.imprimir.Location = new System.Drawing.Point(27, 318);
            this.imprimir.Name = "imprimir";
            this.imprimir.Size = new System.Drawing.Size(353, 48);
            this.imprimir.TabIndex = 9;
            this.imprimir.Text = "Imprimir seres vivos";
            this.imprimir.UseVisualStyleBackColor = true;
            this.imprimir.Click += new System.EventHandler(this.imprimir_Click);
            // 
            // sair
            // 
            this.sair.Location = new System.Drawing.Point(27, 430);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(353, 48);
            this.sair.TabIndex = 10;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(424, 524);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.imprimir);
            this.Controls.Add(this.jogar);
            this.Controls.Add(this.como_jogar);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "ALIVE THINGS AR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button como_jogar;
        private System.Windows.Forms.Button jogar;
        private System.Windows.Forms.Button imprimir;
        private System.Windows.Forms.Button sair;
    }
}