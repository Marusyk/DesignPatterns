using System;
using System.Windows.Forms;
using PianoSoundLibrary.Library;
using System.Collections.Generic;

namespace MusicNotes
{
    public partial class Form1 : Form
    {
        private MusicalNote whole;
        private MusicalNote half;
        private MusicalNote quarter;
        private MusicalNote sixteenth;
        private MusicalNote eighth;
        private Staff staff;
        private Tool tool;

        public Position NotePosition { get; set; }
        public Position StaffPosition { get; set; }

        private OutputDevice outputDevice;

        public OutputDevice OutputDevice
        {
            get { return outputDevice; }
        }

        #region form constructor
        public Form1()
        {
            InitializeComponent();
            eighth = new MusicalNote(this, 125);
            sixteenth = new MusicalNote(this, 62);
            quarter = new MusicalNote(this, 250);
            half = new MusicalNote(this, 500);
            whole = new MusicalNote(this, 1000);
            staff = new Staff(this);
            NotePosition = new Position(43, 32);
            StaffPosition = new Position(20, 19);
            outputDevice = new OutputDevice(0);
            drawObject(staff);
        }
        #endregion

        #region events

        private void Form1_Resize(object sender, EventArgs e)
        {
            foreach (var item in RegisteredMusicalObjects.NotesList)
            {
                item.RefreshView();
            }
        }
        private void btnRotate_Click(object sender, EventArgs e)
        {
            tool = new RotateTool(scoreSheetPanel);
            tool.Manipulate();
        }

        private void btnWholeNote_Click(object sender, EventArgs e)
        {
            drawObject(whole);
        }

        private void btnHalfNote_Click(object sender, EventArgs e)
        {
            drawObject(half);
        }

        private void btnQuarterNote_Click(object sender, System.EventArgs e)
        {
            drawObject(quarter);
        }

        private void btnEighthNote_Click(object sender, EventArgs e)
        {
            drawObject(eighth);
        }

        private void btnSixteenthNote_Click(object sender, EventArgs e)
        {
            drawObject(sixteenth);
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            outputDevice.Dispose();
        }

        private void btnAbove_Click(object sender, EventArgs e)
        {
            tool = new RelocationTool(scoreSheetPanel);
            tool.Manipulate();
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            RegisteredMusicalObjects.PlayMelody();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearWorkspace();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            loadFile(openFileDialog1.FileName);
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            saveFileAs(saveFileDialog1.FileName);
        }

        private void btnDelNote_Click(object sender, EventArgs e)
        {
            deleteLastNote();
        }

        private void btnUnMark_Click(object sender, EventArgs e)
        {
            UnMarkAll();
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void scoreSheetPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            btnDelNote.Enabled = RegisteredMusicalObjects.NotesList.Count > 0;
            btnPlay.Enabled = RegisteredMusicalObjects.NotesList.Count > 0;
        }

        private void scoreSheetPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            btnDelNote.Enabled = !(RegisteredMusicalObjects.NotesList.Count == 1);
            btnPlay.Enabled = !(RegisteredMusicalObjects.NotesList.Count == 1);
        }
        #endregion

        #region private methods

        private void loadFile(string filePath)
        {
            ClearWorkspace();
            List<MusicalNote> notesToDraw = NotesSerializer.Deserialize(filePath);
            foreach (var note in notesToDraw)
            {
                note.SetFormWorkSpace(this);
                this.drawNoteFromFile(note);
            }
        }

        private void saveFileAs(string filePath)
        {
            NotesSerializer.Serialize(RegisteredMusicalObjects.NotesList, filePath);
        }

        private void deleteLastNote()
        {
            if (NotePosition.X == 43)
            {
                RegisteredMusicalObjects.UnregisterLastStaff();
                StaffPosition = Position.CalculateStaffPositionOnDeletion(StaffPosition);
            }
            RegisteredMusicalObjects.UnregisterLastNote();
            NotePosition = Position.CalculateNotePositionOnDeletion(NotePosition);
            foreach (var control in scoreSheetPanel.Controls)
            {
                if (control is NoteTranspControl)
                {
                    (control as NoteTranspControl).Hide();
                    (control as NoteTranspControl).Refresh();
                    (control as NoteTranspControl).Show();
                }

            }
        }

        private void drawObject(Graphic obj)
        {
            bool changeFlag = false;
            if (obj is MusicalNote)
            {
                foreach (var control in scoreSheetPanel.Controls)
                {
                    if (control is NoteTranspControl)
                    {
                        if ((control as NoteTranspControl).Marked)
                        {
                            (control as NoteTranspControl).ControlNote.NoteType = (obj as MusicalNote).NoteType;
                            (control as NoteTranspControl).ControlNote.Duration = (obj as MusicalNote).Duration;
                            (control as NoteTranspControl).ResetNoteImage();
                            changeFlag = true;
                        }
                    }
                }
            }
            if (!changeFlag)
            {
                tool = new GraphicTool(obj, scoreSheetPanel);
                tool.Manipulate();
                if (obj is MusicalNote)
                {
                    if (RegisteredMusicalObjects.NotesList[RegisteredMusicalObjects.NotesList.Count - 1].Location.X > 900)
                        drawObject(staff);
                }
            }
        }

        private void drawNoteFromFile(MusicalNote note)
        {
            note.Draw(this.NotePosition);
            this.NotePosition = Position.CalculateNotePosition(this.NotePosition);
            if (RegisteredMusicalObjects.NotesList[RegisteredMusicalObjects.NotesList.Count - 1].Location.X > 900)
                drawObject(staff);
        }

        /// <summary>
        /// Метод снятия выделения со всех выделеных нот.
        /// </summary>
        private void UnMarkAll()
        {
            foreach (var control in scoreSheetPanel.Controls)
            {
                if (control is NoteTranspControl)
                {
                    if ((control as NoteTranspControl).Marked) (control as NoteTranspControl).Marked = false;
                    (control as NoteTranspControl).DeselectNote();
                }
            }
        }

        /// <summary>
        /// Метод очистки среды.
        /// </summary>
        private void ClearWorkspace()
        {
            TranspControl controlToDelete;
            List<TranspControl> controlsToDelete = new List<TranspControl>();
            foreach (var c in this.scoreSheetPanel.Controls)
            {
                controlToDelete = c as TranspControl;
                if (controlToDelete != null) controlsToDelete.Add(controlToDelete);
            }
            foreach (TranspControl c in controlsToDelete) c.Dispose();
            RegisteredMusicalObjects.UnRegisterAll();
            NotePosition = new Position(43, 32);
            StaffPosition = new Position(20, 19);
            drawObject(staff);
        }

        #endregion

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
