using System;
using System.Drawing;
using System.Windows.Forms;

namespace FigureManipulators
{
    class LineManipulator : Manipulator
    {
        int deltaX, deltaY;
        Point currentMouse;
        bool mousePressed;

        // Метод определяющий начальные и конечные координаты манипулятора на форме.
        Point getManipulatorLocation()
        {
            int x, y;
            x = StartPoint.X < EndPoint.X ? StartPoint.X : EndPoint.X;
            y = StartPoint.Y < EndPoint.Y ? StartPoint.Y : EndPoint.Y;
            return new Point(x, y);
        }

        // Метод возвращающий глобальные координаты курсора на контроле относительно формы. 
        Point getMouseLocation(Point curMouse)
        {
            return new Point(curMouse.X + this.Location.X, curMouse.Y + this.Location.Y);
        }

        // Метод задания параметров манипулятора и его обновление.
        void reDrawControl(Point startPoint, Point endPoint)
        {
            this.Size = new Size(Math.Abs(startPoint.X - endPoint.X), Math.Abs(startPoint.Y - endPoint.Y));
            this.Location = getManipulatorLocation();
            this.RecreateHandle();
            this.Refresh();
        }

        public LineManipulator(Point startPoint, Point endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
            reDrawControl(startPoint, endPoint);
        }

        // Прорисовка линии в контроле.
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawLine(new Pen(Color.Blue, 2), new Point(StartPoint.X - Location.X, StartPoint.Y - Location.Y),
                                                        new Point(EndPoint.X - Location.X, EndPoint.Y - Location.Y));
        }

        // Захват курсором манипулятора.
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            currentMouse = getMouseLocation(e.Location);
            mousePressed = true;
            this.Cursor = Cursors.Hand;
        }

        // Определение новых координат после перетаскивания и 
        // задание нового состояния манипулятора.
        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (mousePressed)
            {
                base.OnMouseUp(e);
                deltaX = getMouseLocation(e.Location).X - currentMouse.X;
                deltaY = getMouseLocation(e.Location).Y - currentMouse.Y;
                StartPoint = new Point(StartPoint.X + deltaX, StartPoint.Y + deltaY);
                EndPoint = new Point(EndPoint.X + deltaX, EndPoint.Y + deltaY);
                reDrawControl(StartPoint, EndPoint);
                currentMouse = getMouseLocation(e.Location);
            }
            else
            {
                mousePressed = false;
            }
            this.Cursor = Cursors.Arrow;
        }
    }
}
