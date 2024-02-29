using SportsClub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsClub.WebApp.Controllers
{
    public class MembersController : Controller
    {
        // GET: Members
        public ActionResult Index()
        {
            List<Member> lstMembers = new List<Member>
            {
                new Member("Koenraad","Pecceu"),
                new Member("Mieke", "Lapeire")
            };
            return View(lstMembers);
        }
    }
}