﻿using SimpleInjector;

namespace NeoSharp.Core.Network.Factories
{
    public class PeerFactory : IPeerFactory
    {
        private readonly Container _container;

        public PeerFactory(Container container)
        {
            _container = container;
        }

        public IPeer Create()
        {
            return _container.GetInstance<IPeer>();
        }
    }
}
