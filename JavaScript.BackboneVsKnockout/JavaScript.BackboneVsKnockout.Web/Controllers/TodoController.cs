using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JavaScript.BackboneVsKnockout.Web.Controllers
{
    public class TodoController : Controller
    {     
        public ActionResult Backbone()
        {
            return View(Model.ToDo.All);
        }

        public ActionResult Knockout()
        {
            return View(Model.ToDo.All);
        }

        public ActionResult Save(IList<Model.ToDo> todos)
        {
            Model.ToDo.All = todos;
            return Json(true);
        }
    }
}
