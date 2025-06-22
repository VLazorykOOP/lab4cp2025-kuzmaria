using System;
using System.Windows.Forms;

namespace FurnitureAppVS9
{
    public partial class SearchForm : Form
    {
        public string SearchText { get; private set; }

        public SearchForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchText = txtSearch.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
