using System.Configuration;
using System.Data;
using System.Windows;
using Virtual_IED_GUI.Stores;
using Virtual_IED_GUI.ViewModels;

namespace Virtual_IED_GUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private readonly NavegationStore _navegationStore = new();
        private readonly IecNavegationStore _iecNavegationStore = new();
        private readonly ModalNavegationStore _modalNavegationStore = new();

        protected override void OnStartup(StartupEventArgs e)
        {
            _navegationStore.CurrentViewModel = new Iec61850ViewModel(_iecNavegationStore, _modalNavegationStore);

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navegationStore, _iecNavegationStore, _modalNavegationStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }

}
