using System;

namespace Higrow.AspNetCore.TestSupport
{
    public class TypeWithObsoleteAttribute
    {
        [Obsolete]
        public string ObsoleteProperty { get; set; }
    }
}