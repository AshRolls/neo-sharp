using NeoSharp.Application.Client;
using SimpleInjector;

namespace NeoSharp.Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            Composition.Compose(out var container);            

            IClientManager client = container.GetInstance<IClientManager>();
            client.RunClient(args);

            container.Dispose();
        }
    }
}
