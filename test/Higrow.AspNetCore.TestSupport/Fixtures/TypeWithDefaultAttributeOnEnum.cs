using System.ComponentModel;

namespace Higrow.AspNetCore.TestSupport
{
    public class TypeWithDefaultAttributeOnEnum
    {
        [DefaultValue(IntEnum.Value4)]
        public IntEnum EnumWithDefault { get; set; }
    }
}
