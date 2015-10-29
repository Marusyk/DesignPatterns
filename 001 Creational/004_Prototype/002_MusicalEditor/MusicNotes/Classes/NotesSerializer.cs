using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MusicNotes
{
    [XmlRoot("MyMelody")]
    public class NotesSerializer
    {
        [XmlArray("MusicalNotes")]
        [XmlArrayItem("Note")]
        public List<MusicalNote> NotesToSerialize { get; private set; }

        public NotesSerializer()
        {
            NotesToSerialize = new List<MusicalNote>();
        }

        static public void Serialize(List<NoteTranspControl> noteControls, string filePath)
        {
            NotesSerializer thisSerializer = new NotesSerializer();
            foreach (var control in noteControls)
                thisSerializer.NotesToSerialize.Add(control.ControlNote);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(NotesSerializer));
            using (FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.Read))
                xmlSerializer.Serialize(stream, thisSerializer);
        }

        static public List<MusicalNote> Deserialize(string filePath)
        {
            NotesSerializer thisSerializer = new NotesSerializer();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(NotesSerializer));

            try
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    // Восстанавливаем объект из XML-файла.
                    thisSerializer = xmlSerializer.Deserialize(stream) as NotesSerializer;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return thisSerializer.NotesToSerialize;
        }
    }
}
