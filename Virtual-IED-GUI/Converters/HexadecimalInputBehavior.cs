using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows;

namespace Virtual_IED_GUI.Converters
{
    public class HexadecimalInputBehavior
    {
        private static readonly Regex HexadecimalRegex = new Regex("^[0-9A-Fa-f]+$");
        public static readonly DependencyProperty IsHexadecimalInputProperty =
            DependencyProperty.RegisterAttached(
                "IsHexadecimalInput",
                typeof(bool),
                typeof(HexadecimalInputBehavior),
                new PropertyMetadata(false, OnIsHexadecimalInputChanged));

        public static bool GetIsHexadecimalInput(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsHexadecimalInputProperty);
        }

        public static void SetIsHexadecimalInput(DependencyObject obj, bool value)
        {
            obj.SetValue(IsHexadecimalInputProperty, value);
        }

        private static void OnIsHexadecimalInputChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is TextBox textBox)
            {
                if ((bool)e.NewValue)
                {
                    textBox.PreviewTextInput += TextBox_PreviewTextInput;
                }
                else
                {
                    textBox.PreviewTextInput -= TextBox_PreviewTextInput;
                }
            }
        }

        private static void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsHexadecimal(e.Text);
        }

        private static bool IsHexadecimal(string text)
        {
            return HexadecimalRegex.IsMatch(text);
        }
    }
}
