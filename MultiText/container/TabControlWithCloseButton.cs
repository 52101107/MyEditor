using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MultiText.container
{
    public class TabControlWithCloseButton : TabControl
    {
        #region Indexer

        /// <summary>
        /// 选项卡显示的图片。
        /// </summary>
        [Browsable(true)]
        [Description("选项卡的图片。只有在DisplayMode为Image和All时有效。")]
        public Image TabImage { get; set; }

        /// <summary>
        /// 选项卡显示模式。
        /// </summary>
        [Browsable(true)]
        [DefaultValue(TabDisplayMode.Close)]
        [Description("选项卡显示模式。")]
        public TabDisplayMode DisplayMode { get; set; }

        /// <summary>
        /// 字体Padding。Padding.X表示字体左边空白，Padding.Y表示字体上方空白。
        /// </summary>
        [Browsable(true)]
        [Description("字体Padding。Padding.X表示字体左边空白，Padding.Y表示字体上方空白。")]
        public Point TextPadding { get; set; }

        /// <summary>
        /// 关闭按钮Padding。Padding.X表示按钮右边空白，Padding.Y表示按钮上下方空白。
        /// </summary>
        [Browsable(true)]
        [Description("关闭按钮Padding。Padding.X表示按钮右边空白，Padding.Y表示按钮上下方空白。")]
        public Point CloseButtonPadding { get; set; }

        /// <summary>
        /// 图片Padding。Padding.X表示图标左边空白，Padding.Y表示图标上下方空白。
        /// </summary>
        [Browsable(true)]
        [Description("图片Padding。Padding.X表示图标左边空白，Padding.Y表示图标上下方空白。")]
        public Point ImagePadding { get; set; }

        /// <summary>
        /// 摘要:
        ///     此成员对于此控件无意义。
        ///
        /// 返回结果:
        ///     在控件中显示的背景图像。
        /// </summary>
        [Browsable(false)]
        public new Point Padding { get; set; }

        /// <summary>
        /// 被选中的选项卡的背景色。
        /// </summary>
        [Browsable(true)]
        [Description("被选中的选项卡的背景色。")]
        public Color SelectedTabColor { get; set; }

        #endregion


        #region Public Methods
        //
        // 摘要:
        //     初始化 System.Windows.Forms.TabControl 类的新实例。
        public TabControlWithCloseButton() : base()
        {
            // 初始化
            InitializeTabControlWithCloseButton();

        }

        public void InitializeTabControlWithCloseButton()
        {
            DisplayMode = TabDisplayMode.Close;

            // 自定义TabControl时，DrawMode必须设为OwnerDrawFixed。
            DrawMode = TabDrawMode.OwnerDrawFixed;

            //增加选项卡绘制事件
            DrawItem += DrawItemWithExitButton;

            //增加Item点击事件
            MouseDown += TabItemClosedByMouseDown;
        }

        #endregion


        #region Private Methods

        /// <summary>
        /// 重新绘制选项卡。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DrawItemWithExitButton(object sender, DrawItemEventArgs e)
        {
            Rectangle closeButtonRect = new Rectangle();        // 关闭按钮边框
            Rectangle currentTabRect = GetTabRect(e.Index);     // 获取当前选项卡的边框
            Rectangle imageRect = new Rectangle();              // 图标边框

            // 计算关闭按钮大小
            closeButtonRect.Height = currentTabRect.Height - 2 * CloseButtonPadding.Y;
            closeButtonRect.Width = closeButtonRect.Height;

            // 计算图标大小
            imageRect.Height = currentTabRect.Height - 2 * ImagePadding.Y;
            imageRect.Width = imageRect.Height;

            // 绘制选项卡
            // 绘制选项卡背景色
            if (e.Index == this.SelectedIndex)
            {
                e.Graphics.FillRectangle(new SolidBrush(SelectedTabColor), currentTabRect);
            }

            string text = TabPages[e.Index].Text;
            switch (DisplayMode)
            {
                case TabDisplayMode.Close:
                    #region Close

                    // 绘制关闭按钮
                    // 计算close的Rectangle位置
                    closeButtonRect.X = currentTabRect.X + currentTabRect.Width -
                        closeButtonRect.Width - CloseButtonPadding.X;
                    closeButtonRect.Y = currentTabRect.Y + CloseButtonPadding.Y;
                    // 绘制关闭按钮方框(只画X)
                    //e.Graphics.DrawRectangle(Pens.Black, closeButtonRect);
                    //绘制关闭按钮颜色,Color.FromArgb将10进制的8 位颜色值
                    //e.Graphics.FillRectangle(new SolidBrush(Color.Red),
                    //    new Rectangle(closeButtonRect.X + 1, closeButtonRect.Y + 1,
                    //    closeButtonRect.Width - 1, closeButtonRect.Height - 1));
                    // 绘制关闭的X
                    e.Graphics.DrawLine(
                        new Pen(Color.Gray) { Width = 2 },
                        closeButtonRect.X + 4,
                        closeButtonRect.Y + 4,
                        closeButtonRect.X + closeButtonRect.Width - 4,
                        closeButtonRect.Y + closeButtonRect.Height - 4);
                    e.Graphics.DrawLine(
                        new Pen(Color.Gray) { Width = 2 },
                        closeButtonRect.X + 4,
                        closeButtonRect.Y + closeButtonRect.Height - 4,
                        closeButtonRect.X + closeButtonRect.Width - 4,
                        closeButtonRect.Y + 4);

                    // 绘制文字
                    if ((currentTabRect.Width - TextPadding.X -
                        closeButtonRect.Width - CloseButtonPadding.X) / 12
                        < TabPages[e.Index].Text.Length)
                    {
                        // 选项卡长度可容纳字数小于Text长度
                        text = TabPages[e.Index].Text.Substring(0,
                            (currentTabRect.Width - ImagePadding.X -
                            imageRect.Width - TextPadding.X) / 12 - 1)
                            + "…";
                    }
                    e.Graphics.DrawString(text, Font,
                        new SolidBrush(TabPages[e.Index].ForeColor),
                        currentTabRect.X + TextPadding.X,     // 字体左边插入空白
                        currentTabRect.Y + TextPadding.Y);    // 字体上方插入空白
                    break;

                #endregion
                case TabDisplayMode.Image:
                    #region Image

                    // 绘制图标
                    // 计算图标的边框
                    imageRect.Height = currentTabRect.Height - 2 * ImagePadding.Y;
                    imageRect.Width = imageRect.Height;
                    imageRect.X = currentTabRect.X + ImagePadding.X;
                    imageRect.Y = currentTabRect.Y + ImagePadding.Y;
                    if (TabImage != null)
                        e.Graphics.DrawImage(TabImage, imageRect);

                    // 绘制文字
                    if ((currentTabRect.Width - ImagePadding.X -
                        imageRect.Width - TextPadding.X) / 12
                        < TabPages[e.Index].Text.Length)
                    {
                        // 选项卡长度可容纳字数小于Text长度
                        text = TabPages[e.Index].Text.Substring(0,
                            (currentTabRect.Width - ImagePadding.X -
                            imageRect.Width - TextPadding.X) / 12 - 1)
                            + "…";
                    }
                    e.Graphics.DrawString(text, Font,
                        new SolidBrush(TabPages[e.Index].ForeColor),
                        imageRect.X + imageRect.Width + TextPadding.X,     // 字体左边插入空白
                        currentTabRect.Y + TextPadding.Y);    // 字体上方插入空白
                    break;

                #endregion
                case TabDisplayMode.All:
                    #region All

                    // 绘制图标
                    // 计算图标的边框
                    imageRect.Height = currentTabRect.Height - 2 * ImagePadding.Y;
                    imageRect.Width = imageRect.Height;
                    imageRect.X = currentTabRect.X + ImagePadding.X;
                    imageRect.Y = currentTabRect.Y + ImagePadding.Y;
                    if (TabImage != null)
                        e.Graphics.DrawImage(TabImage, imageRect);

                    // 绘制关闭按钮
                    // 计算close的边框位置
                    closeButtonRect.X = currentTabRect.X + currentTabRect.Width - closeButtonRect.Width - CloseButtonPadding.X;
                    closeButtonRect.Y = currentTabRect.Y + CloseButtonPadding.Y;
                    // 绘制关闭按钮方框
                    //e.Graphics.DrawRectangle(Pens.Black, closeButtonRect);
                    //绘制关闭按钮颜色,Color.FromArgb将10进制的8 位颜色值
                    //e.Graphics.FillRectangle(new SolidBrush(Color.Red),
                    //    new Rectangle(closeButtonRect.X + 1, closeButtonRect.Y + 1,
                    //    closeButtonRect.Width - 1, closeButtonRect.Height - 1));
                    // 绘制关闭的X
                    e.Graphics.DrawLine(
                        new Pen(Color.Gray) { Width = 2 },
                        closeButtonRect.X + 4,
                        closeButtonRect.Y + 4,
                        closeButtonRect.X + closeButtonRect.Width - 4,
                        closeButtonRect.Y + closeButtonRect.Height - 4);
                    e.Graphics.DrawLine(
                        new Pen(Color.Gray) { Width = 2 },
                        closeButtonRect.X + 4,
                        closeButtonRect.Y + closeButtonRect.Height - 4,
                        closeButtonRect.X + closeButtonRect.Width - 4,
                        closeButtonRect.Y + 4);

                    // 绘制文字
                    if ((currentTabRect.Width - ImagePadding.X -
                        imageRect.Width - TextPadding.X -
                        closeButtonRect.Width - CloseButtonPadding.X) / 12
                        < TabPages[e.Index].Text.Length)
                    {
                        // 选项卡长度可容纳字数小于Text长度
                        text = TabPages[e.Index].Text.Substring(0,
                            (currentTabRect.Width - ImagePadding.X -
                            imageRect.Width - TextPadding.X -
                            closeButtonRect.Width - CloseButtonPadding.X) / 12 - 1)
                            + "…";
                    }
                    e.Graphics.DrawString(text, Font,
                        new SolidBrush(TabPages[e.Index].ForeColor),
                        imageRect.X + imageRect.Width + TextPadding.X,     // 字体左边插入空白
                        currentTabRect.Y + TextPadding.Y);    // 字体上方插入空白
                    break;

                    #endregion
            }

        }

        /// <summary>
        /// MosuDown事件，关闭选项卡。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabItemClosedByMouseDown(object sender, MouseEventArgs e)
        {
            // 图标模式或非鼠标左键点击直接退出
            if (DisplayMode == TabDisplayMode.Image || e.Button != MouseButtons.Left)
                return;

            Rectangle selectedRect = GetTabRect(SelectedIndex); // 获取选中的选项卡
            Rectangle closeButtonRect = new Rectangle();        // 关闭按钮边框

            // 计算关闭按钮位置
            closeButtonRect.Height = selectedRect.Height - 2 * CloseButtonPadding.Y;
            closeButtonRect.Width = selectedRect.Height;
            closeButtonRect.X = selectedRect.X + selectedRect.Width
                - CloseButtonPadding.X - closeButtonRect.Width;
            closeButtonRect.Y = selectedRect.Y + CloseButtonPadding.Y;

            // 处理鼠标点击事件
            if (e.X >= closeButtonRect.X &&
                e.X <= closeButtonRect.X + closeButtonRect.Width &&
                e.Y >= closeButtonRect.Y &&
                e.Y <= closeButtonRect.Y + closeButtonRect.Height)
            {
                this.TabPages.RemoveAt(this.SelectedIndex);
            }
        }

        #endregion

        /// <summary>
        /// TabControl显示方式
        /// </summary>
        public enum TabDisplayMode
        {
            /// <summary>
            /// 具有关闭功能
            /// </summary>
            Close = 0,
            /// <summary>
            /// 具有图片功能
            /// </summary>
            Image = 1,
            /// <summary>
            /// 同时具有关闭和图片功能
            /// </summary>
            All = 2
        }
    }
}
