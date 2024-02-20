using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web2.Models;

namespace web2.Controllers
{
    public class AboutUsController : Controller
    {
        Models.User u = new Models.User();
        public void setProps(User u) {
            u.FirstName = "Million";
            u.LastName = "Eyassu";
            u.Email = "mdeyassu2@cincinnatistate.edu"; 
        }
        
        public ActionResult Index()
        {
            setProps(u);
            return View(u);
        }


        [HttpPost]
        public ActionResult Index(FormCollection col) {
            if (col["btnSubmit"] == "close") { 
               return  RedirectToAction("../Home/Index");
            }

            if (col["btnSubmit"] == "more") {
                return RedirectToAction("More");
            }

            return View(u);
            
        }

        // opens the More view
        public ActionResult More() {
            setProps(u);
            return View(u);
        }


        // returns to index from More view
        [HttpPost]
        public ActionResult More(FormCollection col) {
            if (col["btnSubmit"] == "close") {
                return RedirectToAction("Index");
            }

            return View(u);
        }

    }
}