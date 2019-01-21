using System;

namespace Сalculator.Helpers
{
    static class IArgumentHelper
    {
        public static OneArgument ConvertToOneArgument(this IArguments iArguments)
        {
            var arg = iArguments as OneArgument;
            if (arg == null) throw new InvalidOperationException($"{nameof(iArguments)} не правильного типа ");
            return arg;
        }

        public static TwoArguments ConvertToTwoArguments(this IArguments iArguments)
        {
            var arg = iArguments as TwoArguments;
            if (arg == null) throw new InvalidOperationException($"{nameof(iArguments)} не правильного типа ");
            return arg;
        }
    }
}
