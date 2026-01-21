namespace Macao_Rewritten
{
    partial class TipJoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipJoc));
            this.label1 = new System.Windows.Forms.Label();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnTurneu = new System.Windows.Forms.Button();
            this.btnSunet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(199, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(700, 204);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alege tipul jocului";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNormal
            // 
            this.btnNormal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNormal.BackgroundImage = global::Macao_Rewritten.Properties.Resources.mana;
            this.btnNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNormal.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNormal.Location = new System.Drawing.Point(215, 451);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(254, 135);
            this.btnNormal.TabIndex = 1;
            this.btnNormal.Text = "Normal";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnTurneu
            // 
            this.btnTurneu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTurneu.BackgroundImage = global::Macao_Rewritten.Properties.Resources.mana;
            this.btnTurneu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTurneu.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurneu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTurneu.Location = new System.Drawing.Point(645, 451);
            this.btnTurneu.Name = "btnTurneu";
            this.btnTurneu.Size = new System.Drawing.Size(254, 135);
            this.btnTurneu.TabIndex = 2;
            this.btnTurneu.Text = "Turneu";
            this.btnTurneu.UseVisualStyleBackColor = true;
            this.btnTurneu.Click += new System.EventHandler(this.btnTurneu_Click);
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
            this.btnSunet.TabIndex = 3;
            this.btnSunet.UseVisualStyleBackColor = false;
            this.btnSunet.Click += new System.EventHandler(this.btnSunet_Click);
            // 
            // TipJoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Macao_Rewritten.Properties.Resources.fereastra;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.btnSunet);
            this.Controls.Add(this.btnTurneu);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TipJoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Macao";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnTurneu;
        private System.Windows.Forms.Button btnSunet;
    }
}