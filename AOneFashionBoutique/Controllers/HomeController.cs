using AOneFashionBoutique.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AOneFashionBoutique.Controllers
{
    public class HomeController : Controller
    {
        FashionBoutiqueEntities fashionBoutiqueEntities = new FashionBoutiqueEntities();


        public ActionResult ViewQueryRecord()
        {
            return View(fashionBoutiqueEntities.Queries.ToList());
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(Query QID)
        {

            var d = fashionBoutiqueEntities.Queries.Where(x => x.id == QID.id).FirstOrDefault();
            fashionBoutiqueEntities.Queries.Remove(d);
            fashionBoutiqueEntities.SaveChanges();
            return RedirectToAction("ViewQueryRecord");

        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }




        [HttpPost]
        public ActionResult sendMessage(Contact contact)
        {
            //Pass the data to store the record into the table 


            contact.sendMessage("insert into Query values('" + contact.QName + "','" + contact.QEmail + "','" + contact.QSubject + "','" + contact.QMessage + "')");
            return View("done");




        }


        public ActionResult done()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}