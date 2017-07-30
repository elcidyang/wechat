using Abp.Web.Mvc.Views;

namespace WeChat.Web.Views
{
    public abstract class WeChatWebViewPageBase : WeChatWebViewPageBase<dynamic>
    {

    }

    public abstract class WeChatWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected WeChatWebViewPageBase()
        {
            LocalizationSourceName = WeChatConsts.LocalizationSourceName;
        }
    }
}