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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MacaoForm));
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
            this.lblSimbolCurent = new System.Windows.Forms.Label();
            this.btnSunet = new System.Windows.Forms.Button();
            this.lblScorJucator = new System.Windows.Forms.Label();
            this.pbJucator = new System.Windows.Forms.PictureBox();
            this.pbRobot = new System.Windows.Forms.PictureBox();
            this.lblNumeJucator = new System.Windows.Forms.Label();
            this.lblNumeRobot = new System.Windows.Forms.Label();
            this.lblScorRobot = new System.Windows.Forms.Label();
            this.lblNumarRunde = new System.Windows.Forms.Label();
            this.pnlTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTabla)).BeginInit();
            this.pnlSelectareSimbol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbJucator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRobot)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTabla
            // 
            this.pnlTabla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTabla.BackColor = System.Drawing.Color.Transparent;
            this.pnlTabla.Controls.Add(this.pbTabla);
            this.pnlTabla.Location = new System.Drawing.Point(170, 271);
            this.pnlTabla.Name = "pnlTabla";
            this.pnlTabla.Size = new System.Drawing.Size(732, 140);
            this.pnlTabla.TabIndex = 0;
            // 
            // pbTabla
            // 
            this.pbTabla.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pbTabla.Location = new System.Drawing.Point(341, 12);
            this.pbTabla.Name = "pbTabla";
            this.pbTabla.Size = new System.Drawing.Size(80, 120);
            this.pbTabla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTabla.TabIndex = 11;
            this.pbTabla.TabStop = false;
            // 
            // pnlJucator
            // 
            this.pnlJucator.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnlJucator.AutoScroll = true;
            this.pnlJucator.BackgroundImage = global::Macao_Rewritten.Properties.Resources.mana;
            this.pnlJucator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlJucator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlJucator.Location = new System.Drawing.Point(170, 417);
            this.pnlJucator.Name = "pnlJucator";
            this.pnlJucator.Padding = new System.Windows.Forms.Padding(12, 12, 0, 0);
            this.pnlJucator.Size = new System.Drawing.Size(732, 255);
            this.pnlJucator.TabIndex = 5;
            // 
            // btnJoaca
            // 
            this.btnJoaca.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnJoaca.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnJoaca.BackgroundImage = global::Macao_Rewritten.Properties.Resources.joaca;
            this.btnJoaca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJoaca.Location = new System.Drawing.Point(322, 678);
            this.btnJoaca.Name = "btnJoaca";
            this.btnJoaca.Size = new System.Drawing.Size(117, 63);
            this.btnJoaca.TabIndex = 6;
            this.btnJoaca.UseVisualStyleBackColor = false;
            this.btnJoaca.Click += new System.EventHandler(this.btnJoaca_Click);
            // 
            // btnTrage
            // 
            this.btnTrage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTrage.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnTrage.BackgroundImage = global::Macao_Rewritten.Properties.Resources.trage;
            this.btnTrage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrage.Location = new System.Drawing.Point(654, 678);
            this.btnTrage.Name = "btnTrage";
            this.btnTrage.Size = new System.Drawing.Size(117, 63);
            this.btnTrage.TabIndex = 8;
            this.btnTrage.TabStop = false;
            this.btnTrage.UseVisualStyleBackColor = false;
            this.btnTrage.Click += new System.EventHandler(this.btnTrage_Click);
            // 
            // lblCarteIndicator
            // 
            this.lblCarteIndicator.AutoSize = true;
            this.lblCarteIndicator.BackColor = System.Drawing.Color.Transparent;
            this.lblCarteIndicator.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCarteIndicator.Location = new System.Drawing.Point(40, 36);
            this.lblCarteIndicator.Name = "lblCarteIndicator";
            this.lblCarteIndicator.Size = new System.Drawing.Size(0, 16);
            this.lblCarteIndicator.TabIndex = 4;
            // 
            // pnlBot
            // 
            this.pnlBot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlBot.AutoScroll = true;
            this.pnlBot.BackgroundImage = global::Macao_Rewritten.Properties.Resources.mana;
            this.pnlBot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBot.Location = new System.Drawing.Point(170, 9);
            this.pnlBot.Name = "pnlBot";
            this.pnlBot.Padding = new System.Windows.Forms.Padding(12, 12, 0, 0);
            this.pnlBot.Size = new System.Drawing.Size(732, 255);
            this.pnlBot.TabIndex = 11;
            // 
            // lblSimbol
            // 
            this.lblSimbol.AutoSize = true;
            this.lblSimbol.BackColor = System.Drawing.Color.Transparent;
            this.lblSimbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimbol.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSimbol.Location = new System.Drawing.Point(35, 12);
            this.lblSimbol.Name = "lblSimbol";
            this.lblSimbol.Size = new System.Drawing.Size(139, 16);
            this.lblSimbol.TabIndex = 13;
            this.lblSimbol.Text = "Selecteaza simbol:";
            this.lblSimbol.Visible = false;
            // 
            // btnConfirmaSimbol
            // 
            this.btnConfirmaSimbol.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnConfirmaSimbol.BackgroundImage = global::Macao_Rewritten.Properties.Resources.fereastra;
            this.btnConfirmaSimbol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmaSimbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmaSimbol.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConfirmaSimbol.Location = new System.Drawing.Point(48, 140);
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
            this.pnlSelectareSimbol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSelectareSimbol.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlSelectareSimbol.BackgroundImage = global::Macao_Rewritten.Properties.Resources.mana;
            this.pnlSelectareSimbol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSelectareSimbol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSelectareSimbol.Controls.Add(this.lblSimbol);
            this.pnlSelectareSimbol.Controls.Add(this.btnConfirmaSimbol);
            this.pnlSelectareSimbol.Location = new System.Drawing.Point(458, 270);
            this.pnlSelectareSimbol.Name = "pnlSelectareSimbol";
            this.pnlSelectareSimbol.Size = new System.Drawing.Size(213, 193);
            this.pnlSelectareSimbol.TabIndex = 15;
            this.pnlSelectareSimbol.Visible = false;
            // 
            // btnIesire
            // 
            this.btnIesire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIesire.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnIesire.BackgroundImage = global::Macao_Rewritten.Properties.Resources.iesi;
            this.btnIesire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIesire.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIesire.Location = new System.Drawing.Point(930, 678);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(117, 63);
            this.btnIesire.TabIndex = 16;
            this.btnIesire.UseVisualStyleBackColor = false;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // lblTuraCurenta
            // 
            this.lblTuraCurenta.BackColor = System.Drawing.Color.Transparent;
            this.lblTuraCurenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTuraCurenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuraCurenta.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTuraCurenta.Location = new System.Drawing.Point(12, 79);
            this.lblTuraCurenta.Name = "lblTuraCurenta";
            this.lblTuraCurenta.Size = new System.Drawing.Size(144, 66);
            this.lblTuraCurenta.TabIndex = 17;
            this.lblTuraCurenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStrigaMacao
            // 
            this.btnStrigaMacao.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStrigaMacao.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnStrigaMacao.BackgroundImage = global::Macao_Rewritten.Properties.Resources.macao;
            this.btnStrigaMacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStrigaMacao.Location = new System.Drawing.Point(488, 678);
            this.btnStrigaMacao.Name = "btnStrigaMacao";
            this.btnStrigaMacao.Size = new System.Drawing.Size(117, 63);
            this.btnStrigaMacao.TabIndex = 18;
            this.btnStrigaMacao.UseVisualStyleBackColor = false;
            this.btnStrigaMacao.Visible = false;
            this.btnStrigaMacao.Click += new System.EventHandler(this.btnStrigaMacao_Click);
            // 
            // lblSimbolCurent
            // 
            this.lblSimbolCurent.BackColor = System.Drawing.Color.Transparent;
            this.lblSimbolCurent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSimbolCurent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimbolCurent.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSimbolCurent.Location = new System.Drawing.Point(12, 197);
            this.lblSimbolCurent.Name = "lblSimbolCurent";
            this.lblSimbolCurent.Size = new System.Drawing.Size(144, 67);
            this.lblSimbolCurent.TabIndex = 19;
            this.lblSimbolCurent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSunet
            // 
            this.btnSunet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSunet.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSunet.BackgroundImage = global::Macao_Rewritten.Properties.Resources.sound_button;
            this.btnSunet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSunet.ForeColor = System.Drawing.Color.Transparent;
            this.btnSunet.Location = new System.Drawing.Point(1000, 9);
            this.btnSunet.Name = "btnSunet";
            this.btnSunet.Size = new System.Drawing.Size(70, 70);
            this.btnSunet.TabIndex = 20;
            this.btnSunet.UseVisualStyleBackColor = false;
            this.btnSunet.Click += new System.EventHandler(this.btnSunet_Click);
            // 
            // lblScorJucator
            // 
            this.lblScorJucator.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblScorJucator.BackColor = System.Drawing.Color.Transparent;
            this.lblScorJucator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScorJucator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScorJucator.ForeColor = System.Drawing.SystemColors.Control;
            this.lblScorJucator.Location = new System.Drawing.Point(12, 385);
            this.lblScorJucator.Name = "lblScorJucator";
            this.lblScorJucator.Size = new System.Drawing.Size(144, 67);
            this.lblScorJucator.TabIndex = 21;
            this.lblScorJucator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblScorJucator.Visible = false;
            // 
            // pbJucator
            // 
            this.pbJucator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbJucator.BackColor = System.Drawing.Color.Transparent;
            this.pbJucator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbJucator.Location = new System.Drawing.Point(8, 462);
            this.pbJucator.Name = "pbJucator";
            this.pbJucator.Size = new System.Drawing.Size(150, 150);
            this.pbJucator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbJucator.TabIndex = 22;
            this.pbJucator.TabStop = false;
            // 
            // pbRobot
            // 
            this.pbRobot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRobot.BackColor = System.Drawing.Color.Transparent;
            this.pbRobot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbRobot.Image = global::Macao_Rewritten.Properties.Resources.sans;
            this.pbRobot.Location = new System.Drawing.Point(920, 101);
            this.pbRobot.Name = "pbRobot";
            this.pbRobot.Size = new System.Drawing.Size(150, 150);
            this.pbRobot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRobot.TabIndex = 23;
            this.pbRobot.TabStop = false;
            // 
            // lblNumeJucator
            // 
            this.lblNumeJucator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNumeJucator.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeJucator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeJucator.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumeJucator.Location = new System.Drawing.Point(8, 619);
            this.lblNumeJucator.Name = "lblNumeJucator";
            this.lblNumeJucator.Size = new System.Drawing.Size(150, 122);
            this.lblNumeJucator.TabIndex = 24;
            this.lblNumeJucator.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNumeRobot
            // 
            this.lblNumeRobot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeRobot.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeRobot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeRobot.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumeRobot.Location = new System.Drawing.Point(921, 254);
            this.lblNumeRobot.Name = "lblNumeRobot";
            this.lblNumeRobot.Size = new System.Drawing.Size(148, 29);
            this.lblNumeRobot.TabIndex = 25;
            this.lblNumeRobot.Text = "Bot";
            this.lblNumeRobot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScorRobot
            // 
            this.lblScorRobot.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblScorRobot.BackColor = System.Drawing.Color.Transparent;
            this.lblScorRobot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScorRobot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScorRobot.ForeColor = System.Drawing.SystemColors.Control;
            this.lblScorRobot.Location = new System.Drawing.Point(926, 296);
            this.lblScorRobot.Name = "lblScorRobot";
            this.lblScorRobot.Size = new System.Drawing.Size(144, 67);
            this.lblScorRobot.TabIndex = 26;
            this.lblScorRobot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblScorRobot.Visible = false;
            // 
            // lblNumarRunde
            // 
            this.lblNumarRunde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumarRunde.BackColor = System.Drawing.Color.Transparent;
            this.lblNumarRunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumarRunde.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumarRunde.Location = new System.Drawing.Point(921, 619);
            this.lblNumarRunde.Name = "lblNumarRunde";
            this.lblNumarRunde.Size = new System.Drawing.Size(148, 29);
            this.lblNumarRunde.TabIndex = 27;
            this.lblNumarRunde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MacaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = global::Macao_Rewritten.Properties.Resources.fereastra;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.lblNumarRunde);
            this.Controls.Add(this.lblScorRobot);
            this.Controls.Add(this.lblNumeRobot);
            this.Controls.Add(this.lblNumeJucator);
            this.Controls.Add(this.pbRobot);
            this.Controls.Add(this.pbJucator);
            this.Controls.Add(this.lblScorJucator);
            this.Controls.Add(this.btnSunet);
            this.Controls.Add(this.pnlSelectareSimbol);
            this.Controls.Add(this.lblSimbolCurent);
            this.Controls.Add(this.pnlTabla);
            this.Controls.Add(this.btnStrigaMacao);
            this.Controls.Add(this.lblTuraCurenta);
            this.Controls.Add(this.btnIesire);
            this.Controls.Add(this.pnlBot);
            this.Controls.Add(this.lblCarteIndicator);
            this.Controls.Add(this.btnTrage);
            this.Controls.Add(this.btnJoaca);
            this.Controls.Add(this.pnlJucator);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MacaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Macao";
            this.pnlTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTabla)).EndInit();
            this.pnlSelectareSimbol.ResumeLayout(false);
            this.pnlSelectareSimbol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbJucator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRobot)).EndInit();
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
        private System.Windows.Forms.Button btnConfirmaSimbol;
        private System.Windows.Forms.Panel pnlSelectareSimbol;
        private System.Windows.Forms.Button btnIesire;
        private System.Windows.Forms.Label lblTuraCurenta;
        private System.Windows.Forms.Button btnStrigaMacao;
        private System.Windows.Forms.Label lblSimbol;
        private System.Windows.Forms.Label lblSimbolCurent;
        private System.Windows.Forms.Button btnSunet;
        private System.Windows.Forms.Label lblScorJucator;
        private System.Windows.Forms.PictureBox pbJucator;
        private System.Windows.Forms.PictureBox pbRobot;
        private System.Windows.Forms.Label lblNumeJucator;
        private System.Windows.Forms.Label lblNumeRobot;
        private System.Windows.Forms.Label lblScorRobot;
        private System.Windows.Forms.Label lblNumarRunde;
    }
}

