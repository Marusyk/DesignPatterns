using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FigureManipulators
{
    class RectangleManipulator : Manipulator
    {
        private int deltaX, deltaY;
        Point currentMouse;
        bool mousePressed = false;

        private Point getManipulatorLocation()
        {
            int x, y;
            x = StartPoint.X < EndPoint.X ? StartPoint.X : EndPoint.X;
            y = StartPoint.Y < EndPoint.Y ? StartPoint.Y : EndPoint.Y;
            return new Point(x, y);
        }

        private Point getMouseLocation(Point curMouse)
        {
            return new Point(curMouse.X + this.Location.X, curMouse.Y + this.Location.Y);
        }

        private void ReDraw(Point startPoint, Point endPoint)
        {
            this.Size = new Size(Math.Abs(startPoint.X - endPoint.X), Math.Abs(startPoint.Y - endPoint.Y));
            this.Location = getManipulatorLocation();
            this.RecreateHandle();
            this.Refresh();
        }

        public RectangleManipulator(Point startPoint, Point endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
            ReDraw(startPoint, endPoint);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Size s = new Size(20, 20);
            //Point p = new Point(this.Location.X - this.Size.Width,this.Location.Y - this.Size.Height);
            Rectangle rect = new Rectangle(this.Location, this.Size);
           
            e.Graphics.DrawRectangle(new Pen(Color.Blue, 2), rect);
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            currentMouse = getMouseLocation(e.Location);
            mousePressed = true;
            this.Cursor = Cursors.Hand;
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (mousePressed)
            {
                base.OnMouseMove(e);
                //this.Location = getMouseLocation(e.Location);
                this.Refresh();
            }
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (mousePressed)
            {
                base.OnMouseUp(e);
                deltaX = getMouseLocation(e.Location).X - currentMouse.X;
                deltaY = getMouseLocation(e.Location).Y - currentMouse.Y;
                StartPoint = new Point(StartPoint.X + deltaX, StartPoint.Y + deltaY);
                EndPoint = new Point(EndPoint.X + deltaX, EndPoint.Y + deltaY);
                ReDraw(StartPoint, EndPoint);
                currentMouse = getMouseLocation(e.Location);
            }
            else
                mousePressed = false;
            this.Cursor = Cursors.Arrow;
        }
    }
}
