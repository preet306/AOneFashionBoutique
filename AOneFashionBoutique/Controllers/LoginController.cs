using AOneFashionBoutique.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AOneFashionBoutique.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AdminLogin login)
        {
            //Pass the data to store the record into the table 

            DataTable tbl = new DataTable();
            tbl = login.Login("select * from Login where LoginName='" + login.QName + "'and LoginPassword='" + login.QPassword + "'");

            if (tbl.Rows.Count > 0)
            {
                return View("ValidLogin");
            }
            else
            {
                return View("InvalidLogin");
            }



        }




        // GET: Login
        public ActionResult ValidLogin()
        {
            return View();
        }


        // GET: Login
        public ActionResult InvalidLogin()
        {
            return View();
        }



    }
}