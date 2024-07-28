using Microsoft.Win32;
using System.Configuration;
using System.Data;
using System.IO;
using System.Windows;
using System.Xml.Serialization;
using Virtual_IED_GUI.Models;
using Virtual_IED_GUI.Stores;
using Virtual_IED_GUI.ViewModels;
using static Virtual_IED_GUI.Models.SclClass;

namespace Virtual_IED_GUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private string vIEDDataPath = "vIEDData.xml";
        [XmlRoot("IedDAta")]
        public class vIEDData
        {
            public IED IED { get; set; }
            public MMSDataSetStore MMSDataSetStore { get; set; }
            public GooseSenderStore GooseSenderStore { get; set; }

        }

        private readonly NavegationStore _navegationStore = new();
        private readonly IecNavegationStore _iecNavegationStore = new();
        private readonly ModalNavegationStore _modalNavegationStore = new();
        private readonly MMSDataSetStore _mmsDataSetStore = new();
        private readonly GooseSenderStore _gooseSenderStore = new();
        private readonly IED _ied = new();

        protected override void OnStartup(StartupEventArgs e)
        {

            LoadAppData();


            _navegationStore.CurrentViewModel = new Iec61850ViewModel(_iecNavegationStore, _modalNavegationStore, _ied, _mmsDataSetStore, _gooseSenderStore);

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navegationStore, _iecNavegationStore, _modalNavegationStore, _ied, _mmsDataSetStore, _gooseSenderStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            SaveAppData();
            _navegationStore.CurrentViewModel?.Dispose();
            _iecNavegationStore.CurrentViewModel?.Dispose();
            _modalNavegationStore.CurrentViewModel?.Dispose();
            base.OnExit(e);
        }


        private void SaveAppData()
        {
            var appData = new vIEDData()
            {
                IED = _ied,
                MMSDataSetStore = _mmsDataSetStore,
                GooseSenderStore = _gooseSenderStore,
            };

            var serializer = new XmlSerializer(typeof(vIEDData));
            using (var writer = new StreamWriter(vIEDDataPath))
            {
                serializer.Serialize(writer, appData);
            }
        }

        private bool LoadAppData()
        {
            if (File.Exists(vIEDDataPath))
            {
                try
                {
                    var serializer = new XmlSerializer(typeof(vIEDData));
                    using (var reader = new StreamReader(vIEDDataPath))
                    {
                        var appData = (vIEDData)serializer.Deserialize(reader);

                        // Restore the data to the application stores
                        _ied.Load(appData.IED);
                        _mmsDataSetStore.Load(appData.MMSDataSetStore);
                        _gooseSenderStore.Load(appData.GooseSenderStore);
                        // Add other stores or necessary data here
                    }

                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
    }

}
