namespace ShopifyInventoryTool
{
    partial class ImportImagesAndDetailsDialog
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
            this._locationTb = new System.Windows.Forms.TextBox();
            this._browseButton = new System.Windows.Forms.Button();
            this._locationLabel = new System.Windows.Forms.Label();
            this._importButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _locationTb
            // 
            this._locationTb.Location = new System.Drawing.Point(12, 28);
            this._locationTb.Name = "_locationTb";
            this._locationTb.ReadOnly = true;
            this._locationTb.Size = new System.Drawing.Size(283, 20);
            this._locationTb.TabIndex = 0;
            // 
            // _browseButton
            // 
            this._browseButton.Location = new System.Drawing.Point(301, 25);
            this._browseButton.Name = "_browseButton";
            this._browseButton.Size = new System.Drawing.Size(75, 23);
            this._browseButton.TabIndex = 11;
            this._browseButton.Text = "Browse...";
            this._browseButton.UseVisualStyleBackColor = true;
            this._browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // _locationLabel
            // 
            this._locationLabel.AutoSize = true;
            this._locationLabel.Location = new System.Drawing.Point(13, 12);
            this._locationLabel.Name = "_locationLabel";
            this._locationLabel.Size = new System.Drawing.Size(96, 13);
            this._locationLabel.TabIndex = 6;
            this._locationLabel.Text = "Location of images";
            // 
            // _importButton
            // 
            this._importButton.Location = new System.Drawing.Point(301, 64);
            this._importButton.Name = "_importButton";
            this._importButton.Size = new System.Drawing.Size(75, 23);
            this._importButton.TabIndex = 10;
            this._importButton.Text = "Import";
            this._importButton.UseVisualStyleBackColor = true;
            this._importButton.Click += new System.EventHandler(this._importButton_Click);
            // 
            // ImportImagesAndDetailsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 101);
            this.Controls.Add(this._importButton);
            this.Controls.Add(this._locationLabel);
            this.Controls.Add(this._browseButton);
            this.Controls.Add(this._locationTb);
            this.Name = "ImportImagesAndDetailsDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import Data from Images";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _locationTb;
        private System.Windows.Forms.Button _browseButton;
        private System.Windows.Forms.Label _locationLabel;
        private System.Windows.Forms.Button _importButton;
    }
}