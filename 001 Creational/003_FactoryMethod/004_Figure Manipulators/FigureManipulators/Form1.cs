using System;
using System.Drawing;
using System.Windows.Forms;

namespace FigureManipulators
{
    public partial class Form1 : Form
    {
        Point startPoint, endPoint;
        Figure lineFigure, textFigure;
        bool lineFigureSelected;
        bool textFigureSelected;
        bool mouseButtonPressed;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
            mouseButtonPressed = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (mouseButtonPressed && lineFigureSelected)
            {
                endPoint = e.Location;
                lineFigure = new LineFigure(startPoint, endPoint);
                this.Controls.Add(lineFigure.manipulator);
                this.Refresh();
            }
            mouseButtonPressed = false;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && textFigureSelected)
            {
                startPoint = e.Location;
                textFigure = new TextFigure(startPoint);
                this.Controls.Add(textFigure.manipulator);
                this.Refresh();
            }
        }

        private void add_Line_btn_Click(object sender, EventArgs e)
        {
            lineFigureSelected = true;
            textFigureSelected = false;
        }

        private void add_Text_btn_Click(object sender, EventArgs e)
        {
            textFigureSelected = true;
            lineFigureSelected = false;
        }
    }
}
