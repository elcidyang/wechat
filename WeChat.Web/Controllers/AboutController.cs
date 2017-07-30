using System.Web.Mvc;

namespace WeChat.Web.Controllers
{
    public class AboutController : WeChatControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}