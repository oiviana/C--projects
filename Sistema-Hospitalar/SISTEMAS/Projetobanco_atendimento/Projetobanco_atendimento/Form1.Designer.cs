namespace Projetobanco_atendimento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dtatendimento = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.colsenha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpreferencial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeratualizagrid = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timerhorario = new System.Windows.Forms.Timer(this.components);
            this.lbhoras = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtatendimento)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dtatendimento
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtatendimento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtatendimento.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtatendimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtatendimento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtatendimento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtatendimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtatendimento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colsenha,
            this.colpreferencial});
            this.dtatendimento.DoubleBuffered = true;
            this.dtatendimento.EnableHeadersVisualStyles = false;
            this.dtatendimento.HeaderBgColor = System.Drawing.Color.DodgerBlue;
            this.dtatendimento.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.dtatendimento.Location = new System.Drawing.Point(684, 35);
            this.dtatendimento.Name = "dtatendimento";
            this.dtatendimento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtatendimento.RowHeadersVisible = false;
            this.dtatendimento.Size = new System.Drawing.Size(103, 363);
            this.dtatendimento.TabIndex = 0;
            // 
            // colsenha
            // 
            this.colsenha.HeaderText = "SENHA:";
            this.colsenha.Name = "colsenha";
            // 
            // colpreferencial
            // 
            this.colpreferencial.HeaderText = "PREFERENCIAL";
            this.colpreferencial.Name = "colpreferencial";
            this.colpreferencial.Visible = false;
            // 
            // timeratualizagrid
            // 
            this.timeratualizagrid.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(392, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 53);
            this.label1.TabIndex = 2;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(42, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 79);
            this.button1.TabIndex = 3;
            this.button1.Text = "PRÓXIMO CLIENTE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(241, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 53);
            this.label2.TabIndex = 4;
            this.label2.Text = "SENHA ATUAL:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerhorario
            // 
            this.timerhorario.Enabled = true;
            this.timerhorario.Tick += new System.EventHandler(this.timerhorario_Tick);
            // 
            // lbhoras
            // 
            this.lbhoras.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhoras.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbhoras.Location = new System.Drawing.Point(525, 35);
            this.lbhoras.Name = "lbhoras";
            this.lbhoras.Size = new System.Drawing.Size(129, 53);
            this.lbhoras.TabIndex = 5;
            this.lbhoras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(39, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 53);
            this.label3.TabIndex = 6;
            this.label3.Text = "ATENDENTE:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(39, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 53);
            this.label4.TabIndex = 7;
            this.label4.Text = "GUICHÊ:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(53, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 53);
            this.label5.TabIndex = 8;
            this.label5.Text = "ATENDIMENTOS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 448);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbhoras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtatendimento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtatendimento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtatendimento;
        private System.Windows.Forms.Timer timeratualizagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsenha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpreferencial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerhorario;
        private System.Windows.Forms.Label lbhoras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

