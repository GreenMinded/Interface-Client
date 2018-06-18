using InterfaceCli.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InterfaceCli.Controllers
{
    public class QuestionController : Controller
    {
        // GET: Scheduler

        public ActionResult Question()
        {
            Questions questions = new Questions();
            ViewData["Questions"] = questions.ObtainQuestionBase();

            return View();


        }
    }
}