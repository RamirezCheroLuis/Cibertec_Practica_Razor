using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class ContactTypeController : Controller
    {
        // GET: Person
        ContactTypeData _contact = new ContactTypeData();
        public ActionResult Index()
        {
            
            return View(_contact.GetList());
        }
        public ActionResult Create()
        {
            return View(new ContactType());
        }
        [HttpPost]
        public ActionResult Create(ContactType client)
        {
            if (ModelState.IsValid)
            {
                _contact.Add(client);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int ID)
        {
            ContactType cliente = _contact.GetContactType(ID);
            if (cliente == null)
            {
                return RedirectToAction("Index");
            }
            return View(cliente);
        }
        [HttpPost]
        public ActionResult Edit(ContactType client)
        {
            if (ModelState.IsValid)
            {
                _contact.Update(client);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Delete(int id)
        {
            var client = _contact.GetContactType(id);
            if (client == null)
            {
                return RedirectToAction("Index");
            }
            return View(client);
        }

        [HttpPost]
        public ActionResult Delete(ContactType client)
        {
            if (_contact.Delete(client) > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Details(int id)
        {
            var client = _contact.GetContactType(id);
            if (client == null)
            {
                return RedirectToAction("Index");
            }
            return View(client);
        }
    }
}