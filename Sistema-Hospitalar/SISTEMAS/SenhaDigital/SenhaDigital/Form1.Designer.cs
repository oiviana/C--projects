namespace SenhaDigital
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lbsenha = new System.Windows.Forms.Label();
            this.lbguiche = new System.Windows.Forms.Label();
            this.timersenha = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = false;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(25, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1127, 417);
            this.label2.TabIndex = 1;
            // 
            // lbsenha
            // 
            this.lbsenha.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 300F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsenha.ForeColor = System.Drawing.Color.DarkRed;
            this.lbsenha.Location = new System.Drawing.Point(43, 157);
            this.lbsenha.Name = "lbsenha";
            this.lbsenha.Size = new System.Drawing.Size(638, 354);
            this.lbsenha.TabIndex = 2;
            this.lbsenha.Text = "sees";
            this.lbsenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbguiche
            // 
            this.lbguiche.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbguiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 140.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbguiche.ForeColor = System.Drawing.Color.DarkRed;
            this.lbguiche.Location = new System.Drawing.Point(735, 242);
            this.lbguiche.Name = "lbguiche";
            this.lbguiche.Size = new System.Drawing.Size(304, 236);
            this.lbguiche.TabIndex = 5;
            this.lbguiche.Text = "OI";
            this.lbguiche.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbguiche.Click += new System.EventHandler(this.lbguiche_Click);
            // 
            // timersenha
            // 
            this.timersenha.Enabled = true;
            this.timersenha.Interval = 1000;
            this.timersenha.Tick += new System.EventHandler(this.timersenha_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(125, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 118);
            this.label1.TabIndex = 6;
            this.label1.Text = "SENHA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(668, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(451, 118);
            this.label3.TabIndex = 7;
            this.label3.Text = "GUICHÊ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1179, 582);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbguiche);
            this.Controls.Add(this.lbsenha);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label lbguiche;
        private System.Windows.Forms.Label lbsenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timersenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

