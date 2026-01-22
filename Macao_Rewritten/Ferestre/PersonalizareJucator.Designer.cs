namespace Macao_Rewritten
{
    partial class PersonalizareJucator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalizareJucator));
            this.lstPozeProfil = new System.Windows.Forms.ListView();
            this.txtNumeJucator = new System.Windows.Forms.TextBox();
            this.lblNumeJucator = new System.Windows.Forms.Label();
            this.lblPoza = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAnulare = new System.Windows.Forms.Button();
            this.imgLstListaImagini = new System.Windows.Forms.ImageList(this.components);
            this.btnSunet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstPozeProfil
            // 
            this.lstPozeProfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstPozeProfil.HideSelection = false;
            this.lstPozeProfil.Location = new System.Drawing.Point(327, 292);
            this.lstPozeProfil.Name = "lstPozeProfil";
            this.lstPozeProfil.Size = new System.Drawing.Size(479, 343);
            this.lstPozeProfil.TabIndex = 0;
            this.lstPozeProfil.UseCompatibleStateImageBehavior = false;
            this.lstPozeProfil.ItemActivate += new System.EventHandler(this.lstPozeProfil_ItemActivate);
            // 
            // txtNumeJucator
            // 
            this.txtNumeJucator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumeJucator.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeJucator.Location = new System.Drawing.Point(327, 195);
            this.txtNumeJucator.Name = "txtNumeJucator";
            this.txtNumeJucator.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNumeJucator.Size = new System.Drawing.Size(479, 53);
            this.txtNumeJucator.TabIndex = 1;
            // 
            // lblNumeJucator
            // 
            this.lblNumeJucator.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNumeJucator.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeJucator.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeJucator.ForeColor = System.Drawing.Color.Transparent;
            this.lblNumeJucator.Location = new System.Drawing.Point(120, 210);
            this.lblNumeJucator.Name = "lblNumeJucator";
            this.lblNumeJucator.Size = new System.Drawing.Size(127, 44);
            this.lblNumeJucator.TabIndex = 2;
            this.lblNumeJucator.Text = "Nume :";
            this.lblNumeJucator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPoza
            // 
            this.lblPoza.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPoza.BackColor = System.Drawing.Color.Transparent;
            this.lblPoza.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoza.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPoza.Location = new System.Drawing.Point(107, 282);
            this.lblPoza.Name = "lblPoza";
            this.lblPoza.Size = new System.Drawing.Size(170, 114);
            this.lblPoza.TabIndex = 3;
            this.lblPoza.Text = "Poza de profil : ";
            this.lblPoza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(230, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(662, 105);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modifica datele";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.BackgroundImage = global::Macao_Rewritten.Properties.Resources.mana;
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOk.Location = new System.Drawing.Point(231, 664);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(191, 77);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnAnulare
            // 
            this.btnAnulare.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAnulare.BackgroundImage = global::Macao_Rewritten.Properties.Resources.mana;
            this.btnAnulare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnulare.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnulare.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAnulare.Location = new System.Drawing.Point(662, 664);
            this.btnAnulare.Name = "btnAnulare";
            this.btnAnulare.Size = new System.Drawing.Size(201, 77);
            this.btnAnulare.TabIndex = 8;
            this.btnAnulare.Text = "Anulare";
            this.btnAnulare.UseVisualStyleBackColor = true;
            this.btnAnulare.Click += new System.EventHandler(this.btnAnulare_Click);
            // 
            // imgLstListaImagini
            // 
            this.imgLstListaImagini.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgLstListaImagini.ImageSize = new System.Drawing.Size(16, 16);
            this.imgLstListaImagini.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnSunet
            // 
            this.btnSunet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSunet.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSunet.BackgroundImage = global::Macao_Rewritten.Properties.Resources.sound_button;
            this.btnSunet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSunet.ForeColor = System.Drawing.Color.Transparent;
            this.btnSunet.Location = new System.Drawing.Point(1000, 12);
            this.btnSunet.Name = "btnSunet";
            this.btnSunet.Size = new System.Drawing.Size(70, 70);
            this.btnSunet.TabIndex = 9;
            this.btnSunet.UseVisualStyleBackColor = false;
            this.btnSunet.Click += new System.EventHandler(this.btnSunet_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(847, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 277);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pentru a selecta imaginea, efectueaza dublu-click";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PersonalizareJucator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Macao_Rewritten.Properties.Resources.fereastra;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSunet);
            this.Controls.Add(this.btnAnulare);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPoza);
            this.Controls.Add(this.lblNumeJucator);
            this.Controls.Add(this.txtNumeJucator);
            this.Controls.Add(this.lstPozeProfil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonalizareJucator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Macao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstPozeProfil;
        private System.Windows.Forms.TextBox txtNumeJucator;
        private System.Windows.Forms.Label lblNumeJucator;
        private System.Windows.Forms.Label lblPoza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAnulare;
        private System.Windows.Forms.ImageList imgLstListaImagini;
        private System.Windows.Forms.Button btnSunet;
        private System.Windows.Forms.Label label1;
    }
}