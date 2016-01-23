using System;
using NzbDrone.Common.Http;

namespace NzbDrone.Core.Indexers
{
    public class IndexerRequest
    {
        public HttpRequest HttpRequest { get; private set; }

        public IndexerRequest(string url, HttpAccept httpAccept)
        {
            HttpRequest = new HttpRequest(url, httpAccept);
            HttpRequest.IsIndexerRequest = true;
        }

        public IndexerRequest(HttpRequest httpRequest)
        {
            HttpRequest = httpRequest;
            HttpRequest.IsIndexerRequest = true;
        }

        public Uri Url
        {
            get { return HttpRequest.Url; }
        }
    }
}
