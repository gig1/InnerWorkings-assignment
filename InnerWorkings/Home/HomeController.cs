using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.Jobs.Queries.GetJobsList;
using Application.Jobs.Commands.AddExtraMargin;

namespace InnerWorkings.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGetJobsListQuery _jobsQuery;

        public HomeController()
        {

        }

        public HomeController(IGetJobsListQuery jobsQuery)
        {
            _jobsQuery = jobsQuery;
        }

        public ActionResult Index()
        {
            var jobs = _jobsQuery.Execute();
            return View(jobs);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}