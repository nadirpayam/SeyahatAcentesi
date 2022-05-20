
namespace SeyahatAcentesi
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.buttonOgrenciGiris = new System.Windows.Forms.Button();
            this.buttonUyeOl = new System.Windows.Forms.Button();
            this.labelAnasayfa = new System.Windows.Forms.Label();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOgrenciGiris
            // 
            this.buttonOgrenciGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOgrenciGiris.BackgroundImage")));
            this.buttonOgrenciGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOgrenciGiris.Location = new System.Drawing.Point(247, 207);
            this.buttonOgrenciGiris.Name = "buttonOgrenciGiris";
            this.buttonOgrenciGiris.Size = new System.Drawing.Size(264, 81);
            this.buttonOgrenciGiris.TabIndex = 3;
            this.buttonOgrenciGiris.UseVisualStyleBackColor = true;
            this.buttonOgrenciGiris.Click += new System.EventHandler(this.buttonOgrenciGiris_Click);
            // 
            // buttonUyeOl
            // 
            this.buttonUyeOl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUyeOl.BackgroundImage")));
            this.buttonUyeOl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUyeOl.Location = new System.Drawing.Point(247, 325);
            this.buttonUyeOl.Name = "buttonUyeOl";
            this.buttonUyeOl.Size = new System.Drawing.Size(264, 81);
            this.buttonUyeOl.TabIndex = 2;
            this.buttonUyeOl.UseVisualStyleBackColor = true;
            this.buttonUyeOl.Click += new System.EventHandler(this.buttonUyeOl_Click);
            // 
            // labelAnasayfa
            // 
            this.labelAnasayfa.BackColor = System.Drawing.Color.Transparent;
            this.labelAnasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAnasayfa.ForeColor = System.Drawing.Color.White;
            this.labelAnasayfa.Location = new System.Drawing.Point(24, 76);
            this.labelAnasayfa.Name = "labelAnasayfa";
            this.labelAnasayfa.Size = new System.Drawing.Size(734, 92);
            this.labelAnasayfa.TabIndex = 37;
            this.labelAnasayfa.Text = "SEYAHAT ACENTESİ";
            this.labelAnasayfa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackColor = System.Drawing.Color.Transparent;
            this.buttonCikis.FlatAppearance.BorderSize = 0;
            this.buttonCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCikis.Font = new System.Drawing.Font("Constantia", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCikis.ForeColor = System.Drawing.Color.Maroon;
            this.buttonCikis.Location = new System.Drawing.Point(712, 11);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(85, 76);
            this.buttonCikis.TabIndex = 38;
            this.buttonCikis.Text = "X";
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.labelAnasayfa);
            this.Controls.Add(this.buttonOgrenciGiris);
            this.Controls.Add(this.buttonUyeOl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Anasayfa";
            this.Text = "Form1";
            
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOgrenciGiris;
        private System.Windows.Forms.Button buttonUyeOl;
        private System.Windows.Forms.Label labelAnasayfa;
        private System.Windows.Forms.Button buttonCikis;
    }
}

