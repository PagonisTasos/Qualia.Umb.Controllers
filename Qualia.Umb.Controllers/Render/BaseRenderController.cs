using System;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common;

namespace Qualia.Umb.Controllers
{
    public abstract partial class BaseRenderController : Umbraco.Cms.Web.Common.Controllers.RenderController
    {
        protected BaseRenderController(IRenderInjections renderInjections) 
            : base(renderInjections.Logger, renderInjections.CompositeViewEngine, renderInjections.UmbracoContextAccessor)
        {
            VariationContextAccessor = renderInjections.VariationContextAccessor;
            UmbracoHelper = renderInjections.UmbracoHelper;
        }

        public IVariationContextAccessor VariationContextAccessor { get; set; }
        protected UmbracoHelper UmbracoHelper { get; }
    }
}
