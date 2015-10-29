using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace Adapter
{
    /// <summary>
    /// Aбстрактний класс Manipulator который реализует взаимодесйствие и контролирует состояние
    /// обьекта-манипулятора. Манипуляторы представлены кастомными контролами
    /// </summary>

    public abstract class Manipulator : Control
    {
        //состояние манипулятора на форме.
        public Point StartPoint { get; protected set; }
        public Point EndPoint { get; protected set; }
       
        //задание базовых параметров контрола
        public Manipulator()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.Opaque, true);
            this.BackColor = Color.Transparent;
            this.DoubleBuffered = false;
        }

        //определяет параметры необходимые при создании контрола
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_TRANSPARENT = 0x00000020;
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= WS_EX_TRANSPARENT;
                return createParams;
            }
        }
    }
}
