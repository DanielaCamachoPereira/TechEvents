using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechEvents.Models;

namespace TechEvents.Controllers
{
    public class ReportesAdminController : Controller
    {

        private ApplicationDbContext context = new ApplicationDbContext();

        [HttpGet]
        public ActionResult totalUsuariosActivos()
        {
           var usuarios = context.Users.ToList();
           return View(usuarios);
        }

       
    }
}
