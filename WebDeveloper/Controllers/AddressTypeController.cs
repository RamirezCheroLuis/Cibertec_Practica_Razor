using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class AddressTypeController : Controller
    {
        // GET: Person
        AddressTypeData _address = new AddressTypeData();
        public ActionResult Index()
        {

            return View(_address.GetList());
        }
        public ActionResult Create()
        {
            return View(new AddressType());
        }
        [HttpPost]
        public ActionResult Create(AddressType client)
        {
            if (ModelState.IsValid)
            {
                _address.Add(client);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int ID)
        {
            AddressType cliente = _address.GetAddressType(ID);
            if (cliente == null)
            {
                return RedirectToAction("Index");
            }
            return View(cliente);
        }
        [HttpPost]
        public ActionResult Edit(AddressType client)
        {
            if (ModelState.IsValid)
            {
                _address.Update(client);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Delete(int id)
        {
            var client = _address.GetAddressType(id);
            if (client == null)
            {
                return RedirectToAction("Index");
            }
            return View(client);
        }

        [HttpPost]
        public ActionResult Delete(AddressType client)
        {
            if (_address.Delete(client) > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Details(int id)
        {
            var client = _address.GetAddressType(id);
            if (client == null)
            {
                return RedirectToAction("Index");
            }
            return View(client);
        }
    }
}