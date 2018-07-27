using Autofac;
using Autofac.Features.ResolveAnything;
using Fourth.Automation.Framework.Core;
using Fourth.Automation.Framework.Reporting;
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

            return builder;
        }
    }
}