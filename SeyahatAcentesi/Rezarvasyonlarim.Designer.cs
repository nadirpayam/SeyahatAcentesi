
namespace SeyahatAcentesi
{
    partial class Rezarvasyonlarim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rezarvasyonlarim));
            this.dataGridViewRezlerim = new System.Windows.Forms.DataGridView();
            this.buttonRezİptal = new System.Windows.Forms.Button();
            this.buttonUlasim = new System.Windows.Forms.Button();
            this.buttonKonak = new System.Windows.Forms.Button();
            this.buttonRapor = new System.Windows.Forms.Button();
            this.buttonCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezlerim)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRezlerim
            // 
            this.dataGridViewRezlerim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRezlerim.Location = new System.Drawing.Point(45, 94);
            this.dataGridViewRezlerim.Name = "dataGridViewRezlerim";
            this.dataGridViewRezlerim.RowHeadersWidth = 51;
            this.dataGridViewRezlerim.RowTemplate.Height = 24;
            this.dataGridViewRezlerim.Size = new System.Drawing.Size(572, 181);
            this.dataGridViewRezlerim.TabIndex = 0;
            // 
            // buttonRezİptal
            // 
            this.buttonRezİptal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRezİptal.BackgroundImage")));
            this.buttonRezİptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRezİptal.Location = new System.Drawing.Point(501, 313);
            this.buttonRezİptal.Name = "buttonRezİptal";
            this.buttonRezİptal.Size = new System.Drawing.Size(136, 67);
            this.buttonRezİptal.TabIndex = 1;
            this.buttonRezİptal.UseVisualStyleBackColor = true;
            this.buttonRezİptal.Click += new System.EventHandler(this.buttonRezİptal_Click);
            // 
            // buttonUlasim
            // 
            this.buttonUlasim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUlasim.BackgroundImage")));
            this.buttonUlasim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUlasim.Location = new System.Drawing.Point(172, 313);
            this.buttonUlasim.Name = "buttonUlasim";
            this.buttonUlasim.Size = new System.Drawing.Size(136, 67);
            this.buttonUlasim.TabIndex = 2;
            this.buttonUlasim.UseVisualStyleBackColor = true;
            this.buttonUlasim.Click += new System.EventHandler(this.buttonUlasim_Click);
            // 
            // buttonKonak
            // 
            this.buttonKonak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonKonak.BackgroundImage")));
            this.buttonKonak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonKonak.Location = new System.Drawing.Point(335, 313);
            this.buttonKonak.Name = "buttonKonak";
            this.buttonKonak.Size = new System.Drawing.Size(136, 67);
            this.buttonKonak.TabIndex = 3;
            this.buttonKonak.UseVisualStyleBackColor = true;
            this.buttonKonak.Click += new System.EventHandler(this.buttonKonak_Click);
            // 
            // buttonRapor
            // 
            this.buttonRapor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRapor.BackgroundImage")));
            this.buttonRapor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRapor.Location = new System.Drawing.Point(3, 306);
            this.buttonRapor.Name = "buttonRapor";
            this.buttonRapor.Size = new System.Drawing.Size(115, 81);
            this.buttonRapor.TabIndex = 4;
            this.buttonRapor.UseVisualStyleBackColor = true;
            this.buttonRapor.Click += new System.EventHandler(this.buttonRapor_Click);
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackColor = System.Drawing.Color.Transparent;
            this.buttonCikis.FlatAppearance.BorderSize = 0;
            this.buttonCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCikis.Font = new System.Drawing.Font("Constantia", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCikis.ForeColor = System.Drawing.Color.Maroon;
            this.buttonCikis.Location = new System.Drawing.Point(600, 12);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(85, 76);
            this.buttonCikis.TabIndex = 39;
            this.buttonCikis.Text = "X";
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // Rezarvasyonlarim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(697, 418);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.buttonRapor);
            this.Controls.Add(this.buttonKonak);
            this.Controls.Add(this.buttonUlasim);
            this.Controls.Add(this.buttonRezİptal);
            this.Controls.Add(this.dataGridViewRezlerim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rezarvasyonlarim";
            this.Text = "Rezarvasyonlarim";
            this.Load += new System.EventHandler(this.Rezarvasyonlarim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezlerim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRezlerim;
        private System.Windows.Forms.Button buttonRezİptal;
        private System.Windows.Forms.Button buttonUlasim;
        private System.Windows.Forms.Button buttonKonak;
        private System.Windows.Forms.Button buttonRapor;
        private System.Windows.Forms.Button buttonCikis;
    }
}