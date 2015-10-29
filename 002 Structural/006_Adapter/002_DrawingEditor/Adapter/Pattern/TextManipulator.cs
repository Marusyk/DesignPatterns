using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Adapter
{
    class TextManipulator : Manipulator
    {
        Label textInside;
        private int deltaX, deltaY;
        Point currentMouse;
        bool mousePressed = false;

        // Метод, возвращающий глобальные координаты курсора на контроле относительно формы 
        Point GetMouseLocation(Point curMouse)
        {
            return new Point(curMouse.X + this.Location.X, curMouse.Y + this.Location.Y);
        }

        // Перерисовка манипулятора
        void ReDrawControl(Point startPoint)
        {
            Size = new Size(textInside.Text.Length * 8, textInside.Size.Height);
            Location = startPoint;
            RecreateHandle();
            Refresh();
        }

        public TextManipulator(Point startPoint, Label label)
        {
            textInside = label;
            StartPoint = startPoint;
            ReDrawControl(startPoint);
            Controls.Add(textInside);
            textInside.MouseDown += TextInside_MouseDown;
            textInside.MouseUp += TextInside_MouseUp;
        }

        //методы обработчики textInside вызывающие переопределенние 
        //методы обработчики базового класса Manipulator
        void TextInside_MouseDown(object sender, MouseEventArgs e)
        {
            OnMouseDown(e);
        }

        void TextInside_MouseUp(object sender, MouseEventArgs e)
        {
            OnMouseUp(e);
        }

        // Метод определяющий новые координаты манипулятора на форме
        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (mousePressed)
            {
                base.OnMouseUp(e);
                deltaX = GetMouseLocation(e.Location).X - currentMouse.X;
                deltaY = GetMouseLocation(e.Location).Y - currentMouse.Y;
                StartPoint = new Point(StartPoint.X + deltaX, StartPoint.Y + deltaY);
                ReDrawControl(StartPoint);
                currentMouse = GetMouseLocation(e.Location);
            }
            else
                mousePressed = false;
            Cursor = Cursors.Arrow;
        }

        // Определение координат текущего манипулятора по клику
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            currentMouse = GetMouseLocation(e.Location);
            mousePressed = true;
            Cursor = Cursors.Hand;
        }
    }
}
