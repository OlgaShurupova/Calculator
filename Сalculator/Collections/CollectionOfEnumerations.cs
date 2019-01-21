using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сalculator
{
    /// <summary>
    /// Перечисление всех действий над переменными. 
    /// </summary>
    public enum AllActions
    {
        Add,
        Subtract,
        Divide,
        Multiply,
        GetPercentages,
        GetSquareRoot,
        GetRoot,
        GetFactorial,
        GetPower,
        GetDecimalLogarithm,
        GetNaturalLogarithm,
        GetSin,
        cos,
        GetTan,
        GetModule,
        GetTanh,
        GetCosh,
        GetSinh,
        GetInt,
        Dms,
        GetAtan,
        GetAcos,
        GetAsin,
        GetAsinh,
        GetAcosh,
        GetAtanh,
        Deg,
        GetFrac,
        GetExp,
        GetBackwardFraction,
        GetNegative,
        AddToMemory,
        SubtractFromMemory,
        ClearMemory,
        SaveToMemory,
        ReadFromMemory,
        Exp,
    };


    /// <summary>
    /// Перечисление единиц измеренияя тригонометрических функций. 
    /// </summary>                   
    public enum Units
    {
        degrees,
        radians,
        grads,
    };
}
