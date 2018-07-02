using Abp.Web.Mvc.Views;

namespace VR.Tian.Web.Views
{
    public abstract class TianWebViewPageBase : TianWebViewPageBase<dynamic>
    {

    }

    public abstract class TianWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected TianWebViewPageBase()
        {
            LocalizationSourceName = TianConsts.LocalizationSourceName;
        }
    }
}