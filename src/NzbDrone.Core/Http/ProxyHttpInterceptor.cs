using NzbDrone.Common.Http;
using NzbDrone.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NzbDrone.Core.Http
{
    public class ProxyHttpInterceptor : IHttpRequestInterceptor
    {
        private readonly IConfigService _configService;

        public ProxyHttpInterceptor(IConfigService configService)
        {
            this._configService = configService;
        }

        public HttpResponse PostResponse(HttpResponse response)
        {
            return response;
        }

        public HttpRequest PreRequest(HttpRequest request)
        {
            if(_configService.ProxyEnabled == UseProxy.Global ||
                (_configService.ProxyEnabled == UseProxy.IndexersOnly && request.IsIndexerRequest))
            {
                request.Proxy = new HttpRequestProxySettings(_configService.ProxyType,
                    _configService.ProxyHostname,
                    _configService.ProxyPort,
                    _configService.ProxyUsername == string.Empty ? null : _configService.ProxyUsername,
                    _configService.ProxyPassword == string.Empty ? null : _configService.ProxyPassword);
            }

            return request;
        }
    }
}
