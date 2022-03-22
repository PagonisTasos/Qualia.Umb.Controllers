using System;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Web.Common;

namespace Qualia.Umb.Controllers
{

    public abstract partial class BaseSurfaceController : Umbraco.Cms.Web.Website.Controllers.SurfaceController
	{
		public IVariationContextAccessor VariationContextAccessor { get; }
		public ILocalizationService LocalizationService { get; }
		protected UmbracoHelper UmbracoHelper { get; }

		public BaseSurfaceController(ISurfaceInjections surfaceInjections)
			: base(
				  surfaceInjections.UmbracoContextAccessor, 
				  surfaceInjections.DatabaseFactory, 
				  surfaceInjections.Services,
				  surfaceInjections.AppCaches,
				  surfaceInjections.ProfilingLogger,
				  surfaceInjections.PublishedUrlProvider)
		{
			VariationContextAccessor = surfaceInjections.VariationContextAccessor;
			LocalizationService = surfaceInjections.LocalizationService;
			UmbracoHelper = surfaceInjections.UmbracoHelper;
		}
	}
}
