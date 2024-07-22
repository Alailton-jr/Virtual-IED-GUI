using System.Windows;
using System.Windows.Input;

namespace Virtual_IED_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                try
                {
                    if (e.GetPosition(this).Y < 100)
                    {
                        if (WindowState == WindowState.Normal)
                            this?.DragMove();
                        else
                        {
                            WindowState = WindowState.Normal;
                            double x = e.GetPosition(this).X;
                            double y = e.GetPosition(this).Y;
                            Left = x - Width/2;
                            Top = y;
                            this?.DragMove();
                        }
                    }

                }
                catch
                {
                    // ignored
                }
            }
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Maximize_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
            }
            else
            {
                WindowState = WindowState.Normal;
            }
        }

    }
}