using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Higrow.AspNetCore.SwaggerGen;

namespace Higrow.AspNetCore.Newtonsoft.Test
{
    public class VendorExtensionsSchemaFilter : ISchemaFilter
    {
        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            schema.Extensions.Add("X-foo", new OpenApiString("bar"));
        }
    }
}