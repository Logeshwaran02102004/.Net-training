using MVC_DataBasedemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_DataBasedemo.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        SQL_DAY_1Entities db = new SQL_DAY_1Entities();
        // GET: Category
        public ActionResult Index()
        {
            //1. The below action method uses scaffolde d view
            List<Product> catlist = db.Products.ToList();
            return View(catlist);
        }

        //2. the below action method does not use scaffolded view
        public ActionResult GetCategoryDetails()
        {
            List<Product> catlist = db.Products.ToList();
            return View(catlist);
        }

        //3. Adding or inserting a new category
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product) // passing data from view to controller thru model object 
        {
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int Id)
        {
            Product c = db.Products.Find(Id);
            return View(c);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteCategory(int Id)
        {
            Product cat = db.Products.Find(Id);
            db.Products.Remove(cat);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //5. category details
        public ActionResult Details(int Id)
        {
            Product product = db.Products.Find(Id);
            return View(product);
        }

        //6. edit
        public ActionResult Edit(int Id)
        {
            Product product = db.Products.Find(Id);
            return View(product);
        }

        [HttpPost, ActionName("Edit")]
        public ActionResult Update(Product product)
        {
            Product c = db.Products.Find(product.pro_id);
            c.pro_name = product.pro_name;
            c.price = product.price;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //7. sorting category by name
        public ActionResult GetCategoryByName()
        {
            List<String> sortedcatlist = (from c in db.Products
                                          orderby c.pro_name
                                          select c.pro_name).ToList();

            return View(sortedcatlist);
        }
    }
}