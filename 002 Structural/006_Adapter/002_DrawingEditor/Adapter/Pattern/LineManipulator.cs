using System;
using System.Drawing;
using System.Windows.Forms;

namespace Adapter
{
    class LineManipulator : Manipulator
    {
        int deltaX, deltaY;
        Point currentMouse;
        bool mousePressed = false;
        Pen color;

        // Метод определяющий начальный и конечные координаты манипулятора на форме
        Point GetManipulatorLocation()
        { 
            int x ,y;
            x = StartPoint.X < EndPoint.X ? StartPoint.X : EndPoint.X;
            y = StartPoint.Y < EndPoint.Y ? StartPoint.Y : EndPoint.Y;
            return new Point(x, y);
        }

        // Метод возвращающий глобальные координаты курсора на контроле относительно формы 
        Point GetMouseLocation(Point curMouse)
        {
            return new Point(curMouse.X + this.Location.X, curMouse.Y + this.Location.Y);
        }

        // Метод задания параметров манипулятора и его обновление
        void GeDrawControl(Point startPoint, Point endPoint)
        {
            Size = new Size(Math.Abs(startPoint.X - endPoint.X), Math.Abs(startPoint.Y - endPoint.Y));
            Location = GetManipulatorLocation();
            RecreateHandle();
            Refresh();
        }

        public LineManipulator(Point startPoint, Point endPoint, Pen color)
        {
            this.color = color;
            StartPoint = startPoint;
            EndPoint = endPoint;
            GeDrawControl(startPoint, endPoint);
        }
        
        // Прорисовка линии в контроле
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawLine(color, new Point(StartPoint.X - Location.X, StartPoint.Y - Location.Y), 
                                                        new Point(EndPoint.X - Location.X, EndPoint.Y - Location.Y));
        }

        // Захват курсором манипулятора
        protected override void OnMouseDown(MouseEventArgs e)
        {   
                base.OnMouseDown(e);
                currentMouse = GetMouseLocation(e.Location);
                mousePressed = true;
                Cursor = Cursors.Hand;
        }

        // Определение новых координат после перетаскивания и задание нового состояния манипулятора 
        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (mousePressed)
            {
                base.OnMouseUp(e);
                deltaX = GetMouseLocation(e.Location).X - currentMouse.X;
                deltaY = GetMouseLocation(e.Location).Y - currentMouse.Y;
                StartPoint = new Point(StartPoint.X + deltaX, StartPoint.Y + deltaY);
                EndPoint = new Point(EndPoint.X + deltaX, EndPoint.Y + deltaY);
                GeDrawControl(StartPoint, EndPoint);
                currentMouse = GetMouseLocation(e.Location);                
            }
            else
                mousePressed = false;
            Cursor = Cursors.Arrow;
        }
    }
}
