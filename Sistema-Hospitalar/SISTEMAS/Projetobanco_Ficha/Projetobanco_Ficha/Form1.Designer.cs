namespace Projetobanco_Ficha
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbprefer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbsuasenha = new System.Windows.Forms.Label();
            this.timersenhaaparece = new System.Windows.Forms.Timer(this.components);
            this.timersenhasome = new System.Windows.Forms.Timer(this.components);
            this.btnormal = new System.Windows.Forms.Button();
            this.btpreferencia = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timerprefer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbprefer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbsuasenha);
            this.panel1.Location = new System.Drawing.Point(352, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 319);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // lbprefer
            // 
            this.lbprefer.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprefer.ForeColor = System.Drawing.Color.DarkRed;
            this.lbprefer.Location = new System.Drawing.Point(50, 121);
            this.lbprefer.Name = "lbprefer";
            this.lbprefer.Size = new System.Drawing.Size(167, 57);
            this.lbprefer.TabIndex = 2;
            this.lbprefer.Text = "ATENDIMENTO PREFERENCIAL";
            this.lbprefer.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(50, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "SUA SENHA:";
            // 
            // lbsuasenha
            // 
            this.lbsuasenha.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsuasenha.ForeColor = System.Drawing.Color.DimGray;
            this.lbsuasenha.Location = new System.Drawing.Point(50, 54);
            this.lbsuasenha.Name = "lbsuasenha";
            this.lbsuasenha.Size = new System.Drawing.Size(144, 67);
            this.lbsuasenha.TabIndex = 0;
            this.lbsuasenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timersenhaaparece
            // 
            this.timersenhaaparece.Interval = 400;
            this.timersenhaaparece.Tick += new System.EventHandler(this.timersenha_Tick);
            // 
            // timersenhasome
            // 
            this.timersenhasome.Interval = 4000;
            this.timersenhasome.Tick += new System.EventHandler(this.timersenhasome_Tick);
            // 
            // btnormal
            // 
            this.btnormal.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnormal.FlatAppearance.BorderSize = 0;
            this.btnormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnormal.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnormal.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnormal.Location = new System.Drawing.Point(52, 96);
            this.btnormal.Name = "btnormal";
            this.btnormal.Size = new System.Drawing.Size(223, 84);
            this.btnormal.TabIndex = 4;
            this.btnormal.Text = "NORMAL";
            this.btnormal.UseVisualStyleBackColor = false;
            this.btnormal.Click += new System.EventHandler(this.button1_Click);
            // 
            // btpreferencia
            // 
            this.btpreferencia.BackColor = System.Drawing.Color.Goldenrod;
            this.btpreferencia.FlatAppearance.BorderSize = 0;
            this.btpreferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btpreferencia.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpreferencia.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btpreferencia.Location = new System.Drawing.Point(52, 210);
            this.btpreferencia.Name = "btpreferencia";
            this.btpreferencia.Size = new System.Drawing.Size(223, 84);
            this.btpreferencia.TabIndex = 5;
            this.btpreferencia.Text = "PREFERENCIAL";
            this.btpreferencia.UseVisualStyleBackColor = false;
            this.btpreferencia.Click += new System.EventHandler(this.btpreferencia_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(48, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "RETIRE SUA SENHA";
            // 
            // timerprefer
            // 
            this.timerprefer.Interval = 4900;
            this.timerprefer.Tick += new System.EventHandler(this.timerprefer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(609, 343);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btpreferencia);
            this.Controls.Add(this.btnormal);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbsuasenha;
        private System.Windows.Forms.Timer timersenhaaparece;
        private System.Windows.Forms.Timer timersenhasome;
        private System.Windows.Forms.Button btnormal;
        private System.Windows.Forms.Button btpreferencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbprefer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerprefer;
    }
}

