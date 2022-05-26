
namespace SeyahatAcentesi
{
    partial class KullaniciAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciAnasayfa));
            this.buttonRezYap = new System.Windows.Forms.Button();
            this.buttonRezlerim = new System.Windows.Forms.Button();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRezYap
            // 
            this.buttonRezYap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRezYap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRezYap.BackgroundImage")));
            this.buttonRezYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRezYap.Location = new System.Drawing.Point(271, 133);
            this.buttonRezYap.Name = "buttonRezYap";
            this.buttonRezYap.Size = new System.Drawing.Size(218, 84);
            this.buttonRezYap.TabIndex = 0;
            this.buttonRezYap.UseVisualStyleBackColor = false;
            this.buttonRezYap.Click += new System.EventHandler(this.buttonRezYap_Click);
            // 
            // buttonRezlerim
            // 
            this.buttonRezlerim.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRezlerim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRezlerim.BackgroundImage")));
            this.buttonRezlerim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRezlerim.Location = new System.Drawing.Point(271, 293);
            this.buttonRezlerim.Name = "buttonRezlerim";
            this.buttonRezlerim.Size = new System.Drawing.Size(218, 84);
            this.buttonRezlerim.TabIndex = 1;
            this.buttonRezlerim.UseVisualStyleBackColor = false;
            this.buttonRezlerim.Click += new System.EventHandler(this.buttonRezlerim_Click);
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackColor = System.Drawing.Color.Transparent;
            this.buttonCikis.FlatAppearance.BorderSize = 0;
            this.buttonCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCikis.Font = new System.Drawing.Font("Constantia", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCikis.ForeColor = System.Drawing.Color.Maroon;
            this.buttonCikis.Location = new System.Drawing.Point(416, 12);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(85, 76);
            this.buttonCikis.TabIndex = 39;
            this.buttonCikis.Text = "X";
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // KullaniciAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(513, 467);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.buttonRezlerim);
            this.Controls.Add(this.buttonRezYap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KullaniciAnasayfa";
            this.Text = "KullaniciAnasayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRezYap;
        private System.Windows.Forms.Button buttonRezlerim;
        private System.Windows.Forms.Button buttonCikis;
    }
}