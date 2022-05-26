
namespace SeyahatAcentesi
{
    partial class RaporAlmak
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
            this.buttonXML = new System.Windows.Forms.Button();
            this.buttonHTML = new System.Windows.Forms.Button();
            this.buttonJSON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonXML
            // 
            this.buttonXML.Location = new System.Drawing.Point(61, 34);
            this.buttonXML.Name = "buttonXML";
            this.buttonXML.Size = new System.Drawing.Size(224, 116);
            this.buttonXML.TabIndex = 0;
            this.buttonXML.Text = "XML";
            this.buttonXML.UseVisualStyleBackColor = true;
            // 
            // buttonHTML
            // 
            this.buttonHTML.Location = new System.Drawing.Point(61, 215);
            this.buttonHTML.Name = "buttonHTML";
            this.buttonHTML.Size = new System.Drawing.Size(224, 116);
            this.buttonHTML.TabIndex = 1;
            this.buttonHTML.Text = "HTML";
            this.buttonHTML.UseVisualStyleBackColor = true;
            // 
            // buttonJSON
            // 
            this.buttonJSON.Location = new System.Drawing.Point(61, 406);
            this.buttonJSON.Name = "buttonJSON";
            this.buttonJSON.Size = new System.Drawing.Size(224, 116);
            this.buttonJSON.TabIndex = 2;
            this.buttonJSON.Text = "JSON";
            this.buttonJSON.UseVisualStyleBackColor = true;
            // 
            // RaporAlmak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 595);
            this.Controls.Add(this.buttonJSON);
            this.Controls.Add(this.buttonHTML);
            this.Controls.Add(this.buttonXML);
            this.Name = "RaporAlmak";
            this.Text = "RaporAlmak";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonXML;
        private System.Windows.Forms.Button buttonHTML;
        private System.Windows.Forms.Button buttonJSON;
    }
}