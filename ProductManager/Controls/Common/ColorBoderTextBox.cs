using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManager.Controls.Common
{
    public class ColorBoderTextBox : TextBox
    {
        //获取的当前进程，以便重绘控件
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr GetWindowDC(IntPtr hWnd);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        //是否启用热点效果
        private bool _HotTrack = true;
        //边框颜色
        public Color _BorderColor = Color.FromName("#CCCCCC");
        //热点边框颜色
        private Color _HotColor = Color.FromArgb(100, 0, 255, 255);
        //是否鼠标经过
        private bool _IsMouseOver = false;
        public ColorBoderTextBox() : base() {
            this.BorderStyle = BorderStyle.FixedSingle;
            this.AutoSize = false;
            this.Height = 40;
        }

        public sealed override bool AutoSize
        {
            get { return base.AutoSize; }
            set { base.AutoSize = value; }
        }

        /// <summary>
        /// 鼠标移动到该控件上时
        /// </summary>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            this._IsMouseOver = true;
            //如果启用HotTrack,则开始重绘，
            //如果不加判断，则当鼠标在控件上移动时，控件边框会不断重绘，导致控件边框闪烁。下同
            if (this._HotTrack)
            {
                this.Invalidate();
            }
            base.OnMouseMove(e);
        }
        /// <summary>
        ///当 鼠标从该控件 移开时
        /// </summary>
        protected override void OnMouseLeave(EventArgs e)
        {
            this._IsMouseOver = false;
            if (this._HotTrack)
            {
                this.Invalidate();
            }
            base.OnMouseLeave(e);
        }
        /// <summary>
        /// 控件获得焦点 时
        /// </summary>
        protected override void OnGotFocus(EventArgs e)
        {
            if (this._HotTrack)
            {
                this.Invalidate();
            }
            base.OnGotFocus(e);
        }
        protected override void OnLostFocus(EventArgs e)
        {
            if (this._HotTrack)
            {
                this.Invalidate();
            }
            base.OnLostFocus(e);
        }
        /// <summary>
        /// 获得操作系统消息
        /// </summary>
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0xf || m.Msg == 0x133)
            {
                //拦截系统消息，获得当前控件进程以便重绘。
                //
                //MSDN:重写 OnPaint 将禁止修改所有控件的外观
                //那些由 Windows 完成所有绘图的控件（例如 TextBox）从不调用他的OnPaint方法

                //因此将永远不会使用自定义码。请参见你要修改的特定控件的文档,
                //查看 OnPaint 方法是否可用。如果某个控件未将 OnPaint 作为成员方法列出，
                //则你无法通过重写此方法改变外观。

                //MSDN：要了解可用的Message.Msg,Message.LParam 和 Message.WParam 值，
                //请参考位于 MSND Library 中的 Platform SDK 文档参考。可在 Platform SDK ("Core SDK" 一节)
                //下载中包含的 windows.h 头文件中找到实际常数值，该文件也可在 MSDN上找到.
                IntPtr hDC = GetWindowDC(m.HWnd);
                if (hDC.ToInt32() == 0)
                    return;
                //只有在边框为FixedSingle时自定义边框样式才有效
                if (this.BorderStyle == BorderStyle.FixedSingle)
                {
                    //边框Width为 2个像素
                    Pen p = new Pen(this._BorderColor, 2);
                    if (this._HotTrack)
                    {
                        if (this.Focused)
                        {
                            p.Color = this._HotColor;
                        }
                    }
                    else
                    {
                        if (this._IsMouseOver)
                        {
                            p.Color = this._HotColor;
                        }
                        else
                        {
                            p.Color = this._BorderColor;
                        }
                    }
                    //绘制边框
                    Graphics g = Graphics.FromHdc(hDC);
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.DrawRectangle(p, 0, 0, this.Width - 2, this.Height - 2);
                    p.Dispose();
                }
                //返回结果
                m.Result = IntPtr.Zero;
                //释放
                ReleaseDC(m.HWnd, hDC);
            }

        }

    }
}
