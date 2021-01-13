using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETMVCCORE.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error")]
        [AllowAnonymous]
        public IActionResult Error()
        {
            var exceptionInfo = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            ViewBag.ExceptionPath = exceptionInfo.Path;
            ViewBag.ExceptionMessage = exceptionInfo.Error.Message;
            ViewBag.StackTrace = exceptionInfo.Error.StackTrace;
            return View("Error");

        }

        [Route("Error/{statusCode}")]
        public IActionResult statusCodeHandler(int statusCode)
        {
            var statusCodeRecorder = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            switch (statusCode)
            {
                case 404:
                    ViewBag.Path = statusCodeRecorder.OriginalPath;
                    ViewBag.QS = statusCodeRecorder.OriginalQueryString;
                    break;
            }
            return View("NotFound");
        }
    }
}