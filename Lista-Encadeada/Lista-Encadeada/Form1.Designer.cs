﻿namespace Lista_Encadeada
{
    partial class Form1
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
            this.Setar = new System.Windows.Forms.Button();
            this.Setador = new System.Windows.Forms.TextBox();
            this.listando = new System.Windows.Forms.RichTextBox();
            this.porPosicao = new System.Windows.Forms.RadioButton();
            this.posicao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Setar
            // 
            this.Setar.BackColor = System.Drawing.Color.LightCyan;
            this.Setar.Font = new System.Drawing.Font("ABeeZee", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Setar.Location = new System.Drawing.Point(139, 142);
            this.Setar.Name = "Setar";
            this.Setar.Size = new System.Drawing.Size(133, 30);
            this.Setar.TabIndex = 0;
            this.Setar.Text = "APERTE!";
            this.Setar.UseVisualStyleBackColor = false;
            this.Setar.Click += new System.EventHandler(this.Valores);
            // 
            // Setador
            // 
            this.Setador.Location = new System.Drawing.Point(12, 142);
            this.Setador.Name = "Setador";
            this.Setador.Size = new System.Drawing.Size(100, 20);
            this.Setador.TabIndex = 1;
            this.Setador.Text = "Insira o valor aqui...";
            this.Setador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Setador.Click += new System.EventHandler(this.ZerarValor);
            // 
            // listando
            // 
            this.listando.Enabled = false;
            this.listando.Location = new System.Drawing.Point(12, 12);
            this.listando.Name = "listando";
            this.listando.Size = new System.Drawing.Size(260, 124);
            this.listando.TabIndex = 2;
            this.listando.Text = "";
            // 
            // porPosicao
            // 
            this.porPosicao.AutoSize = true;
            this.porPosicao.Location = new System.Drawing.Point(13, 189);
            this.porPosicao.Name = "porPosicao";
            this.porPosicao.Size = new System.Drawing.Size(81, 17);
            this.porPosicao.TabIndex = 3;
            this.porPosicao.TabStop = true;
            this.porPosicao.Text = "Por posição";
            this.porPosicao.UseVisualStyleBackColor = true;
            this.porPosicao.CheckedChanged += new System.EventHandler(this.PorPosicao);
            // 
            // posicao
            // 
            this.posicao.Enabled = false;
            this.posicao.Location = new System.Drawing.Point(13, 212);
            this.posicao.Name = "posicao";
            this.posicao.Size = new System.Drawing.Size(81, 20);
            this.posicao.TabIndex = 4;
            this.posicao.Text = "Posição";
            this.posicao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.posicao.Click += new System.EventHandler(this.ZerarPosicao);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.posicao);
            this.Controls.Add(this.porPosicao);
            this.Controls.Add(this.listando);
            this.Controls.Add(this.Setador);
            this.Controls.Add(this.Setar);
            this.Name = "Form1";
            this.Text = "Encadeando uma Lista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Setar;
        private System.Windows.Forms.RichTextBox listando;
        public System.Windows.Forms.TextBox Setador;
        private System.Windows.Forms.RadioButton porPosicao;
        private System.Windows.Forms.TextBox posicao;
    }
}

