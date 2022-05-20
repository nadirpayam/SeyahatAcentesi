
namespace SeyahatAcentesi
{
    partial class Kullaniciİslemler
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
            this.buttonRezarvasyon = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRezarvasyon
            // 
            this.buttonRezarvasyon.Location = new System.Drawing.Point(71, 136);
            this.buttonRezarvasyon.Name = "buttonRezarvasyon";
            this.buttonRezarvasyon.Size = new System.Drawing.Size(246, 131);
            this.buttonRezarvasyon.TabIndex = 0;
            this.buttonRezarvasyon.Text = "Rezarvasyon Yap";
            this.buttonRezarvasyon.UseVisualStyleBackColor = true;
            this.buttonRezarvasyon.Click += new System.EventHandler(this.buttonRezarvasyon_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(419, 136);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(246, 131);
            this.buttonSil.TabIndex = 1;
            this.buttonSil.Text = "Rezarvasyonlarım";
            this.buttonSil.UseVisualStyleBackColor = true;
            // 
            // Kullaniciİslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonRezarvasyon);
            this.Name = "Kullaniciİslemler";
            this.Text = "Kullaniciİslemler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRezarvasyon;
        private System.Windows.Forms.Button buttonSil;
    }
}