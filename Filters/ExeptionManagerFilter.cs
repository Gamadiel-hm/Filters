using Filters.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Filters.Filters
{
    public class ExeptionManagerFilter(IWebHostEnvironment webHostEnvironment, IModelMetadataProvider modelMetadataProvider) : IExceptionFilter
    {
        private readonly IWebHostEnvironment _webHostEnvironment = webHostEnvironment;
        private readonly IModelMetadataProvider _modelMetadataProvider = modelMetadataProvider;

        public void OnException(ExceptionContext context)
        {
            if (context.Exception is MyException)
            {
                context.Result = new JsonResult("Fallo algo en la aplicacion" + _webHostEnvironment.ApplicationName
                + "ExeptionType" + context.Exception.GetType());
            }
        }
    }
}
