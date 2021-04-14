using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace ZomatoApp.Core.ApiControllers
{
    [System.Web.Http.Route("api/[controller]")]
    [ApiController]
    public class ValueController : System.Web.Mvc.ControllerBase
    {
        protected override void ExecuteCore()
        {
            throw new NotImplementedException();
        }
    }
}
