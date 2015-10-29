using System;
using System.Threading;
using System.Windows.Forms;
using MusicNotes.Properties;
using PianoSoundLibrary.Library;
using System.Xml.Serialization;

namespace MusicNotes
{
    [XmlRoot("MusicalNote")]
    /// <summary>
    /// Абстрактный класс MusicalNote
    /// </summary>
    public class MusicalNote : Graphic
    {
        /// <summary>
        /// duration-длительность звучания ноты
        /// </summary>
        private int dur;
        /// <summary>
        /// идентификатор ноты max value=127
        /// </summary>
        private int value;
        //private Form1 form1;
        // private int p;

        [XmlAttribute("Duration")]
        public int Duration { get { return dur; } set { this.dur = value; } }

        [XmlAttribute("Value")]
        public int Value { get { return value; } set { this.value = value; } }

        [XmlIgnore]
        public NoteLength NoteType { get; set; }

        public MusicalNote()
        {

        }

        public MusicalNote(Form form, int noteDur)
            : base(form)
        {
            dur = noteDur;
            value = 60;
            this.getNoteImage(noteDur);
        }

        /// <summary>
        /// Возращает соответствующую ноте область нотного стана
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        private StaffTranspControl getRespStaff(TranspControl control)
        {
            foreach (var staff in RegisteredMusicalObjects.StaffList)
            {
                if (staff.Location.X == control.Location.X && staff.Location.Y == control.Location.Y - 13)
                {
                    return staff;
                }
            }
            return null;
        }

        /// <summary>
        /// Метод определение катинки ноты, которая соответствует заданой длине
        /// </summary>
        /// <param name="duration">Длина звучания ноты</param>
        private void getNoteImage(int duration)
        {
            switch (duration)
            {
                case 62:
                    image = Resources.SixteenthNoteSmall2323;
                    NoteType = NoteLength.Sixteenth;
                    break;
                case 125:
                    image = Resources.EighthNoteSmall2323;
                    NoteType = NoteLength.Eighth;
                    break;
                case 250:
                    image = Resources.QuarterNoteSmall2323;
                    NoteType = NoteLength.QuarterNote;
                    break;
                case 500:
                    image = Resources.HalfNoteSmall2323;
                    NoteType = NoteLength.HalfNote;
                    break;
                case 1000:
                    image = Resources.WholeNoteSmall2323;
                    NoteType = NoteLength.WholeNote;
                    break;
            }
        }

        /// <summary>
        /// protected метод Play(). Проигрывает ноту в зависимости от заданных ей характеристик
        /// </summary>
        public void Play()
        {
            try
            {
                var form1 = form as Form1;
                if (form1 != null && value <= 127)
                {
                    form1.OutputDevice.Send(new ChannelMessage(ChannelCommand.NoteOn, 0, value, 127));
                    Thread.Sleep(dur);
                    form1.OutputDevice.Send(new ChannelMessage(ChannelCommand.NoteOff, 0, value, 127));
                }
                else
                {
                    MessageBox.Show(Resources.MusicalNote_Play_Ошибка_задания_характеристик_ноты_);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Определение метода Draw
        /// </summary>
        /// <param name="position"></param>
        public override void Draw(Position position)
        {
            NoteTranspControl control = new NoteTranspControl(this);
            #region In case of Deserealization
            //-----------------------В случае десереализации----------------------------------------------
            //---------Добавление картинки к ноте соответственно длительности звучания
            if (this.image == null) this.getNoteImage(this.dur);
            //---------Переопределение позиции ноты по оси Y 
            int posYValidated = position.Y;
            if (this.value != 60)
            {
                for (int i = 60; i < this.value; i=i+1)
                {
                    if (!NotesCollections.SharpNotes.Contains(i)) posYValidated = posYValidated - 2;
                }
            }
            //--------------------------------------------------------------------------------------------
            #endregion
            control.BackColor = System.Drawing.Color.Transparent;
            control.BrushColor = System.Drawing.Color.Transparent;
            control.Location = new System.Drawing.Point(position.X, posYValidated);
            control.Name = "transpControl1";
            control.Opacity = 100;
            control.Image = image;
            control.Size = new System.Drawing.Size(this.image.Width, this.image.Height);
            control.StaffBinded = getRespStaff(control);
            scoreSheetPanel.Controls.Add(control);
         
            //    form.Controls.Add(control);
            
            form.ResumeLayout(false);
        }

        /// <summary>
        /// Метод клонирования прототипа
        /// </summary>
        /// <returns></returns>
        public override Graphic Clone()
        {
            MusicalNote clonedNote = new MusicalNote(form, dur);
            return clonedNote;
        }

        /// <summary>
        /// Метод привязки графического объекта(ноты) к определённой форме. Используется в случае десериализации.
        /// </summary>
        /// <param name="form">Форма к которой будет привязана нота</param>
        public void SetFormWorkSpace(Form form)
        {
            this.form = form;
            var getPanel = form.Controls.Find("panel1", false)[0].Controls.Find("scoreSheetPanel", false)[0];
            scoreSheetPanel = (getPanel as Panel);
        }
    }
}
