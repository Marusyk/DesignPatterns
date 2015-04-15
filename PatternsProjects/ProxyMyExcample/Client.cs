using System;

namespace ProxyMyExcample
{
    class Client : IProtocol
    {
        public string GetSite { get; set; }
        public Client(string site)
        {
            GetSite = site;
        }

        public void Connect()
        {
            GetSite = NET.GetSite(GetSite);
        }
    }
}
