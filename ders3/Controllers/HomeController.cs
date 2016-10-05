﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ders3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.GirisBasarisiz = false;

            if (Request.HttpMethod=="Post")
            {
                if (Request.Form["username"] == "murat" && Request.Form["password"] == "123")
                {
                    return Redirect("/Panel/Index");
                }
                ViewBag.GirisBasarisiz = true;
            }
            return View();
        }
    }
}