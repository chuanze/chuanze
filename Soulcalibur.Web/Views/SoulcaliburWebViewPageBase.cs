using Abp.Web.Mvc.Views;

namespace Soulcalibur.Web.Views
{
    public abstract class SoulcaliburWebViewPageBase : SoulcaliburWebViewPageBase<dynamic>
    {

    }

    public abstract class SoulcaliburWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected SoulcaliburWebViewPageBase()
        {
            LocalizationSourceName = SoulcaliburConsts.LocalizationSourceName;
        }
    }
}