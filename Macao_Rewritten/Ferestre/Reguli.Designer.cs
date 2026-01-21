namespace Macao_Rewritten
{
    partial class Reguli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reguli));
            this.label1 = new System.Windows.Forms.Label();
            this.btnIesire = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSunet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(107, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(862, 407);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnIesire
            // 
            this.btnIesire.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIesire.BackgroundImage = global::Macao_Rewritten.Properties.Resources.iesibuton;
            this.btnIesire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIesire.Location = new System.Drawing.Point(431, 591);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(240, 120);
            this.btnIesire.TabIndex = 2;
            this.btnIesire.UseVisualStyleBackColor = true;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 67.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(286, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(536, 150);
            this.label2.TabIndex = 3;
            this.label2.Text = "Reguli";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnSunet.TabIndex = 4;
            this.btnSunet.UseVisualStyleBackColor = false;
            this.btnSunet.Click += new System.EventHandler(this.btnSunet_Click);
            // 
            // Reguli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Macao_Rewritten.Properties.Resources.fereastra;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.btnSunet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIesire);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reguli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reguli";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIesire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSunet;
    }
}