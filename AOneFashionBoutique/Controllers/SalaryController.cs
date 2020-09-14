using AOneFashionBoutique.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AOneFashionBoutique.Controllers
{
    public class SalaryController : Controller
    {

        FashionBoutiqueEntities fashionBoutiqueEntities = new FashionBoutiqueEntities();
        // GET: Customer
        public ActionResult ViewPaymentRecord()
        {
            return View(fashionBoutiqueEntities.Salaries.ToList());
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
        public ActionResult Create([Bind(Exclude = "id")]Salary salary)
        {
            if (!ModelState.IsValid)
                return View();
            fashionBoutiqueEntities.Salaries.Add(salary);
            fashionBoutiqueEntities.SaveChanges();
            return RedirectToAction("ViewPaymentRecord");
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            var PID = (from m in fashionBoutiqueEntities.Salaries where m.id == id select m).First();
            return View(PID);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(Salary PID)
        {
            var orignalRecord = (from m in fashionBoutiqueEntities.Salaries where m.id == PID.id select m).First();

            if (!ModelState.IsValid)
                return View(orignalRecord);
            fashionBoutiqueEntities.Entry(orignalRecord).CurrentValues.SetValues(PID);

            fashionBoutiqueEntities.SaveChanges();
            return RedirectToAction("ViewPaymentRecord");

        }

        // GET: Customer/Delete/5
        public ActionResult Delete(Salary PID)
        {

            var d = fashionBoutiqueEntities.Salaries.Where(x => x.id == PID.id).FirstOrDefault();
            fashionBoutiqueEntities.Salaries.Remove(d);
            fashionBoutiqueEntities.SaveChanges();
            return RedirectToAction("ViewPaymentRecord");

        }


        // POST: Salary/Delete/5
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
