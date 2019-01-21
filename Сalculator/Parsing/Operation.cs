using System;
using System.Collections.Generic;

namespace Сalculator
{
    class Operation : IElements
    {

        public static Operation Create(string action)
        {
            var designations = new Dictionary<string, AllActions>()
            {
                {"^", AllActions.GetPower},
                {"*", AllActions.Multiply},
                {"/", AllActions.Divide},
                {"-", AllActions.Subtract},
                {"+", AllActions.Add},
                {"sin", AllActions.GetSin},
                {"asin", AllActions.GetAsin},
                {"sinh", AllActions.GetSinh},
                {"asinh", AllActions.GetAsinh},
                {"cos", AllActions.cos},
                {"acos", AllActions.GetAcos},
                {"cosh", AllActions.GetCosh},
                {"acosh", AllActions.GetAcosh},
                {"sqrt", AllActions.GetSquareRoot },
                {"tan", AllActions.GetTan},
                {"atan", AllActions.GetAtan},
                {"tanh", AllActions.GetTanh},
                {"atanh", AllActions.GetAtanh},
                {"yroot", AllActions.GetRoot},
                {"fact", AllActions.GetFactorial },
                {"lg", AllActions. GetDecimalLogarithm},
                {"ln", AllActions. GetNaturalLogarithm},
                {"%", AllActions. GetModule },
                {"int", AllActions.GetInt },
                {"frac", AllActions.GetFrac },
                {"exp", AllActions.GetExp},
                {"inverse", AllActions. GetBackwardFraction},
                {"#", AllActions.GetNegative},
                {"dms", AllActions.Dms},
                {"deg", AllActions.Deg},
            };

            if (!designations.ContainsKey(action))
            {
                throw new InvalidOperationException();
            }

            return new Operation()
            {
                Action = designations[action]
            };
        }

        public AllActions Action { get; set; }
    }
}
