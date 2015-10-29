using System.Drawing;
using System.Windows.Forms;


namespace MusicNotes
{
    public class RotateTool : Tool
    {
        public RotateTool(Panel panel)
            : base(panel)
        {
        }

        public override void Manipulate()
        {
            if (scoreSheetPanel == null)
                return;

            // Повернуть все выделеные ноты
            foreach (Control c in scoreSheetPanel.Controls)
            {
                {
                    var curPB = c as TranspControl;

                    if (curPB != null && curPB is NoteTranspControl)
                    {
                        var pb = curPB as NoteTranspControl;

                        if (pb.Marked)
                        {
                            Image image = Rotate.RotateImage(pb.Image, new Point(0, 0), 180);
                            pb.Image = image;
                            pb.Hide();
                            pb.Refresh();
                            pb.Show();

                            if (!pb.Rotated)
                                pb.Rotated = true;
                            else
                                pb.Rotated = false;

                            scoreSheetPanel.ResumeLayout(false);
                        }
                    }
                }
            }
        }
    }
}

