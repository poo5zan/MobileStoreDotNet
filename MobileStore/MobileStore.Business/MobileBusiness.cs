using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileStore.DataTransferObject;

namespace MobileStore.Business
{
    public class MobileBusiness : IMobileBusiness
    {
        public List<MobileDto> Get()
        {
            return new List<MobileDto>() {
                new MobileDto() {
                    Id = 1,
                    Name = "Mobile1"
                },
                new MobileDto() {
                    Id = 2,
                    Name = "Mobile2"
                }
            };
        }

        public MobileDto Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
