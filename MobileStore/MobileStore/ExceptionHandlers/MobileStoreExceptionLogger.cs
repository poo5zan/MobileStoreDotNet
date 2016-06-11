using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Http.ExceptionHandling;

namespace MobileStore.ExceptionHandlers
{
    public class MobileStoreExceptionLogger : ExceptionLogger
    {
        public override void Log(ExceptionLoggerContext context)
        {
            Debug.Write(context.Exception.Message);
        }
    }
}