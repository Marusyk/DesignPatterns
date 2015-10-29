using System.Windows.Forms;
using System.Drawing;

namespace FigureManipulators
{
    class TextManipulator : Manipulator
    {
        Label textInside;
        int deltaX, deltaY;
        Point currentMouse;
        bool mousePressed;

        // Метод возвращающий глобальные координаты курсора на контроле относительно формы. 
        Point getMouseLocation(Point curMouse)
        {
            return new Point(curMouse.X + this.Location.X, curMouse.Y + this.Location.Y);
        }

        // Перерисовка манипулятора.
        void reDrawControl(Point startPoint)
        {
            this.Size = new Size(87, 13);
            this.Location = startPoint;
            this.RecreateHandle();
            setLable();
            this.Refresh();
        }

        // Задание параметров textInside.
        void setLable()
        {
            textInside.Location = new Point(0, 0);
            textInside.Size = this.Size;
            textInside.Text = "HELLO!!!";
            this.textInside.Refresh();
        }

        public TextManipulator(Point startPoint)
        {
            textInside = new Label();
            StartPoint = startPoint;
            reDrawControl(startPoint);
            this.Controls.Add(textInside);
            textInside.MouseDown += textInside_MouseDown;
            textInside.MouseUp += textInside_MouseUp;
        }

        // Методы обработчики textInside вызывающие переопределенные 
        // методы обработчики базового класса Manipulator.
        void textInside_MouseDown(object sender, MouseEventArgs e)
        {
            this.OnMouseDown(e);
        }

        void textInside_MouseUp(object sender, MouseEventArgs e)
        {
            this.OnMouseUp(e);
        }

        // Задание параметров манипулятора при перерисовке.
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            textInside.ForeColor = Color.Red;
        }

        // Метод определяющий новые координаты манипулятора на форме.
        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (mousePressed)
            {
                base.OnMouseUp(e);
                deltaX = getMouseLocation(e.Location).X - currentMouse.X;
                deltaY = getMouseLocation(e.Location).Y - currentMouse.Y;
                StartPoint = new Point(StartPoint.X + deltaX, StartPoint.Y + deltaY);
                reDrawControl(StartPoint);
                currentMouse = getMouseLocation(e.Location);
            }
            else
            {
                mousePressed = false;
            }
            this.Cursor = Cursors.Arrow;
        }

        // Определение координат текущего манипулятора по клику.
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            currentMouse = getMouseLocation(e.Location);
            mousePressed = true;
            this.Cursor = Cursors.Hand;
        }
    }
}
