using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodMyExcample
{
    abstract class TwoColorFlag
    {
        public void Draw()
        {
            DrawTopPart();
            DrawBottomPart();
        }

        protected abstract void DrawTopPart();
        protected abstract void DrawBottomPart();
    }
}
