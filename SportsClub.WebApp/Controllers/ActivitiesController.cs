using SportsClub.Bll;
using SportsClub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsClub.WebApp.Controllers
{
    public class ActivitiesController : Controller
    {
        // GET: Activities
        public ActionResult Index()
        {
            List<Activity> lstActivities = Activities.Read();
            return View(lstActivities);
        }
    }
}