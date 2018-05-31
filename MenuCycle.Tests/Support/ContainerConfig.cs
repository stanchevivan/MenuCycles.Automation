using Autofac;
using Autofac.Features.ResolveAnything;
using Fourth.Automation.Framework.Core;
using Fourth.Automation.Framework.Reporting;
using MenuCycle.Data.Services;
using SpecFlow.Autofac;

namespace MenuCycle.Tests.Support
{
    public static class ContainerConfig
    {
        [ScenarioDependencies]
        public static ContainerBuilder CreateContainerBuilder()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Artefacts>().As<IArtefacts>();

            builder.RegisterInstance(DriverFactory.Create());

            builder.RegisterSource(new AnyConcreteTypeNotAlreadyRegisteredSource());

            //this.objectContainer.RegisterFactoryAs(d =>
            //d.Resolve<DefaultValuesService>().GetDefaults(36, 1, "SodexoUp"));
            builder.Register(d =>
            {
                d.Resolve<DefaultValuesService>().GetDefaults(36, 1, "SodexoUp");
                return d as DefaultValuesService;
            });

            return builder;
        }
    }
}