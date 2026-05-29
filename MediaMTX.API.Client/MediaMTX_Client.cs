using System;
using System.Net.Http;
using System.Threading.Tasks;
using MediaMTX.API.Api;
using Microsoft.Extensions.Hosting;
using MediaMTX.API.Client;
using MediaMTX.API.Extensions;
using MediaMTX.API.Model;
using Microsoft.Extensions.DependencyInjection;

namespace MediaMTX.API.Client
{
    public class MediaMTX_Client
    {
        IHost _host;
        
        public IGeneralApi General { get; private set; }
        public IPathsApi Paths { get; private set; }
        public IConfigurationApi Configuration { get; private set; }
        
        public MediaMTX_Client(int port)
        {
            _host = Host.CreateDefaultBuilder().ConfigureApi((context, services, options) =>
            {
                options.AddApiHttpClients(client =>
                    client.BaseAddress = new Uri("http://localhost:" + port));
            }).Build();

            General = _host.Services.GetRequiredService<IGeneralApi>();
            Paths = _host.Services.GetRequiredService<IPathsApi>();
            Configuration = _host.Services.GetService<IConfigurationApi>();
        }
    }
}