﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Squad55.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            
            return View() ;
        }

        public ActionResult Cursos()
        {
           

            return View();
        }

        public ActionResult CursoMarketingDigital()
        {


            return View();
        }

        public ActionResult CursoLogicaProgramcao()
        {


            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}