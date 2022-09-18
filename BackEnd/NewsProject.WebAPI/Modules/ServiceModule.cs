using Autofac;
using NewsProject.Business.Concreate;
using NewsProject.Core.DAL.EntityFramework.UnitOfWork;
using NewsProject.DAL.Concreate.EntityFramework;
using NewsProject.DAL.Concreate.UnitOfWork;
using System.Reflection;
using Module = Autofac.Module;
namespace NewsProject.WebAPI.Modules
{
    public class ServiceModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            var apiAssembly = Assembly.GetExecutingAssembly();

            var serviceAssembly = Assembly.GetAssembly(typeof(NewsService));

            builder.RegisterAssemblyTypes(apiAssembly, serviceAssembly).Where(x => x.Name.EndsWith
            ("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();
        }
    }
}
