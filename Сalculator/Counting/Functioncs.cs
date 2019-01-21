using System;
using Сalculator.Helpers;

namespace Сalculator
{

    interface IFunction
    {
        double Solve(IArguments iArguments);
        int GetNumberArgs();
    }

    internal class ActionTypeAttribute : Attribute
    {

        public ActionTypeAttribute(AllActions actionType)
        {
            ActionType = actionType;
        }
        public AllActions ActionType { get; set; }

    }

    abstract class OneArgumentFunction : IFunction
    {
        public int GetNumberArgs() => 1;

        public abstract double Solve(IArguments iArguments);
    }

    abstract class TwoArgumentsFunction: IFunction
    {
        public int GetNumberArgs() => 2;

        public abstract double Solve(IArguments iArguments);
    }

    [ActionType(AllActions.GetSin)]
    class SinTrigonometricFunctioncs : OneArgumentFunction
    {
        public override double Solve(IArguments iArguments)
        {
            var arg = iArguments.ConvertToOneArgument();
            var converter = new Converter();
            return Math.Sin(converter.GetAngle(arg.First, arg.Unit));
        }

    }
    [ActionType(AllActions.GetAsin)]
    class ASinTrigonometricFunctioncs : OneArgumentFunction
    {        
        public override double Solve(IArguments iArguments)
        {
            var arg = iArguments.ConvertToOneArgument();
            var converter = new Converter();
            if (Math.Abs(arg.First) > 1) throw new InputErrorException($"выход за пределы ОДЗ");
            return Math.Asin(converter.GetAngle(arg.First, arg.Unit));
        }

    }
    [ActionType(AllActions.GetSinh)]
    class SinhTrigonometricFunctioncs : OneArgumentFunction
    {
        
        public override double Solve(IArguments iArguments)
        {
            var arg = iArguments.ConvertToOneArgument();
            var converter = new Converter();
            return Math.Sinh(converter.GetAngle(arg.First, arg.Unit));
        }
    }

    [ActionType(AllActions.GetAsinh)]
    class ASinhTrigonometricFunctioncs : OneArgumentFunction
    {
       
        public override double Solve(IArguments iArguments)
        {
            var arg = iArguments.ConvertToOneArgument();
            var converter = new Converter();
            arg.First = converter.GetAngle(arg.First, arg.Unit);
            return Math.Log(arg.First + Math.Sqrt(arg.First * arg.First + 1));
        }
    }
    

    [ActionType(AllActions.cos)]
    class CosTrigonometricFunctioncs : OneArgumentFunction
    {
        public override double Solve(IArguments iArguments)
        {
            var arg = iArguments.ConvertToOneArgument();
            var converter = new Converter();
            return Math.Cos(converter.GetAngle(arg.First, arg.Unit));
        }

    }

    [ActionType(AllActions.GetAcos)]
    class ACosTrigonometricFunctioncs : OneArgumentFunction
    {
      
        public override double Solve(IArguments iArguments)
        {
            var arg = iArguments.ConvertToOneArgument();
            var converter = new Converter();
            arg.First = converter.GetAngle(arg.First, arg.Unit);
            if (Math.Abs(arg.First) > 1) throw new InputErrorException($"выход за пределы ОДЗ");
            return Math.Acos(arg.First);
        }

    }

    [ActionType(AllActions.GetCosh)]
    class CoshTrigonometricFunctioncs : OneArgumentFunction
    {     
        public override double Solve(IArguments iArguments)
        {
            var converter = new Converter();
            var arg = iArguments.ConvertToOneArgument();
            return Math.Cosh(converter.GetAngle(arg.First, arg.Unit));
        }

    }

    [ActionType(AllActions.GetAcosh)]
    class ACoshTrigonometricFunctioncs : OneArgumentFunction
    {
        public override double Solve(IArguments iArguments)
        {
            var arg = iArguments.ConvertToOneArgument();
            var converter = new Converter();
            arg.First = converter.GetAngle(arg.First, arg.Unit);
            if (arg.First <= 1) throw new InputErrorException($"выход за пределы ОДЗ");
            return Math.Log(arg.First + Math.Sqrt(arg.First * arg.First - 1));
        }

    }

    [ActionType(AllActions.GetTan)]
    class TanTrigonometricFunctioncs : OneArgumentFunction
    {
      
        public override double Solve(IArguments iArguments)
        {
            var arg = iArguments.ConvertToOneArgument();
            var converter = new Converter();
            return Math.Tan(converter.GetAngle(arg.First, arg.Unit));
        }

    }

    [ActionType(AllActions.GetAtan)]
    class ATanTrigonometricFunctioncs : OneArgumentFunction
    {
        public override double Solve(IArguments iArguments)
        {
            var arg = iArguments.ConvertToOneArgument();
            var converter = new Converter();
            return Math.Atan(converter.GetAngle(arg.First, arg.Unit));
        }

    }

    [ActionType(AllActions.GetTanh)]
    class TanhTrigonometricFunctioncs : OneArgumentFunction
    {
     
        public override double Solve(IArguments iArguments)
        {
            var arg = iArguments.ConvertToOneArgument();
            var converter = new Converter();
            return Math.Tanh(converter.GetAngle(arg.First, arg.Unit));
        }
    }

    [ActionType(AllActions.GetAtanh)]
    class ATanhTrigonometricFunctioncs : OneArgumentFunction
    {
        public override double Solve(IArguments iArguments)
        {
            var arg = iArguments.ConvertToOneArgument();
            var converter = new Converter();
            arg.First = converter.GetAngle(arg.First, arg.Unit);
            if (Math.Abs(arg.First) > 1) throw new InputErrorException($"выход за пределы ОДЗ");
            return 0.5 * Math.Log((1 + arg.First) / (1 - arg.First));
        }
    }


    [ActionType(AllActions.GetNaturalLogarithm)]
    class NaturalLogarithmFunctioncs : OneArgumentFunction
    {       
        public override double Solve(IArguments iArguments)
        {
            var arg = iArguments.ConvertToOneArgument();
            return Math.Log(arg.First);
        }
    }

    [ActionType(AllActions.GetDecimalLogarithm)]
    class DecimalLogarithmFunctioncs : OneArgumentFunction
    {     
        public override double Solve(IArguments iArguments)
        {
            var arg = iArguments.ConvertToOneArgument();
            return Math.Log10(arg.First);
        }
    }

    [ActionType(AllActions.GetRoot)]
    class GetRoot : OneArgumentFunction
    {
        public override double Solve(IArguments iArguments)
        {
            var arg = iArguments.ConvertToTwoArguments();
            return Math.Pow(arg.First, 1 / arg.Second);
        }
    }

    [ActionType(AllActions.GetInt)]
    class GetInt: OneArgumentFunction
    {        
        public override double Solve(IArguments iArguments)
        {
            var arg = iArguments.ConvertToOneArgument();
            return (int)(arg.First);
        }
    }

    [ActionType(AllActions.GetExp)]
    class GetExp: OneArgumentFunction
    {       
        public override double Solve(IArguments iArguments)
        {
           var arg= iArguments.ConvertToOneArgument();
            return Math.Exp(arg.First);
        }
    }

 

    [ActionType(AllActions.GetFrac)]
    /// <summary>
    /// Получение дробной части числа. 
    /// </summary>
    /// <param name="argument"></param>
    /// <returns></returns>
    class GetFracFunctioncs : OneArgumentFunction
    {
        public override double Solve(IArguments iArguments)
        {
            var arg = iArguments.ConvertToOneArgument();
            return Math.Abs(arg.First - Math.Truncate(arg.First));
        }
    }


    [ActionType(AllActions.Add)]
    class Add: TwoArgumentsFunction
    {
      
        public override double Solve(IArguments iArguments)
        {
            var arg = iArguments.ConvertToTwoArguments();
            return arg.First + arg.Second;
        }
    }

    [ActionType(AllActions.Subtract)]
    class Substract: TwoArgumentsFunction
    {       
        public override double Solve(IArguments iArguments)
        {
            var arg = iArguments.ConvertToTwoArguments();
            return arg.First - arg.Second;
        }

    }

    [ActionType(AllActions.Multiply)]
    class Multiply : TwoArgumentsFunction
    {
        
        public override double Solve(IArguments iArguments)
        {
            var arg = iArguments.ConvertToTwoArguments();
            return arg.First * arg.Second;
        }
    }

    [ActionType(AllActions.Divide)]
    class Divide : TwoArgumentsFunction
    {
      
        public override double Solve(IArguments iArguments)
        {
            var arg = iArguments.ConvertToTwoArguments();
            if (arg.Second == 0) throw new InputErrorException("выход запределы ОДЗ");
            return arg.First / arg.Second;
        }
    }


    [ActionType(AllActions.GetSquareRoot)]
    class GetSquareRoot : OneArgumentFunction
    {
      
        public override double Solve(IArguments iArguments)
        {
            var arg = iArguments.ConvertToOneArgument();
            if (arg.First < 0) throw new InputErrorException("выход за пределы ОДЗ");
            return Math.Sqrt(arg.First);
        }
    }

    [ActionType(AllActions.GetPower)]
    class GetPower: TwoArgumentsFunction
    {        
        public override double Solve(IArguments iArguments)
        {
            var arg = iArguments.ConvertToTwoArguments();
            return Math.Pow(arg.First, arg.Second);
        }
    }

    [ActionType(AllActions.GetNegative)]
    class GetNegative : OneArgumentFunction
    {      
        public override double Solve(IArguments iArguments)
        {
            var arg = iArguments.ConvertToOneArgument();
            return -arg.First;
        }
    }
    [ActionType(AllActions.GetModule)]
    class GetModule: TwoArgumentsFunction
    {       
        public override double Solve(IArguments iArguments)
        {
            var arg = iArguments.ConvertToTwoArguments();
            return arg.First % arg.Second;
        }
    }

    [ActionType(AllActions.GetFactorial)]
    class GetFuctorial : OneArgumentFunction
    {       
        public override double Solve(IArguments iArguments)
        {
            var arg = iArguments.ConvertToOneArgument();
            var newArg = (int)arg.First;
            return Factorial(newArg);
        }

        private int Factorial(int newArg)
        {
            if (newArg == 0 || newArg == 1) return 1;
            else return newArg*Factorial(newArg-1);
        }
    }

    [ActionType(AllActions.Dms)]
    /// <summary>
    /// Конвертация из формата ДД,ММСС в ДД,ДДДД.        
    /// </summary>
    /// <param name="argument"></param>
    /// <returns></returns>
    class GetDms : OneArgumentFunction
    {       
        public override double Solve(IArguments iArguments)
        {
            var arg = iArguments.ConvertToOneArgument();
            int degrees = (int)arg.First;
            int minutes = (int)(GetFrac(arg.First) * 60);
            arg.First *= 100;
            double seconds = GetFrac(arg.First) * 36;
            return degrees + (double)minutes / 100 + (double)seconds / 10000;
        }
        private double GetFrac(double newArg)
        {
            return Math.Abs(newArg - (int)(newArg));
        }
    }

    [ActionType(AllActions.Deg)]
    /// <summary>
    /// Конвертация из формата ДД,ДДДД в ДД,ММСС.
    /// </summary>
    /// <param name="argument"></param>
    /// <returns></returns>
    class GetDegrees : OneArgumentFunction
    {      
        public override double Solve(IArguments iArguments)
        {
            var arg = iArguments.ConvertToOneArgument();
            int degrees = (int)arg.First;
            int minutes = (int)(GetFrac(arg.First) * 100);
            arg.First = (GetFrac(arg.First) * 100);
            int seconds = (int)(GetFrac(arg.First) * 100);
            return degrees + (double)minutes / 60 + seconds / 3600;
        }
        private double GetFrac(double newArg)
        {
            return Math.Abs(newArg - (int)(newArg));
        }
    }

    class Converter
    {
        /// <summary>
        /// Передает полученное значение угла во внешний код. 
        /// </summary>
        /// <param name="angle"></param>
        /// <param name="unit"></param>
        /// <returns></returns>
        public double GetAngle(double angle, Units unit)
        {
            var converter = new Converter();
            return ConvertAngle(angle, unit);
        }

        /// <summary>
        /// Выполняет конвертацию в радианы. 
        /// </summary>
        /// <param name="angle"></param>
        /// <param name="unit"></param>
        /// <returns></returns>
        private double ConvertAngle(double angle, Units unit)
        {
            switch (unit)
            {
                case Units.degrees:
                    return angle * Math.PI / 180;
                case Units.grads:
                    return angle * Math.PI / 200;
                default:
                    return angle;
            }
        }
    }
}
