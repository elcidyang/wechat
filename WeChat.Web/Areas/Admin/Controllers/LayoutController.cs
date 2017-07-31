using Abp.Application.Navigation;
using Abp.Configuration.Startup;
using Abp.Localization;
using Abp.Threading;
using System.Web.Mvc;
using WeChat.Sessions;
using WeChat.Web.Areas.Admin.Models;
using WeChat.Web.Controllers;

namespace WeChat.Web.Areas.Admin.Controllers
{
    public class LayoutController : WeChatControllerBase
    {
        private readonly IUserNavigationManager _userNavigationManager;
        private readonly ISessionAppService _sessionAppService;
        private readonly IMultiTenancyConfig _multiTenancyConfig;
        private readonly ILanguageManager _languageManager;

        public LayoutController(
            IUserNavigationManager userNavigationManager,
            ISessionAppService sessionAppService,
            IMultiTenancyConfig multiTenancyConfig,
            ILanguageManager languageManager)
        {
            _userNavigationManager = userNavigationManager;
            _sessionAppService = sessionAppService;
            _multiTenancyConfig = multiTenancyConfig;
            _languageManager = languageManager;
        }

        [ChildActionOnly]
        public ContentResult Theme()
        {
            var theme = string.Empty;

            if (AbpSession.UserId.HasValue)
            {
                var loginInformations = AsyncHelper.RunSync(() => _sessionAppService.GetCurrentLoginInformations());
                theme = loginInformations.User.Theme;
            }
            return new ContentResult{Content = theme };
        }

        [ChildActionOnly]
        public PartialViewResult Header()
        {
            var model = new AdminInfoViewModel();

            if (AbpSession.UserId.HasValue)
            {
                model = new AdminInfoViewModel
                {
                    LoginInformations = AsyncHelper.RunSync(() => _sessionAppService.GetCurrentLoginInformations())
                };
            }
            return PartialView("_Header", model);
        }

        [ChildActionOnly]
        public PartialViewResult SideBar()
        {
            return PartialView("_SideBar");
        }

        [ChildActionOnly]
        public PartialViewResult Footer()
        {
            return PartialView("_Footer");
        }

        [ChildActionOnly]
        public PartialViewResult ControlSideBar()
        {
            return PartialView("_ControlSideBar");
        }
    }
}