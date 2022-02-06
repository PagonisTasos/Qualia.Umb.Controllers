using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.Extensions.Logging;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common;
using Umbraco.Cms.Web.Common.Controllers;

namespace Qualia.Umb.Controllers
{
    public interface IRenderInjections
    {
        public ILogger<RenderController> Logger { get; }
        public ICompositeViewEngine CompositeViewEngine { get; }
        public IUmbracoContextAccessor UmbracoContextAccessor { get; }
        public IVariationContextAccessor VariationContextAccessor { get; }
        public UmbracoHelper UmbracoHelper { get; }
    }
}
