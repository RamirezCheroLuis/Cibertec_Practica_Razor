﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

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
        public ActionResult Create()
        {
            return View(new Person());
        }
        [HttpPost]
        public ActionResult Create(Person client)
        {
            if (ModelState.IsValid)
            {
                _person.Add(client);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int ID)
        {
            Person cliente = _person.GetPerson(ID);
            if (cliente == null)
            {
                return RedirectToAction("Index");
            }
            return View(cliente);
        }
        [HttpPost]
        public ActionResult Edit(Person client)
        {
            if (ModelState.IsValid)
            {
                _person.Update(client);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Delete(int id)
        {
            var client = _person.GetPerson(id);
            if (client == null)
            {
                return RedirectToAction("Index");
            }
            return View(client);
        }

        [HttpPost]
        public ActionResult Delete(Person client)
        {
            if (_person.Delete(client) > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Details(int id)
        {
            var client = _person.GetPerson(id);
            if (client == null)
            {
                return RedirectToAction("Index");
            }
            return View(client);
        }
    }
}