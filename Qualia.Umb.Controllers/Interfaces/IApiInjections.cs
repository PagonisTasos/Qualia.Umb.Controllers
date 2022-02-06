using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.Extensions.Logging;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Web.Common;

namespace Qualia.Umb.Controllers
{
    public interface IApiInjections
    {
        public IVariationContextAccessor VariationContextAccessor { get; }
        public UmbracoHelper UmbracoHelper { get; }
        public ILocalizationService LocalizationService { get; }
    }
}
