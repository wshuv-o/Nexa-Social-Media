using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace media
{
    public class CustomRoundPictureBox:PictureBox
    {
        private int borderSize = 2;
        private Color borderColor = Color.RoyalBlue;
        private Color borderColor2 = Color.HotPink;
        private DashStyle borderLineStyle = DashStyle.Solid;
        private DashCap borderCapStyle = DashCap.Flat;
        private float gradientAngle = 50F;

        public CustomRoundPictureBox()
        {
            this.Size = new Size(100, 100);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; this.Invalidate( ); }
        }
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; this.Invalidate(); }
        }
        public Color BorderColor2
        {
            get { return borderColor2; }
            set { borderColor2 = value; this.Invalidate(); }
        }
        public DashStyle BorderLineStyle
        {
            get { return borderLineStyle; }
            set
            {
                borderLineStyle = value;
                this.Invalidate();
            }
        }
        public DashStyle BorderDashStyle { 
        
            get { return borderLineStyle; }
            set
            {
                borderLineStyle = value;
                this.Invalidate();
            }
        }
        public DashCap BorderCapStyle
        {
            get { return borderCapStyle; }
            set
            {
                this.borderCapStyle = value; this.Invalidate();
            }
        }
        public float GradientAngle
        {
            get { return gradientAngle; }

            set
            {
                gradientAngle = value;
                this.Invalidate();
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Size = new Size(this.Width, this.Height);
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            var graph = pe.Graphics;
            var rectContourSmooth = Rectangle.Inflate(this.ClientRectangle, -1, -1);
            var rectBorder = Rectangle.Inflate(rectContourSmooth, -borderSize, -borderSize);
            var smoothSize = borderSize > 0 ? borderSize * 3 : 1;
            using (var borderColor= new LinearGradientBrush(rectBorder, this.borderColor, this.borderColor2, gradientAngle))
            using (var pathRegion = new GraphicsPath())
            using (var penSmooth = new Pen(this.Parent.BackColor,  smoothSize))
            using(var penBorder= new Pen(borderColor, borderSize))
            {
                penBorder.DashStyle = BorderLineStyle;
                penBorder.DashCap = borderCapStyle;
                pathRegion.AddEllipse(rectContourSmooth);
                this.Region = new Region(pathRegion);
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                graph.DrawEllipse(penSmooth, rectContourSmooth);
                if (this.borderSize > 0)
                {
                    graph.DrawEllipse(penBorder, rectBorder);
                }


            }
        }

    }
}
