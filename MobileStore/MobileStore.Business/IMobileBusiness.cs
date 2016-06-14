using MobileStore.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.Business
{
    public interface IMobileBusiness
    {
        List<MobileDto> Get();
        MobileDto Get(int id);
    }
}
