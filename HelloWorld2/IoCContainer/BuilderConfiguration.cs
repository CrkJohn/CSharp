using Autofac;
using HelloWorld.Facade;
using Microsoft.Extensions.Configuration;

namespace HelloWorld.IoCContainer
{
    public static class BuilderConfiguration
    {
        public static ContainerBuilder BuildContext(this ContainerBuilder builder, IConfiguration settings)
        {
            builder.BuildServicesContext(settings);
            builder.RegisterType<BarkFacade>();
            return builder;
        }
    }
}