using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virtual_IED_GUI.Components;
using static Virtual_IED_GUI.Models.SCLClass;

namespace Virtual_IED_GUI.Models
{
    public class SclData
    {
        public SCL scl { get; } = new();

        // Header Parameters
        public string Revision { get; set; }

        // Communication Parameters
        public string subNetworkName { get; set; }
        public BitRateEnum BitRate { get; set; }
        public string IedName { get; set; }
        public string ApName { get; set; }

        //IED Parameters
        public string IedDesc { get; set; }

        public SclData()
        {
            CreateDefaultSCL();
        }


        private ObservableCollection<TreeNode> GetDaTypeTreeNode(string daTypeID, TreeNode parent)
        {
            ObservableCollection<TreeNode> daTypeTree = new ObservableCollection<TreeNode>();
            tDAType[] DaTypeList = scl.DataTypeTemplates.DAType;

            foreach (tDAType daType in DaTypeList)
            {
                if (daType.id == daTypeID)
                {
                    foreach (tBDA item in daType.BDA)
                    {
                        TreeNode bdaNode = new TreeNode(item.name, parent);
                        if (item.type != null)
                        {
                            bdaNode.Children = GetDaTypeTreeNode(item.type, bdaNode);
                        }
                        daTypeTree.Add(bdaNode);
                    }
                    break;
                }
            }

            return daTypeTree;
        }

        private ObservableCollection<TreeNode> GetDoTypeNodeTree(string doTypeID, TreeNode parent, string fc)
        {
            ObservableCollection<TreeNode> doTypeTree = new ObservableCollection<TreeNode>();

            tDOType[] DoTypeList = scl.DataTypeTemplates.DOType;

            foreach (tDOType doType in DoTypeList)
            {
                if (doType.id == doTypeID)
                {
                    foreach (tUnNaming item in doType.Items)
                    {
                        if (item is tDA)
                        {
                            var da = item as tDA;
                            if (da.fc.ToString() == fc)
                            {
                                TreeNode daNode = new TreeNode(da.name, parent);
                                daNode.PropagateHasDataToParents(true);
                                if (da.type != null && da.bType != tBasicTypeEnum.Enum)
                                {
                                    daNode.Children = GetDaTypeTreeNode(da.type, daNode);
                                }
                                doTypeTree.Add(daNode);
                            }
                        }
                        else if (item is tSDO)
                        {
                            var sdo = item as tSDO;
                            TreeNode sdoNode = new TreeNode(sdo.name, parent);
                            sdoNode.Children = GetDoTypeNodeTree(sdo.type, sdoNode, fc);


                            doTypeTree.Add(sdoNode);
                        }
                    }
                    break;
                }
            }
            return doTypeTree;
        }
        
        private ObservableCollection<TreeNode> GetLogicalNodeTreeNode(string LnType, TreeNode parent, string fc)
        {
            ObservableCollection<TreeNode> logicalNodeTree = new ObservableCollection<TreeNode>();

            var lNodeType = scl.DataTypeTemplates.LNodeType;

            foreach (var lnType in lNodeType)
            {
                if (lnType.id == LnType)
                {
                    foreach (tDO Do in lnType.DO)
                    {
                        TreeNode doNode = new TreeNode(Do.name, parent);
                        if (Do.type != null)
                        {
                            doNode.Children = GetDoTypeNodeTree(Do.type, doNode, fc);
                        }

                        logicalNodeTree.Add(doNode);
                    }
                    break;
                }
            }

            return logicalNodeTree;
        }

        private ObservableCollection<TreeNode> GetLDeviceTreeNode(tLDevice ldevice, TreeNode parent, string fc)
        {
            ObservableCollection<TreeNode> ldeviceTree = new ObservableCollection<TreeNode>();

            var lns = ldevice.LN;
            var ln0 = ldevice.LN0;

            //string displayName = ln0 + ln0.
            var ln0Node = new TreeNode(ln0.lnClass+ln0.inst, parent);
            ln0Node.Children = GetLogicalNodeTreeNode(ln0.lnType, ln0Node, fc);
            ldeviceTree.Add(ln0Node);

            foreach (var ln in lns)
            {
                string displayName = ln.prefix + ln.lnClass + ln.inst;
                TreeNode lnNode = new TreeNode(displayName, parent);
                lnNode.Children = GetLogicalNodeTreeNode(ln.lnType, lnNode, fc);

                ldeviceTree.Add(lnNode);
            }
            return ldeviceTree;
        }
        
        public ObservableCollection<TreeNode> GetTreeNode(string fc)
        {
            //TreeNode root = new TreeNode(IedName, null){Children = new ObservableCollection<TreeNode>()};
            TreeNode root = new TreeNode("vIED", null) { Children = new ObservableCollection<TreeNode>() };
            // ROOT -> LD -> DO -> DA
            var Ldevices = ((tServer)(scl.IED[0].AccessPoint[0].Items[0])).LDevice;

            for (int i = 0; i < Ldevices.Length; i++)
            {
                TreeNode ld = new TreeNode(Ldevices[i].inst, root);
                ld.Children = GetLDeviceTreeNode(Ldevices[i], ld, fc);

                root.Children.Add(ld);
            }


            return [root];
        }

        // Define a enum
        public enum BitRateEnum
        {
            M10,
            M100,
            G1,
            G10
        }

        private tHeader CreateDefaultHeader()
        {
            var header = new tHeader()
            {
                id = "Virtual IED Project",
                revision = Revision
            };
            return header;
        }

        private tCommunication CreateDefaultCommunication()
        {
            tCommunication communication = new tCommunication();

            tSubNetwork subNetwork = new tSubNetwork() { name = subNetworkName };
            switch (BitRate)
            {
                case BitRateEnum.G1:
                    {
                        subNetwork.BitRate = new tBitRateInMbPerSec() { Value = 1, multiplier = tUnitMultiplierEnum.G };
                        break;
                    }
                case BitRateEnum.G10:
                    {
                        subNetwork.BitRate = new tBitRateInMbPerSec() { Value = 10, multiplier = tUnitMultiplierEnum.G };
                        break;
                    }
                case BitRateEnum.M10:
                    {
                        subNetwork.BitRate = new tBitRateInMbPerSec() { Value = 10, multiplier = tUnitMultiplierEnum.M };
                        break;
                    }
                case BitRateEnum.M100:
                    {
                        subNetwork.BitRate = new tBitRateInMbPerSec() { Value = 100, multiplier = tUnitMultiplierEnum.M };
                        break;
                    }
            }

            tConnectedAP connectedAp = new tConnectedAP();
            connectedAp.apName = ApName;
            connectedAp.iedName = IedName;

            subNetwork.ConnectedAP = [connectedAp];
            communication.SubNetwork = [subNetwork];

            return communication;
        }

        private LN0 createLn0()
        {
            LN0 ln0 = new LN0()
            {
                lnClass = "LLN0",
                lnType = "LN0",
                inst = null,
                DOI = [
                    new tDOI(){name = "Mod"},
                        new tDOI(){name = "Beh"},
                        new tDOI(){name = "Health"},
                        new tDOI(){name = "NamPlt"}
                ]
            };
            return ln0;
        }

        private tIED CreateDefaultIed()
        {
            var ied = new tIED()
            {
                name = IedName,
                desc = IedDesc,
                type = "vIED"
            };

            tAccessPoint accessPoint = new tAccessPoint();
            accessPoint.Services = new tServices()
            {
                DynAssociation = new tServiceWithOptionalMax(),
                GetDirectory = new tServiceYesNo(),
                GOOSE = new tGOOSEcapabilities() { max = 8 },
                ConfDataSet = new tServiceForConfDataSet()
            };

            tServer server = new tServer();



            tLN lphd = new tLN()
            {
                lnClass = "LPHD",
                lnType = "LPHD1",
                inst = "1",
                prefix = "DevID",
                DOI = [
                    new tDOI(){name = "PhyNam"},
                        new tDOI(){name = "PhyHealth"},
                        new tDOI(){name = "Proxy"},
                    ]
            };

            tLDevice cfg = new tLDevice
            {
                inst = "CFG",
                desc = "DataSets",
                LN0 = createLn0(),
                LN = [lphd]
            };

            tLDevice pro = new tLDevice
            {
                inst = "PRO",
                desc = "Protection Device",
                LN0 = createLn0(),
                LN = []
            };

            tLDevice met = new tLDevice
            {
                inst = "MET",
                desc = "Measurement Device",
                LN0 = createLn0(),
                LN = []
            };

            tLDevice con = new tLDevice
            {
                inst = "CON",
                desc = "Control Device",
                LN0 = createLn0(),
                LN = []
            };

            server.LDevice = [cfg, pro, met, con];
            accessPoint.Items = [server];
            ied.AccessPoint = [accessPoint];

            return ied;
        }

        private tDataTypeTemplates CreateDataTypeTemplate()
        {
            tDataTypeTemplates dataTypeTemplates = new tDataTypeTemplates();

            dataTypeTemplates.LNodeType =
            [
                // LN0
                new tLNodeType()
                    {
                        id = "LN0", lnClass = "LLN0",
                        DO = [
                            new tDO(){name = "Mod", type = "modINC"},
                            new tDO(){name = "Beh", type = "behINS"},
                            new tDO(){name = "Health", type = "healthINS"},
                            new tDO(){name = "NamPlt", type = "LPL_LN0"}
                        ]
                    },
                    // LPHD1
                    new tLNodeType()
                    {
                        id = "LPHD1", lnClass = "LPHD",
                        DO = [
                            new tDO(){name = "PhyNam", type = "DPL_1"},
                            new tDO(){name = "PhyHealth", type = "healthINS"},
                            new tDO(){name = "Proxy", type = "SPS_0"}
                        ]
                    },
                    // PIOC1
                    new tLNodeType()
                    {
                        id = "PIOC1", lnClass = "PIOC",
                        DO = [
                            new tDO(){name = "Mod", type = "modINC"},
                            new tDO(){name = "Beh", type = "behINS"},
                            new tDO(){name = "Health", type = "healthINS"},
                            new tDO(){name = "NamPlt", type = "LPL_0"},
                            new tDO(){name = "Op", type = "ACT_0"}
                        ]
                    },
                    // PTOC1
                    new tLNodeType()
                    {
                        id = "PTOC1", lnClass = "PTOC",
                        DO = [
                            new tDO(){name = "Mod", type = "modINC"},
                            new tDO(){name = "Beh", type = "behINS"},
                            new tDO(){name = "Health", type = "healthINS"},
                            new tDO(){name = "NamPlt", type = "LPL_0"},
                            new tDO(){name = "Str", type = "ACD_0"},
                            new tDO(){name = "Op", type = "ACT_0"}
                        ]
                    },
                    // PTUV
                    new tLNodeType()
                    {
                        id = "PTUV1", lnClass = "PTUV",
                        DO = [
                            new tDO(){name = "Mod", type = "modINC"},
                            new tDO(){name = "Beh", type = "behINS"},
                            new tDO(){name = "Health", type = "healthINS"},
                            new tDO(){name = "NamPlt", type = "LPL_0"},
                            new tDO(){name = "Str", type = "ACD_0"},
                            new tDO(){name = "Op", type = "ACT_0"}
                        ]
                    },
                    // PTOV
                    new tLNodeType()
                    {
                        id = "PTOV1", lnClass = "PTOV",
                        DO = [
                            new tDO(){name = "Mod", type = "modINC"},
                            new tDO(){name = "Beh", type = "behINS"},
                            new tDO(){name = "Health", type = "healthINS"},
                            new tDO(){name = "NamPlt", type = "LPL_0"},
                            new tDO(){name = "Str", type = "ACD_0"}
                        ]
                    },
                    //MMXU1
                    new tLNodeType()
                    {
                        id = "MMXU1", lnClass = "MMXU",
                        DO = [
                            new tDO(){name = "Mod", type = "modINC"},
                            new tDO(){name = "Beh", type = "behINS"},
                            new tDO(){name = "Health", type = "healthINS"},
                            new tDO(){name = "NamPlt", type = "LPL_0"},
                            new tDO(){name = "TotW", type = "analogMV"},
                            new tDO(){name = "TotVAr", type = "analogMV"},
                            new tDO(){name = "TotPF", type = "analogMV"},
                            new tDO(){name = "Hz", type = "analogMV"},
                            new tDO(){name = "PhV", type = "WYE_3"},
                            new tDO(){name = "PPV", type = "DEL_0"},
                            new tDO(){name = "VSyn", type = "CMV_0"},
                            new tDO(){name = "A", type = "WYE_0"},
                            new tDO(){name = "W", type = "WYE_4"},
                            new tDO(){name = "VAr", type = "WYE_4"},
                            new tDO(){name = "PF", type = "WYE_4"}
                        ]
                    },
                ];

            dataTypeTemplates.DOType =
            [
                new tDOType()
                    {
                        id = "modINC",
                        cdc = tCDCEnum.INC,
                        Items =
                        [
                            new tDA() { name = "stVal", bType = tBasicTypeEnum.Enum, type = "Mod", dchg = true, fc = tFCEnum.ST },
                            new tDA() { name = "q", bType = tBasicTypeEnum.Quality, qchg = true, fc = tFCEnum.ST },
                            new tDA() { name = "t", bType = tBasicTypeEnum.Timestamp, fc = tFCEnum.ST },
                            new tDA() { name = "ctlModel", bType = tBasicTypeEnum.Enum, type = "ctlModel", fc = tFCEnum.CF }
                        ]
                    },
                    new tDOType()
                    {
                        id = "behINS",
                        cdc = tCDCEnum.INS,
                        Items =
                        [
                            new tDA() { name = "stVal", bType = tBasicTypeEnum.Enum, type = "Beh", dchg = true, fc = tFCEnum.ST },
                            new tDA() { name = "q", bType = tBasicTypeEnum.Quality, qchg = true, fc = tFCEnum.ST },
                            new tDA() { name = "t", bType = tBasicTypeEnum.Timestamp, fc = tFCEnum.ST }
                        ]
                    },
                    new tDOType()
                    {
                        id = "healthINS",
                        cdc = tCDCEnum.INS,
                        Items =
                        [
                            new tDA()
                            {
                                name = "stVal", bType = tBasicTypeEnum.Enum, type = "Health", dchg = true, fc = tFCEnum.ST
                            },
                            new tDA() { name = "q", bType = tBasicTypeEnum.Quality, qchg = true, fc = tFCEnum.ST },
                            new tDA() { name = "t", bType = tBasicTypeEnum.Timestamp, fc = tFCEnum.ST }
                        ]
                    },
                    new tDOType()
                    {
                        id = "LPL_LN0",
                        cdc = tCDCEnum.LPL,
                        Items =
                        [
                            new tDA() { name = "vendor", bType = tBasicTypeEnum.VisString255, fc = tFCEnum.DC },
                            new tDA() { name = "swRev", bType = tBasicTypeEnum.VisString255, fc = tFCEnum.DC },
                            new tDA() { name = "configRev", bType = tBasicTypeEnum.VisString255, fc = tFCEnum.DC },
                            new tDA() { name = "d", bType = tBasicTypeEnum.VisString255, fc = tFCEnum.DC },
                            new tDA() { name = "ldNs", bType = tBasicTypeEnum.VisString255, fc = tFCEnum.EX }
                        ]
                    },
                    new tDOType()
                    {
                        id = "DPL_1",
                        cdc = tCDCEnum.DPL,
                        Items =
                        [
                            new tDA() { name = "vendor", bType = tBasicTypeEnum.VisString255, fc = tFCEnum.DC }
                        ]
                    },
                    new tDOType()
                    {
                        id = "SPS_0",
                        cdc = tCDCEnum.SPS,
                        Items =
                        [
                            new tDA() { name = "stVal", bType = tBasicTypeEnum.BOOLEAN, dchg = true, fc = tFCEnum.ST },
                            new tDA() { name = "q", bType = tBasicTypeEnum.Quality, qchg = true, fc = tFCEnum.ST },
                            new tDA() { name = "t", bType = tBasicTypeEnum.Timestamp, fc = tFCEnum.ST }
                        ]
                    },
                    new tDOType()
                    {
                        id = "LPL_0",
                        cdc = tCDCEnum.LPL,
                        Items =
                        [
                            new tDA() { name = "vendor", bType = tBasicTypeEnum.VisString255, fc = tFCEnum.DC },
                            new tDA() { name = "swRev", bType = tBasicTypeEnum.VisString255, fc = tFCEnum.DC },
                            new tDA() { name = "configRev", bType = tBasicTypeEnum.VisString255, fc = tFCEnum.DC },
                            new tDA() { name = "d", bType = tBasicTypeEnum.VisString255, fc = tFCEnum.DC }
                        ]
                    },
                    new tDOType()
                    {
                        id = "ACT_0",
                        cdc = tCDCEnum.ACT,
                        Items =
                        [
                            new tDA() { name = "general", bType = tBasicTypeEnum.BOOLEAN, dchg = true, fc = tFCEnum.ST },
                            new tDA() { name = "q", bType = tBasicTypeEnum.Quality, qchg = true, fc = tFCEnum.ST },
                            new tDA() { name = "t", bType = tBasicTypeEnum.Timestamp, fc = tFCEnum.ST }
                        ]
                    },
                    new tDOType()
                    {
                        id = "ACD_0",
                        cdc = tCDCEnum.ACD,
                        Items =
                        [
                            new tDA() { name = "general", bType = tBasicTypeEnum.BOOLEAN, dchg = true, fc = tFCEnum.ST },
                            new tDA()
                            {
                                name = "dirGeneral", bType = tBasicTypeEnum.Enum, type = "dirGeneral", dchg = true, fc = tFCEnum.ST
                            },
                            new tDA() { name = "q", bType = tBasicTypeEnum.Quality, qchg = true, fc = tFCEnum.ST },
                            new tDA() { name = "t", bType = tBasicTypeEnum.Timestamp, fc = tFCEnum.ST }
                        ]
                    },
                    new tDOType()
                    {
                        id = "DPC_direct_normal",
                        cdc = tCDCEnum.DPC,
                        Items =
                        [
                            new tDA() { name = "Oper", bType = tBasicTypeEnum.Struct, type = "Oper_b", fc = tFCEnum.CO },
                            new tDA() { name = "stVal", bType = tBasicTypeEnum.Dbpos, dchg = true, fc = tFCEnum.ST },
                            new tDA() { name = "q", bType = tBasicTypeEnum.Quality, qchg = true, fc = tFCEnum.ST },
                            new tDA() { name = "t", bType = tBasicTypeEnum.Timestamp, fc = tFCEnum.ST },
                            new tDA() { name = "ctlModel", bType = tBasicTypeEnum.Enum, type = "ctlModel", fc = tFCEnum.CF }
                        ]
                    },
                    new tDOType()
                    {
                        id = "INS_0",
                        cdc = tCDCEnum.INS,
                        Items =
                        [
                            new tDA() { name = "stVal", bType = tBasicTypeEnum.INT32, dchg = true, fc = tFCEnum.ST },
                            new tDA() { name = "q", bType = tBasicTypeEnum.Quality, qchg = true, fc = tFCEnum.ST },
                            new tDA() { name = "t", bType = tBasicTypeEnum.Timestamp, fc = tFCEnum.ST }
                        ]
                    },
                    new tDOType()
                    {
                        id = "DPC_0",
                        cdc = tCDCEnum.DPC,
                        Items =
                        [
                            new tDA() { name = "stVal", bType = tBasicTypeEnum.Dbpos, dchg = true, fc = tFCEnum.ST },
                            new tDA() { name = "q", bType = tBasicTypeEnum.Quality, qchg = true, fc = tFCEnum.ST },
                            new tDA() { name = "t", bType = tBasicTypeEnum.Timestamp, fc = tFCEnum.ST },
                            new tDA() { name = "ctlModel", bType = tBasicTypeEnum.Enum, type = "ctlModel", fc = tFCEnum.CF }
                        ]
                    },
                    new tDOType()
                    {
                        id = "SPC_1",
                        cdc = tCDCEnum.SPC,
                        Items =
                        [
                            new tDA() { name = "stVal", bType = tBasicTypeEnum.BOOLEAN, dchg = true, fc = tFCEnum.ST },
                            new tDA() { name = "q", bType = tBasicTypeEnum.Quality, qchg = true, fc = tFCEnum.ST },
                            new tDA() { name = "t", bType = tBasicTypeEnum.Timestamp, fc = tFCEnum.ST },
                            new tDA() { name = "ctlModel", bType = tBasicTypeEnum.Enum, type = "ctlModel", fc = tFCEnum.CF }
                        ]
                    },
                    new tDOType()
                    {
                        id = "CBOpCapINS",
                        cdc = tCDCEnum.INS,
                        Items =
                        [
                            new tDA()
                            {
                                name = "stVal", bType = tBasicTypeEnum.Enum, type = "CBOpCap", dchg = true, fc = tFCEnum.ST
                            },
                            new tDA() { name = "q", bType = tBasicTypeEnum.Quality, qchg = true, fc = tFCEnum.ST },
                            new tDA() { name = "t", bType = tBasicTypeEnum.Timestamp, fc = tFCEnum.ST }
                        ]
                    },
                    new tDOType()
                    {
                        id = "analogMV",
                        cdc = tCDCEnum.MV,
                        Items =
                        [
                            new tDA() { name = "instMag", bType = tBasicTypeEnum.Struct, type = "AnalogValue_0", fc = tFCEnum.MX },
                            new tDA()
                            {
                                name = "mag", bType = tBasicTypeEnum.Struct, type = "AnalogValue_0", dchg = true, fc = tFCEnum.MX
                            },
                            new tDA() { name = "units", bType = tBasicTypeEnum.Struct, type = "Units_0", fc = tFCEnum.CF },
                            new tDA() { name = "q", bType = tBasicTypeEnum.Quality, qchg = true, fc = tFCEnum.MX },
                            new tDA() { name = "t", bType = tBasicTypeEnum.Timestamp, fc = tFCEnum.MX },
                            new tDA() { name = "db", bType = tBasicTypeEnum.INT32U, fc = tFCEnum.CF }
                        ]
                    },
                    new tDOType()
                    {
                        id = "WYE_3",
                        cdc = tCDCEnum.WYE,
                        Items =
                        [
                            new tSDO() { name = "phsA", type = "CMV_0" },
                            new tSDO() { name = "phsB", type = "CMV_0" },
                            new tSDO() { name = "phsC", type = "CMV_0" }
                        ]
                    },
                    new tDOType()
                    {
                        id = "CMV_0",
                        cdc = tCDCEnum.CMV,
                        Items =
                        [
                            new tDA() { name = "instCVal", bType = tBasicTypeEnum.Struct, type = "Vector_0", fc = tFCEnum.MX },
                            new tDA()
                            {
                                name = "cVal", bType = tBasicTypeEnum.Struct, type = "Vector_0", dchg = true, fc = tFCEnum.MX
                            },
                            new tDA() { name = "units", bType = tBasicTypeEnum.Struct, type = "Units_0", fc = tFCEnum.CF },
                            new tDA() { name = "q", bType = tBasicTypeEnum.Quality, qchg = true, fc = tFCEnum.MX },
                            new tDA() { name = "t", bType = tBasicTypeEnum.Timestamp, fc = tFCEnum.MX },
                            new tDA() { name = "db", bType = tBasicTypeEnum.INT32U, fc = tFCEnum.CF }
                        ]
                    },
                    new tDOType()
                    {
                        id = "DEL_0",
                        cdc = tCDCEnum.DEL,
                        Items =
                        [
                            new tSDO() { name = "phsAB", type = "CMV_0" },
                            new tSDO() { name = "phsBC", type = "CMV_0" },
                            new tSDO() { name = "phsCA", type = "CMV_0" }
                        ]
                    },
                    new tDOType()
                    {
                        id = "WYE_0",
                        cdc = tCDCEnum.WYE,
                        Items =
                        [
                            new tSDO() { name = "phsA", type = "CMV_0" },
                            new tSDO() { name = "phsB", type = "CMV_0" },
                            new tSDO() { name = "phsC", type = "CMV_0" },
                            new tSDO() { name = "neut", type = "CMV_0" },
                            new tSDO() { name = "res", type = "CMV_0" }
                        ]
                    },
                    new tDOType()
                    {
                        id = "WYE_4",
                        cdc = tCDCEnum.WYE,
                        Items =
                        [
                            new tSDO() { name = "phsA", type = "analogMV" },
                            new tSDO() { name = "phsB", type = "analogMV" },
                            new tSDO() { name = "phsC", type = "analogMV" }
                        ]
                    },
                    new tDOType()
                    {
                        id = "SEQ_0",
                        cdc = tCDCEnum.SEQ,
                        Items =
                        [
                            new tSDO() { name = "c1", type = "CMV_0" },
                            new tSDO() { name = "c2", type = "CMV_0" },
                            new tSDO() { name = "c3", type = "CMV_0" },
                            new tDA() { name = "seqT", bType = tBasicTypeEnum.Enum, type = "seqT", fc = tFCEnum.MX }
                        ]
                    },
                    new tDOType()
                    {
                        id = "LPL_2",
                        cdc = tCDCEnum.LPL,
                        Items =
                        [
                            new tDA() { name = "vendor", bType = tBasicTypeEnum.VisString255, fc = tFCEnum.DC },
                            new tDA() { name = "swRev", bType = tBasicTypeEnum.VisString255, fc = tFCEnum.DC },
                            new tDA() { name = "configRev", bType = tBasicTypeEnum.VisString255, fc = tFCEnum.DC },
                            new tDA() { name = "d", bType = tBasicTypeEnum.VisString255, fc = tFCEnum.DC },
                            new tDA() { name = "lnNs", bType = tBasicTypeEnum.VisString255, fc = tFCEnum.EX },
                            new tDA() { name = "dataNs", bType = tBasicTypeEnum.VisString255, fc = tFCEnum.EX }
                        ]
                    },
                    new tDOType()
                    {
                        id = "WYE_6",
                        cdc = tCDCEnum.WYE,
                        Items =
                        [
                            new tSDO() { name = "phsA", type = "analogMV" },
                            new tSDO() { name = "phsB", type = "analogMV" },
                            new tSDO() { name = "phsC", type = "analogMV" },
                            new tSDO() { name = "res", type = "analogMV" },
                            new tSDO() { name = "neut", type = "analogMV" },
                            new tSDO() { name = "nseq", type = "analogMV" },
                            new tDA() { name = "dataNs", bType = tBasicTypeEnum.VisString255, fc = tFCEnum.EX }
                        ]
                    },
                    new tDOType()
                    {
                        id = "SPC_direct_normal",
                        cdc = tCDCEnum.SPC,
                        Items =
                        [
                            new tDA() { name = "Oper", bType = tBasicTypeEnum.Struct, type = "Oper_b", fc = tFCEnum.CO },
                            new tDA() { name = "stVal", bType = tBasicTypeEnum.BOOLEAN, dchg = true, fc = tFCEnum.ST },
                            new tDA() { name = "q", bType = tBasicTypeEnum.Quality, qchg = true, fc = tFCEnum.ST },
                            new tDA() { name = "t", bType = tBasicTypeEnum.Timestamp, fc = tFCEnum.ST },
                            new tDA() { name = "ctlModel", bType = tBasicTypeEnum.Enum, type = "ctlModel", fc = tFCEnum.CF }
                        ]
                    }
            ];

            dataTypeTemplates.DAType =
            [
                new tDAType()
                    {
                        id = "Oper_b",
                        BDA =
                        [
                            new tBDA() { name = "ctlVal", bType = tBasicTypeEnum.BOOLEAN },
                            new tBDA() { name = "origin", bType = tBasicTypeEnum.Struct, type = "Originator_0" },
                            new tBDA() { name = "ctlNum", bType = tBasicTypeEnum.INT8U },
                            new tBDA() { name = "T", bType = tBasicTypeEnum.Timestamp },
                            new tBDA() { name = "Test", bType = tBasicTypeEnum.BOOLEAN },
                            new tBDA() { name = "Check", bType = tBasicTypeEnum.Check }
                        ]
                    },
                    new tDAType()
                    {
                        id = "Originator_0",
                        BDA =
                        [
                            new tBDA() { name = "orCat", bType = tBasicTypeEnum.Enum, type = "orCat" },
                            new tBDA() { name = "orIdent", bType = tBasicTypeEnum.Octet64 }
                        ]
                    },
                    new tDAType()
                    {
                        id = "AnalogValue_0",
                        BDA =
                        [
                            new tBDA() { name = "f", bType = tBasicTypeEnum.FLOAT32 }
                        ]
                    },
                    new tDAType()
                    {
                        id = "Units_0",
                        BDA =
                        [
                            new tBDA() { name = "unit", bType = tBasicTypeEnum.Enum, type = "SIUnit" },
                            new tBDA() { name = "multiplier", bType = tBasicTypeEnum.Enum, type = "multiplier" }
                        ]
                    },
                    new tDAType()
                    {
                        id = "Vector_0",
                        BDA =
                        [
                            new tBDA() { name = "mag", bType = tBasicTypeEnum.Struct, type = "AnalogValue_0" },
                            new tBDA() { name = "ang", bType = tBasicTypeEnum.Struct, type = "AnalogValue_0" }
                        ]
                    }
            ];

            dataTypeTemplates.EnumType = [
                new tEnumType()
                    {
                        id = "Mod",
                        EnumVal =
                        [
                            new tEnumVal() { ord = 1, Value = "on" },
                            new tEnumVal() { ord = 2, Value = "blocked" },
                            new tEnumVal() { ord = 3, Value = "test" },
                            new tEnumVal() { ord = 4, Value = "test/blocked" },
                            new tEnumVal() { ord = 5, Value = "off" }
                        ]
                    },
                    new tEnumType()
                    {
                        id = "ctlModel",
                        EnumVal =
                        [
                            new tEnumVal() { ord = 0, Value = "status-only" },
                            new tEnumVal() { ord = 1, Value = "direct-with-normal-security" },
                            new tEnumVal() { ord = 2, Value = "sbo-with-normal-security" },
                            new tEnumVal() { ord = 3, Value = "direct-with-enhanced-security" },
                            new tEnumVal() { ord = 4, Value = "sbo-with-enhanced-security" }
                        ]
                    },
                    new tEnumType()
                    {
                        id = "Beh",
                        EnumVal =
                        [
                            new tEnumVal() { ord = 1, Value = "on" },
                            new tEnumVal() { ord = 2, Value = "blocked" },
                            new tEnumVal() { ord = 3, Value = "test" },
                            new tEnumVal() { ord = 4, Value = "test/blocked" },
                            new tEnumVal() { ord = 5, Value = "off" }
                        ]
                    },
                    new tEnumType()
                    {
                        id = "Health",
                        EnumVal =
                        [
                            new tEnumVal() { ord = 1, Value = "Ok" },
                            new tEnumVal() { ord = 2, Value = "Warning" },
                            new tEnumVal() { ord = 3, Value = "Alarm" }
                        ]
                    },
                    new tEnumType()
                    {
                        id = "dirGeneral",
                        EnumVal =
                        [
                            new tEnumVal() { ord = 0, Value = "unknown"}
                            ]
                    },
                    new tEnumType()
                    {
                        id = "orCat",
                        EnumVal =
                        [
                            new tEnumVal() { ord = 0, Value = "not-supported" },
                            new tEnumVal() { ord = 1, Value = "bay-control" },
                            new tEnumVal() { ord = 2, Value = "station-control" },
                            new tEnumVal() { ord = 3, Value = "remote-control" },
                            new tEnumVal() { ord = 4, Value = "automatic-bay" },
                            new tEnumVal() { ord = 5, Value = "automatic-station" },
                            new tEnumVal() { ord = 6, Value = "automatic-remote" },
                            new tEnumVal() { ord = 7, Value = "maintenance" },
                            new tEnumVal() { ord = 8, Value = "process" }
                        ]
                    },
                    new tEnumType()
                    {
                        id = "CBOpCap",
                        EnumVal =
                        [
                            new tEnumVal() { ord = 1, Value = "None" },
                            new tEnumVal() { ord = 2, Value = "Open" },
                            new tEnumVal() { ord = 3, Value = "Close" },
                            new tEnumVal() { ord = 4, Value = "Close-Open" },
                            new tEnumVal() { ord = 5, Value = "Open-Close-Open" },
                            new tEnumVal() { ord = 6, Value = "Close-Open-Close-Open" }
                        ]
                    },
                    new tEnumType()
                    {
                        id = "SIUnit",
                        EnumVal =
                        [
                            new tEnumVal() { ord = 1, Value = "none" },
                            new tEnumVal() { ord = 2, Value = "m" },
                            new tEnumVal() { ord = 3, Value = "kg" },
                            new tEnumVal() { ord = 4, Value = "s" },
                            new tEnumVal() { ord = 5, Value = "A" },
                            new tEnumVal() { ord = 6, Value = "K" },
                            new tEnumVal() { ord = 7, Value = "mol" },
                            new tEnumVal() { ord = 8, Value = "cd" },
                            new tEnumVal() { ord = 9, Value = "deg" },
                            new tEnumVal() { ord = 10, Value = "rad" },
                            new tEnumVal() { ord = 11, Value = "sr" },
                            new tEnumVal() { ord = 21, Value = "Gy" },
                            new tEnumVal() { ord = 22, Value = "q" },
                            new tEnumVal() { ord = 23, Value = "°C" },
                            new tEnumVal() { ord = 24, Value = "Sv" },
                            new tEnumVal() { ord = 25, Value = "F" },
                            new tEnumVal() { ord = 26, Value = "C" },
                            new tEnumVal() { ord = 27, Value = "S" },
                            new tEnumVal() { ord = 28, Value = "H" },
                            new tEnumVal() { ord = 29, Value = "V" },
                            new tEnumVal() { ord = 30, Value = "ohm" },
                            new tEnumVal() { ord = 31, Value = "J" },
                            new tEnumVal() { ord = 32, Value = "N" },
                            new tEnumVal() { ord = 33, Value = "Hz" },
                            new tEnumVal() { ord = 34, Value = "lx" },
                            new tEnumVal() { ord = 35, Value = "Lm" },
                            new tEnumVal () { ord = 36, Value = "Wb" },
                            new tEnumVal () { ord = 37, Value = "T" },
                            new tEnumVal () { ord = 38, Value = "W" },
                            new tEnumVal () { ord = 39, Value = "Pa" },
                            new tEnumVal () { ord = 41, Value = "m²" },
                            new tEnumVal () { ord = 42, Value = "m³" },
                            new tEnumVal () { ord = 43, Value = "m/s" },
                            new tEnumVal () { ord = 44, Value = "m/s²" },
                            new tEnumVal () { ord = 45, Value = "m³/s" },
                            new tEnumVal () { ord = 46, Value = "m/m³" },
                            new tEnumVal () { ord = 47, Value = "M" },
                            new tEnumVal () { ord = 48, Value = "kg/m³" },
                            new tEnumVal () { ord = 49, Value = "m²/s" },
                            new tEnumVal () { ord = 50, Value = "W/mK" },
                            new tEnumVal () { ord = 51, Value = "J/K" },
                            new tEnumVal () { ord = 52, Value = "ppm" },
                            new tEnumVal () { ord = 53, Value = "1/s" },
                            new tEnumVal () { ord = 54, Value = "rad/s" },
                            new tEnumVal () { ord = 61, Value = "VA" },
                            new tEnumVal () { ord = 62, Value = "Watts" },
                            new tEnumVal () { ord = 63, Value = "VAr" },
                            new tEnumVal () { ord = 64, Value = "theta" },
                            new tEnumVal () { ord = 65, Value = "Cos(theta)" },
                            new tEnumVal () { ord = 66, Value = "Vs" },
                            new tEnumVal () { ord = 67, Value = "V²" },
                            new tEnumVal () { ord = 68, Value = "As" },
                            new tEnumVal () { ord = 69, Value = "A²" },
                            new tEnumVal () { ord = 70, Value = "A²t" },
                            new tEnumVal () { ord = 71, Value = "VAh" },
                            new tEnumVal () { ord = 72, Value = "Wh" },
                            new tEnumVal () { ord = 73, Value = "VArh" },
                            new tEnumVal () { ord = 74, Value = "V/Hz" }
                        ]
                    },
                    new tEnumType()
                    {
                        id = "multiplier",
                        EnumVal =
                        [
                            new tEnumVal() { ord = -24, Value = "y" },
                            new tEnumVal() { ord = -21, Value = "z" },
                            new tEnumVal() { ord = -18, Value = "a" },
                            new tEnumVal() { ord = -15, Value = "f" },
                            new tEnumVal() { ord = -12, Value = "p" },
                            new tEnumVal() { ord = -9, Value = "n" },
                            new tEnumVal() { ord = -6, Value = "µ" },
                            new tEnumVal() { ord = -3, Value = "m" },
                            new tEnumVal() { ord = -2, Value = "c" },
                            new tEnumVal() { ord = -1, Value = "d" },
                            new tEnumVal() { ord = 0 },
                            new tEnumVal() { ord = 1, Value = "da" },
                            new tEnumVal() { ord = 2, Value = "h" },
                            new tEnumVal() { ord = 3, Value = "k" },
                            new tEnumVal() { ord = 6, Value = "M" },
                            new tEnumVal() { ord = 10, Value = "G" },
                            new tEnumVal() { ord = 12, Value = "T" },
                            new tEnumVal() { ord = 15, Value = "P" },
                            new tEnumVal() { ord = 18, Value = "E" },
                            new tEnumVal() { ord = 21, Value = "Z" },
                            new tEnumVal() { ord = 24, Value = "Y" }
                        ]
                    },
                    new tEnumType()
                    {
                        id = "seqT",
                        EnumVal =
                        [
                            new tEnumVal() { ord = 0, Value = "pos-neg-zero" },
                            new tEnumVal() { ord = 1, Value = "dir-quad-zero" }
                        ]
                    }
            ];

            return dataTypeTemplates;
        }

        private void CreateDefaultSCL()
        {
            // SCL Structure
            // - Header
            // - Communication
            // - IED
            // - DataTypeTemplates

            scl.Header = CreateDefaultHeader();
            scl.Communication = CreateDefaultCommunication();
            scl.IED = [CreateDefaultIed()];
            scl.DataTypeTemplates = CreateDataTypeTemplate();
        }
    }

}
