using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FigureManipulators
{
    class RectangleFigure : Figure
    {
        private Point endPoint;
        private Point startPoint;

        public RectangleFigure(Point startPoint, Point endPoint)
        {
            this.startPoint = startPoint;
            this.endPoint = endPoint;
            manipulator = CreateManipulator();
        }

        public override Manipulator CreateManipulator()
        {
            return new RectangleManipulator(startPoint, endPoint);
        }
    }
}
