using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidgetFactoryApplication
{
    class LinuxFactory : WidgetFactory
    {
        public override AbstractWindow CreateWindow()
        {
            return new LinuxForm();
        }

        public override AbstractButton CreateButton()
        {
            return new LinuxButton();
        }
    }
}
