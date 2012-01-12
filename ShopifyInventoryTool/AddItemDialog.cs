using System;
using System.Windows.Forms;

namespace ShopifyInventoryTool
{
    public partial class AddItemDialog : Form
    {
        public AddItemDialog()
        {
            InitializeComponent();
        }

        private void _addButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        public string ItemName
        {
            get
            {
                return _nameTb.Text;
            }
        }
    }
}
