using Autofac;

namespace Repository
{
    public static class AFConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();

            builder.RegisterType<DataRepository>().As<IDataRepository>();

            return builder.Build();
        }
    }
}