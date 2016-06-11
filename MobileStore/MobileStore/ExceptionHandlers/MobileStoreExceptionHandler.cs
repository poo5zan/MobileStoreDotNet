using MobileStore.Common;
using MobileStore.Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MobileStore.ExceptionHandlers
{
    public class MobileStoreExceptionHandler : ExceptionHandler
    {
        public override void Handle(ExceptionHandlerContext context)
        {
            HttpStatusCode httpStatusCode;
            string errorMessage = String.Empty;

            if (context.Exception is UnauthorizedAccessException)              
            {
                httpStatusCode = HttpStatusCode.Unauthorized;
                if (String.IsNullOrWhiteSpace(context.Exception.Message))
                {
                    errorMessage = ErrorMessage.Exception.UnAuthorizedAccess;
                }
                else
                {
                    errorMessage = context.Exception.Message;
                }
            }
            else if (context.Exception.InnerException is UnauthorizedAccessException)
            {
                //catching exception thrown from ApiController Base
                //as it wraps the thrown UnAuthorizedAccessException into another exception that
                //it fails to create controller
                httpStatusCode = HttpStatusCode.Unauthorized;
                if (String.IsNullOrWhiteSpace(context.Exception.Message))
                {
                    errorMessage = ErrorMessage.Exception.UnAuthorizedAccess;
                }
                else
                {
                    errorMessage = context.Exception.InnerException.Message;
                }
            }
            else if (context.Exception is RecordNotFoundException)
            {
                httpStatusCode = HttpStatusCode.NoContent;
                if (String.IsNullOrWhiteSpace(context.Exception.Message))
                {
                    errorMessage = ErrorMessage.Exception.RecordNotFound;
                }
                else
                {
                    errorMessage = context.Exception.Message;
                }
            }
            else if (context.Exception is RecordAlreadyExistsException)
            {
                httpStatusCode = HttpStatusCode.Conflict;
                if (String.IsNullOrWhiteSpace(context.Exception.Message))
                {
                    errorMessage = ErrorMessage.Exception.RecordAlreadyExists;
                }
                else
                {
                    errorMessage = context.Exception.Message;
                }
            }
            else
            {
                httpStatusCode = HttpStatusCode.InternalServerError;
                if (String.IsNullOrWhiteSpace(context.Exception.Message))
                {
                    errorMessage = ErrorMessage.Exception.Unknown;
                }
                else
                {
                    errorMessage = context.Exception.Message;
                }
            }

            context.Result = new ErrorResult()
            {
                StatusCode = httpStatusCode,
                Content = errorMessage,
                Request = context.ExceptionContext.Request
            };


        }

        private class ErrorResult : IHttpActionResult
        {
            public HttpRequestMessage Request { get; set; }
            public string Content { get; set; }
            public HttpStatusCode StatusCode { get; set; }

            public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
            {
                HttpResponseMessage responseMessage = new HttpResponseMessage(StatusCode);
                responseMessage.Content = new StringContent(Content);
                responseMessage.RequestMessage = Request;
                return Task.FromResult(responseMessage);
                
            }
        }
    }
}