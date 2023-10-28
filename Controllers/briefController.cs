using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ScamStore.Controllers
{
    public class briefController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}