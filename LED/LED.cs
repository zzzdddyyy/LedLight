using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace LED
{
    public partial class LED : UserControl
    {
        public LED()
        {
            InitializeComponent();
            Catch_Load(null, null);
        }
        //窗体初始化操作
        private void Catch_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);//调整大小
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.UpdateStyles();
            //以上两句是为了设置控件样式为双缓冲，这可以有效减少图片闪烁的问题
        }


        #region LED属性
        private Color centerColor = Color.White;
        private Color gridentColor = Color.LightGreen;
        private Color borderColor = Color.LightGray;
        private int borderWidth = 2;
        private int distance = 4;
        /// <summary>
        /// 中心颜色
        /// </summary>
        [Category("LED")]
        [Description("中心颜色 by BT zdy")]
        public Color CenterColor
        {
            get { return centerColor; }
            set { centerColor = value; Invalidate(); }
        }
        /// <summary>
        /// 渐变颜色
        /// </summary>
        [Category("LED")]
        [Description("渐变颜色 by BT zdy")]
        public Color GridentColor
        {
            get { return gridentColor; }
            set { gridentColor = value; Invalidate(); }
        }
        /// <summary>
        /// 边框颜色
        /// </summary>
        [Category("LED")]
        [Description("边线颜色 by BT zdy")]
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); }
        }

        /// <summary>
        /// 边框线宽
        /// </summary>
        [Category("LED")]
        [Description("边线宽度 by BT zdy")]
        public int BorderWidth
        {
            get { return borderWidth; }
            set { borderWidth = value; Invalidate(); }
        }
        /// <summary>
        /// 中心距
        /// </summary>
        [Category("LED")]
        [Description("中心距 by BT zdy")]
        public int Distance
        {
            get { return distance; }
            set { distance = value; Invalidate(); }
        }
        #endregion

        /// <summary>
        /// 重绘控件
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {

            //1、创建画布
            Graphics g = e.Graphics; //创建画板,这里的画板是由Form提供的.

            // 提高GDI显示效果
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;//抗锯齿
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            //2、准备画笔
            Pen p = new Pen(borderColor, borderWidth);
            //定义矩形，作为外圆圆的外接矩形
            Rectangle rectangleOut = new Rectangle(borderWidth, borderWidth, this.Width - 2 * borderWidth, this.Height - 2 * borderWidth);
            g.DrawEllipse(p, rectangleOut);
            //2、准备画笔

            //定义矩形，作为nei圆圆的外接矩形
            Rectangle rectangleIn = new Rectangle(borderWidth + distance, borderWidth + distance, this.Width - 2 * borderWidth - 2 * distance, this.Height - 2 * borderWidth - 2 * distance);
            g.DrawEllipse(p, rectangleIn);


            //3、路径填充
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(rectangleIn);
            PathGradientBrush pathGradientBrush = new PathGradientBrush(path);
            pathGradientBrush.CenterColor = centerColor;//中心颜色
            pathGradientBrush.SurroundColors = new Color[] { gridentColor };//四周颜色

            g.FillPath(pathGradientBrush, path);
            base.OnPaint(e);
        }
    }
}
