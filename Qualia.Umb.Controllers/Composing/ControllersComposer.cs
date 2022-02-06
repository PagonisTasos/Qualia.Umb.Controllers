using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace Qualia.Umb.Controllers
{
    public class ControllersComposer : IComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            builder.Services.AddScoped<ISurfaceInjections, SurfaceInjections>();
            builder.Services.AddScoped<IRenderInjections, RenderInjections>();
            builder.Services.AddScoped<IApiInjections, ApiInjections>();
        }
    }
}
