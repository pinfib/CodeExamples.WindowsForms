using Calculator.Model;
using Calculator.Presenter;
using Calculator.View;
using System;
using System.Windows.Forms;

namespace Calculator
{
    static class CalculatorProgram
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var view = new CalculatorView();
            var model = new CalculatorModel();
            var presenter = new CalculatorPresenter(view, model);

            presenter.StartView();
        }
    }
}