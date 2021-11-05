using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using nuevaApp.Models;

namespace nuevaApp.Controllers
{
    public class PersonalController : Controller
    {
      public IActionResult Index()
    {
        Personal personal = new Personal();
         
         personal.name ="freddie";
         personal.lastname = "Mercurio";
         personal.age = 45;

        return View(personal);
    }
    }
}