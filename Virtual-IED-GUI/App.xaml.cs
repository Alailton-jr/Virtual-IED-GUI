using Microsoft.Win32;
using System.Configuration;
using System.Data;
using System.IO;
using System.Windows;
using System.Xml.Serialization;
using Virtual_IED_GUI.Models;
using Virtual_IED_GUI.Stores;
using Virtual_IED_GUI.ViewModels;
using static Virtual_IED_GUI.Models.SCLClass;

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
        private readonly IED _ied = new();

        protected override void OnStartup(StartupEventArgs e)
        {
            _navegationStore.CurrentViewModel = new Iec61850ViewModel(_iecNavegationStore, _modalNavegationStore, _ied);

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navegationStore, _iecNavegationStore, _modalNavegationStore, _ied)
            };
            MainWindow.Show();

            Iec61850.IedData iedData = new Iec61850.IedData();
            iedData.IedDesc = "Virtual IED";
            iedData.ApName = "S1";
            iedData.IedName = "vIED";
            iedData.BitRate = Iec61850.IedData.BitRateEnum.M100;
            iedData.subNetworkName = "subNetwork";
            iedData.Revision = "1.0";

            iedData.CreateDefaultSCL();

            XmlSerializer serializer = new XmlSerializer(typeof(SCL));
            using (FileStream stream = new FileStream("vIED.CID", FileMode.Create))
            {
                serializer.Serialize(stream, iedData.scl);
            }


            base.OnStartup(e);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            _navegationStore.CurrentViewModel?.Dispose();
            _iecNavegationStore.CurrentViewModel?.Dispose();
            _modalNavegationStore.CurrentViewModel?.Dispose();
            base.OnExit(e);
        }
    }

}
