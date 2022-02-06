using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Services;

namespace Qualia.Umb.Controllers
{
    public interface IVariationContextController
    {
        public IVariationContextAccessor VariationContextAccessor { get; }
        public ILocalizationService LocalizationService { get; }
    }
}
