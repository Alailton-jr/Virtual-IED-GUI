using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Virtual_IED_GUI.Controls;
using NCalc;
using Expression = NCalc.Expression;

namespace Virtual_IED_GUI.Components
{
    public class NumTextBox : TextBox
    {
        public NumTextBox()
        {
            this.LostFocus += TextBox_TextChanged;
            this.KeyDown += NumericTextBox_OnKeyDown;
        }

        private void TextBox_TextChanged(object sender, RoutedEventArgs e)
        {
            EvaluateText();
        }

        private void NumericTextBox_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                EvaluateText();
            }
        }

        private void EvaluateText()
        {
            try
            {
                var expression = this.Text;
                var result = EvaluateExpression(expression);
                this.Text = result.ToString();
                this.CaretIndex = this.Text.Length;
            }
            catch
            {
                // Handle invalid expressions if necessary
            }
        }

        private double EvaluateExpression(string expression)
        {
            try
            {
                var e = new Expression(expression);

                e.EvaluateFunction += (name, args) =>
                {
                    if (name == "sqrt")
                    {
                        args.Result = Math.Sqrt(Convert.ToDouble(args.Parameters[0].Evaluate()));
                    }
                };

                var result = e.Evaluate();
                return Convert.ToDouble(result);
            }
            catch
            {
                return double.NaN;
            }
        }
    }
}
