using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;
    
    
namespace MeyawoPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            ViewBag.categoryCount = db.TblCategory.Count();
            ViewBag.projectCount = db.TblProject.Count();
            ViewBag.messageCount =db.TblCantact.Count();
            ViewBag.flutterProjectCount =db.TblProject.Where(x=>x.ProjectCategory ==1).Count();
            ViewBag.isReadMessageCount = db.TblCantact.Where(x=> x.Isread == false).Count();
            ViewBag.lastProjectName = db.LastProjectName().FirstOrDefault();

            return View();
        }
    }
}