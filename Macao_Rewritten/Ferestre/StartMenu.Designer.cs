namespace Macao_Rewritten
{
    partial class StartMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenu));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnIesire = new System.Windows.Forms.Button();
            this.btnSunet = new System.Windows.Forms.Button();
            this.btnReguli = new System.Windows.Forms.Button();
            this.btnOptiuni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStart.BackgroundImage = global::Macao_Rewritten.Properties.Resources.startbuton;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.Location = new System.Drawing.Point(199, 560);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(240, 120);
            this.btnStart.TabIndex = 0;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnIesire
            // 
            this.btnIesire.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIesire.BackgroundImage = global::Macao_Rewritten.Properties.Resources.iesibuton;
            this.btnIesire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIesire.Location = new System.Drawing.Point(660, 560);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(240, 120);
            this.btnIesire.TabIndex = 1;
            this.btnIesire.UseVisualStyleBackColor = true;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
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
            this.btnSunet.TabIndex = 2;
            this.btnSunet.UseVisualStyleBackColor = false;
            this.btnSunet.Click += new System.EventHandler(this.btnSunet_Click);
            // 
            // btnReguli
            // 
            this.btnReguli.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReguli.BackgroundImage = global::Macao_Rewritten.Properties.Resources.reguli;
            this.btnReguli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReguli.Location = new System.Drawing.Point(632, 12);
            this.btnReguli.Name = "btnReguli";
            this.btnReguli.Size = new System.Drawing.Size(160, 80);
            this.btnReguli.TabIndex = 3;
            this.btnReguli.UseVisualStyleBackColor = true;
            this.btnReguli.Click += new System.EventHandler(this.btnReguli_Click);
            // 
            // btnOptiuni
            // 
            this.btnOptiuni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOptiuni.BackgroundImage = global::Macao_Rewritten.Properties.Resources.optiuni;
            this.btnOptiuni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOptiuni.Location = new System.Drawing.Point(300, 12);
            this.btnOptiuni.Name = "btnOptiuni";
            this.btnOptiuni.Size = new System.Drawing.Size(160, 80);
            this.btnOptiuni.TabIndex = 4;
            this.btnOptiuni.UseVisualStyleBackColor = true;
            this.btnOptiuni.Click += new System.EventHandler(this.btnOptiuni_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Macao_Rewritten.Properties.Resources.startscreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.btnOptiuni);
            this.Controls.Add(this.btnReguli);
            this.Controls.Add(this.btnSunet);
            this.Controls.Add(this.btnIesire);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Macao";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnIesire;
        private System.Windows.Forms.Button btnSunet;
        private System.Windows.Forms.Button btnReguli;
        private System.Windows.Forms.Button btnOptiuni;
    }
}