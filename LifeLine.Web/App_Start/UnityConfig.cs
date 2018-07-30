using System.Web.Mvc;
using LifeLine.Infrastructure;
using LifeLine.Interfaces;
using Unity;
using Unity.Mvc5;

namespace LifeLine.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

			// register all your components with the container here
			// it is NOT necessary to register your controllers

			container.RegisterType<IBloodDonorRepository, BloodDonorRepository>();

			DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}