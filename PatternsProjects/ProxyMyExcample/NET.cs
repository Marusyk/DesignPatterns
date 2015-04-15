using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyMyExcample
{
    class NET
    {
        public static string GetSite(string site)
        {
            return string.Format("http://{0}", site);
        }
    }
}
