using MobileStore.DependencyInjection.Container;
using MobileStore.Service;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace MobileStore.App_Start
{
    public class NinjectConfig
    {
        public static StandardKernel CreateKernel() {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            DependencyConfig.RegisterServices(kernel);
            //RegisterServices(kernel);
            return kernel;
        }

        //private static void RegisterServices(IKernel kernel)
        //{
        //    kernel.Bind<IMobileService>().To<MobileService>();
        //}
    }
}