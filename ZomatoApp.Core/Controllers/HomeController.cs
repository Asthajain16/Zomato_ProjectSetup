using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace ZomatoApp.Core.Controllers
{
    class HomeController :Controller
    {
        public IActionResult Index() 
        {
             return (IActionResult)View(); 
        }
       
    }
}
