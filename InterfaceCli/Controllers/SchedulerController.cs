using InterfaceCli.APIGreen;
using InterfaceCli.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InterfaceCli.Controllers
{
    public class SchedulerController : Controller
    {
        // GET: Scheduler

        public ActionResult SchedulerQuestion()
        {
            Questions questions = new Questions();
            Dates date = new Dates();

            ViewData["Questions"] = questions.ObtainQuestionBase();
            ViewData["Date1"] = date.Datestr1;
            ViewData["Date2"] = date.Datestr2;
            ViewData["Date3"] = date.Datestr3;
            ViewData["Date4"] = date.Datestr4;
            ViewData["Date5"] = date.Datestr5;
            ViewData["Date6"] = date.Datestr6;
            ViewData["Date7"] = date.Datestr7;

            return View();


        }

    }
}