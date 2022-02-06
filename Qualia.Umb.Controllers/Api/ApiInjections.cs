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
    public class ApiInjections : IApiInjections
    {
        public ApiInjections(
            IVariationContextAccessor variationContextAccessor
            , UmbracoHelper umbracoHelper
            , ILocalizationService localizationService
            )
        {
            VariationContextAccessor = variationContextAccessor;
            UmbracoHelper = umbracoHelper;
            LocalizationService = localizationService;
        }

        public IVariationContextAccessor VariationContextAccessor { get; }
        public UmbracoHelper UmbracoHelper { get; }
        public ILocalizationService LocalizationService { get; }
    }
}
