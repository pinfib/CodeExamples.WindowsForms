using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Calculator.View
{
    internal partial class CalculatorView : Form
    {
        internal double Number
        {
            get
            {
                if (textBoxData.Text != "")
                {
                    return Convert.ToDouble(textBoxData.Text, CultureInfo.CurrentCulture);
                }

                return 0;
            }
            set
            {
                textBoxData.Text = value.ToString();
                textBoxData.DataIsResult = true;
            }
        }

        internal double Memory
        {
            get
            {
                return Convert.ToDouble(labelCurrentMemory.Text, CultureInfo.CurrentCulture);
            }
            set
            {
                labelCurrentMemory.Text = value.ToString();
            }
        }

        internal string CurrentOperation
        {
            get
            {
                return labelCurrentOperation.Text;
            }
            set
            {
                labelCurrentOperation.Text = value;
            }
        }

        internal bool IsResult
        {
            get
            {
                return textBoxData.DataIsResult;
            }
            set
            {
                textBoxData.DataIsResult = value;
            }
        }

        internal CalculatorView()
        {
            InitializeComponent();

            buttonDecimalSeparator.Text = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator; // разделитель выбирается в зависимости от региональных стандартов
        }

        internal void StartView()
        {
            Application.Run(this);
        }

        internal void SetOperations(Control control, List<string> list, EventHandler eventHandler)
        {
            foreach (var e in list)
            {
                control.Controls.Add(new CalculatorButton(e, eventHandler));
            }
        }

        private void SymbolAddition(object sender, EventArgs e)
        {
            var currentButton = sender as Button;

            if (textBoxData.DataIsResult) // если в текст-боксе результат выражения, его нужно стереть
            {
                textBoxData.Text = currentButton.Text;
                textBoxData.DataIsResult = false;
                return;
            }

            if (currentButton.Text == CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator && textBoxData.Text.Contains(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                return;     // если в тексt-боксе уже есть точка, то ничего не добавлять
            }

            textBoxData.Text += currentButton.Text;
        }

        internal bool DataIsResult()
        {
            return textBoxData.DataIsResult;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}