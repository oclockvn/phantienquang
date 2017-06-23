namespace phantienquang
{
    using Autofac;
    using Autofac.Integration.Mvc;
    using oclockvn.Repository;
    using System.Reflection;
    using System.Web.Mvc;
    using Models;

    public class DependencyConfig
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.Register(t => new UnitOfWork(new ApplicationDbContext())).As<IUnitOfWork>();
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));

            var assembly = Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly)
                   .Where(t => t.Name.EndsWith("Store"))
                   .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(assembly)
                   .Where(t => t.Name.EndsWith("Handler"))
                   .AsImplementedInterfaces();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}