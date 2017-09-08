﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScrumCentral.Models;
using ScrumCentral.Helpers;

namespace ScrumCentral.Controllers
{
    public class HomeController : Controller
    {
        
        MongoDbHandler dbHandler = MongoDbHandler.Instance;
        public IActionResult Index()
        {
            PokerSession pokerSession = new PokerSession();
            pokerSession.Name = "Michael";
            pokerSession.TotalCount = 10;
            dbHandler.InsertPokerSession(pokerSession);
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}