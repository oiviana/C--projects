namespace ProjetoJackpot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.JACKPOT = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.timeralavanca = new System.Windows.Forms.Timer(this.components);
            this.btnalavanca = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pbimg3 = new System.Windows.Forms.PictureBox();
            this.pbimg2 = new System.Windows.Forms.PictureBox();
            this.pbimg1 = new System.Windows.Forms.PictureBox();
            this.pbalavanca = new System.Windows.Forms.PictureBox();
            this.lbldinheiro = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lbtentativas = new System.Windows.Forms.Label();
            this.lbpremio = new System.Windows.Forms.Label();
            this.timerlimpaimagens = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbimg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbalavanca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // JACKPOT
            // 
            this.JACKPOT.Font = new System.Drawing.Font("Lucida Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JACKPOT.ForeColor = System.Drawing.Color.Gold;
            this.JACKPOT.Location = new System.Drawing.Point(364, 9);
            this.JACKPOT.Name = "JACKPOT";
            this.JACKPOT.Size = new System.Drawing.Size(453, 55);
            this.JACKPOT.TabIndex = 0;
            this.JACKPOT.Text = "JÉQUIPÓTE\r\n\r\n\r\n\r\n";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-1, 67);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(987, 11);
            this.bunifuSeparator1.TabIndex = 1;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            this.bunifuSeparator1.Load += new System.EventHandler(this.bunifuSeparator1_Load);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(-1, 1);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(987, 10);
            this.bunifuSeparator2.TabIndex = 2;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(21, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(718, 245);
            this.label1.TabIndex = 6;
            // 
            // timeralavanca
            // 
            this.timeralavanca.Interval = 900;
            this.timeralavanca.Tick += new System.EventHandler(this.timeralavanca_Tick);
            // 
            // btnalavanca
            // 
            this.btnalavanca.Activecolor = System.Drawing.Color.Firebrick;
            this.btnalavanca.BackColor = System.Drawing.Color.Firebrick;
            this.btnalavanca.BackgroundImage = global::ProjetoJackpot.Properties.Resources.alavanca;
            this.btnalavanca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnalavanca.BorderRadius = 0;
            this.btnalavanca.ButtonText = "bunifuFlatButton1";
            this.btnalavanca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnalavanca.DisabledColor = System.Drawing.Color.Gray;
            this.btnalavanca.Iconcolor = System.Drawing.Color.Transparent;
            this.btnalavanca.Iconimage = null;
            this.btnalavanca.Iconimage_right = null;
            this.btnalavanca.Iconimage_right_Selected = null;
            this.btnalavanca.Iconimage_Selected = null;
            this.btnalavanca.IconMarginLeft = 0;
            this.btnalavanca.IconMarginRight = 0;
            this.btnalavanca.IconRightVisible = true;
            this.btnalavanca.IconRightZoom = 0D;
            this.btnalavanca.IconVisible = true;
            this.btnalavanca.IconZoom = 90D;
            this.btnalavanca.IsTab = false;
            this.btnalavanca.Location = new System.Drawing.Point(784, 84);
            this.btnalavanca.Name = "btnalavanca";
            this.btnalavanca.Normalcolor = System.Drawing.Color.Firebrick;
            this.btnalavanca.OnHovercolor = System.Drawing.Color.Firebrick;
            this.btnalavanca.OnHoverTextColor = System.Drawing.Color.White;
            this.btnalavanca.selected = false;
            this.btnalavanca.Size = new System.Drawing.Size(123, 277);
            this.btnalavanca.TabIndex = 7;
            this.btnalavanca.Text = "bunifuFlatButton1";
            this.btnalavanca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnalavanca.Textcolor = System.Drawing.Color.White;
            this.btnalavanca.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalavanca.Click += new System.EventHandler(this.btnalavanca_Click);
            // 
            // pbimg3
            // 
            this.pbimg3.BackColor = System.Drawing.Color.Khaki;
            this.pbimg3.Location = new System.Drawing.Point(527, 93);
            this.pbimg3.Name = "pbimg3";
            this.pbimg3.Size = new System.Drawing.Size(193, 219);
            this.pbimg3.TabIndex = 5;
            this.pbimg3.TabStop = false;
            // 
            // pbimg2
            // 
            this.pbimg2.BackColor = System.Drawing.Color.Khaki;
            this.pbimg2.Location = new System.Drawing.Point(285, 93);
            this.pbimg2.Name = "pbimg2";
            this.pbimg2.Size = new System.Drawing.Size(193, 219);
            this.pbimg2.TabIndex = 4;
            this.pbimg2.TabStop = false;
            this.pbimg2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbimg1
            // 
            this.pbimg1.BackColor = System.Drawing.Color.Khaki;
            this.pbimg1.Location = new System.Drawing.Point(44, 93);
            this.pbimg1.Name = "pbimg1";
            this.pbimg1.Size = new System.Drawing.Size(193, 219);
            this.pbimg1.TabIndex = 3;
            this.pbimg1.TabStop = false;
            // 
            // pbalavanca
            // 
            this.pbalavanca.Image = global::ProjetoJackpot.Properties.Resources.alavancaprabaixo;
            this.pbalavanca.Location = new System.Drawing.Point(818, 332);
            this.pbalavanca.Name = "pbalavanca";
            this.pbalavanca.Size = new System.Drawing.Size(89, 279);
            this.pbalavanca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbalavanca.TabIndex = 8;
            this.pbalavanca.TabStop = false;
            this.pbalavanca.Visible = false;
            // 
            // lbldinheiro
            // 
            this.lbldinheiro.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldinheiro.ForeColor = System.Drawing.Color.Gold;
            this.lbldinheiro.Location = new System.Drawing.Point(12, 484);
            this.lbldinheiro.Name = "lbldinheiro";
            this.lbldinheiro.Size = new System.Drawing.Size(286, 35);
            this.lbldinheiro.TabIndex = 10;
            this.lbldinheiro.Text = "SUAS TENTATIVAS:";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Brown;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(921, 601);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(48, 47);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 12;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(12, 576);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 35);
            this.label2.TabIndex = 13;
            this.label2.Text = "PRÊMIO ACUMULADO:";
            // 
            // lbtentativas
            // 
            this.lbtentativas.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtentativas.ForeColor = System.Drawing.Color.Gold;
            this.lbtentativas.Location = new System.Drawing.Point(348, 484);
            this.lbtentativas.Name = "lbtentativas";
            this.lbtentativas.Size = new System.Drawing.Size(57, 35);
            this.lbtentativas.TabIndex = 14;
            this.lbtentativas.Click += new System.EventHandler(this.lbtentativas_Click);
            // 
            // lbpremio
            // 
            this.lbpremio.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpremio.ForeColor = System.Drawing.Color.Gold;
            this.lbpremio.Location = new System.Drawing.Point(348, 576);
            this.lbpremio.Name = "lbpremio";
            this.lbpremio.Size = new System.Drawing.Size(193, 35);
            this.lbpremio.TabIndex = 15;
            this.lbpremio.Click += new System.EventHandler(this.lbpremio_Click);
            // 
            // timerlimpaimagens
            // 
            this.timerlimpaimagens.Interval = 1000;
            this.timerlimpaimagens.Tick += new System.EventHandler(this.timerlimpaimagens_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(981, 660);
            this.Controls.Add(this.lbpremio);
            this.Controls.Add(this.lbtentativas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.lbldinheiro);
            this.Controls.Add(this.pbalavanca);
            this.Controls.Add(this.btnalavanca);
            this.Controls.Add(this.pbimg3);
            this.Controls.Add(this.pbimg2);
            this.Controls.Add(this.pbimg1);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.JACKPOT);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbimg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbalavanca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel JACKPOT;
        private System.Windows.Forms.PictureBox pbimg1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.PictureBox pbimg3;
        private System.Windows.Forms.PictureBox pbimg2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnalavanca;
        private System.Windows.Forms.Timer timeralavanca;
        private System.Windows.Forms.PictureBox pbalavanca;
        private System.Windows.Forms.Label lbldinheiro;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbtentativas;
        private System.Windows.Forms.Label lbpremio;
        private System.Windows.Forms.Timer timerlimpaimagens;
    }
}

