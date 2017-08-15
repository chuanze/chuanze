using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Soulcalibur.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : SoulcaliburControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}