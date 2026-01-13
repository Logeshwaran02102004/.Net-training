using CodeFirstapproachprj.Models;
using CodeFirstapproachprj.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstapproachprj.Controllers
{
    public class CodeController : Controller
    {
        IMovieRepository repo = new MovieRepository();

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            repo.Add(movie);
            repo.Save();
            return RedirectToAction("Index");
        }

        public ActionResult Index()
        {
            return View(repo.GetAll());
        }

        public ActionResult Edit(int id)
        {
            return View(repo.GetById(id));
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            repo.Update(movie);
            repo.Save();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            repo.Delete(id);
            repo.Save();
            return RedirectToAction("Index");
        }

        public ActionResult MoviesByYear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MoviesByYear(int year)
        {
            return View(repo.GetByYear(year));
        }

        public ActionResult MoviesByDirector()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MoviesByDirector(string director)
        {
            return View(repo.GetByDirector(director));
        }
    }
}