using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сalculator
{
    class StorageHelper
    {
        private Storage _storage = new Storage();

        /// <summary>
        /// Словарь вызова методов работы с памятью. 
        /// </summary>
        private Dictionary<AllActions, Func<double, double>> _operationsWithMemory = new Dictionary<AllActions, Func<double, double>>();

        /// <summary>
        /// Заполнение словаря данными о методах работы с памятью. 
        /// </summary>
        public void NewOperationsWithMemory()
        {
            _operationsWithMemory.Add(AllActions.SaveToMemory, (arg) => _storage.SaveToMemory(arg));
            _operationsWithMemory.Add(AllActions.ReadFromMemory, (arg) => _storage.ReadFromMemory());
            _operationsWithMemory.Add(AllActions.ClearMemory, (arg) => _storage.ClearMemory());
            _operationsWithMemory.Add(AllActions.AddToMemory, (arg) => _storage.AddToMemory(arg));
            _operationsWithMemory.Add(AllActions.SubtractFromMemory, (arg) => _storage.SubtractFromMemory(arg));
        }

        public Func<double, double> GetOperationWithMemory(AllActions actionType)
        {
            if (!_operationsWithMemory.ContainsKey(actionType))
            {
                throw new InvalidOperationException($"Словарь операций не содержит такого ключа {actionType}");
            }

            return _operationsWithMemory[actionType];
        }

    }
}
