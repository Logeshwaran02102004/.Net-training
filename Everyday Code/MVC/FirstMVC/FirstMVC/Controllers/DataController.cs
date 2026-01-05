using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        public ActionResult Index()
        {
            //1. passing an object to the view that will be used as a model
            //ViewBag.data = "Flowers List";
            //List<string> flowers = new List<string>
            //{
            //    "Roses","Lilies","Jasmine","Marigold"
            //};
            //return View(flowers);
            List<string> studentList;
            studentList = TempData["stores"] as List<string>;
           // return View(studentList);

            // to check if the data is available in previous controller
            return RedirectToAction("getting_TempData_from_DataController", "Demo");
        }

        //checking if the viewbag can pass on the data/info to further request

        public ActionResult TestDataTransfer()
        {
            ViewBag.data1 = "Data One";
            ViewData["data2"] = "Data Two";
            return View();   // data passed to the current view
            //return RedirectToAction("Index");

            

        }


        //3.passing data through viewbag and viewdata
        //public ActionResult OfficeRules()
        //{
        //    List<string> rules = new List<string>
        //    {
        //        "Be on time","carry your Id Card","Complete Work as per Your Deadlines","Avoid T-shirts"
        //    };

        //    //3.1 transfer data through viewbag
        //    ViewBag.offrules= rules;
        //}



        //4.passing data through temp data object
        public ActionResult FirstTempRequest()
        {
            List<string> stationaries = new List<string>()
            {
                "pens","notebook","scale","pencils"
            };
            TempData["stores"]=stationaries;
            //4.1 using temp data in the current view 
            //return View();

            //reirecting to secondTempRequest   
            return RedirectToAction("SecondTempRequest");
        }


        public ActionResult SecondTempRequest()
        {
            //creted above actionmethod and using in this action method
            List<string> stdlist;
            stdlist = TempData["stores"] as List<string>;
            //return View(stdlist);

            // redirect to index
            return RedirectToAction("Index");
        }


        // to print the deatails which is passed from the hr controller
        public ActionResult Display_Valuesfrom_HrController()
        {
            return View(TempData["Stored"]);
        }
    }
}