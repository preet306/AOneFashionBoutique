using AOneFashionBoutique.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AOneFashionBoutique.Controllers
{
    public class CustomerController : Controller
    {
        FashionBoutiqueEntities fashionBoutiqueEntities = new FashionBoutiqueEntities();
        // GET: Customer
        public ActionResult ViewCustomerRecord()
        {
            return View(fashionBoutiqueEntities.Customers.ToList());
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
        public ActionResult Create([Bind(Exclude = "id")]Customer customer)
        {
            if (!ModelState.IsValid)
                return View();
            fashionBoutiqueEntities.Customers.Add(customer);
            fashionBoutiqueEntities.SaveChanges();
            return RedirectToAction("ViewCustomerRecord");
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            var CID = (from m in fashionBoutiqueEntities.Customers where m.id == id select m).First();
            return View(CID);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(Customer CID)
        {
            var orignalRecord = (from m in fashionBoutiqueEntities.Customers where m.id == CID.id select m).First();

            if (!ModelState.IsValid)
                return View(orignalRecord);
            fashionBoutiqueEntities.Entry(orignalRecord).CurrentValues.SetValues(CID);

            fashionBoutiqueEntities.SaveChanges();
            return RedirectToAction("ViewCustomerRecord");

        }

        // GET: Customer/Delete/5
        public ActionResult Delete(Customer CID)
        {

            var d = fashionBoutiqueEntities.Customers.Where(x => x.id == CID.id).FirstOrDefault();
            fashionBoutiqueEntities.Customers.Remove(d);
            fashionBoutiqueEntities.SaveChanges();
            return RedirectToAction("ViewCustomerRecord");

        }

        // POST: Customer/Delete/5
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
