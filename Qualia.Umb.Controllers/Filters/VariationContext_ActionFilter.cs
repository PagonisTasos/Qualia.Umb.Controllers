using System;
using System.Linq;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Qualia.Umb.Controllers
{
    public class VariationContext_ActionFilter : Attribute, Microsoft.AspNetCore.Mvc.Filters.IActionFilter
    {
        public void OnActionExecuting(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext context)
        {
            IVariationContextController controller = (IVariationContextController)context.Controller;

            var locale =
                GetLocale_fromHeaders(context)
                ?? GetLocale_fromQuery(context)
                ?? GetLocale_fromRoute(context)
                ;

            if (!LocaleExistsInCms(controller, locale))
            {
                locale = GetLocale_default(controller);
            }

            //UmbracoContent needs this for lang variation
            controller.VariationContextAccessor.VariationContext = new VariationContext(locale);
            //UmbracoDictionary needs this for lang variation
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(locale);
            //lets assign the current cult since we assigned the current ui cult
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(locale);
        }

        public void OnActionExecuted(Microsoft.AspNetCore.Mvc.Filters.ActionExecutedContext context)
        {
            // Do nothing after the action executes.
        }


        private string? GetLocale_fromHeaders(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext context)
            => context.HttpContext.Request.Headers["locale"].ToString().NullIfEmpty();

        private string? GetLocale_fromQuery(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext context)
            => context.HttpContext.Request.Query["locale"].ToString().NullIfEmpty();

        private string? GetLocale_fromRoute(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext context)
            => context.RouteData.Values["locale"]?.ToString().NullIfEmpty();

        private bool LocaleExistsInCms(IVariationContextController c, string? locale)
            => c.LocalizationService.GetAllLanguages().Select(x => x.CultureInfo.Name).ToList().Any(x => x.Equals(locale, StringComparison.OrdinalIgnoreCase));
        private string GetLocale_default(IVariationContextController c)
            => c.LocalizationService.GetDefaultLanguageIsoCode();
    }
}
