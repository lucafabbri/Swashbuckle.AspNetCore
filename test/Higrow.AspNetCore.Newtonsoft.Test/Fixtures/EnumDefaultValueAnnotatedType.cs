using System.ComponentModel;
using Higrow.AspNetCore.TestSupport;

namespace Higrow.AspNetCore.Newtonsoft.Test
{
    public class EnumDefaultValueAnnotatedType
    {
        [DefaultValue(IntEnum.Value8)]
        public IntEnum IntEnumWithDefaultValue { get; set; }

        [DefaultValue(JsonConverterAnnotatedEnum.X)]
        public JsonConverterAnnotatedEnum AnnotatedEnumWithDefaultValue { get; set; }
    }
}
