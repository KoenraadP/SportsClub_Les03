using SportsClub.Bll;
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
        // CREATE

        // READ ALL
        public ActionResult Index()
        {
            List<Member> lstMembers = Members.Read();
            return View(lstMembers);
        }

        // READ SINGLE

        // UPDATE

        // DELETE
    }
}