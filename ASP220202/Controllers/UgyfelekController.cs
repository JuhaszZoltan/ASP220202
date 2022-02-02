using ASP220202.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP220202.Controllers
{
    //Update-Package Microsoft.CodeDom.Providers.DotNetCompilerPlatform -r

    //enable-migrations
    //add-migration <név>
    //add-migration <név> -force
    //update-database
    public class UgyfelekController : Controller
    {
        //static List<Ugyfel> _fakeDB = new List<Ugyfel>()
        //{
        //    new Ugyfel(){ Id = 1, Nev = "Cserepes Virág", },
        //    new Ugyfel(){ Id = 2, Nev = "Lapos Elemér", },
        //};
        #region appdbcontext
        private ApplicationDbContext _context;
        public UgyfelekController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        #endregion

        // GET: Ugyfelek/(Index)
        public ActionResult Index()
        {
            var ugyfelek = _context.Ugyfelek;
            return View(ugyfelek);
        }

        //GET Ugyfelek/Reszletek/{Id}
        public ActionResult Reszletek(int id)
        {
            var fakeUgyfel = _context.Ugyfelek.FirstOrDefault(x => x.Id == id);
            if (fakeUgyfel is null)
                return Content("HIBA!");
            else return View(fakeUgyfel);
        }
    }
}