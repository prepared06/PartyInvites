using Microsoft.AspNetCore.Mvc;
using PartyInvites.Data;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        private ResponseContext _db;

        public HomeController(ResponseContext db)
        {
            _db = db;
        }
        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
        }
        public ViewResult Index()
        {
            return View(new Party());
        }     

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if(ModelState.IsValid)
            {
                _db.GuestResponses.Add(guestResponse);
                _db.SaveChanges();
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
            
        }

        public ViewResult ListResponses()
        {
            var res = _db.GuestResponses.Where(r => r.WillAtend == true);          
            return View(res);
        }
    }
}