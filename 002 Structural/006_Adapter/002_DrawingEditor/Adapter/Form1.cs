using System;
using System.Drawing;
using System.Windows.Forms;

namespace Adapter
{
    public partial class Form1 : Form
    {
        DrawingEditor drawingEditor;
        Point startPoint, endPoint;
        bool lineFigureSelected, textFigureSelected;
        bool mouseButtonPressed;
        string text;

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
                drawingEditor = new DrawingEditor(new Line(startPoint, endPoint));
                drawingEditor.Draw();
                Controls.Add(drawingEditor.Manipulator);
                Refresh();
            }
            mouseButtonPressed = false;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && textFigureSelected)
            {
                startPoint = e.Location;
                text = textBox1.Text;
                drawingEditor = new DrawingEditor(new TextShape(startPoint, text));
                drawingEditor.Draw();
                Controls.Add(drawingEditor.Manipulator);
                Refresh();
            }
        }

        private void AddLineButton_Click(object sender, EventArgs e)
        {
            lineFigureSelected = true;
            textFigureSelected = false;
        }

        private void AddTextButton_Click(object sender, EventArgs e)
        {
            textFigureSelected = true;
            lineFigureSelected = false;
        }
    }
}
