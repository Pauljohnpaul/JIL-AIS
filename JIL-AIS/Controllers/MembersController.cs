using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JIL_AIS.Areas.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace JIL_AIS.Controllers
{
    public class MembersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}