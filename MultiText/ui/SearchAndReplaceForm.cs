using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiText.ui
{
    public partial class SearchAndReplaceForm : Form
    {
        private DocumentProcessor documentProcessor;
        public SearchAndReplaceForm(DocumentProcessor documentProcessor)
        {
            InitializeComponent();
            this.documentProcessor = documentProcessor;
        }

        private void searchNextButton_Click(object sender, EventArgs e)
        {
            if (!isSearchTextEmpty())
            {
                documentProcessor.Search(searchTextBox.Text);
            }
        }

        private void searchAllButton_Click(object sender, EventArgs e)
        {
            // 
            // 暂不实现
            //if (!isSearchTextEmpty())
            //{
            //}
        }

        private bool isSearchTextEmpty()
        {
            return searchTextBox.Text == null || searchTextBox.Text == "";
        }

        private void replaceCurStringButton_Click(object sender, EventArgs e)
        {
            if (!isSearchTextEmpty())
            {
                documentProcessor.Replace(replaceTextBox.Text);
            }
        }

        private void replaceAllStringButton_Click(object sender, EventArgs e)
        {
            // 
            // 暂不实现
        }
    }
}
