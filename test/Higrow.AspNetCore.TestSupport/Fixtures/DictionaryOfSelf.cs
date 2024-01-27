using System.Collections.Generic;

namespace Higrow.AspNetCore.TestSupport
{
    public class DictionaryOfSelf : Dictionary<string, DictionaryOfSelf>
    {
    }
}