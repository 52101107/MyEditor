

namespace MultiText
{
    partial class DocumentProcessor
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.historyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToDBMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.pageSettingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.searchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.allMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linewrapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontsizeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontcolorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lookhelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newButton = new System.Windows.Forms.ToolStripButton();
            this.openButton = new System.Windows.Forms.ToolStripButton();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.copyButton = new System.Windows.Forms.ToolStripButton();
            this.pasteButton = new System.Windows.Forms.ToolStripButton();
            this.cutButton = new System.Windows.Forms.ToolStripButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControlWithCloseButton = new MultiText.container.TabControlWithCloseButton();
            this.tabPageTemplate = new System.Windows.Forms.TabPage();
            this.richTextBoxTemplate = new System.Windows.Forms.RichTextBox();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControlWithCloseButton.SuspendLayout();
            this.tabPageTemplate.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editMenuItem,
            this.formatMenuItem,
            this.viewMenuItem,
            this.helpMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1176, 34);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "菜单栏";
            this.menuStrip.KeyDown += new System.Windows.Forms.KeyEventHandler(this.menuStrip_KeyDown);
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuItem,
            this.openMenuItem,
            this.saveMenuItem,
            this.saveAsMenuItem,
            this.toolStripSeparator1,
            this.historyMenuItem,
            this.saveToDBMenuItem,
            this.toolStripSeparator3,
            this.pageSettingMenuItem,
            this.printMenuItem,
            this.toolStripSeparator2,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.ShortcutKeyDisplayString = "Ctrl + N";
            this.fileMenuItem.Size = new System.Drawing.Size(80, 28);
            this.fileMenuItem.Text = "文件(&F)";
            // 
            // newMenuItem
            // 
            this.newMenuItem.Image = global::MultiText.Properties.Resources._new;
            this.newMenuItem.Name = "newMenuItem";
            this.newMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
            this.newMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newMenuItem.Size = new System.Drawing.Size(224, 30);
            this.newMenuItem.Text = "新建(&N)";
            this.newMenuItem.Click += new System.EventHandler(this.newMenuItem_Click);
            // 
            // openMenuItem
            // 
            this.openMenuItem.Image = global::MultiText.Properties.Resources.open;
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
            this.openMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMenuItem.Size = new System.Drawing.Size(224, 30);
            this.openMenuItem.Text = "打开(&O)";
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Image = global::MultiText.Properties.Resources.save;
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.saveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenuItem.Size = new System.Drawing.Size(224, 30);
            this.saveMenuItem.Text = "保存(&S)";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // saveAsMenuItem
            // 
            this.saveAsMenuItem.Image = global::MultiText.Properties.Resources.saveas;
            this.saveAsMenuItem.Name = "saveAsMenuItem";
            this.saveAsMenuItem.Size = new System.Drawing.Size(224, 30);
            this.saveAsMenuItem.Text = "另存为(&A)";
            this.saveAsMenuItem.Click += new System.EventHandler(this.saveAsMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // historyMenuItem
            // 
            this.historyMenuItem.Image = global::MultiText.Properties.Resources.history;
            this.historyMenuItem.Name = "historyMenuItem";
            this.historyMenuItem.Size = new System.Drawing.Size(224, 30);
            this.historyMenuItem.Text = "历史记录";
            this.historyMenuItem.Click += new System.EventHandler(this.historyMenuItem_Click);
            // 
            // saveToDBMenuItem
            // 
            this.saveToDBMenuItem.Image = global::MultiText.Properties.Resources.database;
            this.saveToDBMenuItem.Name = "saveToDBMenuItem";
            this.saveToDBMenuItem.Size = new System.Drawing.Size(224, 30);
            this.saveToDBMenuItem.Text = "保存到数据库";
            this.saveToDBMenuItem.Click += new System.EventHandler(this.saveToDBMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(221, 6);
            // 
            // pageSettingMenuItem
            // 
            this.pageSettingMenuItem.Image = global::MultiText.Properties.Resources.pagesetting;
            this.pageSettingMenuItem.Name = "pageSettingMenuItem";
            this.pageSettingMenuItem.Size = new System.Drawing.Size(224, 30);
            this.pageSettingMenuItem.Text = "页面设置(&U)";
            this.pageSettingMenuItem.Click += new System.EventHandler(this.pageSettingMenuItem_Click);
            // 
            // printMenuItem
            // 
            this.printMenuItem.Image = global::MultiText.Properties.Resources.print;
            this.printMenuItem.Name = "printMenuItem";
            this.printMenuItem.ShortcutKeyDisplayString = "Ctrl+P";
            this.printMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printMenuItem.Size = new System.Drawing.Size(224, 30);
            this.printMenuItem.Text = "打印(&P)";
            this.printMenuItem.Click += new System.EventHandler(this.printMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Image = global::MultiText.Properties.Resources.exit;
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(224, 30);
            this.exitMenuItem.Text = "退出(&X)";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // editMenuItem
            // 
            this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoMenuItem,
            this.toolStripSeparator4,
            this.cutMenuItem,
            this.copyMenuItem,
            this.pasteMenuItem,
            this.deleteMenuItem,
            this.toolStripSeparator5,
            this.searchMenuItem,
            this.replaceMenuItem,
            this.toolStripSeparator6,
            this.allMenuItem,
            this.dateMenuItem});
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(80, 28);
            this.editMenuItem.Text = "编辑(&E)";
            // 
            // undoMenuItem
            // 
            this.undoMenuItem.Image = global::MultiText.Properties.Resources.undo;
            this.undoMenuItem.Name = "undoMenuItem";
            this.undoMenuItem.ShortcutKeyDisplayString = "Ctrl+Z";
            this.undoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoMenuItem.Size = new System.Drawing.Size(229, 30);
            this.undoMenuItem.Text = "撤销(&U)";
            this.undoMenuItem.Click += new System.EventHandler(this.undoMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(226, 6);
            // 
            // cutMenuItem
            // 
            this.cutMenuItem.Image = global::MultiText.Properties.Resources.cut;
            this.cutMenuItem.Name = "cutMenuItem";
            this.cutMenuItem.ShortcutKeyDisplayString = "Ctrl+X";
            this.cutMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutMenuItem.Size = new System.Drawing.Size(229, 30);
            this.cutMenuItem.Text = "剪接(&T)";
            this.cutMenuItem.Click += new System.EventHandler(this.cutMenuItem_Click);
            // 
            // copyMenuItem
            // 
            this.copyMenuItem.Image = global::MultiText.Properties.Resources.copy;
            this.copyMenuItem.Name = "copyMenuItem";
            this.copyMenuItem.ShortcutKeyDisplayString = "Ctrl+C";
            this.copyMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyMenuItem.Size = new System.Drawing.Size(229, 30);
            this.copyMenuItem.Text = "复制(&C)";
            this.copyMenuItem.Click += new System.EventHandler(this.copyMenuItem_Click);
            // 
            // pasteMenuItem
            // 
            this.pasteMenuItem.Image = global::MultiText.Properties.Resources.paste;
            this.pasteMenuItem.Name = "pasteMenuItem";
            this.pasteMenuItem.ShortcutKeyDisplayString = "Ctrl+V";
            this.pasteMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteMenuItem.Size = new System.Drawing.Size(229, 30);
            this.pasteMenuItem.Text = "粘贴(&P)";
            this.pasteMenuItem.Click += new System.EventHandler(this.pasteMenuItem_Click);
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Image = global::MultiText.Properties.Resources.delete;
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.ShortcutKeyDisplayString = "Delete";
            this.deleteMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteMenuItem.Size = new System.Drawing.Size(229, 30);
            this.deleteMenuItem.Text = "删除(&L)";
            this.deleteMenuItem.Click += new System.EventHandler(this.deleteMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(226, 6);
            // 
            // searchMenuItem
            // 
            this.searchMenuItem.Image = global::MultiText.Properties.Resources.search;
            this.searchMenuItem.Name = "searchMenuItem";
            this.searchMenuItem.ShortcutKeyDisplayString = "Ctrl+F";
            this.searchMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.searchMenuItem.Size = new System.Drawing.Size(229, 30);
            this.searchMenuItem.Text = "查找(&F)";
            this.searchMenuItem.Click += new System.EventHandler(this.searchMenuItem_Click);
            // 
            // replaceMenuItem
            // 
            this.replaceMenuItem.Image = global::MultiText.Properties.Resources.replace;
            this.replaceMenuItem.Name = "replaceMenuItem";
            this.replaceMenuItem.ShortcutKeyDisplayString = "Ctrl+H";
            this.replaceMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.replaceMenuItem.Size = new System.Drawing.Size(229, 30);
            this.replaceMenuItem.Text = "替换(&R)";
            this.replaceMenuItem.Click += new System.EventHandler(this.replaceMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(226, 6);
            // 
            // allMenuItem
            // 
            this.allMenuItem.Image = global::MultiText.Properties.Resources.all;
            this.allMenuItem.Name = "allMenuItem";
            this.allMenuItem.ShortcutKeyDisplayString = "Ctrl+A";
            this.allMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.allMenuItem.Size = new System.Drawing.Size(229, 30);
            this.allMenuItem.Text = "全选(&A)";
            this.allMenuItem.Click += new System.EventHandler(this.allMenuItem_Click);
            // 
            // dateMenuItem
            // 
            this.dateMenuItem.Image = global::MultiText.Properties.Resources.date;
            this.dateMenuItem.Name = "dateMenuItem";
            this.dateMenuItem.ShortcutKeyDisplayString = "F5";
            this.dateMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.dateMenuItem.Size = new System.Drawing.Size(229, 30);
            this.dateMenuItem.Text = "时间/日期(&D)";
            this.dateMenuItem.Click += new System.EventHandler(this.dateMenuItem_Click);
            // 
            // formatMenuItem
            // 
            this.formatMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linewrapMenuItem,
            this.fontsizeMenuItem,
            this.fontcolorMenuItem});
            this.formatMenuItem.Name = "formatMenuItem";
            this.formatMenuItem.Size = new System.Drawing.Size(85, 28);
            this.formatMenuItem.Text = "格式(&O)";
            // 
            // linewrapMenuItem
            // 
            this.linewrapMenuItem.Image = global::MultiText.Properties.Resources.linewrap;
            this.linewrapMenuItem.Name = "linewrapMenuItem";
            this.linewrapMenuItem.Size = new System.Drawing.Size(194, 30);
            this.linewrapMenuItem.Text = "自动换行(&W)";
            this.linewrapMenuItem.Click += new System.EventHandler(this.linewrapMenuItem_Click);
            // 
            // fontsizeMenuItem
            // 
            this.fontsizeMenuItem.Image = global::MultiText.Properties.Resources.fontsize;
            this.fontsizeMenuItem.Name = "fontsizeMenuItem";
            this.fontsizeMenuItem.Size = new System.Drawing.Size(194, 30);
            this.fontsizeMenuItem.Text = "字体大小(&F)";
            this.fontsizeMenuItem.Click += new System.EventHandler(this.fontsizeMenuItem_Click);
            // 
            // fontcolorMenuItem
            // 
            this.fontcolorMenuItem.Image = global::MultiText.Properties.Resources.fontcolor;
            this.fontcolorMenuItem.Name = "fontcolorMenuItem";
            this.fontcolorMenuItem.Size = new System.Drawing.Size(194, 30);
            this.fontcolorMenuItem.Text = "字体颜色(&C)";
            this.fontcolorMenuItem.Click += new System.EventHandler(this.fontcolorMenuItem_Click);
            // 
            // viewMenuItem
            // 
            this.viewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMenuItem});
            this.viewMenuItem.Name = "viewMenuItem";
            this.viewMenuItem.Size = new System.Drawing.Size(82, 28);
            this.viewMenuItem.Text = "查看(&V)";
            // 
            // statusMenuItem
            // 
            this.statusMenuItem.Image = global::MultiText.Properties.Resources.status;
            this.statusMenuItem.Name = "statusMenuItem";
            this.statusMenuItem.Size = new System.Drawing.Size(168, 30);
            this.statusMenuItem.Text = "状态栏(&S)";
            this.statusMenuItem.Click += new System.EventHandler(this.statusMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lookhelpMenuItem,
            this.toolStripSeparator7,
            this.aboutMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(84, 28);
            this.helpMenuItem.Text = "帮助(&H)";
            // 
            // lookhelpMenuItem
            // 
            this.lookhelpMenuItem.Image = global::MultiText.Properties.Resources.help;
            this.lookhelpMenuItem.Name = "lookhelpMenuItem";
            this.lookhelpMenuItem.Size = new System.Drawing.Size(190, 30);
            this.lookhelpMenuItem.Text = "查看帮助(&H)";
            this.lookhelpMenuItem.Click += new System.EventHandler(this.lookhelpMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(187, 6);
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Image = global::MultiText.Properties.Resources.about;
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(190, 30);
            this.aboutMenuItem.Text = "关于(&A)";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newButton,
            this.openButton,
            this.saveButton,
            this.copyButton,
            this.pasteButton,
            this.cutButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 34);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip.Size = new System.Drawing.Size(1176, 31);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "工具栏";
            this.toolStrip.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStrip_KeyDown);
            // 
            // newButton
            // 
            this.newButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newButton.Image = global::MultiText.Properties.Resources._new;
            this.newButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(28, 28);
            this.newButton.Text = "新建";
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // openButton
            // 
            this.openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openButton.Image = global::MultiText.Properties.Resources.open;
            this.openButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(28, 28);
            this.openButton.Text = "打开";
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Image = global::MultiText.Properties.Resources.save;
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(28, 28);
            this.saveButton.Text = "保存";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyButton.Image = global::MultiText.Properties.Resources.copy;
            this.copyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(28, 28);
            this.copyButton.Text = "复制";
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // pasteButton
            // 
            this.pasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteButton.Image = global::MultiText.Properties.Resources.paste;
            this.pasteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteButton.Name = "pasteButton";
            this.pasteButton.Size = new System.Drawing.Size(28, 28);
            this.pasteButton.Text = "粘贴";
            this.pasteButton.Click += new System.EventHandler(this.pasteButton_Click);
            // 
            // cutButton
            // 
            this.cutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutButton.Image = global::MultiText.Properties.Resources.cut;
            this.cutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutButton.Name = "cutButton";
            this.cutButton.Size = new System.Drawing.Size(28, 28);
            this.cutButton.Text = "剪接";
            this.cutButton.Click += new System.EventHandler(this.cutButton_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1168, 592);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "新建文件1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(1165, 589);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1168, 592);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "新建文件2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1168, 597);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1168, 597);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabControlWithCloseButton
            // 
            this.tabControlWithCloseButton.CloseButtonPadding = new System.Drawing.Point(0, 0);
            this.tabControlWithCloseButton.Controls.Add(this.tabPageTemplate);
            this.tabControlWithCloseButton.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlWithCloseButton.ImagePadding = new System.Drawing.Point(0, 0);
            this.tabControlWithCloseButton.ItemSize = new System.Drawing.Size(150, 20);
            this.tabControlWithCloseButton.Location = new System.Drawing.Point(0, 80);
            this.tabControlWithCloseButton.Name = "tabControlWithCloseButton";
            this.tabControlWithCloseButton.SelectedIndex = 0;
            this.tabControlWithCloseButton.SelectedTabColor = System.Drawing.Color.Silver;
            this.tabControlWithCloseButton.Size = new System.Drawing.Size(1176, 625);
            this.tabControlWithCloseButton.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlWithCloseButton.TabImage = null;
            this.tabControlWithCloseButton.TabIndex = 2;
            this.tabControlWithCloseButton.TextPadding = new System.Drawing.Point(8, 4);
            // 
            // tabPageTemplate
            // 
            this.tabPageTemplate.Controls.Add(this.richTextBoxTemplate);
            this.tabPageTemplate.Location = new System.Drawing.Point(4, 24);
            this.tabPageTemplate.Name = "tabPageTemplate";
            this.tabPageTemplate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTemplate.Size = new System.Drawing.Size(1168, 597);
            this.tabPageTemplate.TabIndex = 0;
            this.tabPageTemplate.Text = "tabPageTemplate";
            this.tabPageTemplate.UseVisualStyleBackColor = true;
            // 
            // richTextBoxTemplate
            // 
            this.richTextBoxTemplate.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxTemplate.Name = "richTextBoxTemplate";
            this.richTextBoxTemplate.Size = new System.Drawing.Size(1168, 591);
            this.richTextBoxTemplate.TabIndex = 0;
            this.richTextBoxTemplate.Text = "";
            this.richTextBoxTemplate.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // DocumentProcessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 692);
            this.Controls.Add(this.tabControlWithCloseButton);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DocumentProcessor";
            this.Text = "DocumentProcessor";
            this.SizeChanged += new System.EventHandler(this.DocumentProcessor_SizeChanged);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabControlWithCloseButton.ResumeLayout(false);
            this.tabPageTemplate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem historyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToDBMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem pageSettingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem cutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem searchMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem allMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linewrapMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontsizeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontcolorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lookhelpMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton newButton;
        private System.Windows.Forms.ToolStripButton openButton;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripButton copyButton;
        private System.Windows.Forms.ToolStripButton pasteButton;
        private System.Windows.Forms.ToolStripButton cutButton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBox;
        private container.TabControlWithCloseButton tabControlWithCloseButton;
        private System.Windows.Forms.TabPage tabPageTemplate;
        private System.Windows.Forms.RichTextBox richTextBoxTemplate;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}

