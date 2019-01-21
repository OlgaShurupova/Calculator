using System;
using System.Collections.Generic;

namespace Сalculator
{

    class ParseHelper
    {
        /// <summary>
        /// Словарь приоритетов операций.
        /// Самый низкий приоритет - 0, самый высокий - 3.
        /// </summary>
        public Dictionary<string, int> PrioritetsOfOperations { get; } = new Dictionary<string, int>()
        {
            {"sin",3},
            {"sinh", 3},
            {"asin", 3},
            {"asinh", 3},
            {"cos", 3},
            {"acos", 3},
            {"cosh", 3},
            {"acosh", 3},
            {"tan", 3},
            {"atan", 3},
            {"tanh", 3},
            {"atanh", 3},
            {"^", 3},
            {"sqrt",3},
            {"fact", 3},
            {"lg", 3},
            {"ln",3},
            {"int",3 },
            {"frac",3},
            {"exp", 3},
            {"inverse", 3},
            {"#", 3},
            {"%", 2},
            {"yroot", 2},
            {"*", 2},
            {"/", 2},
            {"-", 1},
            {"+", 1},
            {"(", 0},
            {")", 0},
        };

        /// <summary>
        /// Сравнение приоритетов текущей операции и операции, лежащей на вершине стека. 
        /// </summary>
        /// <param name="firstOperation"></param>
        /// <param name="secondOperation"></param>
        /// <returns></returns>
        public bool ChekCondition(string firstOperation, string secondOperation)
        {
            var prioritetFirst = PrioritetsOfOperations[firstOperation];
            var prioritetSecond = PrioritetsOfOperations[secondOperation];
            return prioritetFirst <= prioritetSecond;
        }
    }
}
