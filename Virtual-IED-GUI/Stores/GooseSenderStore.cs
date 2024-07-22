using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Virtual_IED_GUI.Models;

namespace Virtual_IED_GUI.Stores
{
    [Serializable]
    public class GooseSenderStore
    {

        private List<GooseData> _gooseDataList;
        public List<GooseData> GooseDataList
        {
            get => _gooseDataList;
            set
            {
                _gooseDataList = value;
            }
        }

        private GooseData _selectedGooseData;

        public GooseData SelectedGooseData
        {
            get => _selectedGooseData;
            set
            {
                _selectedGooseData = value;
            }
        }

        [field: XmlIgnore]
        public Action GooseListChanged;

        public GooseSenderStore()
        {
            _gooseDataList = new();
        }

        public void AddGooseData(GooseData gooseData)
        {
            _gooseDataList.Add(gooseData);
            GooseListChanged?.Invoke();
        }

        public void RemoveGooseData()
        {
            if (_gooseDataList.Count > 0)
            {
                _gooseDataList.RemoveAt(_gooseDataList.Count - 1);
                GooseListChanged?.Invoke();
            }
        }

        public void UpdateGooseData(GooseData gooseData)
        {
            var index = _gooseDataList.FindIndex(x => x.ID == gooseData.ID);
            if (index != -1)
            {
                _gooseDataList[index] = gooseData;
                GooseListChanged?.Invoke();
            }
        }


        
        private const string FixedMacPrefix = "01:0C:CD:01";
        private int ExtractLastHexFromMac(string mac)
        {
            var parts = mac.Split(':');
            return parts.Length == 6 && int.TryParse(parts[5], System.Globalization.NumberStyles.HexNumber, null, out var number) ? number : 0;
        }
        private string GenerateNextMacAddress()
        {
            var existingMacs = GooseDataList
                .Select(i => i.MacAddress)
                .ToList();

            var maxNumber = existingMacs
                .Select(mac => ExtractLastHexFromMac(mac))
                .DefaultIfEmpty(0)
                .Max();

            return $"{FixedMacPrefix}:{(maxNumber + 1):X2}:{(maxNumber + 1):X2}";
        }

        private const string DefaultNamePrefix = "vIEDGODat";
        private string GenerateNextDefaultName()
        {
            var existingNames = GooseDataList
                .Where(i => i.Name.StartsWith(DefaultNamePrefix))
                .Select(i => i.Name)
                .ToList();

            var maxNumber = existingNames
                .Select(name => ExtractNumberFromName(name))
                .DefaultIfEmpty(0)
                .Max();

            return $"{DefaultNamePrefix}{maxNumber + 1}";
        }
        private int ExtractNumberFromName(string name)
        {
            var numberPart = name.Substring(DefaultNamePrefix.Length);
            return int.TryParse(numberPart, out var number) ? number : 0;
        }

        public GooseData GetDefaultGooseData()
        {
            GooseData gooseData = new GooseData
            {
                Name = GenerateNextDefaultName(),
                Description = "New Goose Data",
                DataSet = "New DataSet",
                LDevice = "New LDevice",
                appID = 4000,
                VLanID = null,
                VLanPriority = 0,
                MacAddress = GenerateNextMacAddress()
            };
            return gooseData;
        }




        public void Load(GooseSenderStore appDataGooseSenderStore)
        {
            _gooseDataList.Clear();
            foreach (var gooseData in appDataGooseSenderStore.GooseDataList)
            {
                _gooseDataList.Add(gooseData);
            }
        }


    }
}
