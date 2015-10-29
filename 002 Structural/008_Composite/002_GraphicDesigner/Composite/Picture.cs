using System.Collections.Generic;
using System.Drawing;

namespace Composite
{
    class Picture : IGraphic
    {
        List<IGraphic> list;

        public Picture()
        {
            this.list = new List<IGraphic>();
        }

        public void Draw(Graphics device)
        {
            foreach (IGraphic item in list)
                item.Draw(device);
        }

        public void Add(IGraphic graphic)
        {
            this.list.Add(graphic);
        }

        public void Remove(IGraphic graphic)
        {
            this.list.Remove(graphic);
        }

        public IGraphic GetChild(int child)
        {
            return this.list[child];
        }
    }
}
