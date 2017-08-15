using System.Web.Mvc;

namespace Soulcalibur.Web.Controllers
{
    public class AboutController : SoulcaliburControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}