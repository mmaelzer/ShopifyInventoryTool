namespace ShopifyInventoryTool
{
    partial class MainForm
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
            this._splitContainer = new System.Windows.Forms.SplitContainer();
            this._addTagButton = new System.Windows.Forms.Button();
            this._addTypeButton = new System.Windows.Forms.Button();
            this._addVendorButton = new System.Windows.Forms.Button();
            this._productPriceTb = new System.Windows.Forms.TextBox();
            this._productPriceLabel = new System.Windows.Forms.Label();
            this._imageUrlLabel = new System.Windows.Forms.Label();
            this._tagsCLB = new System.Windows.Forms.CheckedListBox();
            this._imageUrlTb = new System.Windows.Forms.TextBox();
            this._saveProductButton = new System.Windows.Forms.Button();
            this._typeComboBox = new System.Windows.Forms.ComboBox();
            this._vendorComboBox = new System.Windows.Forms.ComboBox();
            this._tagsLabel = new System.Windows.Forms.Label();
            this._typeLabel = new System.Windows.Forms.Label();
            this._vendorLabel = new System.Windows.Forms.Label();
            this._productDescTb = new System.Windows.Forms.RichTextBox();
            this._productDescLabel = new System.Windows.Forms.Label();
            this._productNameTb = new System.Windows.Forms.TextBox();
            this._productNameLabel = new System.Windows.Forms.Label();
            this._vertSplitContainer = new System.Windows.Forms.SplitContainer();
            this._dataGrid = new System.Windows.Forms.DataGridView();
            this._handleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._titleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._bodyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._vendorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._tagsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._imageSrcColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._numProductsLabel = new System.Windows.Forms.Label();
            this._numProductCountLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this._fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromCsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).BeginInit();
            this._splitContainer.Panel1.SuspendLayout();
            this._splitContainer.Panel2.SuspendLayout();
            this._splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._vertSplitContainer)).BeginInit();
            this._vertSplitContainer.Panel1.SuspendLayout();
            this._vertSplitContainer.Panel2.SuspendLayout();
            this._vertSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _splitContainer
            // 
            this._splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this._splitContainer.Location = new System.Drawing.Point(0, 24);
            this._splitContainer.Name = "_splitContainer";
            // 
            // _splitContainer.Panel1
            // 
            this._splitContainer.Panel1.Controls.Add(this._addTagButton);
            this._splitContainer.Panel1.Controls.Add(this._addTypeButton);
            this._splitContainer.Panel1.Controls.Add(this._addVendorButton);
            this._splitContainer.Panel1.Controls.Add(this._productPriceTb);
            this._splitContainer.Panel1.Controls.Add(this._productPriceLabel);
            this._splitContainer.Panel1.Controls.Add(this._imageUrlLabel);
            this._splitContainer.Panel1.Controls.Add(this._tagsCLB);
            this._splitContainer.Panel1.Controls.Add(this._imageUrlTb);
            this._splitContainer.Panel1.Controls.Add(this._saveProductButton);
            this._splitContainer.Panel1.Controls.Add(this._typeComboBox);
            this._splitContainer.Panel1.Controls.Add(this._vendorComboBox);
            this._splitContainer.Panel1.Controls.Add(this._tagsLabel);
            this._splitContainer.Panel1.Controls.Add(this._typeLabel);
            this._splitContainer.Panel1.Controls.Add(this._vendorLabel);
            this._splitContainer.Panel1.Controls.Add(this._productDescTb);
            this._splitContainer.Panel1.Controls.Add(this._productDescLabel);
            this._splitContainer.Panel1.Controls.Add(this._productNameTb);
            this._splitContainer.Panel1.Controls.Add(this._productNameLabel);
            // 
            // _splitContainer.Panel2
            // 
            this._splitContainer.Panel2.Controls.Add(this._vertSplitContainer);
            this._splitContainer.Size = new System.Drawing.Size(984, 543);
            this._splitContainer.SplitterDistance = 301;
            this._splitContainer.TabIndex = 1;
            // 
            // _addTagButton
            // 
            this._addTagButton.Location = new System.Drawing.Point(240, 355);
            this._addTagButton.Name = "_addTagButton";
            this._addTagButton.Size = new System.Drawing.Size(49, 21);
            this._addTagButton.TabIndex = 23;
            this._addTagButton.Text = "add";
            this._addTagButton.UseVisualStyleBackColor = true;
            this._addTagButton.Click += new System.EventHandler(this.addTagButton_Click);
            // 
            // _addTypeButton
            // 
            this._addTypeButton.Location = new System.Drawing.Point(240, 307);
            this._addTypeButton.Name = "_addTypeButton";
            this._addTypeButton.Size = new System.Drawing.Size(49, 21);
            this._addTypeButton.TabIndex = 22;
            this._addTypeButton.Text = "add";
            this._addTypeButton.UseVisualStyleBackColor = true;
            this._addTypeButton.Click += new System.EventHandler(this.addTypeButton_Click);
            // 
            // _addVendorButton
            // 
            this._addVendorButton.Location = new System.Drawing.Point(240, 261);
            this._addVendorButton.Name = "_addVendorButton";
            this._addVendorButton.Size = new System.Drawing.Size(49, 21);
            this._addVendorButton.TabIndex = 21;
            this._addVendorButton.Text = "add";
            this._addVendorButton.UseVisualStyleBackColor = true;
            this._addVendorButton.Click += new System.EventHandler(this.addVendorButton_Click);
            // 
            // _productPriceTb
            // 
            this._productPriceTb.Location = new System.Drawing.Point(12, 218);
            this._productPriceTb.Name = "_productPriceTb";
            this._productPriceTb.Size = new System.Drawing.Size(278, 20);
            this._productPriceTb.TabIndex = 20;
            // 
            // _productPriceLabel
            // 
            this._productPriceLabel.AutoSize = true;
            this._productPriceLabel.Location = new System.Drawing.Point(8, 202);
            this._productPriceLabel.Name = "_productPriceLabel";
            this._productPriceLabel.Size = new System.Drawing.Size(31, 13);
            this._productPriceLabel.TabIndex = 19;
            this._productPriceLabel.Text = "Price";
            // 
            // _imageUrlLabel
            // 
            this._imageUrlLabel.AutoSize = true;
            this._imageUrlLabel.Location = new System.Drawing.Point(10, 457);
            this._imageUrlLabel.Name = "_imageUrlLabel";
            this._imageUrlLabel.Size = new System.Drawing.Size(61, 13);
            this._imageUrlLabel.TabIndex = 2;
            this._imageUrlLabel.Text = "Image URL";
            // 
            // _tagsCLB
            // 
            this._tagsCLB.FormattingEnabled = true;
            this._tagsCLB.Location = new System.Drawing.Point(11, 355);
            this._tagsCLB.Name = "_tagsCLB";
            this._tagsCLB.Size = new System.Drawing.Size(222, 94);
            this._tagsCLB.TabIndex = 18;
            // 
            // _imageUrlTb
            // 
            this._imageUrlTb.Location = new System.Drawing.Point(11, 473);
            this._imageUrlTb.Name = "_imageUrlTb";
            this._imageUrlTb.Size = new System.Drawing.Size(278, 20);
            this._imageUrlTb.TabIndex = 3;
            // 
            // _saveProductButton
            // 
            this._saveProductButton.Location = new System.Drawing.Point(164, 509);
            this._saveProductButton.Name = "_saveProductButton";
            this._saveProductButton.Size = new System.Drawing.Size(125, 23);
            this._saveProductButton.TabIndex = 16;
            this._saveProductButton.Text = "Update Product";
            this._saveProductButton.UseVisualStyleBackColor = true;
            this._saveProductButton.Click += new System.EventHandler(this.saveProductButton_Click);
            // 
            // _typeComboBox
            // 
            this._typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._typeComboBox.FormattingEnabled = true;
            this._typeComboBox.Location = new System.Drawing.Point(12, 307);
            this._typeComboBox.Name = "_typeComboBox";
            this._typeComboBox.Size = new System.Drawing.Size(221, 21);
            this._typeComboBox.Sorted = true;
            this._typeComboBox.TabIndex = 14;
            // 
            // _vendorComboBox
            // 
            this._vendorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._vendorComboBox.FormattingEnabled = true;
            this._vendorComboBox.Location = new System.Drawing.Point(12, 261);
            this._vendorComboBox.Name = "_vendorComboBox";
            this._vendorComboBox.Size = new System.Drawing.Size(221, 21);
            this._vendorComboBox.Sorted = true;
            this._vendorComboBox.TabIndex = 13;
            // 
            // _tagsLabel
            // 
            this._tagsLabel.AutoSize = true;
            this._tagsLabel.Location = new System.Drawing.Point(7, 339);
            this._tagsLabel.Name = "_tagsLabel";
            this._tagsLabel.Size = new System.Drawing.Size(31, 13);
            this._tagsLabel.TabIndex = 12;
            this._tagsLabel.Text = "Tags";
            // 
            // _typeLabel
            // 
            this._typeLabel.AutoSize = true;
            this._typeLabel.Location = new System.Drawing.Point(8, 288);
            this._typeLabel.Name = "_typeLabel";
            this._typeLabel.Size = new System.Drawing.Size(31, 13);
            this._typeLabel.TabIndex = 10;
            this._typeLabel.Text = "Type";
            // 
            // _vendorLabel
            // 
            this._vendorLabel.AutoSize = true;
            this._vendorLabel.Location = new System.Drawing.Point(8, 244);
            this._vendorLabel.Name = "_vendorLabel";
            this._vendorLabel.Size = new System.Drawing.Size(41, 13);
            this._vendorLabel.TabIndex = 8;
            this._vendorLabel.Text = "Vendor";
            // 
            // _productDescTb
            // 
            this._productDescTb.Location = new System.Drawing.Point(12, 62);
            this._productDescTb.Name = "_productDescTb";
            this._productDescTb.Size = new System.Drawing.Size(278, 132);
            this._productDescTb.TabIndex = 7;
            this._productDescTb.Text = "";
            // 
            // _productDescLabel
            // 
            this._productDescLabel.AutoSize = true;
            this._productDescLabel.Location = new System.Drawing.Point(9, 46);
            this._productDescLabel.Name = "_productDescLabel";
            this._productDescLabel.Size = new System.Drawing.Size(100, 13);
            this._productDescLabel.TabIndex = 6;
            this._productDescLabel.Text = "Product Description";
            // 
            // _productNameTb
            // 
            this._productNameTb.Location = new System.Drawing.Point(12, 22);
            this._productNameTb.Name = "_productNameTb";
            this._productNameTb.Size = new System.Drawing.Size(279, 20);
            this._productNameTb.TabIndex = 5;
            // 
            // _productNameLabel
            // 
            this._productNameLabel.AutoSize = true;
            this._productNameLabel.Location = new System.Drawing.Point(9, 6);
            this._productNameLabel.Name = "_productNameLabel";
            this._productNameLabel.Size = new System.Drawing.Size(75, 13);
            this._productNameLabel.TabIndex = 4;
            this._productNameLabel.Text = "Product Name";
            // 
            // _vertSplitContainer
            // 
            this._vertSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._vertSplitContainer.Location = new System.Drawing.Point(0, 0);
            this._vertSplitContainer.Name = "_vertSplitContainer";
            this._vertSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // _vertSplitContainer.Panel1
            // 
            this._vertSplitContainer.Panel1.Controls.Add(this._dataGrid);
            // 
            // _vertSplitContainer.Panel2
            // 
            this._vertSplitContainer.Panel2.Controls.Add(this._numProductsLabel);
            this._vertSplitContainer.Panel2.Controls.Add(this._numProductCountLabel);
            this._vertSplitContainer.Size = new System.Drawing.Size(679, 543);
            this._vertSplitContainer.SplitterDistance = 497;
            this._vertSplitContainer.TabIndex = 0;
            // 
            // _dataGrid
            // 
            this._dataGrid.AllowUserToAddRows = false;
            this._dataGrid.AllowUserToDeleteRows = false;
            this._dataGrid.AllowUserToResizeRows = false;
            this._dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._handleColumn,
            this._titleColumn,
            this._bodyColumn,
            this._vendorColumn,
            this._priceColumn,
            this._typeColumn,
            this._tagsColumn,
            this._imageSrcColumn});
            this._dataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this._dataGrid.Location = new System.Drawing.Point(0, 0);
            this._dataGrid.Name = "_dataGrid";
            this._dataGrid.RowHeadersVisible = false;
            this._dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dataGrid.ShowEditingIcon = false;
            this._dataGrid.Size = new System.Drawing.Size(679, 494);
            this._dataGrid.TabIndex = 0;
            this._dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            this._dataGrid.SelectionChanged += new System.EventHandler(this.dataGrid_SelectionChanged);
            // 
            // _handleColumn
            // 
            this._handleColumn.HeaderText = "Handle";
            this._handleColumn.Name = "_handleColumn";
            // 
            // _titleColumn
            // 
            this._titleColumn.HeaderText = "Title";
            this._titleColumn.Name = "_titleColumn";
            // 
            // _bodyColumn
            // 
            this._bodyColumn.HeaderText = "Body";
            this._bodyColumn.Name = "_bodyColumn";
            // 
            // _vendorColumn
            // 
            this._vendorColumn.HeaderText = "Vendor";
            this._vendorColumn.Name = "_vendorColumn";
            // 
            // _priceColumn
            // 
            this._priceColumn.HeaderText = "Price";
            this._priceColumn.Name = "_priceColumn";
            // 
            // _typeColumn
            // 
            this._typeColumn.HeaderText = "Type";
            this._typeColumn.Name = "_typeColumn";
            // 
            // _tagsColumn
            // 
            this._tagsColumn.HeaderText = "Tags";
            this._tagsColumn.Name = "_tagsColumn";
            // 
            // _imageSrcColumn
            // 
            this._imageSrcColumn.HeaderText = "Image Src";
            this._imageSrcColumn.Name = "_imageSrcColumn";
            // 
            // _numProductsLabel
            // 
            this._numProductsLabel.AutoSize = true;
            this._numProductsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._numProductsLabel.Location = new System.Drawing.Point(163, 11);
            this._numProductsLabel.Name = "_numProductsLabel";
            this._numProductsLabel.Size = new System.Drawing.Size(18, 20);
            this._numProductsLabel.TabIndex = 1;
            this._numProductsLabel.Text = "0";
            // 
            // _numProductCountLabel
            // 
            this._numProductCountLabel.AutoSize = true;
            this._numProductCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._numProductCountLabel.Location = new System.Drawing.Point(3, 11);
            this._numProductCountLabel.Name = "_numProductCountLabel";
            this._numProductCountLabel.Size = new System.Drawing.Size(154, 20);
            this._numProductCountLabel.TabIndex = 0;
            this._numProductCountLabel.Text = "Number of Products:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileToolStripMenuItem,
            this._importToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // _fileToolStripMenuItem
            // 
            this._fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this._fileToolStripMenuItem.Name = "_fileToolStripMenuItem";
            this._fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this._fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.newToolStripMenuItem.Text = "New...";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // _importToolStripMenuItem
            // 
            this._importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromCsvToolStripMenuItem,
            this.fromImagesToolStripMenuItem});
            this._importToolStripMenuItem.Name = "_importToolStripMenuItem";
            this._importToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this._importToolStripMenuItem.Text = "Import";
            // 
            // fromCsvToolStripMenuItem
            // 
            this.fromCsvToolStripMenuItem.Name = "fromCsvToolStripMenuItem";
            this.fromCsvToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fromCsvToolStripMenuItem.Text = "From csv...";
            this.fromCsvToolStripMenuItem.Click += new System.EventHandler(this.fromCsvToolStripMenuItem_Click);
            // 
            // fromImagesToolStripMenuItem
            // 
            this.fromImagesToolStripMenuItem.Name = "fromImagesToolStripMenuItem";
            this.fromImagesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fromImagesToolStripMenuItem.Text = "From images...";
            this.fromImagesToolStripMenuItem.Click += new System.EventHandler(this.fromImagesToolStripMenuItem_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 567);
            this.Controls.Add(this._splitContainer);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(800, 605);
            this.Name = "MainForm";
            this.Text = "Shopify Inventory Utility";
            this._splitContainer.Panel1.ResumeLayout(false);
            this._splitContainer.Panel1.PerformLayout();
            this._splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).EndInit();
            this._splitContainer.ResumeLayout(false);
            this._vertSplitContainer.Panel1.ResumeLayout(false);
            this._vertSplitContainer.Panel2.ResumeLayout(false);
            this._vertSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._vertSplitContainer)).EndInit();
            this._vertSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer _splitContainer;
        private System.Windows.Forms.Label _tagsLabel;
        private System.Windows.Forms.Label _typeLabel;
        private System.Windows.Forms.Label _vendorLabel;
        private System.Windows.Forms.RichTextBox _productDescTb;
        private System.Windows.Forms.Label _productDescLabel;
        private System.Windows.Forms.TextBox _productNameTb;
        private System.Windows.Forms.Label _productNameLabel;
        private System.Windows.Forms.TextBox _imageUrlTb;
        private System.Windows.Forms.Label _imageUrlLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem _fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button _saveProductButton;
        private System.Windows.Forms.ComboBox _typeComboBox;
        private System.Windows.Forms.ComboBox _vendorComboBox;
        private System.Windows.Forms.SplitContainer _vertSplitContainer;
        private System.Windows.Forms.DataGridView _dataGrid;
        private System.Windows.Forms.CheckedListBox _tagsCLB;
        private System.Windows.Forms.DataGridViewTextBoxColumn _handleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _titleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _bodyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _vendorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _typeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _tagsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _imageSrcColumn;
        private System.Windows.Forms.TextBox _productPriceTb;
        private System.Windows.Forms.Label _productPriceLabel;
        private System.Windows.Forms.ToolStripMenuItem _importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromCsvToolStripMenuItem;
        private System.Windows.Forms.Label _numProductsLabel;
        private System.Windows.Forms.Label _numProductCountLabel;
        private System.Windows.Forms.Button _addTypeButton;
        private System.Windows.Forms.Button _addVendorButton;
        private System.Windows.Forms.Button _addTagButton;
        private System.Windows.Forms.ToolStripMenuItem fromImagesToolStripMenuItem;
    }
}

