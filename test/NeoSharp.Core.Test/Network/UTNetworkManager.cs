﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NeoSharp.Core.Network;
using NeoSharp.TestHelpers;

namespace NeoSharp.Core.Test.Network
{
    [TestClass]
    public class UtNetworkManager : TestBase
    {
        [TestMethod]
        public void StartNetwork_Starts_Server()
        {
            // Arrange 
            var serverMock = AutoMockContainer.GetMock<IServer>();

            var networkManager = AutoMockContainer.Create<NetworkManager>();

            // Act
            networkManager.StartNetwork();

            // Asset
            serverMock.Verify(x => x.Start(), Times.Once);
        }

        [TestMethod]
        public void StopNetwork_Stops_Server()
        {
            // Arrange 
            var serverMock = AutoMockContainer.GetMock<IServer>();

            var networkManager = AutoMockContainer.Create<NetworkManager>();

            // Act
            networkManager.StopNetwork();

            // Asset
            serverMock.Verify(x => x.Stop(), Times.Once);
        }
    }
}