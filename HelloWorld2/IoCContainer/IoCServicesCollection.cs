using Autofac;
using HelloWorld.Services;
using HelloWorld.Services.impl;
using Microsoft.Extensions.Configuration;

namespace HelloWorld.IoCContainer
{
    public static class IoCServicesCollection
    {
        public static ContainerBuilder BuildServicesContext(this ContainerBuilder builder, IConfiguration settings)
        {
            
            builder.RegisterType<BarkServiceImpl>().As<BarkSerivce>();
            return builder;
        }
    }
}