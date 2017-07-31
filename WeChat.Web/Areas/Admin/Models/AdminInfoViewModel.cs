
using WeChat.Sessions.Dto;

namespace WeChat.Web.Areas.Admin.Models
{
    /// <summary>
    /// 后台管理员
    /// </summary>
    public class AdminInfoViewModel
    {
        public GetCurrentLoginInformationsOutput LoginInformations { get; set; }
    }
}