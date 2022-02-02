using ASP220202.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP220202.Controllers
{
    //Update-Package Microsoft.CodeDom.Providers.DotNetCompilerPlatform -r
    public class UgyfelekController : Controller
    {
        static List<Ugyfel> _fakeDB = new List<Ugyfel>()
        {
            new Ugyfel(){ Id = 1, Nev = "Cserepes Virág", },
            new Ugyfel(){ Id = 2, Nev = "Lapos Elemér", },
        };

        // GET: Ugyfelek/(Index)
        public ActionResult Index()
        {
            return View(_fakeDB);
        }

        //GET Ugyfelek/Reszletek/{Id}

        public ActionResult Reszletek(int id)
        {
            var fakeUgyfel = _fakeDB.FirstOrDefault(x => x.Id == id);
            if (fakeUgyfel is null)
                return Content("HIBA!");
            else return View(fakeUgyfel);
        }
    }
}