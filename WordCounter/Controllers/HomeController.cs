using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost("/result")]
        public ActionResult Result()
        {
          RepeatCounter newSearch = new RepeatCounter((Request.Form["sentence"]), (Request.Form["searchWord"]));
          newSearch.CountRepeats();

          return View(newSearch);
        }
    }
}
