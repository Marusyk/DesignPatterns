
using System.Windows.Forms;

namespace MusicNotes
{
    /// <summary>
    /// Client: Класс GraphicTool для инструментов, которые создают графические объекты и добавляют их в документ.
    /// Создает новый объект, обращаясь к прототипу с запросом клонировать себя.
    /// </summary>
    /// 
    public class GraphicTool : Tool
    {
        private Graphic prototype;

        public GraphicTool(Graphic prototype, Panel panel)
            : base(panel)
        {
            this.prototype = prototype;
        }

        public override void Manipulate()
        {
            Form1 curForm = scoreSheetPanel.FindForm() as Form1;
            Graphic p = prototype.Clone();

            if (p is MusicalNote)
            {
                p.Draw(curForm.NotePosition);
                curForm.NotePosition = Position.CalculateNotePosition(curForm.NotePosition);
            }
            else
            {
                Position.CalculateStaffPosition(curForm.StaffPosition);

                for (int i = 0; i < 40; i++)
                {
                    p.Draw(curForm.StaffPosition);
                    curForm.StaffPosition = Position.CalculateStaffPosition(curForm.StaffPosition);
                }
            }
        }
    }
}
