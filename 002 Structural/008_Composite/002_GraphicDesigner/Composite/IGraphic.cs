using System.Drawing;

namespace Composite
{
    interface IGraphic
    {
        void Draw(Graphics device);
        void Add(IGraphic graphic);
        void Remove(IGraphic graphic);
        IGraphic GetChild(int child);
    }
}
