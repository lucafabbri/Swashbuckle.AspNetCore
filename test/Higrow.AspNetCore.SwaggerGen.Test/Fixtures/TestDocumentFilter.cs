using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Higrow.AspNetCore.TestSupport;

namespace Higrow.AspNetCore.SwaggerGen.Test
{
    public class TestDocumentFilter : IDocumentFilter
    {
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            swaggerDoc.Extensions.Add("X-foo", new OpenApiString("bar"));
            swaggerDoc.Extensions.Add("X-docName", new OpenApiString(context.DocumentName));
            context.SchemaGenerator.GenerateSchema(typeof(ComplexType), context.SchemaRepository);
        }
    }
}