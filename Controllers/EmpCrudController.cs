using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LinqMvcApplication.Models;

namespace LinqMvcApplication.Controllers
{
    public class EmpCrudController : Controller
    {
        DataClasses2DataContext dc = new DataClasses2DataContext();
        // GET: EmpCrud
        public ActionResult Index()
        {
            var empdetails = from x in dc.emptables select x;
            return View(empdetails);
        }

        // GET: EmpCrud/Details/5 
        public ActionResult Details(int id)
        {
            var getempdetails = dc.emptables.Single(x => x.Empid == id);
            return View(getempdetails);
        }

        // GET: EmpCrud/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpCrud/Create
        [HttpPost]
        public ActionResult Create(emptable collection)
        {
            try
            {
                // TODO: Add insert logic here
                dc.emptables.InsertOnSubmit(collection);
                dc.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpCrud/Edit/5
        public ActionResult Edit(int id)
        {
            var getempdetails = dc.emptables.Single(x => x.Empid == id);
            return View(getempdetails);
        }

        // POST: EmpCrud/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, emptable collection)
        {
            try
            {
                // TODO: Add update logic here
                emptable empupdate = dc.emptables.Single(x => x.Empid == id);
                empupdate.Empname = collection.Empname;
                empupdate.Email = collection.Email;
                empupdate.salary = collection.salary;
                dc.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpCrud/Delete/5
        public ActionResult Delete(int id)
        {
            var getempdetails = dc.emptables.Single(x => x.Empid == id);
            return View(getempdetails);
        }

        // POST: EmpCrud/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, emptable collection)
        {
            try
            {
                // TODO: Add delete logic here
                var empdel = dc.emptables.Single(x => x.Empid == id);
                dc.emptables.DeleteOnSubmit(empdel);
                dc.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
