using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            var dataTable = new DataTable();
            return Convert.ToDouble(dataTable.Compute(expression, string.Empty));
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
