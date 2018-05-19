using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace test
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
            // 自定义TabControl时，DrawMode必须设为OwnerDrawFixed。
            DrawMode = TabDrawMode.OwnerDrawFixed;

            //增加Item关闭事件
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
            Rectangle selectedRect = GetTabRect(SelectedIndex); // 获取当前选中的选项卡的边框
            Rectangle imageRect = new Rectangle();              // 图标边框



        }

        /// <summary>
        /// MosuDown事件，关闭选项卡。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabItemClosedByMouseDown(object sender, MouseEventArgs e)
        {
            // 显示图片模式，或非鼠标左键点击，不产生任何处理
            if (DisplayMode == TabDisplayMode.Image || e.Button != MouseButtons.Left)
                return;

            int width;      //

            // 获取当前选中的选项卡的边框
            Rectangle selectedRect = GetTabRect(SelectedIndex);
            width = base.Padding.X * 2 > selectedRect.Height ?
                selectedRect.Height - 4 : base.Padding.X * 2 - 4;

        }

        #endregion

        /// <summary>
        /// TabControl显示方式
        /// </summary>
        public enum TabDisplayMode
        {
            /// <summary>
            /// 效果与TabControl一致
            /// </summary>
            Normal = 0,
            /// <summary>
            /// 具有关闭功能
            /// </summary>
            Close = 1,
            /// <summary>
            /// 具有图片功能
            /// </summary>
            Image = 2,
            /// <summary>
            /// 同时具有关闭和图片功能
            /// </summary>
            All = 3
        }
    }
}
