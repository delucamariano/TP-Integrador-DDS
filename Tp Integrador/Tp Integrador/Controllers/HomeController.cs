using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CDataManager;

namespace Tp_Integrador.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            DataManager.LevantarDatos();
            return View(DataManager.Clientes);
        }
    }
}