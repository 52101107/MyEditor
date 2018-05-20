using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    /// <summary>   
    /// 重写的TabControl控件 带关闭按钮  
    /// </summary>  
    public class TabControlWithExit : TabControl
    {
        
        public TabControlWithExit():base()
        {
            base.DrawMode = TabDrawMode.OwnerDrawFixed;
            //增加DrawItem事件
            DrawItem += OverridOnDrawItem;
            //增加MouseDown事件
            MouseDown += OverridMouseDown;
        }

        // 用于实际设置的TabControlMode
        private TabControlMode _tabControlMode;


        // 存储控件设置的Padding值
        private Point _padding;

        // 获取或设置绘制控件的选项卡的方式。
        [Browsable(true)]
        [DefaultValue(TabDrawMode.OwnerDrawFixed)]
        [ReadOnly(true)]
        public new TabDrawMode DrawMode
        {
            get
            {
                return base.DrawMode;
            }
        }

        // 选项卡显示的图片
        [Browsable(true)]
        public Image TabImage { get; set; }

        // TabControl显示方式
        [Browsable(true)]
        [DefaultValue(TabControlMode.Close)]
        public TabControlMode StyleMode
        {
            get
            {
                if (_tabControlMode == TabControlMode.Image && this.TabImage == null)
                    _tabControlMode = TabControlMode.Close;
                return _tabControlMode;
            }
            set
            {
                _tabControlMode = value;
                if (_tabControlMode == TabControlMode.Image && this.TabImage == null)
                    _tabControlMode = TabControlMode.Close;
            }
        }

        // 重写父类Padding
        public new Point Padding
        {
            get
            {
                switch (this.StyleMode)
                {
                    case TabControlMode.Normal:
                    case TabControlMode.Close:
                    case TabControlMode.Image:

                        _padding = new Point(base.Padding.X - 4, base.Padding.Y);
                        break;
                    case TabControlMode.All:
                        _padding = new Point((base.Padding.X - 4) / 2, base.Padding.Y);
                        break;
                }
                return _padding;
            }
            set
            {
                _padding = value;
                switch (this.StyleMode)
                {
                    case TabControlMode.Normal:
                    case TabControlMode.Close:
                    case TabControlMode.Image:
                        base.Padding = new Point(_padding.X + 4, _padding.Y);
                        break;
                    case TabControlMode.All:
                        base.Padding = new Point(_padding.X * 2 + 4, _padding.Y);
                        break;
                }
            }
        }

        // 被选中的选择项的背景色
        [Browsable(true)]
        public Color BackGroundColor { get; set; }

        //MosuDown事件，关闭选项卡，此处有点复杂化，使用变量可以在DrawItem中对被选中的TabPage进行赋值操作。
        private void OverridMouseDown(object sender, MouseEventArgs e)
        {
            if (this.StyleMode == TabControlMode.Image || e.Button != MouseButtons.Left)
                return;
            Rectangle selectedRec = this.GetTabRect(this.SelectedIndex);
            int width, yValue;
            double dValue;
            width = base.Padding.X * 2 > selectedRec.Height ? selectedRec.Height - 4 : base.Padding.X * 2 - 4;
            dValue = (selectedRec.Height - width) / 2;
            yValue = Convert.ToInt32(Math.Round(dValue));
            switch (this.StyleMode)
            {
                case TabControlMode.Normal:
                case TabControlMode.Close:
                    selectedRec.X = selectedRec.X + selectedRec.Width - width - 2;
                    selectedRec.Y = selectedRec.Y - yValue;
                    selectedRec.Width = selectedRec.Height = width;
                    break;
                case TabControlMode.Image:
                    break;
                case TabControlMode.All:
                    width = selectedRec.Height = base.Padding.X > selectedRec.Height ? selectedRec.Height - 2 : base.Padding.X - 2;
                    selectedRec.X = selectedRec.X + selectedRec.Width - width - 2;
                    selectedRec.Y = selectedRec.Y + yValue;
                    break;
            }
            if (e.X >= selectedRec.X && e.X <= selectedRec.X + width && e.Y >= selectedRec.Y && e.Y <= selectedRec.Y + width)
                this.TabPages.RemoveAt(this.SelectedIndex);
        }

        private void OverridOnDrawItem(object sender, DrawItemEventArgs e)
        {
            //获取当前选项卡
            Rectangle rec = this.GetTabRect(e.Index);

            //创建新的Rectangle
            Rectangle newRec = new Rectangle();
            int newRecWidth, yValue;
            //计算关闭按钮大小
            newRecWidth = base.Padding.X * 2 > rec.Height ? rec.Height - 4 : base.Padding.X * 2 - 4;
            //计算垂直坐标
            double dValue = (rec.Height - newRecWidth) / 2;
            yValue = Convert.ToInt32(Math.Round(dValue));
            if (e.Index == this.SelectedIndex)
            {
                //进行填充背景色
                e.Graphics.FillRectangle(new SolidBrush(BackGroundColor), rec);
            }
            switch (this.StyleMode)
            {

                case TabControlMode.Normal:
                case TabControlMode.Close:
                    #region Normal,Close
                    //绘制文字
                    e.Graphics.DrawString(this.TabPages[e.Index].Text, this.Font, new SolidBrush(this.TabPages[e.Index].ForeColor), rec.X, rec.Y + base.Padding.Y);
                    //计算close的Rectangle
                    newRec.Width = newRec.Height = newRecWidth;
                    newRec.X = rec.X + rec.Width - newRec.Width - 2;
                    newRec.Y = rec.Y + yValue;
                    //绘制关闭按钮方框
                    e.Graphics.DrawRectangle(Pens.Black, newRec);
                    //绘制关闭按钮颜色,Color.FromArgb将10进制的8 位颜色值
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(191, 83, 62)), new Rectangle(newRec.X + 1, newRec.Y + 1, newRec.Width - 1, newRec.Height - 1));
                    //绘制关闭的X
                    e.Graphics.DrawLine(new Pen(Color.White) { Width = 2 }, newRec.X + 4, newRec.Y + 4, newRec.X + newRec.Width - 4, newRec.Y + newRec.Height - 4);
                    e.Graphics.DrawLine(new Pen(Color.White) { Width = 2 }, newRec.X + 4, newRec.Y + newRec.Height - 4, newRec.X + newRec.Width - 4, newRec.Y + 4);
                    break;
                #endregion
                case TabControlMode.Image:
                    #region Image
                    //计算image的Rectangle
                    newRec.Width = newRec.Height = newRecWidth;
                    newRec.X = rec.X + 1;
                    newRec.Y = rec.Y + yValue;
                    //绘制图片
                    e.Graphics.DrawImage(this.TabImage, newRec);
                    //绘制文字
                    e.Graphics.DrawString(this.TabPages[e.Index].Text, this.Font, new SolidBrush(this.TabPages[e.Index].ForeColor), newRec.X + newRec.Width + 1, rec.Y + base.Padding.Y);
                    break;
                #endregion
                case TabControlMode.All:
                    #region All
                    //计算image的Rectangle
                    newRec.Width = newRec.Height = base.Padding.X > rec.Height ? rec.Height - 2 : base.Padding.X - 2;
                    newRec.X = rec.X + 1;
                    newRec.Y = rec.Y + yValue;
                    //绘制图片
                    e.Graphics.DrawImage(this.TabImage, newRec);
                    //绘制文字
                    e.Graphics.DrawString(this.TabPages[e.Index].Text, this.Font, new SolidBrush(this.TabPages[e.Index].ForeColor), newRec.X + newRec.Width + 1, rec.Y + base.Padding.Y);
                    //计算close的Rectangle
                    newRec.X = rec.X + rec.Width - newRec.Width - 2;
                    //绘制关闭按钮颜色,Color.FromArgb将10进制的8 位颜色值
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(191, 83, 62)), newRec);
                    //绘制关闭的X
                    e.Graphics.DrawLine(new Pen(Color.White) { Width = 2 }, newRec.X + 4, newRec.Y + 4, newRec.X + newRec.Width - 4, newRec.Y + newRec.Height - 4);
                    e.Graphics.DrawLine(new Pen(Color.White) { Width = 2 }, newRec.X + 4, newRec.Y + newRec.Height - 4, newRec.X + newRec.Width - 4, newRec.Y + 4);
                    break;
                    #endregion
            }
        }

        /// <summary>
        /// TabControl显示方式
        /// </summary>
        public enum TabControlMode
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

