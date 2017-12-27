using System.Collections.Generic;
using System.Linq;

namespace Common.Functions.CheckNullableEnumerationForAnyElements
{
    public static class NullableEnumerationAny
    {
        public static bool Any<T>(IEnumerable<T> enumeration)
            => enumeration?.Any() ?? false;
    }
}
