﻿using Microsoft.Extensions.Logging;
using NeoSharp.Core.Network;

namespace NeoSharp.Network
{
    public class NetworkManager : INetworkManager
    {
        private readonly ILogger<NetworkManager> _logger;        
        private readonly IServer _server;        

        public NetworkManager(ILogger<NetworkManager> logger, IServer serverInit)
        {
            _logger = logger;            
            _server = serverInit;

            _logger.LogInformation("Network Manager Initialised");
        }

        public void StartNetwork()
        {            
            _server.StartServer();            
        }

        public void StopNetwork()
        {           
            _server.StopServer();
        }
    }
}
