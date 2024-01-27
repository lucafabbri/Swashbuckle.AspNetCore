using System.Text.Json.Serialization;

namespace Higrow.AspNetCore.SwaggerGen.Test
{
    public class JsonPropertyNameAnnotatedType
    {
        [JsonPropertyName("string-with-json-property-name")]
        public string StringWithJsonPropertyName { get; set; }
    }
}
