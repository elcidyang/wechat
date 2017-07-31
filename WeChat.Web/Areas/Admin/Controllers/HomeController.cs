using Abp.Web.Mvc.Authorization;
using System.Web.Mvc;
using Abp.Application.Navigation;
using Abp.Configuration.Startup;
using Abp.Localization;
using Abp.Threading;
using Abp.Web.Mvc.Controllers.Results;
using Abp.Zero.Configuration;
using WeChat.Sessions;
using WeChat.Users;
using WeChat.Users.Dto;
using WeChat.Web.Areas.Admin.Models;
using WeChat.Web.Controllers;

namespace WeChat.Web.Areas.Admin.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : WeChatControllerBase
    {
        private readonly IUserNavigationManager _userNavigationManager;
        private readonly ISessionAppService _sessionAppService;
        private readonly IMultiTenancyConfig _multiTenancyConfig;
        private readonly ILanguageManager _languageManager;
        private readonly IUserAppService _userAppService;

        public HomeController(
            IUserAppService userAppService,
            IUserNavigationManager userNavigationManager,
            ISessionAppService sessionAppService,
            IMultiTenancyConfig multiTenancyConfig,
            ILanguageManager languageManager)
        {
            _userAppService = userAppService;
            _userNavigationManager = userNavigationManager;
            _sessionAppService = sessionAppService;
            _multiTenancyConfig = multiTenancyConfig;
            _languageManager = languageManager;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ModifyUserInfo()
        {
            return View();
        }

        /// <summary>
        /// 修改皮肤
        /// </summary>
        /// <param name="skin"></param>
        /// <returns></returns>
        public JsonResult ModifySkin(string skin)
        {
            var loginInfo = AsyncHelper.RunSync(() => _sessionAppService.GetCurrentLoginInformations());
            _userAppService.UpdateUser(new UpdateUserInput
            {
                Id = loginInfo.User.Id,
                Theme = skin
            });
            return Json(new {Success =true,Msg="修改成功！"});
        }
    }
}