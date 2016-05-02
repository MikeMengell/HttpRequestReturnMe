using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HttpRequestReturnMe.Controllers
{
    public class ErrorController : Controller
    {
        [Route("/{statusCode:int}")]
        public IActionResult ReturnHttpError(int statusCode)
        {
            return new HttpStatusCodeResult(statusCode);
        }
    }
}
