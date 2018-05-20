using System;
using System.Collections.Generic;
using System.Drawing;
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
        private const int tabControlWithCloseButtonY = 70;  // tabControlWithCloseButton的Y坐标
        private const int tabPageLocationY = 70;            // tabControlWithCloseButton的Y坐标
        private const int tagItemHeight = 20;               // 选项卡Item高度
        private int count = 0;
        #endregion

        #region Private Variable



        #endregion
        public DocumentProcessor()
        {
            InitializeComponent();
            this.tabControlWithCloseButton.TabPages.Remove(tabPageTemplate);
            // 获取标题栏高度
            int formTitleHeight = Height - ClientRectangle.Height + 1;
            // 调整tabControl的大小
            tabControlWithCloseButton.Size = new Size(this.Width - 2 * formMargin,
                this.Height - tabControlWithCloseButton.Location.Y -
                tabControlWithCloseButton.ItemSize.Height - formMargin);
            richTextBoxTemplate.Size = tabPageTemplate.Size;        // 窗体标题栏高度
                                                                    //tabControlWithCloseButton.Controls.Add(tabPageTemplate);

        }

        private void toolStripSeparator5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void DocumentProcessor_KeyDown(object sender, KeyEventArgs e)
        {

        }

        // 新建文件菜单按钮
        private void newMenuItem_Click(object sender, EventArgs e)
        {
            TabPage newTabPage = new TabPage();
            RichTextBox newRichTextBox = new RichTextBox();

            // newTabPage
            tabControlWithCloseButton.Controls.Add(newTabPage);
            // 
            // tabPageTemplate
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
            newRichTextBox.TabIndex = count;


            count++;
        }

        // 打开文件菜单按钮
        private void openMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        // 保存文件菜单按钮
        private void saveMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 保存文件为菜单按钮
        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {

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

        }

        // 打印菜单按钮
        private void printMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 退出菜单按钮
        private void undoMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 剪接菜单按钮
        private void cutMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 复制菜单按钮
        private void copyMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 粘贴菜单按钮
        private void pasteMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 删除菜单按钮
        private void deleteMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 查找菜单按钮
        private void searchMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 替换菜单按钮
        private void replaceMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 全选菜单按钮
        private void allMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 时间/日期菜单按钮
        private void dateMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 自动换行菜单按钮
        private void linewrapMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 字体大小菜单按钮
        private void fontsizeMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 字体颜色菜单按钮
        private void fontcolorMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 状态栏菜单按钮
        private void statusMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 查看帮助菜单按钮
        private void lookhelpMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 关于菜单按钮
        private void aboutMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 新建文件快捷键按钮
        private void newButton_Click(object sender, EventArgs e)
        {
            newMenuItem_Click(sender, e);
        }

        // 打开文件快捷键按钮
        private void openButton_Click(object sender, EventArgs e)
        {

        }

        // 保存文件快捷键按钮
        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        // 复制快捷键按钮
        private void copyButton_Click(object sender, EventArgs e)
        {

        }

        // 粘贴快捷键按钮
        private void pasteButton_Click(object sender, EventArgs e)
        {

        }

        // 剪接快捷键按钮
        private void cutButton_Click(object sender, EventArgs e)
        {

        }

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

            }

            // 打开文件
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.O)
            {

            }

            // 打印
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.P)
            {

            }

            // 撤销
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.Z)
            {

            }

            // 剪接
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.X)
            {

            }

            // 复制
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.C)
            {

            }

            // 粘贴
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.V)
            {

            }

            // 删除
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.Delete)
            {

            }

            // 查找
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.F)
            {

            }

            // 替换
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.H)
            {

            }

            // 全选
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.A)
            {

            }

            // 时间/日期
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.F5)
            {


            }
        }

        private void toolStrip_KeyDown(object sender, KeyEventArgs e)
        {
            // 新建文件
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.N)
            {
                newMenuItem_Click(sender, e);
            }

            // 保存
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.S)
            {

            }

            // 打开文件
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.O)
            {

            }

            // 剪接
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.X)
            {

            }

            // 复制
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.C)
            {

            }

            // 粘贴
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.V)
            {

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
                tabControlWithCloseButton.ItemSize.Height - 2 * formMargin);
            // 修改模板Size，是为了方便新增RichTextBox
            richTextBoxTemplate.Size = tabControlWithCloseButton.Size;

            // 调整每一个文本编辑器大小
            foreach (TabPage tabPage in tabControlWithCloseButton.TabPages)
            {
                ((RichTextBox)tabPage.Controls[0]).Size = tabControlWithCloseButton.Size;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
