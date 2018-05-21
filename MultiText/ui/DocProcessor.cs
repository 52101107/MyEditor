using MultiText.ui;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MultiText
{
    public partial class DocumentProcessor : Form
    {
        #region Component Size Variable
        //
        // formMargin是从窗体试验出来的一个值的一半（我想象成窗体有一个厚度）。
        // 没有具体含义，我也不知道什么意思
        private const int formMargin = 8;                   // 窗体空白

        #endregion

        #region Private Variable

        private int count = 0;
        private int searchPosition;

        private PageSettings pageSettings = new PageSettings();

        #endregion
        public DocumentProcessor()
        {
            InitializeComponent();
            this.tabControlWithCloseButton.TabPages.Remove(tabPageTemplate);

            // 获取标题栏高度
            int formTitleHeight = Height - ClientRectangle.Height + 1;
            // 调整tabControl的大小
            // formMargin是从窗体试验出来的一个值的一半（我想象成窗体有一个厚度）。
            // 没有具体含义，我也不知道什么意思
            tabControlWithCloseButton.Size = new Size(this.Width - 2 * formMargin,
                this.Height - tabControlWithCloseButton.Location.Y -
                tabControlWithCloseButton.ItemSize.Height);
            // 修改模板Size，是为了方便新增RichTextBox
            richTextBoxTemplate.Size = new Size()
            {
                Width = tabControlWithCloseButton.Size.Width,
                Height = tabControlWithCloseButton.Size.Height - 5 * formMargin,
            };
        }

        // 新建文件菜单按钮
        private void newMenuItem_Click(object sender, EventArgs e)
        {
            TabPage newTabPage = new TabPage();
            RichTextBox newRichTextBox = new RichTextBox();

            // 添加选项卡，并设置为当前选中的选项卡
            tabControlWithCloseButton.Controls.Add(newTabPage);
            tabControlWithCloseButton.SelectedTab = newTabPage;
            // 
            // newTabPage
            // 
            newTabPage.Controls.Add(newRichTextBox);
            newTabPage.Location = tabPageTemplate.Location;
            newTabPage.Name = "tabPage" + count;
            newTabPage.Padding = tabPageTemplate.Padding;
            newTabPage.Size = tabPageTemplate.Size;
            newTabPage.TabIndex = count;
            newTabPage.Text = "新建文件.txt";
            newTabPage.UseVisualStyleBackColor = tabPageTemplate.UseVisualStyleBackColor;
            // 
            // newRichTextBox
            // 
            newRichTextBox.Location = richTextBoxTemplate.Location;
            newRichTextBox.Name = "newRichTextBox" + count;
            newRichTextBox.Size = richTextBoxTemplate.Size;
            newRichTextBox.ScrollBars = richTextBoxTemplate.ScrollBars;
            newRichTextBox.WordWrap = richTextBoxTemplate.WordWrap;
            newRichTextBox.TabIndex = count;


            count++;
        }

        // 打开文件菜单按钮
        private void openMenuItem_Click(object sender, EventArgs e)
        {
            // 打开文件对话框
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 新建标签页
                newMenuItem_Click(sender, e);

                // 获取当前选项卡
                TabPage curTabPage = tabControlWithCloseButton.SelectedTab;
                RichTextBox curRichTextBox = ((RichTextBox)curTabPage.Controls[0]);
                curTabPage.Text = Path.GetFileName(openFileDialog.FileName);
                curRichTextBox.Name = openFileDialog.FileName;
                curRichTextBox.Text = File.ReadAllText(openFileDialog.FileName, Encoding.Default);
            }
        }

        // 保存文件菜单按钮
        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            // 获取当前选项卡
            TabPage curTabPage = tabControlWithCloseButton.SelectedTab;
            if (curTabPage != null)
            {
                RichTextBox curRichTextBox = ((RichTextBox)curTabPage.Controls[0]);
                if (curRichTextBox.Text != "")
                {
                    if (curTabPage.Text.Substring(0, 4) == "新建文件")
                    {
                        // 打开保存文件对话框
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = "(*.txt)|*.txt";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            curTabPage.Text = Path.GetFileName(saveFileDialog.FileName);
                            curRichTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                        }
                    }
                    else
                    {
                        // 保存文件
                        curRichTextBox.SaveFile(curRichTextBox.Name, RichTextBoxStreamType.PlainText);
                    }
                }
            }
        }

        // 保存文件为菜单按钮
        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {
            // 获取当前选项卡
            TabPage curTabPage = tabControlWithCloseButton.SelectedTab;
            if (curTabPage != null)
            {
                RichTextBox curRichTextBox = ((RichTextBox)curTabPage.Controls[0]);

                // 打开保存文件对话框
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "(*.txt)|*.txt"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    curTabPage.Text = Path.GetFileName(saveFileDialog.FileName);
                    curRichTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                }
            }
        }

        // 历史记录菜单按钮
        private void historyMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 保存到数据库菜单按钮
        private void saveToDBMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 页面设置菜单按钮
        private void pageSettingMenuItem_Click(object sender, EventArgs e)
        {
            PageSetupDialog pageSetupDialog = new PageSetupDialog();
            pageSetupDialog.PageSettings = pageSettings;
            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                pageSettings = pageSetupDialog.PageSettings;
            }
        }

        // 打印菜单按钮
        private void printMenuItem_Click(object sender, EventArgs e)
        {
            // 打印文档及页面设置
            PrintDocument printDocument = new PrintDocument();
            PageSetupDialog pageSetupDialog = new PageSetupDialog();
            pageSetupDialog.PageSettings = pageSettings;
            pageSetupDialog.Document = printDocument;

            // 获取当前选项卡
            TabPage curTabPage = tabControlWithCloseButton.SelectedTab;
            if (curTabPage != null)
            {
                RichTextBox curRichTextBox = ((RichTextBox)curTabPage.Controls[0]);

            }

            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                printPreviewDialog.Document = printDocument;
                if (printPreviewDialog.ShowDialog() == DialogResult.OK)
                {

                }
            }

        }

        // 退出菜单按钮
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // 撤销菜单按钮
        private void undoMenuItem_Click(object sender, EventArgs e)
        {
            // 获取当前选项卡
            TabPage curTabPage = tabControlWithCloseButton.SelectedTab;
            if (curTabPage != null)
            {
                RichTextBox curRichTextBox = ((RichTextBox)curTabPage.Controls[0]);
                curRichTextBox.Undo();
            }
        }

        // 剪接菜单按钮
        private void cutMenuItem_Click(object sender, EventArgs e)
        {
            // 获取当前选项卡
            TabPage curTabPage = tabControlWithCloseButton.SelectedTab;
            if (curTabPage != null)
            {
                RichTextBox curRichTextBox = ((RichTextBox)curTabPage.Controls[0]);
                curRichTextBox.Cut();
            }
        }

        // 复制菜单按钮
        private void copyMenuItem_Click(object sender, EventArgs e)
        {
            // 获取当前选项卡
            TabPage curTabPage = tabControlWithCloseButton.SelectedTab;
            if (curTabPage != null)
            {
                RichTextBox curRichTextBox = ((RichTextBox)curTabPage.Controls[0]);
                curRichTextBox.Copy();
            }
        }

        // 粘贴菜单按钮
        private void pasteMenuItem_Click(object sender, EventArgs e)
        {
            // 获取当前选项卡
            TabPage curTabPage = tabControlWithCloseButton.SelectedTab;
            if (curTabPage != null)
            {
                RichTextBox curRichTextBox = ((RichTextBox)curTabPage.Controls[0]);
                curRichTextBox.Paste();
            }
        }

        // 删除菜单按钮
        private void deleteMenuItem_Click(object sender, EventArgs e)
        {
            // 获取当前选项卡
            TabPage curTabPage = tabControlWithCloseButton.SelectedTab;
            if (curTabPage != null)
            {
                RichTextBox curRichTextBox = ((RichTextBox)curTabPage.Controls[0]);
                if (curRichTextBox.SelectedText.Length > 0)
                {
                    curRichTextBox.SelectedText = "";
                }
            }
        }

        // 查找菜单按钮
        private void searchMenuItem_Click(object sender, EventArgs e)
        {
            searchPosition = 0;
            SearchAndReplaceForm searchAndReplaceForm = new SearchAndReplaceForm(this);
            searchAndReplaceForm.Show();
        }

        // 替换菜单按钮
        private void replaceMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 全选菜单按钮
        private void allMenuItem_Click(object sender, EventArgs e)
        {
            // 获取当前选项卡
            TabPage curTabPage = tabControlWithCloseButton.SelectedTab;
            if (curTabPage != null)
            {
                RichTextBox curRichTextBox = ((RichTextBox)curTabPage.Controls[0]);
                curRichTextBox.SelectAll();
            }
        }

        // 时间/日期菜单按钮
        private void dateMenuItem_Click(object sender, EventArgs e)
        {
            // 获取当前选项卡
            TabPage curTabPage = tabControlWithCloseButton.SelectedTab;
            if (curTabPage != null)
            {
                RichTextBox curRichTextBox = ((RichTextBox)curTabPage.Controls[0]);
                curRichTextBox.SelectedText = DateTime.Now.ToString();
            }
        }

        // 自动换行菜单按钮
        private void linewrapMenuItem_Click(object sender, EventArgs e)
        {
            // 获取当前选项卡
            TabPage curTabPage = this.tabControlWithCloseButton.SelectedTab;
            if (curTabPage != null)
            {
                RichTextBox curRichTextBox = (RichTextBox)curTabPage.Controls[0];
                curRichTextBox.WordWrap = !curRichTextBox.WordWrap;
            }
        }

        // 字体大小菜单按钮
        private void fontsizeMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                // 获取当前选项卡
                TabPage curTabPage = this.tabControlWithCloseButton.SelectedTab;
                if (curTabPage != null)
                {
                    RichTextBox curRichTextBox = (RichTextBox)curTabPage.Controls[0];

                    // 修改字体
                    curRichTextBox.Font = fontDialog.Font;
                }
            }
        }

        // 字体颜色菜单按钮
        private void fontcolorMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // 获取当前选项卡
                TabPage curTabPage = this.tabControlWithCloseButton.SelectedTab;
                if (curTabPage != null)
                {
                    RichTextBox curRichTextBox = (RichTextBox)curTabPage.Controls[0];

                    // 修改字体颜色
                    curRichTextBox.ForeColor = colorDialog.Color;
                }
            }
        }

        // 状态栏菜单按钮
        private void statusMenuItem_Click(object sender, EventArgs e)
        {
            //
            // 暂不实现
            // 
        }

        // 查看帮助菜单按钮
        private void lookhelpMenuItem_Click(object sender, EventArgs e)
        {
            // 
            // 没有帮助网址，暂不实现
            // 
        }

        // 关于菜单按钮
        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        // 新建文件快捷键按钮
        private void newButton_Click(object sender, EventArgs e)
        {
            newMenuItem_Click(sender, e);
        }

        // 打开文件快捷键按钮
        private void openButton_Click(object sender, EventArgs e)
        {
            openMenuItem_Click(sender, e);
        }

        // 保存文件快捷键按钮
        private void saveButton_Click(object sender, EventArgs e)
        {
            saveMenuItem_Click(sender, e);
        }

        // 复制快捷键按钮
        private void copyButton_Click(object sender, EventArgs e)
        {
            copyMenuItem_Click(sender, e);
        }

        // 粘贴快捷键按钮
        private void pasteButton_Click(object sender, EventArgs e)
        {
            pasteMenuItem_Click(sender, e);
        }

        // 剪接快捷键按钮
        private void cutButton_Click(object sender, EventArgs e)
        {
            cutMenuItem_Click(sender, e);
        }

        // 快捷键事件
        private void menuStrip_KeyDown(object sender, KeyEventArgs e)
        {
            // 新建文件
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.N)
            {
                newMenuItem_Click(sender, e);
            }

            // 保存
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.S)
            {
                saveMenuItem_Click(sender, e);
            }

            // 打开文件
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.O)
            {
                openMenuItem_Click(sender, e);
            }

            // 打印
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.P)
            {
                printMenuItem_Click(sender, e);
            }

            // 撤销
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.Z)
            {
                undoMenuItem_Click(sender, e);
            }

            // 剪接
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.X)
            {
                cutMenuItem_Click(sender, e);
            }

            // 复制
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.C)
            {
                copyMenuItem_Click(sender, e);
            }

            // 粘贴
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.V)
            {
                pasteMenuItem_Click(sender, e);
            }

            // 删除
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.Delete)
            {
                deleteMenuItem_Click(sender, e);
            }

            // 查找
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.F)
            {
                searchMenuItem_Click(sender, e);
            }

            // 替换
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.H)
            {
                replaceMenuItem_Click(sender, e);
            }

            // 全选
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.A)
            {
                allMenuItem_Click(sender, e);
            }

            // 时间/日期
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.F5)
            {
                dateMenuItem_Click(sender, e);
            }
        }

        // 文档修改
        private void DocumentProcessor_SizeChanged(object sender, EventArgs e)
        {
            // 获取标题栏高度
            int formTitleHeight = Height - ClientRectangle.Height + 1;
            // 调整tabControl的大小
            // formMargin是从窗体试验出来的一个值的一半（我想象成窗体有一个厚度）。
            // 没有具体含义，我也不知道什么意思
            tabControlWithCloseButton.Size = new Size(this.Width - 2 * formMargin,
                this.Height - tabControlWithCloseButton.Location.Y -
                tabControlWithCloseButton.ItemSize.Height);
            // 修改模板Size，是为了方便新增RichTextBox
            richTextBoxTemplate.Size = new Size()
            {
                Width = tabControlWithCloseButton.Size.Width,
                Height = tabControlWithCloseButton.Size.Height - 5 * formMargin,
            };

            // 调整每一个文本编辑器大小
            foreach (TabPage tabPage in tabControlWithCloseButton.TabPages)
            {
                ((RichTextBox)tabPage.Controls[0]).Size = richTextBoxTemplate.Size;
            }
        }
        /// <summary>
        /// 查找文本具体实现。
        /// </summary>
        /// <param name="text"></param>
        public void Search(string text)
        {
            TabPage curTabPage = tabControlWithCloseButton.SelectedTab;
            if (curTabPage != null)
            {
                RichTextBox curRichTextBox = ((RichTextBox)curTabPage.Controls[0]);
                searchPosition = curRichTextBox.Find(text, searchPosition, RichTextBoxFinds.MatchCase);

                // 处理查找结果
                // 未查找到匹配字符串
                if (searchPosition == -1)
                {
                    MessageBox.Show("未找到匹配字符串,再次查找将从文本开始处查找",
                        "提示", MessageBoxButtons.OK);
                    searchPosition = 0;
                }
                else
                {
                    curRichTextBox.Focus();
                    searchPosition += text.Length;
                }
            }
        }

        /// <summary>
        /// 替换字符串具体实现
        /// </summary>
        /// <param name="text"></param>
        public void Replace(string text)
        {
            TabPage curTabPage = tabControlWithCloseButton.SelectedTab;
            if (curTabPage != null)
            {
                RichTextBox curRichTextBox = ((RichTextBox)curTabPage.Controls[0]);
                if (curRichTextBox.SelectedText.Length > 0)
                {
                    curRichTextBox.SelectedText = text;
                }
            }
        }
    }
}
