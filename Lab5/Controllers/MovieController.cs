using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab5.ViewModels;

namespace Lab5.Controllers {
  public class MovieController : Controller {

    private RepoMovie repo = new RepoMovie();
    //
    // GET: /Movie/
    public ActionResult Index() {
      return View(repo.getMoviesFull());
    }

    //
    // GET: /Movie/Details/5
    public ActionResult Details(int id) {
      return View(repo.getMovieFull(id));
    }

    //
    // GET: /Movie/Create
    public ActionResult Create() {
      return View();
    }

    //
    // POST: /Movie/Create
    [HttpPost]
    public ActionResult Create(FormCollection collection) {
      try {
        // TODO: Add insert logic here

        return RedirectToAction("Index");
      }
      catch {
        return View();
      }
    }

    //
    // GET: /Movie/Edit/5
    public ActionResult Edit(int id) {
      return View();
    }

    //
    // POST: /Movie/Edit/5
    [HttpPost]
    public ActionResult Edit(int id, FormCollection collection) {
      try {
        // TODO: Add update logic here

        return RedirectToAction("Index");
      }
      catch {
        return View();
      }
    }

    //
    // GET: /Movie/Delete/5
    public ActionResult Delete(int id) {
      return View();
    }

    //
    // POST: /Movie/Delete/5
    [HttpPost]
    public ActionResult Delete(int id, FormCollection collection) {
      try {
        // TODO: Add delete logic here

        return RedirectToAction("Index");
      }
      catch {
        return View();
      }
    }
  }
}
