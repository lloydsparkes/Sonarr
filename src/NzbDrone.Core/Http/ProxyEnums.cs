using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NzbDrone.Core.Http
{
    public enum UseProxy
    {
        Off,
        Global,
        IndexersOnly
    }

    public enum ProxyType
    {
        Http,
        Socks4,
        Socks5
    }
}
