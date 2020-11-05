using System;
using System.Windows.Forms;

namespace Calculator.View
{
    internal class CalculatorButton : Button
    {
        internal CalculatorButton()
        {
            Size = new System.Drawing.Size(40, 40);
            Margin = new Padding(2, 2, 2, 2);
            UseVisualStyleBackColor = true;
        }

        internal CalculatorButton(string text, EventHandler eventHandler) : this()
        {
            Text = text;
            Click += eventHandler;
        }
    }
}