using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestMVCProject.Controllers
{
    public class MazeController : Controller
    {
        // GET: Maze
        public ActionResult Index()
        {
            return View();
        }
    }
}