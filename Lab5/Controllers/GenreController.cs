﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab5.ViewModels;

namespace Lab5.Controllers {
  public class GenreController : Controller {

    private RepoGenre repo = new RepoGenre();
    //
    // GET: /Genre/
    public ActionResult Index() {
      return View(repo.getGenresFull());
    }

    //
    // GET: /Genre/Details/5
    public ActionResult Details(int id) {
      return View();
    }

    //
    // GET: /Genre/Create
    public ActionResult Create() {
      return View();
    }

    //
    // POST: /Genre/Create
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
    // GET: /Genre/Edit/5
    public ActionResult Edit(int id) {
      return View();
    }

    //
    // POST: /Genre/Edit/5
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
    // GET: /Genre/Delete/5
    public ActionResult Delete(int id) {
      return View();
    }

    //
    // POST: /Genre/Delete/5
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
