using Calculator.Model;
using Calculator.View;
using System;
using System.Windows.Forms;

namespace Calculator.Presenter
{
    internal class CalculatorPresenter
    {
        private readonly CalculatorView _view;

        private readonly CalculatorModel _model;

        internal CalculatorPresenter(CalculatorView view, CalculatorModel model)
        {
            _view = view;
            _model = model;
        }

        internal void StartView()
        {
            _view.SetOperations(_view.flowLayoutPanelBinaryOperations, _model.BinaryOperationsList, CalculateBinaryOperation);
            _view.SetOperations(_view.flowLayoutPanelUnaryOperations, _model.UnaryOperationsList, CalculateUnaryOperation);

            _view.buttonResult.Click += CalculateBinaryOperation;

            _model.MemoryChanged += (sender, e) => _view.Memory = _model.Memory;

            _view.buttonMemoryCleare.Click += (sender, e) => _model.Memory = 0;                     // очистить память
            _view.buttonMemorySubtraction.Click += (sender, e) => _model.Memory -= _view.Number;    // вычесть текущее число из памяти
            _view.buttonMemoryAddition.Click += (sender, e) => _model.Memory += _view.Number;       // прибавить текущее число к памяти

            _view.buttonMemorySave.Click += (sender, e) =>      // сохранить текущее число в память,
            {
                _model.Memory = _view.Number;
                _view.IsResult = true;                          // сохраненное число больше нельзя редактировать
            };

            _view.buttonMemoryRead.Click += (sender, e) =>      // добавить в textBox число из памяти
            {
                _view.Number = _model.Memory;
                _view.IsResult = true;                          // прочитанное число нельзя редактировать
            };

            _view.buttonClearTextBox.Click += (sender, e) => _view.Number = 0;

            _view.buttonClearAll.Click += (sender, e) =>
            {
                _view.Number = 0;
                _view.CurrentOperation = "";
                _model.Result = 0;
            };

            _view.StartView();
        }

        internal void CalculateBinaryOperation(object sender, EventArgs e)
        {
            var currentButton = sender as Button;

            if (!_view.IsResult || currentButton.Text == "=")   // произвести вычисление только если в текст-боксе не результат,
            {                                                   // или если в качестве операции передано "="
                _view.Number = _model.GetResult(_view.Number);
            }

            if (_model.BinaryOperationsList.Contains(currentButton.Text))   // сверить переданную операцию со списком операций,
            {                                                               // чтобы записать только существующее значение в поле текущей операции
                _view.CurrentOperation = currentButton.Text;
                _model.CurrentOperation = currentButton.Text;
            }
        }

        internal void CalculateUnaryOperation(object sender, EventArgs e)
        {
            var currentButton = sender as CalculatorButton;

            _view.Number = _model.GetResult(_view.Number, currentButton.Text);
        }
    }
}