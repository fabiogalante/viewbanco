using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ViewsFromDatabase.Models;

namespace ViewsFromDatabase.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MvcMusicStoreContext db = new MvcMusicStoreContext();
            List<Artist> model = db.Artist.ToList();
            ViewBag.Message = "Esta View está sendo lida do banco!";
            return View(model);
        }


        public ActionResult Aprenda()
        {
            ViewBag.Message = "Aprenda DotNet - www.aprendadotnet.com.br";
            return View();
        }

       
    }
}