using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace EscolaPequenosGenios.Mvc.Helpers
{
    public class ViewRender
    {
        public static async Task<string> RenderViewToStringAsync(Controller controller, string viewName, object model)
        {
            var viewEngine = controller.HttpContext.RequestServices.GetRequiredService<ICompositeViewEngine>();

            var viewResult = viewEngine.FindView(controller.ControllerContext, viewName, false);

            if (viewResult.Success)
            {
                using var writer = new StringWriter();
                var viewContext = new ViewContext(
                    controller.ControllerContext,
                    viewResult.View,
                    new ViewDataDictionary(new EmptyModelMetadataProvider(), new ModelStateDictionary())
                    {
                        Model = model
                    },
                    new TempDataDictionary(controller.HttpContext, controller.HttpContext.RequestServices.GetRequiredService<ITempDataProvider>()),
                    writer,
                    new HtmlHelperOptions()
                );

                await viewResult.View.RenderAsync(viewContext);

                return writer.GetStringBuilder().ToString();
            }
            else
            {
                throw new Exception($"View '{viewName}' not found.");
            }
        }
    }
}
