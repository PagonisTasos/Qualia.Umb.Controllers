using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Web.Common;

namespace Qualia.Umb.Controllers
{
    public abstract partial class BaseApiController : Umbraco.Cms.Web.Common.Controllers.UmbracoApiController
    {
        public IVariationContextAccessor VariationContextAccessor { get; }
        public UmbracoHelper UmbracoHelper { get; }
        public ILocalizationService LocalizationService { get; }

        public BaseApiController(IApiInjections apiInjections)
        {
            VariationContextAccessor = apiInjections.VariationContextAccessor;
            UmbracoHelper = apiInjections.UmbracoHelper;
            LocalizationService = apiInjections.LocalizationService;
        }
    }
}
