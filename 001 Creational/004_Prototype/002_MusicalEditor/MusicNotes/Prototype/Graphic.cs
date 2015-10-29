using System.Drawing;
using System.Windows.Forms;

namespace MusicNotes
{
    /// <summary>
    /// Абстрактный класс Graphic для графических компонентов - нот и нотных станов.
    /// </summary>
    /// <remarks>Prototype, объявляет интерфейс для клонирования самого себя</remarks>
    public abstract class Graphic
    {
        protected Form form;

        protected Panel scoreSheetPanel;
        /// <summary>
        /// Изображение графического элемента
        /// </summary>
        protected Image image;

        protected Graphic(Form f)
        {
            form = f;
            var getPanel = form.Controls.Find("panel1", false)[0].Controls.Find("scoreSheetPanel", false)[0];
            scoreSheetPanel = (getPanel as Panel);
        }

        public Graphic()
        {
        }
        
        public abstract void Draw(Position position);

        public abstract Graphic Clone();
    }
}
