using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Higrow.AspNetCore.SwaggerGen;

namespace Higrow.AspNetCore.Annotations.Test
{
    public class VendorExtensionsOperationFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext contex)
        {
            operation.Extensions.Add("X-property1", new OpenApiString("value"));
        }
    }
}