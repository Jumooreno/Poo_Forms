﻿namespace ListaPooAppExer1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.N2 = new System.Windows.Forms.TextBox();
            this.N1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DesArea = new System.Windows.Forms.Button();
            this.Resul = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // N2
            // 
            this.N2.Location = new System.Drawing.Point(322, 129);
            this.N2.Name = "N2";
            this.N2.Size = new System.Drawing.Size(100, 20);
            this.N2.TabIndex = 0;
            // 
            // N1
            // 
            this.N1.Location = new System.Drawing.Point(105, 129);
            this.N1.Name = "N1";
            this.N1.Size = new System.Drawing.Size(100, 20);
            this.N1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Altura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Base";
            // 
            // DesArea
            // 
            this.DesArea.Location = new System.Drawing.Point(225, 177);
            this.DesArea.Name = "DesArea";
            this.DesArea.Size = new System.Drawing.Size(75, 23);
            this.DesArea.TabIndex = 5;
            this.DesArea.Text = "Area";
            this.DesArea.UseVisualStyleBackColor = true;
            this.DesArea.Click += new System.EventHandler(this.Area);
            // 
            // Resul
            // 
            this.Resul.AutoSize = true;
            this.Resul.Location = new System.Drawing.Point(240, 218);
            this.Resul.Name = "Resul";
            this.Resul.Size = new System.Drawing.Size(13, 13);
            this.Resul.TabIndex = 6;
            this.Resul.Text = "0";
            this.Resul.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Area é : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Resul);
            this.Controls.Add(this.DesArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.N1);
            this.Controls.Add(this.N2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox N2;
        private System.Windows.Forms.TextBox N1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DesArea;
        private System.Windows.Forms.Label Resul;
        private System.Windows.Forms.Label label3;
    }
}

