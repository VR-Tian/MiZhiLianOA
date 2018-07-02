using Abp.AutoMapper;
using VR.Tian.Sessions.Dto;

namespace VR.Tian.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}