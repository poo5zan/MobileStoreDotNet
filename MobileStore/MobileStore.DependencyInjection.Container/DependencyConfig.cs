using MobileStore.Business;
using MobileStore.Service;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.DependencyInjection.Container
{
    public class DependencyConfig
    {
        public static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IMobileService>().To<MobileService>();

            kernel.Bind<IMobileBusiness>().To<MobileBusiness>();
        }
    }
}
