using System;
using System.Collections.Generic;
using System.Linq;

namespace Сalculator
{
    class Parser
    {
        private ParseHelper _operationInitializer = new ParseHelper();

        private string SetOperations = "-+*/^%";         

        /// <summary>
        /// Обрабатывает численное значение аргумента итоговый список. 
        /// </summary>
        /// <param name="currentCharacter"></param>
        private string GetSubString(string str, ref int i)
        {
            string newString = string.Empty;
            var j = 0;
            try
            {
                do
                {
                    newString += str[j];
                    j++;
                    i++;
                } while (CheckCondition(str[j - 1], str[j]));
            }
            catch (IndexOutOfRangeException)
            {
            }
            return newString;
        }

        /// <summary>
        /// Выполняет проверку принадлежности двух соседних символов одному типу
        /// (буква-буква, число-число).
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        private bool CheckCondition(char first, char second)
        {
            return ((char.IsLetter(first) && char.IsLetter(second))
                || (CheckIsNumber(first) && CheckIsNumber(second))) ? true : false;
        }
        /// <summary>
        /// Выполняет проверку на принадлежность к числу. 
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        private bool CheckIsNumber(char arg)
        {
            return (char.IsDigit(arg) || arg == ',' ) ? true : false;
        }
       
        /// <summary>
        /// Обработка операций. 
        /// </summary>
        /// <param name="currentCharacter"></param>
        private void ProcessOperaion(string str, List<IElements> istElements,  Stack<string> stackOperations)
        {
            var parseHelper = new ParseHelper();
            while (stackOperations.Count!=0 && parseHelper.ChekCondition( str, stackOperations.Peek()))
              AddAction(stackOperations.Pop(), istElements);
            
            stackOperations.Push(str);       
        }

        /// <summary>
        /// Перевод из инфиксной записи в ОПЗ.
        /// Сохранение значений аргументов и операций в список. 
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public List<IElements> FillList(string inputString)
        { 
            var listOfElements = new List<IElements>();
            var stackOperations = new Stack<string>();
            var sign = 0;          
            for (int i = 0; i < inputString.Count();)
            {
                var subString = inputString.Substring(i);

                if (subString[0] == '-') subString=ProcessMinus(inputString,  listOfElements, stackOperations, ref i, ref sign);
                
                if (char.IsDigit(subString[0])) ProcessNumber(subString, ref i, listOfElements, ref sign);               

                if (char.IsLetter(subString[0])) ProcessOperaion(GetSubString(subString, ref i), listOfElements, stackOperations);

                if (SetOperations.Contains(subString[0]))
                {
                    ProcessOperaion(subString[0].ToString(),  listOfElements, stackOperations);
                    i++;
                }
                if (subString[0]== '(') ProcessLeftBracket( subString, ref i,  stackOperations);
                if (subString[0] == ')') ProcessRightBracket(subString, ref i, listOfElements,  stackOperations);
            }

            GetFromStack( listOfElements, stackOperations);
            
            return listOfElements;
        }

        /// <summary>
        /// Обрабатывает нажатие унарного минуса. 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="i"></param>
        /// <param name="z"></param>
        private string ProcessMinus(string inputString,  List<IElements> listOfElements,  Stack<string> stackOperations, ref int i, ref int sign)
        {
            if (i != 0 && (char.IsDigit(inputString[i - 1]) || inputString[i - 1] == ')')) ProcessOperaion("+",  listOfElements,  stackOperations);
            sign++;
            i++;
            return inputString.Substring(i);
        }

        /// <summary>
        /// Обработка числа. 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="i"></param>
        private void ProcessNumber(string str, ref int i,  List<IElements> listOfElemtnts, ref int sign)
        {
            var number = new Number();
            number.Argument = double.Parse(GetSubString(str, ref i))*Math.Pow(-1,sign);              
            listOfElemtnts.Add(number);
            sign = 0;
        }

        /// <summary>
        /// Вносит открывающуюся скобку в стек. 
        /// </summary>
        /// <param name="currentCharacter"></param>
        private void ProcessLeftBracket(string str, ref int i, Stack<string> stackOperations)
        {
            stackOperations.Push(str[0].ToString());
            i++;               
        }

        /// <summary>
        /// Обрабатывает закрывающуюся скобку. 
        /// </summary>
        private void ProcessRightBracket(string str, ref int i, List<IElements> listOfElements, Stack<string> stackOperations)
        {           
                var newString = stackOperations.Pop();
                while (newString != "(")
                {
                    AddAction(newString, listOfElements);
                    newString = stackOperations.Pop();
                }
                i++;
        }

        /// <summary>
        /// Вытеснение остатка  операций из стека. 
        /// </summary>
        private void GetFromStack(List<IElements> listOfElements, Stack<string> stackOperations)
        {
            if (stackOperations.Count > 0)
                foreach (var action in stackOperations)
                    AddAction(action, listOfElements);
        }        

        /// <summary>
        /// Вносит операцию в список.
        /// </summary>
        /// <param name="action"></param>
        private void AddAction(string action, List<IElements> listOfElements)
        {
            var operation = Operation.Create(action);
            listOfElements.Add(operation);
        }
    }
}

