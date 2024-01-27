using Newtonsoft.Json;

namespace Higrow.AspNetCore.Newtonsoft.Test
{
    public class JsonRequiredAnnotatedType
    {
        [JsonRequired]
        public string StringWithJsonRequired { get; set; }
    }
}