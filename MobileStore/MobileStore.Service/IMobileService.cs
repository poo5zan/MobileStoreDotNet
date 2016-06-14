using MobileStore.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.Service
{
    public interface IMobileService
    {
        List<MobileDto> Get();
        MobileDto Get(int id);
    }
}
