using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Spor.Class;

namespace Spor.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
           People people = new People(new Tennis());
            return people.Category();
        }

    }
}