﻿namespace ProjetoBanco_Senha
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbsenha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbguiche = new System.Windows.Forms.Label();
            this.timersenha = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(58, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1132, 536);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbsenha
            // 
            this.lbsenha.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 300F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsenha.ForeColor = System.Drawing.Color.DarkRed;
            this.lbsenha.Location = new System.Drawing.Point(239, 195);
            this.lbsenha.Name = "lbsenha";
            this.lbsenha.Size = new System.Drawing.Size(638, 354);
            this.lbsenha.TabIndex = 1;
            this.lbsenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbsenha.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(69, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 107);
            this.label3.TabIndex = 2;
            this.label3.Text = "senha";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(598, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(377, 107);
            this.label4.TabIndex = 3;
            this.label4.Text = "guiche";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbguiche
            // 
            this.lbguiche.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbguiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbguiche.ForeColor = System.Drawing.Color.DarkRed;
            this.lbguiche.Location = new System.Drawing.Point(969, 69);
            this.lbguiche.Name = "lbguiche";
            this.lbguiche.Size = new System.Drawing.Size(186, 107);
            this.lbguiche.TabIndex = 4;
            this.lbguiche.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timersenha
            // 
            this.timersenha.Enabled = true;
            this.timersenha.Interval = 1000;
            this.timersenha.Tick += new System.EventHandler(this.timersenha_Tick);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = false;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1247, 644);
            this.Controls.Add(this.lbguiche);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbsenha);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbsenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbguiche;
        private System.Windows.Forms.Timer timersenha;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

