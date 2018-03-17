using PartyInvite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvite.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hours = DateTime.Now.Hour;
            ViewBag.Greeting = hours < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm() {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse) {
            if (ModelState.IsValid) {
                return View("Thanks", guestResponse);
            }
            else {
                return View();
            }
        }
    }
}