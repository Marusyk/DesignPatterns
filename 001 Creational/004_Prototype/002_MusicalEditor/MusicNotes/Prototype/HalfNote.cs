using System;
using System.Windows.Forms;
using MusicNotes.Properties;


namespace MusicNotes
{
    /// <summary>
    /// ConcretePrototype: Класс Half Note (половинная нота) 
    /// конкретный прототип:-реализует операцию клонирования себя
    /// </summary>
    public class HalfNote : MusicalNote
    {

        public HalfNote(Form form)
            :base(form)
        {
            duration = 500;
            value = 100;
            image = Resources.HalfNote;
        }

        public override void Draw(Position position)
        { 
            TranspControl control=new TranspControl();
            control.BackColor = System.Drawing.Color.Transparent;
            control.BrushColor = System.Drawing.Color.Transparent;
            control.Size = new System.Drawing.Size(15,15);
            control.Image = Resources.HalfNoteSmall;
            control.Location = new System.Drawing.Point(position.X, position.Y);
            control.Name = "transpControl1";
            control.Opacity = 100;
            form.Controls.Add(control);
            form.ResumeLayout(false);

            Play();
        }

        public override Graphic Clone()
        {
            return new HalfNote(form);
        }
    }
}
