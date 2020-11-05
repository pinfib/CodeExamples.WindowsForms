using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator.Model
{
    internal class CalculatorModel
    {
        private readonly Dictionary<string, Func<double, double, double>> _binaryOperations; // бинарные операции, доупные внутри модели

        private readonly Dictionary<string, Func<double, double>> _unaryOperations; // унарные операции

        private double _memory; // переменная для хранения числа, не участвующего в вычислениях в данный момент

        private string _currentOperation; // переменная для хранения текущей операции

        internal double Memory
        {
            get
            {
                return _memory;
            }
            set
            {
                _memory = value;

                MemoryChanged(this, EventArgs.Empty); // событие для оповещения view об изменении переменной
            }
        }

        internal string CurrentOperation
        {
            get
            {
                if (_currentOperation == null)
                {
                    return "";
                }

                return _currentOperation;
            }
            set
            {
                _currentOperation = value;
            }
        }

        internal double Result { get; set; } // переменная для хранения текущего результата операции

        internal List<string> BinaryOperationsList { get; } // список доступных бинарных операций, передаваемых во view

        internal List<string> UnaryOperationsList { get; } // список доступных унарных операций

        internal EventHandler MemoryChanged;

        internal CalculatorModel()
        {
            _binaryOperations = CalculatorOperations.GetBinaryOperations();
            BinaryOperationsList = _binaryOperations.Keys.ToList();

            _unaryOperations = CalculatorOperations.GetUnaryOperations();
            UnaryOperationsList = _unaryOperations.Keys.ToList();
        }

        internal double GetResult(double number)
        {
            if (CurrentOperation == "")
            {
                Result = number;
            }
            else
            {
                Result = _binaryOperations[CurrentOperation].Invoke(Result, number);
            }

            return Result;
        }

        internal double GetResult(double number, string operation)
        {
            return _unaryOperations[operation].Invoke(number);
        }
    }
}