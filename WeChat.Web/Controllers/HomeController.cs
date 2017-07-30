using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace WeChat.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : WeChatControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}