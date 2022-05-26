
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
            this.dataGridViewRezlerim = new System.Windows.Forms.DataGridView();
            this.buttonRezİptal = new System.Windows.Forms.Button();
            this.buttonUlasim = new System.Windows.Forms.Button();
            this.buttonKonak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezlerim)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRezlerim
            // 
            this.dataGridViewRezlerim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRezlerim.Location = new System.Drawing.Point(55, 31);
            this.dataGridViewRezlerim.Name = "dataGridViewRezlerim";
            this.dataGridViewRezlerim.RowHeadersWidth = 51;
            this.dataGridViewRezlerim.RowTemplate.Height = 24;
            this.dataGridViewRezlerim.Size = new System.Drawing.Size(572, 181);
            this.dataGridViewRezlerim.TabIndex = 0;
            // 
            // buttonRezİptal
            // 
            this.buttonRezİptal.Location = new System.Drawing.Point(64, 240);
            this.buttonRezİptal.Name = "buttonRezİptal";
            this.buttonRezİptal.Size = new System.Drawing.Size(136, 67);
            this.buttonRezİptal.TabIndex = 1;
            this.buttonRezİptal.Text = "rez iptale t";
            this.buttonRezİptal.UseVisualStyleBackColor = true;
            // 
            // buttonUlasim
            // 
            this.buttonUlasim.Location = new System.Drawing.Point(235, 240);
            this.buttonUlasim.Name = "buttonUlasim";
            this.buttonUlasim.Size = new System.Drawing.Size(136, 67);
            this.buttonUlasim.TabIndex = 2;
            this.buttonUlasim.Text = "ulaism iptal et";
            this.buttonUlasim.UseVisualStyleBackColor = true;
            // 
            // buttonKonak
            // 
            this.buttonKonak.Location = new System.Drawing.Point(399, 240);
            this.buttonKonak.Name = "buttonKonak";
            this.buttonKonak.Size = new System.Drawing.Size(136, 67);
            this.buttonKonak.TabIndex = 3;
            this.buttonKonak.Text = "konaklama iptal et";
            this.buttonKonak.UseVisualStyleBackColor = true;
            // 
            // Rezarvasyonlarim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonKonak);
            this.Controls.Add(this.buttonUlasim);
            this.Controls.Add(this.buttonRezİptal);
            this.Controls.Add(this.dataGridViewRezlerim);
            this.Name = "Rezarvasyonlarim";
            this.Text = "Rezarvasyonlarim";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezlerim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRezlerim;
        private System.Windows.Forms.Button buttonRezİptal;
        private System.Windows.Forms.Button buttonUlasim;
        private System.Windows.Forms.Button buttonKonak;
    }
}