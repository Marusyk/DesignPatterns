using System;
using System.Collections.Generic;

namespace ProxyMyExcample
{
    class Proxy : IProtocol
    {
        public IProtocol client;
        List<string> _history = new List<string>();
        public string GetSite { get; set; }

        public void Connect()
        {
            this.client.Connect();
            _history.Add((client as Client).GetSite);
        }

        public List<string> GetHistory()
        {
            return _history;
        }
    }
}
