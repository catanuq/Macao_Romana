namespace Macao_Rewritten
{
    partial class MacaoForm
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
            this.components = new System.ComponentModel.Container();
            this.pnlTabla = new System.Windows.Forms.Panel();
            this.pbTabla = new System.Windows.Forms.PictureBox();
            this.pnlJucator = new System.Windows.Forms.FlowLayoutPanel();
            this.btnJoaca = new System.Windows.Forms.Button();
            this.btnTrage = new System.Windows.Forms.Button();
            this.lblCarteIndicator = new System.Windows.Forms.Label();
            this.pnlBot = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSimbol = new System.Windows.Forms.Label();
            this.btnConfirmaSimbol = new System.Windows.Forms.Button();
            this.pnlSelectareSimbol = new System.Windows.Forms.Panel();
            this.btnIesire = new System.Windows.Forms.Button();
            this.lblTuraCurenta = new System.Windows.Forms.Label();
            this.btnStrigaMacao = new System.Windows.Forms.Button();
            this.timerStrigaMacao = new System.Windows.Forms.Timer(this.components);
            this.pnlTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTabla)).BeginInit();
            this.pnlSelectareSimbol.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTabla
            // 
            this.pnlTabla.Controls.Add(this.pbTabla);
            this.pnlTabla.Location = new System.Drawing.Point(215, 199);
            this.pnlTabla.Name = "pnlTabla";
            this.pnlTabla.Size = new System.Drawing.Size(732, 147);
            this.pnlTabla.TabIndex = 0;
            // 
            // pbTabla
            // 
            this.pbTabla.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pbTabla.Location = new System.Drawing.Point(320, 13);
            this.pbTabla.Name = "pbTabla";
            this.pbTabla.Size = new System.Drawing.Size(80, 120);
            this.pbTabla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTabla.TabIndex = 11;
            this.pbTabla.TabStop = false;
            // 
            // pnlJucator
            // 
            this.pnlJucator.AutoScroll = true;
            this.pnlJucator.Location = new System.Drawing.Point(215, 349);
            this.pnlJucator.Name = "pnlJucator";
            this.pnlJucator.Size = new System.Drawing.Size(732, 276);
            this.pnlJucator.TabIndex = 5;
            // 
            // btnJoaca
            // 
            this.btnJoaca.BackColor = System.Drawing.Color.LightGreen;
            this.btnJoaca.Location = new System.Drawing.Point(43, 334);
            this.btnJoaca.Name = "btnJoaca";
            this.btnJoaca.Size = new System.Drawing.Size(117, 63);
            this.btnJoaca.TabIndex = 6;
            this.btnJoaca.Text = "Joaca Carte";
            this.btnJoaca.UseVisualStyleBackColor = false;
            this.btnJoaca.Click += new System.EventHandler(this.btnJoaca_Click);
            // 
            // btnTrage
            // 
            this.btnTrage.BackColor = System.Drawing.Color.LightGreen;
            this.btnTrage.Location = new System.Drawing.Point(43, 435);
            this.btnTrage.Name = "btnTrage";
            this.btnTrage.Size = new System.Drawing.Size(117, 63);
            this.btnTrage.TabIndex = 8;
            this.btnTrage.TabStop = false;
            this.btnTrage.Text = "Trage Carte";
            this.btnTrage.UseVisualStyleBackColor = false;
            this.btnTrage.Click += new System.EventHandler(this.btnTrage_Click);
            // 
            // lblCarteIndicator
            // 
            this.lblCarteIndicator.AutoSize = true;
            this.lblCarteIndicator.Location = new System.Drawing.Point(40, 36);
            this.lblCarteIndicator.Name = "lblCarteIndicator";
            this.lblCarteIndicator.Size = new System.Drawing.Size(68, 16);
            this.lblCarteIndicator.TabIndex = 4;
            this.lblCarteIndicator.Text = "s-a extras:";
            // 
            // pnlBot
            // 
            this.pnlBot.AutoScroll = true;
            this.pnlBot.Location = new System.Drawing.Point(215, 12);
            this.pnlBot.Name = "pnlBot";
            this.pnlBot.Size = new System.Drawing.Size(732, 194);
            this.pnlBot.TabIndex = 11;
            // 
            // lblSimbol
            // 
            this.lblSimbol.AutoSize = true;
            this.lblSimbol.Location = new System.Drawing.Point(28, 77);
            this.lblSimbol.Name = "lblSimbol";
            this.lblSimbol.Size = new System.Drawing.Size(121, 16);
            this.lblSimbol.TabIndex = 13;
            this.lblSimbol.Text = "Selecteaza simbol:";
            this.lblSimbol.Visible = false;
            // 
            // btnConfirmaSimbol
            // 
            this.btnConfirmaSimbol.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmaSimbol.Location = new System.Drawing.Point(30, 103);
            this.btnConfirmaSimbol.Name = "btnConfirmaSimbol";
            this.btnConfirmaSimbol.Size = new System.Drawing.Size(118, 41);
            this.btnConfirmaSimbol.TabIndex = 14;
            this.btnConfirmaSimbol.Text = "Confirm";
            this.btnConfirmaSimbol.UseVisualStyleBackColor = false;
            this.btnConfirmaSimbol.Visible = false;
            this.btnConfirmaSimbol.Click += new System.EventHandler(this.btnConfirmaSimbol_Click);
            // 
            // pnlSelectareSimbol
            // 
            this.pnlSelectareSimbol.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlSelectareSimbol.Controls.Add(this.btnConfirmaSimbol);
            this.pnlSelectareSimbol.Location = new System.Drawing.Point(12, 96);
            this.pnlSelectareSimbol.Name = "pnlSelectareSimbol";
            this.pnlSelectareSimbol.Size = new System.Drawing.Size(181, 153);
            this.pnlSelectareSimbol.TabIndex = 15;
            this.pnlSelectareSimbol.Visible = false;
            // 
            // btnIesire
            // 
            this.btnIesire.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnIesire.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIesire.Location = new System.Drawing.Point(45, 556);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(115, 51);
            this.btnIesire.TabIndex = 16;
            this.btnIesire.Text = "Iesi din joc";
            this.btnIesire.UseVisualStyleBackColor = false;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // lblTuraCurenta
            // 
            this.lblTuraCurenta.AutoSize = true;
            this.lblTuraCurenta.Location = new System.Drawing.Point(39, 274);
            this.lblTuraCurenta.Name = "lblTuraCurenta";
            this.lblTuraCurenta.Size = new System.Drawing.Size(0, 16);
            this.lblTuraCurenta.TabIndex = 17;
            // 
            // btnStrigaMacao
            // 
            this.btnStrigaMacao.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnStrigaMacao.Location = new System.Drawing.Point(33, 273);
            this.btnStrigaMacao.Name = "btnStrigaMacao";
            this.btnStrigaMacao.Size = new System.Drawing.Size(141, 49);
            this.btnStrigaMacao.TabIndex = 18;
            this.btnStrigaMacao.Text = "MACAO!";
            this.btnStrigaMacao.UseVisualStyleBackColor = false;
            this.btnStrigaMacao.Visible = false;
            this.btnStrigaMacao.Click += new System.EventHandler(this.btnStrigaMacao_Click);
            // 
            // timerStrigaMacao
            // 
            this.timerStrigaMacao.Interval = 2000;
            this.timerStrigaMacao.Tick += new System.EventHandler(this.timerStrigaMacao_Tick);
            // 
            // MacaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(982, 637);
            this.Controls.Add(this.btnStrigaMacao);
            this.Controls.Add(this.lblTuraCurenta);
            this.Controls.Add(this.btnIesire);
            this.Controls.Add(this.pnlSelectareSimbol);
            this.Controls.Add(this.lblSimbol);
            this.Controls.Add(this.pnlBot);
            this.Controls.Add(this.lblCarteIndicator);
            this.Controls.Add(this.btnTrage);
            this.Controls.Add(this.btnJoaca);
            this.Controls.Add(this.pnlJucator);
            this.Controls.Add(this.pnlTabla);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MacaoForm";
            this.Text = "Macao";
            this.pnlTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTabla)).EndInit();
            this.pnlSelectareSimbol.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTabla;
        private System.Windows.Forms.FlowLayoutPanel pnlJucator;
        private System.Windows.Forms.Button btnJoaca;
        private System.Windows.Forms.Button btnTrage;
        private System.Windows.Forms.Label lblCarteIndicator;
        private System.Windows.Forms.PictureBox pbTabla;
        private System.Windows.Forms.FlowLayoutPanel pnlBot;
        private System.Windows.Forms.Label lblSimbol;
        private System.Windows.Forms.Button btnConfirmaSimbol;
        private System.Windows.Forms.Panel pnlSelectareSimbol;
        private System.Windows.Forms.Button btnIesire;
        private System.Windows.Forms.Label lblTuraCurenta;
        private System.Windows.Forms.Button btnStrigaMacao;
        private System.Windows.Forms.Timer timerStrigaMacao;
    }
}

