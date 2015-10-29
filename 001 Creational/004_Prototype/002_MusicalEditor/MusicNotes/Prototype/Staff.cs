using System.Windows.Forms;
using MusicNotes.Properties;

namespace MusicNotes
{
    /// <summary>
    /// ConcretePrototype:Класс Staff (нотный стан) конкретный прототип-реализует операцию клонирования себя
    /// </summary>
    public class Staff : Graphic
    {
        public Staff(Form form)
            : base(form)
        {
            image = Resources.Staff;
        }

        public void setFirstKeyImage()
        {
        }

        public override void Draw(Position position)
        {
            StaffTranspControl control = new StaffTranspControl();
            control.BackColor = System.Drawing.Color.Transparent;
            control.BrushColor = System.Drawing.Color.Transparent;
            control.Size = new System.Drawing.Size(23, 25);            
            control.Location = new System.Drawing.Point(position.X, position.Y);
            if (control.Location.X != 20)
            {
                image = Resources.Staff;
                control.Image = image;
            }
            else
            {
                image = Resources.key;
                control.Image = image;
            }
            control.Opacity = 100;
            control.Enabled = false;
            scoreSheetPanel.Controls.Add(control);
            RegisteredMusicalObjects.RegisterObject(control);
            form.ResumeLayout(false);            
        }

        public override Graphic Clone()
        {
            return new Staff(form);
        }
    }
}
