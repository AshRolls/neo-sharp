﻿using BenchmarkDotNet.Attributes;
using NeoSharp.Core.Network;
using SimpleInjector;
using Moq;
using Microsoft.Extensions.Logging;
using NeoSharp.Core.Network.Factories;
using NeoSharp.Application;

namespace NeoSharp.Network.Benchmark
{       
    public class BM_PeerFactory
    {
        PeerFactory uub;

        [GlobalSetup]
        public void Setup()
        {
            Container cont = new Container();
            cont.Register<IPeer, Peer>(Lifestyle.Transient);
            cont.Register(ConfigureLogger, Lifestyle.Singleton);
            cont.Register(typeof(ILogger<>), typeof(LoggerAdapter<>));
            uub = new PeerFactory(cont);
        }

        private static ILoggerFactory ConfigureLogger()
        {
            Mock<ILoggerFactory> mockLoggerFactory = new Mock<ILoggerFactory>();
            return mockLoggerFactory.Object;
        }

        [Benchmark]
        public void createPeers()
        {
            for (int i=0; i<10000; i++)
                uub.Create();
        }

    }
}
