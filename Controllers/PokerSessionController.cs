using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ScrumCentral.Models;
using ScrumCentral.Helpers;
using Microsoft.AspNetCore.Html;
using Newtonsoft.Json;

namespace ScrumCentral.Controllers
{
    public class PokerSessionController : Controller
    {
        private readonly PokerSessionContext _context;
        private static HTTPHelper hTTPHelper = HTTPHelper.Instance;
        public PokerSessionController(PokerSessionContext context)
        {
            _context = context;
        }

        // GET: PokerSession
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WaitingScreen()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RecieveVote(int cardValue)
        {
            return View();
        }

        [HttpPost]
        public void StartSession(string sessionName)
        {
            hTTPHelper.CreatePokerSession(sessionName);
        }

        public IActionResult NewSession()
        {
            return View();
        }

        public IActionResult DisplayScreen(string sessionName)
        {
            return View((object)sessionName);
        }

        [HttpGet]
        public string UpdatedPokerSession(string sessionName)
        {
            PokerSession pokerSession = hTTPHelper.GetCurrentSession(sessionName);
            var json = JsonConvert.SerializeObject(pokerSession);
            return json;
        }
    }
}
