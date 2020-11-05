using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculator.View
{
    internal class CalculatorDataTextBox : TextBox
    {
        private readonly char _numberDecimalSeparator;

        internal bool DataIsResult { get; set; }

        internal CalculatorDataTextBox()
        {
            Dock = DockStyle.Fill;
            Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            Location = new System.Drawing.Point(3, 14);
            Margin = new Padding(3, 14, 3, 3);
            Size = new System.Drawing.Size(196, 30);

            Click += DeleteResultOperation; // если в текст-боксе результат выражения, его нужно сначала стереть
            KeyPress += InputFilter;

            _numberDecimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator); // разделитель зависит от региональных стандартов

            DataIsResult = true;
        }

        private void DeleteResultOperation(object sender, EventArgs e)
        {
            if (DataIsResult)
            {
                Text = "";
                DataIsResult = false;
            }
        }

        private void InputFilter(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;

            if (number == _numberDecimalSeparator && Text.Contains(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }

            if (!char.IsDigit(number) && number != 8 && number != _numberDecimalSeparator) // цифры, клавиша BackSpace и разделитель десятичных
            {
                e.Handled = true;
            }
        }
    }
}