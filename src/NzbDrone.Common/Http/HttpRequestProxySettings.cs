using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NzbDrone.Common.Http
{
    public enum ProxyType
    {
        Http,
        Socks4,
        Socks5
    }

    public class HttpRequestProxySettings
    {
        public HttpRequestProxySettings(ProxyType type, string host, int port, string username = null, string password = null)
        {
            Type = type;
            Host = host;
            Port = port;
            Username = username;
            Password = password;
        }

        public ProxyType Type { get; private set; }
        public string Host { get; private set; }
        public int Port { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
    }
}
