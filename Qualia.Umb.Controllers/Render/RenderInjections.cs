using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.Extensions.Logging;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common;
using Umbraco.Cms.Web.Common.Controllers;

namespace Qualia.Umb.Controllers
{
    public class RenderInjections : IRenderInjections
    {
        public RenderInjections(
            ILogger<RenderController> logger
            , ICompositeViewEngine compositeViewEngine
            , IUmbracoContextAccessor umbracoContextAccessor
            , IVariationContextAccessor variationContextAccessor
            , UmbracoHelper umbracoHelper
            )
        {
            Logger = logger;
            CompositeViewEngine = compositeViewEngine;
            UmbracoContextAccessor = umbracoContextAccessor;
            VariationContextAccessor = variationContextAccessor;
            UmbracoHelper = umbracoHelper;
        }
        public ILogger<RenderController> Logger { get; }
        public ICompositeViewEngine CompositeViewEngine { get; }
        public IUmbracoContextAccessor UmbracoContextAccessor { get; }
        public IVariationContextAccessor VariationContextAccessor { get; }
        public UmbracoHelper UmbracoHelper { get; }
    }
}
