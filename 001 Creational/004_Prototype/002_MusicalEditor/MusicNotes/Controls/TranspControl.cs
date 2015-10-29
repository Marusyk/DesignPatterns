using System;
using System.Drawing;
using System.Windows.Forms;
using MusicNotes.Properties;

namespace MusicNotes
{
    public abstract class TranspControl : Control
    {
        private Color brushColor = Color.Transparent;
        private int opacity = 100;
        private Image image;

        public bool Marked { get; set; }
        public bool Rotated { get; set; }

        public Image Image
        {
            get { return this.image; }
            set
            {
                if (value != null)
                {
                    this.image = value;
                }
            }
        }

        public Color BrushColor
        {
            get
            {
                return this.brushColor;
            }
            set
            {
                this.brushColor = value;
                this.RecreateHandle();
            }
        }

        public int Opacity
        {
            get
            {
                if (this.opacity > 100)
                    this.opacity = 100;
                else if (this.opacity < 0)
                    this.opacity = 0;
                return this.opacity;
            }
            set
            {
                this.opacity = value;
                this.RecreateHandle();
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 32;
                return createParams;
            }
        }

        public TranspControl()
        {
            SetStyle(ControlStyles.UserMouse, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.Image = Resources.WholeNote;
            this.Width = 23;
            this.Height = 23;
            Marked = false;
            Rotated = false;
        }

        #region Events-Handlers
        protected override void OnPaintBackground(PaintEventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            Color baseColor = this.brushColor;
            int alpha = !(baseColor == Color.Transparent) ? this.opacity * byte.MaxValue / 100 : 0;
            Pen pen = new Pen(Color.Black);
            SolidBrush solidBrush = new SolidBrush(Color.FromArgb(alpha, baseColor));
            graphics.DrawImage(Image, new Point(0, 0));
            graphics.FillRectangle(solidBrush, rect);
            pen.Dispose();
            solidBrush.Dispose();
            graphics.Dispose();
        }

        protected override void OnMove(EventArgs e)
        {
            this.RecreateHandle();
        }

        #endregion


    }
}