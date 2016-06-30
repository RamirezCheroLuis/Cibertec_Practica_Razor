using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;

namespace WebDeveloper.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        PersonData _person = new PersonData();
        public ActionResult Index()
        {
            
            return View(_person.GetList());
        }
    }
}