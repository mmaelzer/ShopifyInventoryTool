using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ShopifyInventoryTool
{
    public partial class MainForm : Form
    {
        #region Fields

        private readonly ShopifyData _shopifyData;

        #endregion

        #region Lifetime

        public MainForm()
        {
            _shopifyData = ShopifyData.Instance;
            InitializeComponent();
            _splitContainer.Enabled = false;
            _importToolStripMenuItem.Enabled = false;
        }

        #endregion

        #region Private Methods

        private void clearControls()
        {
            _productNameTb.Text = string.Empty;
            _productDescTb.Text = string.Empty;
            _productPriceTb.Text = string.Empty;
            _vendorComboBox.Items.Clear();
            _typeComboBox.Items.Clear();
            _tagsCLB.Items.Clear();
            _imageUrlTb.Text = string.Empty;
        }

        private void clearDataGrid()
        {
            _dataGrid.Rows.Clear();
            _numProductsLabel.Text = "0";
        }

        private void clearTagsClb()
        {
            for (var i = 0; i < _tagsCLB.Items.Count; i++)
            {
                _tagsCLB.SetItemChecked(i, false);
            }
        }

        private void enableControls()
        {
            _splitContainer.Enabled = true;
            _importToolStripMenuItem.Enabled = true;
        }

        private void populateDetailsPanel(IEnumerable<ShopifyProduct> products)
        {
            _productNameTb.Text = products.Select(p => p.Title).Distinct().Count() == 1 ? products.Select(p => p.Title).Distinct().FirstOrDefault() : string.Empty;
            _productDescTb.Text = products.Select(p => p.Details).Distinct().Count() == 1 ? products.Select(p => p.Details).Distinct().FirstOrDefault() : string.Empty;
            _productPriceTb.Text = products.Select(p => p.Price).Distinct().Count() == 1 ? products.Select(p => p.Price).Distinct().FirstOrDefault() : string.Empty;
            _vendorComboBox.SelectedItem = products.Select(p => p.Vendor).Distinct().Count() == 1 ? products.Select(p => p.Vendor).Distinct().FirstOrDefault() : string.Empty;
            _typeComboBox.SelectedItem = products.Select(p => p.Type).Distinct().Count() == 1 ? products.Select(p => p.Type).Distinct().FirstOrDefault() : string.Empty;
            _imageUrlTb.Text = products.Select(p => p.ImageSource).Distinct().Count() == 1 ? products.Select(p => p.ImageSource).FirstOrDefault() : string.Empty;
            clearTagsClb();

            if (products.Select(p => p.Tags).Distinct().Count() == 1)
            {
                foreach (var tag in products.Select(p => p.Tags).Distinct().FirstOrDefault())
                {
                    for (var i = 0; i < _tagsCLB.Items.Count; i++)
                    {
                        if ((string) _tagsCLB.Items[i] == tag)
                        {
                            _tagsCLB.SetItemChecked(i, true);
                        }
                    }
                }
            }
        }

        private void populateControls()
        {
            _vendorComboBox.Items.Clear();
            _vendorComboBox.Items.Add("");

            _typeComboBox.Items.Clear();
            _typeComboBox.Items.Add("");

            _tagsCLB.Items.Clear();

            foreach (var vendor in _shopifyData.Vendors)
            {
                _vendorComboBox.Items.Add(vendor);
            }
            foreach (var type in _shopifyData.Types)
            {
                _typeComboBox.Items.Add(type);
            }
            foreach (var tag in _shopifyData.Tags)
            {
                _tagsCLB.Items.Add(tag);
            }
        }

        private void populateDataGrid()
        {
            foreach (var product in _shopifyData.Products)
            {
                _dataGrid.Rows.Add(product.Handle, product.Title, product.Details, product.Vendor, product.Price, product.Type,
                                   string.Join(", ", product.Tags), product.ImageSource);
            }

            _numProductsLabel.Text = _shopifyData.Products.Count().ToString();
        }

        private void populateDetailsPanel(ShopifyProduct product)
        {
            _productNameTb.Text = product.Title;
            _productDescTb.Text = product.Details;
            _productPriceTb.Text = product.Price;
            _vendorComboBox.SelectedItem = product.Vendor;
            _typeComboBox.SelectedItem = product.Type;
            _imageUrlTb.Text = product.ImageSource;
            clearTagsClb();

            foreach (var tag in product.Tags)
            {
                for (var i = 0; i < _tagsCLB.Items.Count; i++)
                {
                    if ((string)_tagsCLB.Items[i] == tag)
                    {
                        _tagsCLB.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void productSelected()
        {
            if (_dataGrid.SelectedRows.Count == 1)
            {
                populateDetailsPanel(_shopifyData.GetProduct((string)_dataGrid.SelectedRows[0].Cells[0].Value));
            }
            if (_dataGrid.SelectedRows.Count > 1)
            {
                var products = new List<ShopifyProduct>();
                for (var i = 0; i < _dataGrid.SelectedRows.Count; i++)
                {
                    products.Add(_shopifyData.GetProduct((string)_dataGrid.SelectedRows[i].Cells[0].Value));
                }
                populateDetailsPanel(products);
            }
        }

        private void getCsvDataAndPopulate()
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "Comma Seperated Values Files (.csv)|*.csv";
                dialog.Title = "Open File";
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    if (!_shopifyData.ReadData(dialog.FileName))
                    {
                        MessageBox.Show(string.Format("Failed to read file '{0}'", dialog.FileName), "Failure");
                    }
                }
            }
            enableControls();
            updateControls();
        }

        private void updateControls()
        {
            _dataGrid.Rows.Clear();
            populateDataGrid();
            populateControls();
        }

        private void refreshDataGrid()
        {
            _dataGrid.Rows.Clear();
            populateDataGrid();
        }

        #endregion

        #region Event Handlers

        private void addVendorButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new AddItemDialog())
            {
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    _vendorComboBox.Items.Add(dialog.ItemName);
                }
            }
        }

        private void addTagButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new AddItemDialog())
            {
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    _tagsCLB.Items.Add(dialog.ItemName);
                }
            }
        }

        private void addTypeButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new AddItemDialog())
            {
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    _typeComboBox.Items.Add(dialog.ItemName);
                }
            }
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productSelected();
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            productSelected();
        }

        private void fromImagesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            using (var dialog = new ImportImagesAndDetailsDialog())
            {
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    var importData = ShopifyImportHelper.GetImportData(dialog.ImagePath);
                    _shopifyData.ImportDataFromImages(dialog.ImagePath, importData);

                    foreach (var dir in Directory.GetDirectories(dialog.ImagePath, "*", SearchOption.AllDirectories))
                    {
                        importData = ShopifyImportHelper.GetImportData(dir);
                        _shopifyData.ImportDataFromImages(dir, importData);
                    }
                    updateControls();
                }
            }
        }

        private void fromCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getCsvDataAndPopulate();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _shopifyData.NewData();
            enableControls();
            clearControls();
            clearDataGrid();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getCsvDataAndPopulate();
        }

        private void saveProductButton_Click(object sender, EventArgs e)
        {
            var products = new List<ShopifyProduct>();

            if (_dataGrid.SelectedRows.Count == 1)
            {
                products.Add(_shopifyData.GetProduct((string)_dataGrid.SelectedRows[0].Cells[0].Value));
            }
            if (_dataGrid.SelectedRows.Count > 1)
            {
                for (var i = 0; i < _dataGrid.SelectedRows.Count; i++)
                {
                    products.Add(_shopifyData.GetProduct((string)_dataGrid.SelectedRows[i].Cells[0].Value));
                }
            }

            updateProducts(products);
            refreshDataGrid();
        }

        private void updateProducts(List<ShopifyProduct> products)
        {
            foreach (var product in products)
            {
                if (products.Count == 1)
                {
                    product.Title = _productNameTb.Text;
                    product.ImageSource = _imageUrlTb.Text;
                }

                if (!string.IsNullOrEmpty(_productDescTb.Text))
                {
                    product.Details = _productDescTb.Text; 
                }
                if (!string.IsNullOrEmpty(_productPriceTb.Text))
                {
                    product.Price = _productPriceTb.Text;
                }
                if (!string.IsNullOrEmpty((string)_vendorComboBox.SelectedItem))
                {
                    product.Vendor = (string)_vendorComboBox.SelectedItem;
                }
                if (!string.IsNullOrEmpty((string)_typeComboBox.SelectedItem))
                {
                    product.Type = (string)_typeComboBox.SelectedItem;
                }
                product.Tags = _tagsCLB.CheckedItems.Cast<string>().ToArray();
            }

            _shopifyData.UpdateData(products);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.FileName = "Products.csv";
                dialog.Filter = "Comma Seperated Values Files (.csv)|*.csv";
                dialog.Title = "Save File";
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    if (_shopifyData.SaveData(dialog.FileName))
                    {
                        MessageBox.Show(string.Format("Successfully saved file '{0}'", dialog.FileName), "Success");
                    }
                    else
                    {
                        MessageBox.Show(string.Format("Failed to save file '{0}'", dialog.FileName), "Failure");
                    }
                }
            }
        }

        #endregion
    }
}
