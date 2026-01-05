using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }


        //1. Normal method
        public string NormalMethod()
        {
            return "Hi All.. Welcome to MVC";
        }

        //2. viewresult

        public ViewResult ViewMethod()
        {
            return View(); 
        }

        //3. Contenresult
        public ContentResult ContentMethod()
        {
            //  return Content("Hello All!! this is the content", "text/plain");

            return Content("<h1 style=color:blue;> Good Evening to All</h1>");
        }

        //4.  it will return the emptyresult

        public EmptyResult EmptyMethod()
        {
            int amt = 45000;
            float si = (amt * 3 * 2) / 100;
            return new EmptyResult();
        }

        //5. this is the method of redirect
        public ActionResult redirectMethod()
        {
            //  return RedirectToAction("ContentMethod"); //redirecting to other action method
            //of the same controller

            return RedirectToAction("index", "home"); //redirecting to other action method
                                                      //of different controller



        }


        //taking the values from the data controller to this controller by using the tempdata
        public ActionResult getting_TempData_from_DataController()
        {
            TempData.Keep();
            return View(TempData["stores"]);
        }

        // storing the temp data by tempdata.keep and then getting the data from this conroller itself
        public ActionResult getting_TempData_from_democontroller()
        {
            return View(TempData["stores"]);
        }

    }
}