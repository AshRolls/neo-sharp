﻿using SimpleInjector;

namespace NeoSharp.Application
{
    public static class Composition
    {
        public static void Compose(out Container container)
        {
            container = new Container();

            CorePackage.RegisterServices(container);            
            ClientPackage.RegisterServices(container);            
            NetworkPackage.RegisterServices(container);

            // verify
            container.Verify();
        }
    }
}
