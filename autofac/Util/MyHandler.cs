using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace autofac.Util
{
    public class MyHandler : HttpClientHandler
    {
        public MyHandler() { }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            // TODO: Do other things
            return base.SendAsync(request, cancellationToken);
        }
    }
}
