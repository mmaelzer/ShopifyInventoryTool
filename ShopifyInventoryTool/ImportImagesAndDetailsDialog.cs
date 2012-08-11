using System;
using System.Windows.Forms;

namespace ShopifyInventoryTool
{
    public partial class ImportImagesAndDetailsDialog : Form
    {
        public ImportImagesAndDetailsDialog()
        {
            InitializeComponent();
        }

        public string ImagePath
        {
            get
            {
                return _locationTb.Text;
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    _locationTb.Text = dialog.SelectedPath;
                }
            }
        }

        private void _importButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_locationTb.Text))
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
