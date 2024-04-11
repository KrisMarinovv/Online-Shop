using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;

namespace Online_Shop.Resources
{
    public partial class RoundControl : Button
    {
        private int m_BorderSize = 2;
        private int m_ButtonRoundRadius = 15;

        private bool IsHighlighted = false;
        private bool IsPressed = false;

        public RoundControl()
        {
            SetStyle(ControlStyles.Opaque |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, false);
            this.DoubleBuffered = false;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Size = new Size(100, 40);
            BackColor = Color.FromArgb(187, 226, 236);
            BackColor2 = Color.FromArgb(187, 226, 236);
            ButtonBorderColor = Color.Black;
            ButtonHighlightColor = Color.FromArgb(255, 232, 199);
            ButtonHighlightColor2 = Color.FromArgb(255, 232, 199);
            ButtonHighlightForeColor = Color.Black;

            ButtonPressedColor = Color.FromArgb(255, 232, 199);
            ButtonPressedColor2 = Color.FromArgb(255, 232, 199);
            ButtonPressedForeColor = Color.White;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020;
                return cp;
            }
        }

        public int BorderSize
        {
            get => m_BorderSize;
            set
            {
                m_BorderSize = Math.Max(Math.Min(value, 6), 0);
                RepaintControl();
            }
        }

        public int ButtonRoundRadius
        {
            get => m_ButtonRoundRadius;
            set
            {
                m_ButtonRoundRadius = Math.Max(Math.Min(value, 44), 1);
                RepaintControl();
            }
        }

        public override string Text
        {
            get => base.Text;
            set
            {
                base.Text = value;
                RepaintControl();
            }
        }

        public Color BorderColor { get; set; } = Color.Tomato;
        public Color BackColor2 { get; set; } = Color.Tomato;

        public Color ButtonBorderColor { get; set; }
        public Color ButtonHighlightColor { get; set; }
        public Color ButtonHighlightColor2 { get; set; }
        public Color ButtonHighlightForeColor { get; set; }
        public Color ButtonPressedColor { get; set; }
        public Color ButtonPressedColor2 { get; set; }
        public Color ButtonPressedForeColor { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            var foreColor = IsPressed ? ButtonPressedForeColor : IsHighlighted ? ButtonHighlightForeColor : ForeColor;
            var backColor = IsPressed ? ButtonPressedColor : IsHighlighted ? ButtonHighlightColor : BackColor;
            var backColor2 = IsPressed ? ButtonPressedColor2 : IsHighlighted ? ButtonHighlightColor2 : BackColor2;
            var rect = Path.GetBounds();

            using (var pen = new Pen(ButtonBorderColor, m_BorderSize))
            using (var pathBrush = new LinearGradientBrush(rect, backColor, backColor2, LinearGradientMode.Vertical))
            using (var textBrush = new SolidBrush(foreColor))
            using (var sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;

                e.Graphics.FillPath(pathBrush, Path);
                if (m_BorderSize > 0) e.Graphics.DrawPath(pen, Path);

                rect.Inflate(-4, -4);
                e.Graphics.DrawString(Text, Font, textBrush, rect, sf);
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            IsHighlighted = true;
            RepaintControl();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            IsHighlighted = false;
            IsPressed = false;
            RepaintControl();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            IsPressed = true;
            RepaintControl();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            IsPressed = false;
            RepaintControl();
        }

        private void RepaintControl()
        {
            Parent?.Invalidate(this.Bounds, true);
            Invalidate();
        }

        private GraphicsPath Path
        {
            get
            {
                var rect = ClientRectangle;
                int scaleOnBorder = -((m_BorderSize / 2) + 2);
                rect.Inflate(scaleOnBorder, scaleOnBorder);
                return GetRoundedRectangle(rect, m_ButtonRoundRadius);
            }
        }

        private GraphicsPath GetRoundedRectangle(Rectangle rect, int d)
        {
            var gp = new GraphicsPath();
            gp.StartFigure();
            gp.AddArc(rect.X, rect.Y, d, d, 180, 90);
            gp.AddArc(rect.X + rect.Width - d, rect.Y, d, d, 270, 90);
            gp.AddArc(rect.X + rect.Width - d, rect.Y + rect.Height - d, d, d, 0, 90);
            gp.AddArc(rect.X, rect.Y + rect.Height - d, d, d, 90, 90);
            gp.CloseFigure();
            return gp;
        }
    }
}
