using System;
using System.Collections.Generic;
using System.Text;

namespace Higrow.AspNetCore.TestSupport.Fixtures
{
    public class FakeControllerWithActionWithParamDefaults
    {
        public void ActionWithEnumParamDefaultValue(IntEnum firstParam = IntEnum.Value4) { }
    }
}
