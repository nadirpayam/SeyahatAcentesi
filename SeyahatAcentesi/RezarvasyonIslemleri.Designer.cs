﻿
namespace SeyahatAcentesi
{
    partial class RezarvasyonIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RezarvasyonIslemleri));
            this.buttonCikis = new System.Windows.Forms.Button();
            this.labelUlasim = new System.Windows.Forms.Label();
            this.labelKonaklama = new System.Windows.Forms.Label();
            this.comboBoxUlasim = new System.Windows.Forms.ComboBox();
            this.comboBoxKonaklama = new System.Windows.Forms.ComboBox();
            this.labelbelirle = new System.Windows.Forms.Label();
            this.buttonGonder = new System.Windows.Forms.Button();
            this.dateTimePickerGidis = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDonus = new System.Windows.Forms.DateTimePicker();
            this.labelDonus = new System.Windows.Forms.Label();
            this.labelGidiş = new System.Windows.Forms.Label();
            this.comboBoxLokasyon = new System.Windows.Forms.ComboBox();
            this.labelLokasyon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackColor = System.Drawing.Color.Transparent;
            this.buttonCikis.FlatAppearance.BorderSize = 0;
            this.buttonCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCikis.Font = new System.Drawing.Font("Constantia", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCikis.ForeColor = System.Drawing.Color.Maroon;
            this.buttonCikis.Location = new System.Drawing.Point(774, 12);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(85, 76);
            this.buttonCikis.TabIndex = 39;
            this.buttonCikis.Text = "X";
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // labelUlasim
            // 
            this.labelUlasim.BackColor = System.Drawing.Color.Transparent;
            this.labelUlasim.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUlasim.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelUlasim.Location = new System.Drawing.Point(160, 175);
            this.labelUlasim.Name = "labelUlasim";
            this.labelUlasim.Size = new System.Drawing.Size(138, 37);
            this.labelUlasim.TabIndex = 40;
            this.labelUlasim.Text = "Ulaşım:";
            // 
            // labelKonaklama
            // 
            this.labelKonaklama.BackColor = System.Drawing.Color.Transparent;
            this.labelKonaklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKonaklama.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelKonaklama.Location = new System.Drawing.Point(104, 238);
            this.labelKonaklama.Name = "labelKonaklama";
            this.labelKonaklama.Size = new System.Drawing.Size(194, 37);
            this.labelKonaklama.TabIndex = 41;
            this.labelKonaklama.Text = "Konaklama:";
            // 
            // comboBoxUlasim
            // 
            this.comboBoxUlasim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUlasim.FormattingEnabled = true;
            this.comboBoxUlasim.Items.AddRange(new object[] {
            "Uçak            -   400",
            "Otobüs        -    100"});
            this.comboBoxUlasim.Location = new System.Drawing.Point(304, 175);
            this.comboBoxUlasim.Name = "comboBoxUlasim";
            this.comboBoxUlasim.Size = new System.Drawing.Size(121, 24);
            this.comboBoxUlasim.TabIndex = 42;
            // 
            // comboBoxKonaklama
            // 
            this.comboBoxKonaklama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKonaklama.FormattingEnabled = true;
            this.comboBoxKonaklama.Items.AddRange(new object[] {
            "Otel - 100",
            "Çadır - 50"});
            this.comboBoxKonaklama.Location = new System.Drawing.Point(304, 238);
            this.comboBoxKonaklama.Name = "comboBoxKonaklama";
            this.comboBoxKonaklama.Size = new System.Drawing.Size(121, 24);
            this.comboBoxKonaklama.TabIndex = 43;
            // 
            // labelbelirle
            // 
            this.labelbelirle.BackColor = System.Drawing.Color.Transparent;
            this.labelbelirle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelbelirle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelbelirle.Location = new System.Drawing.Point(53, 120);
            this.labelbelirle.Name = "labelbelirle";
            this.labelbelirle.Size = new System.Drawing.Size(593, 37);
            this.labelbelirle.TabIndex = 44;
            this.labelbelirle.Text = "Lütfen ulaşım tipini ve konaklamak istediğiniz yeri seçiniz";
            // 
            // buttonGonder
            // 
            this.buttonGonder.Location = new System.Drawing.Point(533, 413);
            this.buttonGonder.Name = "buttonGonder";
            this.buttonGonder.Size = new System.Drawing.Size(140, 84);
            this.buttonGonder.TabIndex = 45;
            this.buttonGonder.Text = "Gönder";
            this.buttonGonder.UseVisualStyleBackColor = true;
            this.buttonGonder.Click += new System.EventHandler(this.buttonGonder_Click);
            // 
            // dateTimePickerGidis
            // 
            this.dateTimePickerGidis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerGidis.Location = new System.Drawing.Point(281, 420);
            this.dateTimePickerGidis.Name = "dateTimePickerGidis";
            this.dateTimePickerGidis.Size = new System.Drawing.Size(146, 22);
            this.dateTimePickerGidis.TabIndex = 46;
            // 
            // dateTimePickerDonus
            // 
            this.dateTimePickerDonus.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDonus.Location = new System.Drawing.Point(281, 475);
            this.dateTimePickerDonus.Name = "dateTimePickerDonus";
            this.dateTimePickerDonus.Size = new System.Drawing.Size(146, 22);
            this.dateTimePickerDonus.TabIndex = 47;
            // 
            // labelDonus
            // 
            this.labelDonus.BackColor = System.Drawing.Color.Transparent;
            this.labelDonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDonus.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelDonus.Location = new System.Drawing.Point(81, 467);
            this.labelDonus.Name = "labelDonus";
            this.labelDonus.Size = new System.Drawing.Size(194, 42);
            this.labelDonus.TabIndex = 49;
            this.labelDonus.Text = "Dönüş";
            // 
            // labelGidiş
            // 
            this.labelGidiş.BackColor = System.Drawing.Color.Transparent;
            this.labelGidiş.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGidiş.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelGidiş.Location = new System.Drawing.Point(115, 420);
            this.labelGidiş.Name = "labelGidiş";
            this.labelGidiş.Size = new System.Drawing.Size(138, 32);
            this.labelGidiş.TabIndex = 48;
            this.labelGidiş.Text = "Gidiş";
            // 
            // comboBoxLokasyon
            // 
            this.comboBoxLokasyon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLokasyon.FormattingEnabled = true;
            this.comboBoxLokasyon.Items.AddRange(new object[] {
            "İzmir        -    4",
            "İstanbul     -    5",
            "Ankara       -    6",
            "Gaziantep    -    2",
            "Hatay        -    1",
            "Manisa       -    2",
            "Bolu         -    3",
            "Antalya       -    3"});
            this.comboBoxLokasyon.Location = new System.Drawing.Point(554, 325);
            this.comboBoxLokasyon.Name = "comboBoxLokasyon";
            this.comboBoxLokasyon.Size = new System.Drawing.Size(121, 24);
            this.comboBoxLokasyon.TabIndex = 51;
            // 
            // labelLokasyon
            // 
            this.labelLokasyon.BackColor = System.Drawing.Color.Transparent;
            this.labelLokasyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelLokasyon.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelLokasyon.Location = new System.Drawing.Point(52, 315);
            this.labelLokasyon.Name = "labelLokasyon";
            this.labelLokasyon.Size = new System.Drawing.Size(496, 37);
            this.labelLokasyon.TabIndex = 50;
            this.labelLokasyon.Text = "Hangi şehire gitmek istiyorsunuz?";
            // 
            // RezarvasyonIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(871, 624);
            this.Controls.Add(this.comboBoxLokasyon);
            this.Controls.Add(this.labelLokasyon);
            this.Controls.Add(this.labelDonus);
            this.Controls.Add(this.labelGidiş);
            this.Controls.Add(this.dateTimePickerDonus);
            this.Controls.Add(this.dateTimePickerGidis);
            this.Controls.Add(this.buttonGonder);
            this.Controls.Add(this.labelbelirle);
            this.Controls.Add(this.comboBoxKonaklama);
            this.Controls.Add(this.comboBoxUlasim);
            this.Controls.Add(this.labelKonaklama);
            this.Controls.Add(this.labelUlasim);
            this.Controls.Add(this.buttonCikis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RezarvasyonIslemleri";
            this.Text = "RezarvasyonIslemleri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.Label labelUlasim;
        private System.Windows.Forms.Label labelKonaklama;
        private System.Windows.Forms.ComboBox comboBoxUlasim;
        private System.Windows.Forms.ComboBox comboBoxKonaklama;
        private System.Windows.Forms.Label labelbelirle;
        private System.Windows.Forms.Button buttonGonder;
        private System.Windows.Forms.DateTimePicker dateTimePickerGidis;
        private System.Windows.Forms.DateTimePicker dateTimePickerDonus;
        private System.Windows.Forms.Label labelDonus;
        private System.Windows.Forms.Label labelGidiş;
        private System.Windows.Forms.ComboBox comboBoxLokasyon;
        private System.Windows.Forms.Label labelLokasyon;
    }
}