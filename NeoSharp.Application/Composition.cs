using NeoSharp.Application.DI;
using SimpleInjector;

namespace NeoSharp.Application
{
    public static class Composition
    {
        public static void Compose(out Container container)
        {
            container = new Container();

            ConfigurationPackage.RegisterServices(container);
            LoggingPackage.RegisterServices(container);
            ClientPackage.RegisterServices(container);            
            NetworkPackage.RegisterServices(container);

            // verify
            container.Verify();
        }
    }
}
