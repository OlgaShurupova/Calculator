using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Сalculator.Helpers;

namespace Сalculator
{
    public partial class MainWin : Form
    {
        private StorageHelper _storageHelper = new StorageHelper();

        /// <summary>
        /// Запоминает нажатие кнопки инвертирования. 
        /// </summary>
        private bool IsInverted = false;

        /// <summary>
        /// Отвечает за формат вывода данных (F-E).
        /// </summary>
        private bool IsFormat = true;

        public MainWin()
        {
            InitializeComponent();
            _storageHelper.NewOperationsWithMemory();
            MoveCursor();
        }

        private void ClearButtonClick(object sender, EventArgs e)
        {
            showResult.Text = string.Empty;
            showError.Text = string.Empty;
            MoveCursor();
        }

        /// <summary>
        /// Знак равенства.  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EqualsButtonClick(object sender, EventArgs e)
        {
            showError.Text = string.Empty;
            var parser = new Parser();
            try
            {
                var result = CountResult(parser.FillList(showResult.Text.Replace(" ", string.Empty)));
                DisplayResult(result);
            }
            catch (Exception)
            {
                showError.Text = "Недопустимый ввод.";
            }
            MoveCursor();
        }

        /// <summary>
        /// Вычисление результата преобразованного строкового выражения. 
        /// </summary>
        private double CountResult(List<IElements> ListOfElements)
        {
            var stackArguments = new Stack<double>();
            foreach (var element in ListOfElements)
            {
                if (element.ToString() == "Сalculator.Number") stackArguments.Push((element as Number).Argument);
                else ProcessAction(element as Operation, stackArguments);
            }
            var result= stackArguments.Pop();
            if (stackArguments.Count != 0) throw new Exception($"в стеке аргумекнтов присутствуют лишние операнды");
            return result;
        }


        /// <summary>
        /// Обработка действия.  
        /// </summary>
        /// <param name="operation"></param>
        private void ProcessAction(Operation operation, Stack<double> stackArguments)
        {
            var funcInstance = operation.Action.GetFunction();

            if (funcInstance.GetNumberArgs() == 1)
            {
                var result = CountOneArgument(stackArguments.Pop(), funcInstance);
                stackArguments.Push(result);
            }
            else
            {
                var result = CountTwoArgs(stackArguments.Pop(), stackArguments.Pop(), funcInstance);
                stackArguments.Push(result);
            }
        }

        /// <summary>
        /// f(x)
        /// </summary>
        /// <param name="arg"></param>
        /// <param name="funcInstance"></param>
        /// <returns></returns>
        private double CountOneArgument(double arg, IFunction funcInstance)
        {
            Units unit = SelectArgument(degrees.Checked, grads.Checked, degrees.Name, grads.Name, radians.Name);
            var argument = new OneArgument() { First = arg, Unit = unit };
            return funcInstance.Solve(argument);
        }

        /// <summary>
        /// f(x,y)
        /// </summary>
        /// <param name="firstArg"></param>
        /// <param name="secondArg"></param>
        /// <param name="funcInstance"></param>
        /// <returns></returns>
        private double CountTwoArgs(double firstArg, double secondArg, IFunction funcInstance)
        {
            var twoArguments = new TwoArguments() { Second = firstArg, First = secondArg };
            return funcInstance.Solve(twoArguments);
        }

        /// <summary>
        ///  Обработчик f(x).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OneArgumentButtonClick(object sender, EventArgs e)
        {
            showResult.Text += (sender as Button).Text + "(";
            MoveCursor();
        }

        /// <summary>
        /// Обработчик введенных числовых значений. 
        /// Вызов функции пересчета введенных значений происходит здесь. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnySymbolButtonClick(object sender, EventArgs e)
        {
            showResult.Text += (sender as Button).Text;
            MoveCursor();
        }

        /// <summary>
        /// Смена названий отдельных кнопок. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvertButtonClick(object sender, EventArgs e)
        {
            IsInverted = !IsInverted;
            if (IsInverted)
            {
                GetNaturalLogarithm.Text = "exp";
                GetSin.Text = "asin";
                GetCos.Text = "acos";
                GetSinh.Text = "asinh";
                GetCosh.Text = "acosh";
                GetTanh.Text = "atanh";
                GetTan.Text = "atan";
                GetPi.Text = "2*pi";
                GetInt.Text = "frac";
                Dms.Text = "deg";
            }
            else
            {
                GetNaturalLogarithm.Text = "ln";
                GetSin.Text = "sin";
                GetCos.Text = "cos";
                GetSinh.Text = "sinh";
                GetCosh.Text = "cosh";
                GetTanh.Text = "tanh";
                GetTan.Text = "tan";
                GetPi.Text = "pi";
                GetInt.Text = "int";
                Dms.Text = "dms";
            }
        }

        /// <summary>
        /// Проверка ввода. Реакция на "=".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowResultKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 37 && (e.KeyChar < 40 || e.KeyChar > 45) && (e.KeyChar < 47 || e.KeyChar > 57)
                && e.KeyChar != 94 && (e.KeyChar < 97 || e.KeyChar > 122) && e.KeyChar != 127)
                e.Handled = true;
            if (e.KeyChar == 61) EqualsButtonClick(sender, e);
        }

        /// <summary>
        /// Устанавливает курсор в поле ввода. 
        /// </summary>
        private void MoveCursor()
        {
            showResult.SelectionStart = showResult.Text.Length;
            showResult.Focus();
        }


        private void BackspaceClick(object sender, EventArgs e)
        {
            try
            {
                showResult.Text = showResult.Text.Substring(0, showResult.Text.Length - 1);
            }
            catch (ArgumentOutOfRangeException)
            {
                showResult.Text = string.Empty;
            }
            MoveCursor();
        }

        /// <summary>
        /// Обработчик кнопок работы с памятью. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MemoryClick(object sender, EventArgs e)
        {
            var actionType = (AllActions)Enum.Parse(typeof(AllActions), (sender as Button).Name);
            var operation = _storageHelper.GetOperationWithMemory(actionType);
            operation(double.Parse(showResult.Text));
            MoveCursor();
        }

        /// <summary>
        /// Считывание значения из памяти. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReadMemoryClick(object sender, EventArgs e)
        {
            var actionType = (AllActions)Enum.Parse(typeof(AllActions), (sender as Button).Name);
            var operation = _storageHelper.GetOperationWithMemory(actionType);
            var result = operation(0);

            DisplayResult(result);
            MoveCursor();
        }

        /// <summary>
        /// Изменение формата числа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeFormatClickk(object sender, EventArgs e)
        {
            IsFormat = !IsFormat;
            MoveCursor();
        }

        /// <summary>
        /// Ввод числа в экспоненциальной форме. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExponentialFormatClick(object sender, EventArgs e)
        {
            showResult.Text = showResult.Text + "*10^";
            MoveCursor();
        }

        /// <summary>
        /// Вывод результата или сообщения об ошибке. 
        /// </summary>
        private void DisplayResult(double result)
        {
            try
            {
                showResult.Text = (IsFormat) ? result.ToString() : result.ToString("0.#e+0");
            }
            catch (InputErrorException)
            {
                showError.Text = "Выход за пределы ОДЗ.";
            }
        }

        /// <summary>
        /// Выбор единицы измерения аргумента тригонометрической функции.
        /// </summary>
        private Units SelectArgument(bool isDegrees, bool isGrads, string degreesName, string gradsName, string radiansName)
        {
            if (isDegrees) return (Units)Enum.Parse(typeof(Units), degreesName);
            if (isGrads) return (Units)Enum.Parse(typeof(Units), gradsName);
            return (Units)Enum.Parse(typeof(Units), radiansName);
        }

        private void PiClick(object sender, EventArgs e)
        {
            var result = IsInverted == false ? Math.PI : 2 * Math.PI;
            DisplayResult(result);
            MoveCursor();
        }

        private void PlusMinusClick(object sender, EventArgs e)
        {
            showResult.Text += "-";
            MoveCursor();
        }
    }
}

