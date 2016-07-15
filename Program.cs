using System;
using Apollo.Services.Core;
using Apollo.Sports.Core;
using Apollo.Sports.Core.Configuration;
using AutoMapper;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Program))]
namespace Apollo.Sports.Core
{
    class Program
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            WebApiHostRunner.Configuration(appBuilder, 
                AutofacConfig.Configure, 
                WebApiConfig.Configure);

            Mapper.Initialize(AutomapperConfig.Configure);
            
        }

        static void Main(string[] args)
        {
            var config = new ProjectConfiguration(
                new Guid("5501698e-6c0f-4386-8ad3-6691a439fea0"),
                new Guid("08EC8F28-4E0A-4FDC-BAE6-05BE7BA59833"),
                "Apollo.Sports.Core",
                "Sports.Core",
                "Sports.Core",
                false,
                true,
                false
            );

            WebApiHostRunner.RunMain(config);
        }
    }
}
