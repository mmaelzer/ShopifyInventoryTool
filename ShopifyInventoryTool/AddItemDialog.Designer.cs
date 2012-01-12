namespace ShopifyInventoryTool
{
    partial class AddItemDialog
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
            this._nameLabel = new System.Windows.Forms.Label();
            this._nameTb = new System.Windows.Forms.TextBox();
            this._addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _nameLabel
            // 
            this._nameLabel.AutoSize = true;
            this._nameLabel.Location = new System.Drawing.Point(11, 16);
            this._nameLabel.Name = "_nameLabel";
            this._nameLabel.Size = new System.Drawing.Size(38, 13);
            this._nameLabel.TabIndex = 0;
            this._nameLabel.Text = "Name:";
            // 
            // _nameTb
            // 
            this._nameTb.Location = new System.Drawing.Point(55, 13);
            this._nameTb.Name = "_nameTb";
            this._nameTb.Size = new System.Drawing.Size(217, 20);
            this._nameTb.TabIndex = 1;
            // 
            // _addButton
            // 
            this._addButton.Location = new System.Drawing.Point(197, 39);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(75, 23);
            this._addButton.TabIndex = 2;
            this._addButton.Text = "Add";
            this._addButton.UseVisualStyleBackColor = true;
            this._addButton.Click += new System.EventHandler(this._addButton_Click);
            // 
            // AddItemDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 72);
            this.Controls.Add(this._addButton);
            this.Controls.Add(this._nameTb);
            this.Controls.Add(this._nameLabel);
            this.Name = "AddItemDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _nameLabel;
        private System.Windows.Forms.TextBox _nameTb;
        private System.Windows.Forms.Button _addButton;
    }
}