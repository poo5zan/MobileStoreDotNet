using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.Common
{
    public class ErrorMessage
    {
        public const String RequiredId = "Id is required";
        

        public class Mobile {
            public const string RequiredMobileInputModel = "MobileInputModel is required";
        }

        public class Exception {
            public const string UnAuthorizedAccess = "User is not authorized";
            public const string RecordAlreadyExists = "Record already exists";
            public const string RecordNotFound = "Record not found";
            public const string Unknown = "Unknown Exception";
        }

    }
}
