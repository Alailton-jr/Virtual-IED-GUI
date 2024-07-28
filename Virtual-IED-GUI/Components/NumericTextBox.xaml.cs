using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using NCalc;
using Expression = NCalc.Expression;

namespace Virtual_IED_GUI.Controls
{
    /// <summary>
    /// Interaction logic for NumericTextBox.xaml
    /// </summary>
    public partial class NumericTextBox : UserControl
    {
        public NumericTextBox()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(
            "Text", 
            typeof(string), 
            typeof(NumericTextBox), 
            new PropertyMetadata(default(string), 
            OnTextChanged));

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        private static void OnTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is NumericTextBox numericTextBox)
            {
                numericTextBox.numericTextBox.Text = e.NewValue as string;
            }
        }

        private void TextBox_TextChanged(object sender, RoutedEventArgs routedEventArgs)
        {
            Text = numericTextBox.Text;
            EvaluateText();
        }

        private void EvaluateText()
        {
            try
            {
                var expression = numericTextBox.Text;
                var result = EvaluateExpression(expression);
                numericTextBox.Text = result.ToString();
                numericTextBox.CaretIndex = numericTextBox.Text.Length;
            }
            catch
            {
                // Handle invalid expressions if necessary
            }
        }

        private double EvaluateExpression(string expression)
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

        private void NumericTextBox_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                EvaluateText();
                var textBox = (TextBox)sender;
                textBox?.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
                e.Handled = true;
            }
        }
    }
}
