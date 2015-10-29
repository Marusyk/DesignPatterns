using System.Collections.Generic;
using System.Windows.Forms;

namespace MusicNotes
{
    public static class RegisteredMusicalObjects
    {
        /// <summary>
        /// Текущий список нот
        /// </summary>
        public static List<NoteTranspControl> NotesList { get; private set; }
        /// <summary>
        /// Текущий список станов
        /// </summary>
        public static List<StaffTranspControl> StaffList { get; private set; }

        static RegisteredMusicalObjects()
        {
            NotesList = new List<NoteTranspControl>();
            StaffList = new List<StaffTranspControl>();
        }
        
        /// <summary>
        /// Метод проигрывания мелодии
        /// </summary>
        public static void PlayMelody()
        {
            foreach (var control in NotesList)
            {
                control.ControlNote.Play();
            }
        }

        /// <summary>
        /// Заорегистрировать объект в реестре объектов
        /// </summary>
        /// <param name="control">TranspControl(стан или нота)</param>
        public static void RegisterObject(TranspControl control)
        {
            if(control is NoteTranspControl)NotesList.Add(control as NoteTranspControl);
            if (control is StaffTranspControl) StaffList.Add(control as StaffTranspControl);
        }

        /// <summary>
        /// Очистить реестр
        /// </summary>
        public static void UnRegisterAll()
        {
            NotesList.Clear();
            StaffList.Clear();
        }

        /// <summary>
        /// Удалить последнюю ноту из реестра.
        /// </summary>
        public static void UnregisterLastNote()
        {
            if (NotesList.Count != 0)
            {
                Form1 noteForm = NotesList[NotesList.Count - 1].FindForm() as Form1;
                var getPanel = noteForm.Controls.Find("panel1",false)[0].Controls.Find("scoreSheetPanel", false)[0];
                Panel noteContainer = (getPanel as Panel);
                noteContainer.Controls.Remove(NotesList[NotesList.Count - 1]);
                NotesList.RemoveAt(NotesList.Count - 1);
            }
        }

        /// <summary>
        /// Удалить последний стан из реестра.
        /// </summary>
        public static void UnregisterLastStaff()
        {
            if (StaffList.Count != 0)
            {
                Form1 staffForm = StaffList[StaffList.Count - 1].FindForm() as Form1;
                var getPanel = staffForm.Controls.Find("panel1", false)[0].Controls.Find("scoreSheetPanel", false)[0];
                Panel staffContainer = (getPanel as Panel);
                for (int i = 0; i < 40; i++)
                {
                    staffContainer.Controls.Remove(StaffList[StaffList.Count - 1]);
                    StaffList.RemoveAt(StaffList.Count - 1);
                }
            }
        }

    }
}