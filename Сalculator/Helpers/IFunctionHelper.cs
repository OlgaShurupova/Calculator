using System;
using System.Linq;
using System.Reflection;

namespace Сalculator.Helpers
{
    static class IFunctionHelper
    {
        public static IFunction GetFunction(this AllActions actionType)
        {
            var types = Assembly.GetExecutingAssembly().GetTypes().Single(x => x.GetCustomAttribute<ActionTypeAttribute>()?.ActionType == actionType);
            var instance = Activator.CreateInstance(types) as IFunction;
            return instance;
        }
    }
}
