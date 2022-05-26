
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
            this.buttonRezYap = new System.Windows.Forms.Button();
            this.buttonRezlerim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRezYap
            // 
            this.buttonRezYap.Location = new System.Drawing.Point(84, 47);
            this.buttonRezYap.Name = "buttonRezYap";
            this.buttonRezYap.Size = new System.Drawing.Size(208, 138);
            this.buttonRezYap.TabIndex = 0;
            this.buttonRezYap.Text = "rez yap";
            this.buttonRezYap.UseVisualStyleBackColor = true;
            this.buttonRezYap.Click += new System.EventHandler(this.buttonRezYap_Click);
            // 
            // buttonRezlerim
            // 
            this.buttonRezlerim.Location = new System.Drawing.Point(370, 47);
            this.buttonRezlerim.Name = "buttonRezlerim";
            this.buttonRezlerim.Size = new System.Drawing.Size(208, 138);
            this.buttonRezlerim.TabIndex = 1;
            this.buttonRezlerim.Text = "rezlerim";
            this.buttonRezlerim.UseVisualStyleBackColor = true;
            this.buttonRezlerim.Click += new System.EventHandler(this.buttonRezlerim_Click);
            // 
            // KullaniciAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRezlerim);
            this.Controls.Add(this.buttonRezYap);
            this.Name = "KullaniciAnasayfa";
            this.Text = "KullaniciAnasayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRezYap;
        private System.Windows.Forms.Button buttonRezlerim;
    }
}