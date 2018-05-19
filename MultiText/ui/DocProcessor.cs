using System;
using System.Drawing;
using System.Windows.Forms;

namespace MultiText
{
    public partial class DocumentProcessor : Form
    {
        #region Component Size Variable

        private const int formMargin = 8;

        private const int tabPageLocationY = 50;
        private const int tabPageLocationX = 0;
        private const int tagItemHeight = 20;
        private const int tagMargin = 3;

        #endregion

        #region

        

        #endregion

        public DocumentProcessor()
        {
            InitializeComponent();

            int formTitleHeight = Height - ClientRectangle.Height + 1;
            tabControl.Size = new Size(Width - tabPageLocationX - 2 * formMargin, Height - tabPageLocationY - formTitleHeight);
            richTextBox.Size = tabPage.Size;
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
            // Ctrl+*快捷键

        }

        // 新建文件
        private void newMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 打开文件
        private void openMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 保存文件
        private void saveMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 保存文件为
        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 历史记录
        private void historyMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 保存到数据库
        private void saveToDBMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 页面设置
        private void pageSettingMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 打印
        private void printMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 退出
        private void undoMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 剪接
        private void cutMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 复制
        private void copyMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 粘贴
        private void pasteMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 删除
        private void deleteMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 查找
        private void searchMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 替换
        private void replaceMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 全选
        private void allMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 时间/日期
        private void dateMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 自动换行
        private void linewrapMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        // 字体大小
        private void fontsizeMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 字体颜色
        private void fontcolorMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 状态栏
        private void statusMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 查看帮助
        private void lookhelpMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 关于
        private void aboutMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 新建文件快捷键按钮
        private void newButton_Click(object sender, EventArgs e)
        {

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

        private void DocumentProcessor_SizeChanged(object sender, EventArgs e)
        {
            int formTitleHeight = Height - ClientRectangle.Height + 1;
            tabControl.Size = new Size(Width - tabPageLocationX - 2 * formMargin, Height - tabPageLocationY - formTitleHeight);
            richTextBox.Size = tabPage.Size;
        }
    }
}
