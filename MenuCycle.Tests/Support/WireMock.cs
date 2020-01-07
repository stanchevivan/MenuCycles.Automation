using System;
using System.Collections.Generic;
using System.Net;
using WireMock.RequestBuilders;
using WireMock.ResponseBuilders;
using WireMock.Server;

namespace MenuCycle.Tests.Support
{
    public class WireMock
    {
        private FluentMockServer mockServer;

        private Dictionary<string, string> headers = new Dictionary<string, string>
        { { "Content-Type", "application/vnd.siren+json" },
            { "Access-Control-Allow-Origin", "http://localhost:4200" },
            { "Access-Control-Allow-Headers", "Authorization, Content-Type, X-Fourth-Org, X-Fourth-UserID"} };

        public void Start()
        {
            mockServer = FluentMockServer.StartWithAdminInterface(new[] { "http://+:4300" });
            var path = AppDomain.CurrentDomain.BaseDirectory;
            mockServer.ReadStaticMappings($"{path}mappings");
        }

        public void Stop()
        {
            mockServer.Stop();
        }

        public void ReplaceResponse(string path, HttpStatusCode statusCode, string body)
        {
            mockServer.Given(Request.Create().WithPath(path).UsingGet())
                .RespondWith(Response.Create()
                .WithHeaders(headers)
                .WithStatusCode(statusCode)
                .WithBody(body)
                .WithTransformer()
                );
        }
    }
}