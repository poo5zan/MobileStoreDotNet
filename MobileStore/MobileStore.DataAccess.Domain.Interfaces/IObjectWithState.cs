using MobileStore.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.DataAccess.Domain.Interfaces
{
    public interface IObjectWithState
    {
        State State { get; set; }
    }
}
