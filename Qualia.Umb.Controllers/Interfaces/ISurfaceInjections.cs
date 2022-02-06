using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Common;

namespace Qualia.Umb.Controllers
{
    public interface ISurfaceInjections
    {
        public IUmbracoContextAccessor UmbracoContextAccessor { get; }
        public IUmbracoDatabaseFactory DatabaseFactory { get; }
        public ServiceContext Services { get; }
        public AppCaches AppCaches { get; }
        public IProfilingLogger ProfilingLogger { get; }
        public IPublishedUrlProvider PublishedUrlProvider { get; }
        public IVariationContextAccessor VariationContextAccessor { get; }
        public ILocalizationService LocalizationService { get; }
        public UmbracoHelper UmbracoHelper { get; }
    }

}
