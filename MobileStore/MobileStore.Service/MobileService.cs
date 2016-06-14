using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileStore.DataTransferObject;
using MobileStore.Business;

namespace MobileStore.Service
{
    public class MobileService : IMobileService
    {
        private IMobileBusiness _mobileBusiness;

        public MobileService(IMobileBusiness mobileBusiness)
        {
            _mobileBusiness = mobileBusiness;
        }

        public List<MobileDto> Get()
        {
            return _mobileBusiness.Get();
        }

        public MobileDto Get(int id)
        {
            return new MobileDto() {
                Id = 1,
                Name = "hha"
            };
        }
    }
}
