using AOneFashionBoutique.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AOneFashionBoutique.Controllers
{
    public class EmployeeController : Controller
    {



        FashionBoutiqueEntities fashionBoutiqueEntities = new FashionBoutiqueEntities();
        // GET: Customer
        public ActionResult ViewEmployeeRecord()
        {
            return View(fashionBoutiqueEntities.Employees.ToList());
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "id")]Employee employee)
        {
            if (!ModelState.IsValid)
                return View();
            fashionBoutiqueEntities.Employees.Add(employee);
            fashionBoutiqueEntities.SaveChanges();
            return RedirectToAction("ViewEmployeeRecord");
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            var EID = (from m in fashionBoutiqueEntities.Employees where m.id == id select m).First();
            return View(EID);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(Employee EID)
        {
            var orignalRecord = (from m in fashionBoutiqueEntities.Employees where m.id == EID.id select m).First();

            if (!ModelState.IsValid)
                return View(orignalRecord);
            fashionBoutiqueEntities.Entry(orignalRecord).CurrentValues.SetValues(EID);

            fashionBoutiqueEntities.SaveChanges();
            return RedirectToAction("ViewEmployeeRecord");

        }

        // GET: Customer/Delete/5
        public ActionResult Delete(Employee EID)
        {

            var d = fashionBoutiqueEntities.Employees.Where(x => x.id == EID.id).FirstOrDefault();
            fashionBoutiqueEntities.Employees.Remove(d);
            fashionBoutiqueEntities.SaveChanges();
            return RedirectToAction("ViewEmployeeRecord");

        }
        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
