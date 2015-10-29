using System;
using System.Windows.Forms;
using MusicNotes.Properties;

namespace MusicNotes
{
    /// <summary>
    /// ConcretePrototype: Класс WholeNote (целая нота) конкретный прототип-реализует операцию клонирования себя
    /// </summary>
    public class WholeNote : MusicalNote
    {

        public WholeNote(Form form)
            : base(form)
        {
            duration = 1000;
            value = 100;
            image = Resources.WholeNote;
        }

        public override void Draw(Position position)
        {
            TranspControl control = new TranspControl();
            control.BackColor = System.Drawing.Color.Transparent;
            control.BrushColor = System.Drawing.Color.Transparent;
            control.Image = Resources.WholeNoteSmall;
            control.Location = new System.Drawing.Point(position.X, position.Y);
            control.Name = "transpControl1";
            control.Opacity = 100;
            control.Size = new System.Drawing.Size(15, 15);
            form.Controls.Add(control);
            form.ResumeLayout(false);

            Play();
        }

        public override Graphic Clone()
        {
            return new WholeNote(form);
        }

    }
}
