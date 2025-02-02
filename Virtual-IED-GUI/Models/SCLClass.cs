﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_IED_GUI.Models
{
    public class SclClass
    {


        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        [System.Xml.Serialization.XmlRootAttribute("Substation", Namespace = "http://www.iec.ch/61850/2003/SCL", IsNullable = false)]
        public partial class tSubstation : tEquipmentContainer
        {

            private tVoltageLevel[] voltageLevelField;

            private tFunction[] functionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("VoltageLevel")]
            public tVoltageLevel[] VoltageLevel
            {
                get
                {
                    return this.voltageLevelField;
                }
                set
                {
                    this.voltageLevelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Function")]
            public tFunction[] Function
            {
                get
                {
                    return this.functionField;
                }
                set
                {
                    this.functionField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tVoltageLevel : tEquipmentContainer
        {

            private tVoltage voltageField;

            private tBay[] bayField;

            private tFunction[] functionField;

            private decimal nomFreqField;

            private bool nomFreqFieldSpecified;

            private byte numPhasesField;

            private bool numPhasesFieldSpecified;

            /// <remarks/>
            public tVoltage Voltage
            {
                get
                {
                    return this.voltageField;
                }
                set
                {
                    this.voltageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Bay")]
            public tBay[] Bay
            {
                get
                {
                    return this.bayField;
                }
                set
                {
                    this.bayField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Function")]
            public tFunction[] Function
            {
                get
                {
                    return this.functionField;
                }
                set
                {
                    this.functionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal nomFreq
            {
                get
                {
                    return this.nomFreqField;
                }
                set
                {
                    this.nomFreqField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool nomFreqSpecified
            {
                get
                {
                    return this.nomFreqFieldSpecified;
                }
                set
                {
                    this.nomFreqFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte numPhases
            {
                get
                {
                    return this.numPhasesField;
                }
                set
                {
                    this.numPhasesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool numPhasesSpecified
            {
                get
                {
                    return this.numPhasesFieldSpecified;
                }
                set
                {
                    this.numPhasesFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tVoltage : tValueWithUnit
        {
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tDurationInSec))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tVoltage))]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tValueWithUnit
        {

            private string unitField;

            private tUnitMultiplierEnum multiplierField;

            private decimal valueField;

            public tValueWithUnit()
            {
                this.multiplierField = tUnitMultiplierEnum.Item;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
            public string unit
            {
                get
                {
                    return this.unitField;
                }
                set
                {
                    this.unitField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(tUnitMultiplierEnum.Item)]
            public tUnitMultiplierEnum multiplier
            {
                get
                {
                    return this.multiplierField;
                }
                set
                {
                    this.multiplierField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public decimal Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public enum tUnitMultiplierEnum
        {

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("")]
            Item,

            /// <remarks/>
            m,

            /// <remarks/>
            k,

            /// <remarks/>
            M,

            /// <remarks/>
            mu,

            /// <remarks/>
            y,

            /// <remarks/>
            z,

            /// <remarks/>
            a,

            /// <remarks/>
            f,

            /// <remarks/>
            p,

            /// <remarks/>
            n,

            /// <remarks/>
            c,

            /// <remarks/>
            d,

            /// <remarks/>
            da,

            /// <remarks/>
            h,

            /// <remarks/>
            G,

            /// <remarks/>
            T,

            /// <remarks/>
            P,

            /// <remarks/>
            E,

            /// <remarks/>
            Z,

            /// <remarks/>
            Y,
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tHeader
        {

            private tText textField;

            private tHitem[] historyField;

            private string idField;

            private string versionField;

            private string revisionField;

            private string toolIDField;

            private tHeaderNameStructure nameStructureField;

            public tHeader()
            {
                this.revisionField = "";
                this.nameStructureField = tHeaderNameStructure.IEDName;
            }

            /// <remarks/>
            public tText Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Hitem", IsNullable = false)]
            public tHitem[] History
            {
                get
                {
                    return this.historyField;
                }
                set
                {
                    this.historyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string version
            {
                get
                {
                    return this.versionField;
                }
                set
                {
                    this.versionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            [System.ComponentModel.DefaultValueAttribute("")]
            public string revision
            {
                get
                {
                    return this.revisionField;
                }
                set
                {
                    this.revisionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string toolID
            {
                get
                {
                    return this.toolIDField;
                }
                set
                {
                    this.toolIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(tHeaderNameStructure.IEDName)]
            public tHeaderNameStructure nameStructure
            {
                get
                {
                    return this.nameStructureField;
                }
                set
                {
                    this.nameStructureField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tText : tAnyContentFromOtherNamespace
        {

            private string sourceField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
            public string source
            {
                get
                {
                    return this.sourceField;
                }
                set
                {
                    this.sourceField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tAccessControl))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tHitem))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tPrivate))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tText))]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public abstract partial class tAnyContentFromOtherNamespace
        {

            private System.Xml.XmlNode[] anyField;

            private System.Xml.XmlAttribute[] anyAttrField;

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            [System.Xml.Serialization.XmlAnyElementAttribute()]
            public System.Xml.XmlNode[] Any
            {
                get
                {
                    return this.anyField;
                }
                set
                {
                    this.anyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAnyAttributeAttribute()]
            public System.Xml.XmlAttribute[] AnyAttr
            {
                get
                {
                    return this.anyAttrField;
                }
                set
                {
                    this.anyAttrField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tAccessControl : tAnyContentFromOtherNamespace
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tHitem : tAnyContentFromOtherNamespace
        {

            private string versionField;

            private string revisionField;

            private string whenField;

            private string whoField;

            private string whatField;

            private string whyField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string version
            {
                get
                {
                    return this.versionField;
                }
                set
                {
                    this.versionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string revision
            {
                get
                {
                    return this.revisionField;
                }
                set
                {
                    this.revisionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string when
            {
                get
                {
                    return this.whenField;
                }
                set
                {
                    this.whenField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string who
            {
                get
                {
                    return this.whoField;
                }
                set
                {
                    this.whoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string what
            {
                get
                {
                    return this.whatField;
                }
                set
                {
                    this.whatField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string why
            {
                get
                {
                    return this.whyField;
                }
                set
                {
                    this.whyField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tPrivate : tAnyContentFromOtherNamespace
        {

            private string typeField;

            private string sourceField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
            public string source
            {
                get
                {
                    return this.sourceField;
                }
                set
                {
                    this.sourceField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public enum tHeaderNameStructure
        {

            /// <remarks/>
            IEDName,
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tEnumVal
        {

            private int ordField;

            private string descField;

            private string valueField;

            public tEnumVal()
            {
                this.descField = "";
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public int ord
            {
                get
                {
                    return this.ordField;
                }
                set
                {
                    this.ordField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            [System.ComponentModel.DefaultValueAttribute("")]
            public string desc
            {
                get
                {
                    return this.descField;
                }
                set
                {
                    this.descField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tProtNs
        {

            private string typeField;

            private string valueField;

            public tProtNs()
            {
                this.typeField = "8-MMS";
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            [System.ComponentModel.DefaultValueAttribute("8-MMS")]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tKDC
        {

            private string iedNameField;

            private string apNameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "Name")]
            public string iedName
            {
                get
                {
                    return this.iedNameField;
                }
                set
                {
                    this.iedNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string apName
            {
                get
                {
                    return this.apNameField;
                }
                set
                {
                    this.apNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tP_PhysConn
        {

            private string typeField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tDurationInMilliSec
        {

            private string unitField;

            private tUnitMultiplierEnum multiplierField;

            private bool multiplierFieldSpecified;

            private decimal valueField;

            public tDurationInMilliSec()
            {
                this.unitField = "s";
                this.multiplierField = tUnitMultiplierEnum.m;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
            public string unit
            {
                get
                {
                    return this.unitField;
                }
                set
                {
                    this.unitField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public tUnitMultiplierEnum multiplier
            {
                get
                {
                    return this.multiplierField;
                }
                set
                {
                    this.multiplierField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool multiplierSpecified
            {
                get
                {
                    return this.multiplierFieldSpecified;
                }
                set
                {
                    this.multiplierFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public decimal Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_IPClassOfTraffic))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_C37118IPPort))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_IPv6ClassOfTraffic))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_Port))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_TCPPort))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_UDPPort))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_MMSPort))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_SNTPPort))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_VLANID))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_VLANPRIORITY))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_APPID))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_MACAddress))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_OSIAEInvoke))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_OSIAEQualifier))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_OSIAPInvoke))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_OSIAPTitle))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_OSIPSEL))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_OSISSEL))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_OSITSEL))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_OSINSAP))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_IPv6FlowLabel))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_DNSName))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_IPv6SUBNET))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_IPv6base))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_IPv6IGMPv3Src))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_IPv6GATEWAY))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_IPv6))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_IPbase))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_IPIGMPv3Src))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_IPGATEWAY))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_IPSUBNET))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_IP))]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tP
        {

            private string typeField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "tP_IP-ClassOfTraffic", Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tP_IPClassOfTraffic : tP
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "tP_C37-118-IP-Port", Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tP_C37118IPPort : tP
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tP_IPv6ClassOfTraffic : tP
        {
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_TCPPort))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_UDPPort))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_MMSPort))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_SNTPPort))]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public abstract partial class tP_Port : tP
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "tP_TCP-Port", Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tP_TCPPort : tP_Port
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "tP_UDP-Port", Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tP_UDPPort : tP_Port
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "tP_MMS-Port", Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tP_MMSPort : tP_Port
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "tP_SNTP-Port", Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tP_SNTPPort : tP_Port
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "tP_VLAN-ID", Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tP_VLANID : tP
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "tP_VLAN-PRIORITY", Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tP_VLANPRIORITY : tP
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tP_APPID : tP
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "tP_MAC-Address", Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tP_MACAddress : tP
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "tP_OSI-AE-Invoke", Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tP_OSIAEInvoke : tP
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "tP_OSI-AE-Qualifier", Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tP_OSIAEQualifier : tP
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "tP_OSI-AP-Invoke", Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tP_OSIAPInvoke : tP
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "tP_OSI-AP-Title", Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tP_OSIAPTitle : tP
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "tP_OSI-PSEL", Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tP_OSIPSEL : tP
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "tP_OSI-SSEL", Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tP_OSISSEL : tP
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "tP_OSI-TSEL", Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tP_OSITSEL : tP
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "tP_OSI-NSAP", Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tP_OSINSAP : tP
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tP_IPv6FlowLabel : tP
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tP_DNSName : tP
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "tP_IPv6-SUBNET", Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tP_IPv6SUBNET : tP
        {
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_IPv6IGMPv3Src))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_IPv6GATEWAY))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_IPv6))]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public abstract partial class tP_IPv6base : tP
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "tP_IPv6-IGMPv3Src", Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tP_IPv6IGMPv3Src : tP_IPv6base
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "tP_IPv6-GATEWAY", Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tP_IPv6GATEWAY : tP_IPv6base
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tP_IPv6 : tP_IPv6base
        {
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_IPIGMPv3Src))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_IPGATEWAY))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_IPSUBNET))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tP_IP))]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public abstract partial class tP_IPbase : tP
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "tP_IP-IGMPv3Src", Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tP_IPIGMPv3Src : tP_IPbase
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "tP_IP-GATEWAY", Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tP_IPGATEWAY : tP_IPbase
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(TypeName = "tP_IP-SUBNET", Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tP_IPSUBNET : tP_IPbase
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tP_IP : tP_IPbase
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tBitRateInMbPerSec
        {

            private string unitField;

            private tUnitMultiplierEnum multiplierField;

            private bool multiplierFieldSpecified;

            private decimal valueField;

            public tBitRateInMbPerSec()
            {
                this.unitField = "b/s";
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string unit
            {
                get
                {
                    return this.unitField;
                }
                set
                {
                    this.unitField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public tUnitMultiplierEnum multiplier
            {
                get
                {
                    return this.multiplierField;
                }
                set
                {
                    this.multiplierField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool multiplierSpecified
            {
                get
                {
                    return this.multiplierFieldSpecified;
                }
                set
                {
                    this.multiplierFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public decimal Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tCert
        {

            private string commonNameField;

            private string idHierarchyField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string commonName
            {
                get
                {
                    return this.commonNameField;
                }
                set
                {
                    this.commonNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string idHierarchy
            {
                get
                {
                    return this.idHierarchyField;
                }
                set
                {
                    this.idHierarchyField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tAssociation
        {

            private string prefixField;

            private string lnClassField;

            private string lnInstField;

            private tAssociationKindEnum kindField;

            private string associationIDField;

            public tAssociation()
            {
                this.prefixField = "";
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            [System.ComponentModel.DefaultValueAttribute("")]
            public string prefix
            {
                get
                {
                    return this.prefixField;
                }
                set
                {
                    this.prefixField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string lnClass
            {
                get
                {
                    return this.lnClassField;
                }
                set
                {
                    this.lnClassField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string lnInst
            {
                get
                {
                    return this.lnInstField;
                }
                set
                {
                    this.lnInstField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public tAssociationKindEnum kind
            {
                get
                {
                    return this.kindField;
                }
                set
                {
                    this.kindField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string associationID
            {
                get
                {
                    return this.associationIDField;
                }
                set
                {
                    this.associationIDField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public enum tAssociationKindEnum
        {

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("pre-established")]
            preestablished,

            /// <remarks/>
            predefined,
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tExtRef
        {

            private string descField;

            private string iedNameField;

            private string ldInstField;

            private string prefixField;

            private string lnClassField;

            private string lnInstField;

            private string doNameField;

            private string daNameField;

            private string intAddrField;

            private tServiceType serviceTypeField;

            private bool serviceTypeFieldSpecified;

            private string srcLDInstField;

            private string srcPrefixField;

            private string srcLNClassField;

            private string srcLNInstField;

            private string srcCBNameField;

            private tServiceType pServTField;

            private bool pServTFieldSpecified;

            private string pLNField;

            private string pDOField;

            private string pDAField;

            public tExtRef()
            {
                this.descField = "";
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            [System.ComponentModel.DefaultValueAttribute("")]
            public string desc
            {
                get
                {
                    return this.descField;
                }
                set
                {
                    this.descField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string iedName
            {
                get
                {
                    return this.iedNameField;
                }
                set
                {
                    this.iedNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string ldInst
            {
                get
                {
                    return this.ldInstField;
                }
                set
                {
                    this.ldInstField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string prefix
            {
                get
                {
                    return this.prefixField;
                }
                set
                {
                    this.prefixField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string lnClass
            {
                get
                {
                    return this.lnClassField;
                }
                set
                {
                    this.lnClassField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string lnInst
            {
                get
                {
                    return this.lnInstField;
                }
                set
                {
                    this.lnInstField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string doName
            {
                get
                {
                    return this.doNameField;
                }
                set
                {
                    this.doNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string daName
            {
                get
                {
                    return this.daNameField;
                }
                set
                {
                    this.daNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string intAddr
            {
                get
                {
                    return this.intAddrField;
                }
                set
                {
                    this.intAddrField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public tServiceType serviceType
            {
                get
                {
                    return this.serviceTypeField;
                }
                set
                {
                    this.serviceTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool serviceTypeSpecified
            {
                get
                {
                    return this.serviceTypeFieldSpecified;
                }
                set
                {
                    this.serviceTypeFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string srcLDInst
            {
                get
                {
                    return this.srcLDInstField;
                }
                set
                {
                    this.srcLDInstField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string srcPrefix
            {
                get
                {
                    return this.srcPrefixField;
                }
                set
                {
                    this.srcPrefixField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string srcLNClass
            {
                get
                {
                    return this.srcLNClassField;
                }
                set
                {
                    this.srcLNClassField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string srcLNInst
            {
                get
                {
                    return this.srcLNInstField;
                }
                set
                {
                    this.srcLNInstField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "Name")]
            public string srcCBName
            {
                get
                {
                    return this.srcCBNameField;
                }
                set
                {
                    this.srcCBNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public tServiceType pServT
            {
                get
                {
                    return this.pServTField;
                }
                set
                {
                    this.pServTField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool pServTSpecified
            {
                get
                {
                    return this.pServTFieldSpecified;
                }
                set
                {
                    this.pServTFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string pLN
            {
                get
                {
                    return this.pLNField;
                }
                set
                {
                    this.pLNField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string pDO
            {
                get
                {
                    return this.pDOField;
                }
                set
                {
                    this.pDOField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string pDA
            {
                get
                {
                    return this.pDAField;
                }
                set
                {
                    this.pDAField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public enum tServiceType
        {

            /// <remarks/>
            Poll,

            /// <remarks/>
            Report,

            /// <remarks/>
            GOOSE,

            /// <remarks/>
            SMV,
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tVal
        {

            private uint sGroupField;

            private bool sGroupFieldSpecified;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint sGroup
            {
                get
                {
                    return this.sGroupField;
                }
                set
                {
                    this.sGroupField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool sGroupSpecified
            {
                get
                {
                    return this.sGroupFieldSpecified;
                }
                set
                {
                    this.sGroupFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tProtocol
        {

            private bool mustUnderstandField;

            private string valueField;

            public tProtocol()
            {
                this.mustUnderstandField = true;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool mustUnderstand
            {
                get
                {
                    return this.mustUnderstandField;
                }
                set
                {
                    this.mustUnderstandField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tClientLN
        {

            private string prefixField;

            private string lnClassField;

            private string lnInstField;

            private string apRefField;

            public tClientLN()
            {
                this.prefixField = "";
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            [System.ComponentModel.DefaultValueAttribute("")]
            public string prefix
            {
                get
                {
                    return this.prefixField;
                }
                set
                {
                    this.prefixField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string lnClass
            {
                get
                {
                    return this.lnClassField;
                }
                set
                {
                    this.lnClassField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string lnInst
            {
                get
                {
                    return this.lnInstField;
                }
                set
                {
                    this.lnInstField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string apRef
            {
                get
                {
                    return this.apRefField;
                }
                set
                {
                    this.apRefField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tTrgOps
        {

            private bool dchgField;

            private bool qchgField;

            private bool dupdField;

            private bool periodField;

            private bool giField;

            public tTrgOps()
            {
                this.dchgField = false;
                this.qchgField = false;
                this.dupdField = false;
                this.periodField = false;
                this.giField = true;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool dchg
            {
                get
                {
                    return this.dchgField;
                }
                set
                {
                    this.dchgField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool qchg
            {
                get
                {
                    return this.qchgField;
                }
                set
                {
                    this.qchgField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool dupd
            {
                get
                {
                    return this.dupdField;
                }
                set
                {
                    this.dupdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool period
            {
                get
                {
                    return this.periodField;
                }
                set
                {
                    this.periodField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(true)]
            public bool gi
            {
                get
                {
                    return this.giField;
                }
                set
                {
                    this.giField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tFCDA
        {

            private string ldInstField;

            private string prefixField;

            private string lnClassField;

            private string lnInstField;

            private string doNameField;

            private string daNameField;

            private tFCEnum fcField;

            private uint ixField;

            private bool ixFieldSpecified;

            public tFCDA()
            {
                this.prefixField = "";
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string ldInst
            {
                get
                {
                    return this.ldInstField;
                }
                set
                {
                    this.ldInstField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            [System.ComponentModel.DefaultValueAttribute("")]
            public string prefix
            {
                get
                {
                    return this.prefixField;
                }
                set
                {
                    this.prefixField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string lnClass
            {
                get
                {
                    return this.lnClassField;
                }
                set
                {
                    this.lnClassField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string lnInst
            {
                get
                {
                    return this.lnInstField;
                }
                set
                {
                    this.lnInstField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string doName
            {
                get
                {
                    return this.doNameField;
                }
                set
                {
                    this.doNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string daName
            {
                get
                {
                    return this.daNameField;
                }
                set
                {
                    this.daNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public tFCEnum fc
            {
                get
                {
                    return this.fcField;
                }
                set
                {
                    this.fcField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint ix
            {
                get
                {
                    return this.ixField;
                }
                set
                {
                    this.ixField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool ixSpecified
            {
                get
                {
                    return this.ixFieldSpecified;
                }
                set
                {
                    this.ixFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public enum tFCEnum
        {

            /// <remarks/>
            ST,

            /// <remarks/>
            MX,

            /// <remarks/>
            CO,

            /// <remarks/>
            SP,

            /// <remarks/>
            SG,

            /// <remarks/>
            SE,

            /// <remarks/>
            SV,

            /// <remarks/>
            CF,

            /// <remarks/>
            DC,

            /// <remarks/>
            EX,

            /// <remarks/>
            SR,

            /// <remarks/>
            BL,

            /// <remarks/>
            OR,
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tRedProt
        {

            private bool hsrField;

            private bool prpField;

            private bool rstpField;

            public tRedProt()
            {
                this.hsrField = false;
                this.prpField = false;
                this.rstpField = false;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool hsr
            {
                get
                {
                    return this.hsrField;
                }
                set
                {
                    this.hsrField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool prp
            {
                get
                {
                    return this.prpField;
                }
                set
                {
                    this.prpField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool rstp
            {
                get
                {
                    return this.rstpField;
                }
                set
                {
                    this.rstpField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tValueHandling
        {

            private bool setToROField;

            public tValueHandling()
            {
                this.setToROField = false;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool setToRO
            {
                get
                {
                    return this.setToROField;
                }
                set
                {
                    this.setToROField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tSupSubscription
        {

            private uint maxGoField;

            private uint maxSvField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint maxGo
            {
                get
                {
                    return this.maxGoField;
                }
                set
                {
                    this.maxGoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint maxSv
            {
                get
                {
                    return this.maxSvField;
                }
                set
                {
                    this.maxSvField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tClientServices
        {

            private tTimeSyncProt timeSyncProtField;

            private tMcSecurity mcSecurityField;

            private bool gooseField;

            private bool gsseField;

            private bool bufReportField;

            private bool unbufReportField;

            private bool readLogField;

            private bool svField;

            private bool supportsLdNameField;

            private uint maxAttributesField;

            private bool maxAttributesFieldSpecified;

            private uint maxReportsField;

            private bool maxReportsFieldSpecified;

            private uint maxGOOSEField;

            private bool maxGOOSEFieldSpecified;

            private uint maxSMVField;

            private bool maxSMVFieldSpecified;

            private bool rGOOSEField;

            private bool rSVField;

            private bool noIctBindingField;

            public tClientServices()
            {
                this.gooseField = false;
                this.gsseField = false;
                this.bufReportField = false;
                this.unbufReportField = false;
                this.readLogField = false;
                this.svField = false;
                this.supportsLdNameField = false;
                this.rGOOSEField = false;
                this.rSVField = false;
                this.noIctBindingField = false;
            }

            /// <remarks/>
            public tTimeSyncProt TimeSyncProt
            {
                get
                {
                    return this.timeSyncProtField;
                }
                set
                {
                    this.timeSyncProtField = value;
                }
            }

            /// <remarks/>
            public tMcSecurity McSecurity
            {
                get
                {
                    return this.mcSecurityField;
                }
                set
                {
                    this.mcSecurityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool goose
            {
                get
                {
                    return this.gooseField;
                }
                set
                {
                    this.gooseField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool gsse
            {
                get
                {
                    return this.gsseField;
                }
                set
                {
                    this.gsseField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool bufReport
            {
                get
                {
                    return this.bufReportField;
                }
                set
                {
                    this.bufReportField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool unbufReport
            {
                get
                {
                    return this.unbufReportField;
                }
                set
                {
                    this.unbufReportField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool readLog
            {
                get
                {
                    return this.readLogField;
                }
                set
                {
                    this.readLogField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool sv
            {
                get
                {
                    return this.svField;
                }
                set
                {
                    this.svField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool supportsLdName
            {
                get
                {
                    return this.supportsLdNameField;
                }
                set
                {
                    this.supportsLdNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint maxAttributes
            {
                get
                {
                    return this.maxAttributesField;
                }
                set
                {
                    this.maxAttributesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool maxAttributesSpecified
            {
                get
                {
                    return this.maxAttributesFieldSpecified;
                }
                set
                {
                    this.maxAttributesFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint maxReports
            {
                get
                {
                    return this.maxReportsField;
                }
                set
                {
                    this.maxReportsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool maxReportsSpecified
            {
                get
                {
                    return this.maxReportsFieldSpecified;
                }
                set
                {
                    this.maxReportsFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint maxGOOSE
            {
                get
                {
                    return this.maxGOOSEField;
                }
                set
                {
                    this.maxGOOSEField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool maxGOOSESpecified
            {
                get
                {
                    return this.maxGOOSEFieldSpecified;
                }
                set
                {
                    this.maxGOOSEFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint maxSMV
            {
                get
                {
                    return this.maxSMVField;
                }
                set
                {
                    this.maxSMVField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool maxSMVSpecified
            {
                get
                {
                    return this.maxSMVFieldSpecified;
                }
                set
                {
                    this.maxSMVFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool rGOOSE
            {
                get
                {
                    return this.rGOOSEField;
                }
                set
                {
                    this.rGOOSEField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool rSV
            {
                get
                {
                    return this.rSVField;
                }
                set
                {
                    this.rSVField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool noIctBinding
            {
                get
                {
                    return this.noIctBindingField;
                }
                set
                {
                    this.noIctBindingField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tTimeSyncProt : tServiceYesNo
        {

            private bool sntpField;

            private bool iec61850_9_3Field;

            private bool c37_238Field;

            private bool otherField;

            public tTimeSyncProt()
            {
                this.sntpField = true;
                this.iec61850_9_3Field = false;
                this.c37_238Field = false;
                this.otherField = false;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(true)]
            public bool sntp
            {
                get
                {
                    return this.sntpField;
                }
                set
                {
                    this.sntpField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool iec61850_9_3
            {
                get
                {
                    return this.iec61850_9_3Field;
                }
                set
                {
                    this.iec61850_9_3Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool c37_238
            {
                get
                {
                    return this.c37_238Field;
                }
                set
                {
                    this.c37_238Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool other
            {
                get
                {
                    return this.otherField;
                }
                set
                {
                    this.otherField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tCommProt))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tTimeSyncProt))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tFileHandling))]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tServiceYesNo
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tCommProt : tServiceYesNo
        {

            private bool ipv6Field;

            public tCommProt()
            {
                this.ipv6Field = false;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool ipv6
            {
                get
                {
                    return this.ipv6Field;
                }
                set
                {
                    this.ipv6Field = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tFileHandling : tServiceYesNo
        {

            private bool mmsField;

            private bool ftpField;

            private bool ftpsField;

            public tFileHandling()
            {
                this.mmsField = true;
                this.ftpField = false;
                this.ftpsField = false;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(true)]
            public bool mms
            {
                get
                {
                    return this.mmsField;
                }
                set
                {
                    this.mmsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool ftp
            {
                get
                {
                    return this.ftpField;
                }
                set
                {
                    this.ftpField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool ftps
            {
                get
                {
                    return this.ftpsField;
                }
                set
                {
                    this.ftpsField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tMcSecurity
        {

            private bool signatureField;

            private bool encryptionField;

            public tMcSecurity()
            {
                this.signatureField = false;
                this.encryptionField = false;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool signature
            {
                get
                {
                    return this.signatureField;
                }
                set
                {
                    this.signatureField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool encryption
            {
                get
                {
                    return this.encryptionField;
                }
                set
                {
                    this.encryptionField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tConfLNs
        {

            private bool fixPrefixField;

            private bool fixLnInstField;

            public tConfLNs()
            {
                this.fixPrefixField = false;
                this.fixLnInstField = false;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool fixPrefix
            {
                get
                {
                    return this.fixPrefixField;
                }
                set
                {
                    this.fixPrefixField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool fixLnInst
            {
                get
                {
                    return this.fixLnInstField;
                }
                set
                {
                    this.fixLnInstField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tSMVSettings))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tGSESettings))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tLogSettings))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tReportSettings))]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public abstract partial class tServiceSettings
        {

            private tServiceSettingsNoDynEnum cbNameField;

            private tServiceSettingsEnum datSetField;

            public tServiceSettings()
            {
                this.cbNameField = tServiceSettingsNoDynEnum.Fix;
                this.datSetField = tServiceSettingsEnum.Fix;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(tServiceSettingsNoDynEnum.Fix)]
            public tServiceSettingsNoDynEnum cbName
            {
                get
                {
                    return this.cbNameField;
                }
                set
                {
                    this.cbNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(tServiceSettingsEnum.Fix)]
            public tServiceSettingsEnum datSet
            {
                get
                {
                    return this.datSetField;
                }
                set
                {
                    this.datSetField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public enum tServiceSettingsNoDynEnum
        {

            /// <remarks/>
            Conf,

            /// <remarks/>
            Fix,
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public enum tServiceSettingsEnum
        {

            /// <remarks/>
            Dyn,

            /// <remarks/>
            Conf,

            /// <remarks/>
            Fix,
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tSMVSettings : tServiceSettings
        {

            private uint[] itemsField;

            private ItemsChoiceType[] itemsElementNameField;

            private tMcSecurity mcSecurityField;

            private tServiceSettingsEnum svIDField;

            private tServiceSettingsEnum optFieldsField;

            private tServiceSettingsEnum smpRateField;

            private bool samplesPerSecField;

            private bool pdcTimeStampField;

            private bool synchSrcIdField;

            private tServiceSettingsNoDynEnum nofASDUField;

            private bool kdaParticipantField;

            public tSMVSettings()
            {
                this.svIDField = tServiceSettingsEnum.Fix;
                this.optFieldsField = tServiceSettingsEnum.Fix;
                this.smpRateField = tServiceSettingsEnum.Fix;
                this.samplesPerSecField = false;
                this.pdcTimeStampField = false;
                this.synchSrcIdField = false;
                this.nofASDUField = tServiceSettingsNoDynEnum.Fix;
                this.kdaParticipantField = false;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("SamplesPerSec", typeof(uint))]
            [System.Xml.Serialization.XmlElementAttribute("SecPerSamples", typeof(uint))]
            [System.Xml.Serialization.XmlElementAttribute("SmpRate", typeof(uint))]
            [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
            public uint[] Items
            {
                get
                {
                    return this.itemsField;
                }
                set
                {
                    this.itemsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public ItemsChoiceType[] ItemsElementName
            {
                get
                {
                    return this.itemsElementNameField;
                }
                set
                {
                    this.itemsElementNameField = value;
                }
            }

            /// <remarks/>
            public tMcSecurity McSecurity
            {
                get
                {
                    return this.mcSecurityField;
                }
                set
                {
                    this.mcSecurityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(tServiceSettingsEnum.Fix)]
            public tServiceSettingsEnum svID
            {
                get
                {
                    return this.svIDField;
                }
                set
                {
                    this.svIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(tServiceSettingsEnum.Fix)]
            public tServiceSettingsEnum optFields
            {
                get
                {
                    return this.optFieldsField;
                }
                set
                {
                    this.optFieldsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(tServiceSettingsEnum.Fix)]
            public tServiceSettingsEnum smpRate
            {
                get
                {
                    return this.smpRateField;
                }
                set
                {
                    this.smpRateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool samplesPerSec
            {
                get
                {
                    return this.samplesPerSecField;
                }
                set
                {
                    this.samplesPerSecField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool pdcTimeStamp
            {
                get
                {
                    return this.pdcTimeStampField;
                }
                set
                {
                    this.pdcTimeStampField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool synchSrcId
            {
                get
                {
                    return this.synchSrcIdField;
                }
                set
                {
                    this.synchSrcIdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(tServiceSettingsNoDynEnum.Fix)]
            public tServiceSettingsNoDynEnum nofASDU
            {
                get
                {
                    return this.nofASDUField;
                }
                set
                {
                    this.nofASDUField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool kdaParticipant
            {
                get
                {
                    return this.kdaParticipantField;
                }
                set
                {
                    this.kdaParticipantField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL", IncludeInSchema = false)]
        public enum ItemsChoiceType
        {

            /// <remarks/>
            SamplesPerSec,

            /// <remarks/>
            SecPerSamples,

            /// <remarks/>
            SmpRate,
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tGSESettings : tServiceSettings
        {

            private tMcSecurity mcSecurityField;

            private tServiceSettingsEnum appIDField;

            private tServiceSettingsEnum dataLabelField;

            private bool kdaParticipantField;

            public tGSESettings()
            {
                this.appIDField = tServiceSettingsEnum.Fix;
                this.dataLabelField = tServiceSettingsEnum.Fix;
                this.kdaParticipantField = false;
            }

            /// <remarks/>
            public tMcSecurity McSecurity
            {
                get
                {
                    return this.mcSecurityField;
                }
                set
                {
                    this.mcSecurityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(tServiceSettingsEnum.Fix)]
            public tServiceSettingsEnum appID
            {
                get
                {
                    return this.appIDField;
                }
                set
                {
                    this.appIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(tServiceSettingsEnum.Fix)]
            public tServiceSettingsEnum dataLabel
            {
                get
                {
                    return this.dataLabelField;
                }
                set
                {
                    this.dataLabelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool kdaParticipant
            {
                get
                {
                    return this.kdaParticipantField;
                }
                set
                {
                    this.kdaParticipantField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tLogSettings : tServiceSettings
        {

            private tServiceSettingsEnum logEnaField;

            private tServiceSettingsEnum trgOpsField;

            private tServiceSettingsEnum intgPdField;

            public tLogSettings()
            {
                this.logEnaField = tServiceSettingsEnum.Fix;
                this.trgOpsField = tServiceSettingsEnum.Fix;
                this.intgPdField = tServiceSettingsEnum.Fix;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(tServiceSettingsEnum.Fix)]
            public tServiceSettingsEnum logEna
            {
                get
                {
                    return this.logEnaField;
                }
                set
                {
                    this.logEnaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(tServiceSettingsEnum.Fix)]
            public tServiceSettingsEnum trgOps
            {
                get
                {
                    return this.trgOpsField;
                }
                set
                {
                    this.trgOpsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(tServiceSettingsEnum.Fix)]
            public tServiceSettingsEnum intgPd
            {
                get
                {
                    return this.intgPdField;
                }
                set
                {
                    this.intgPdField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tReportSettings : tServiceSettings
        {

            private tServiceSettingsEnum rptIDField;

            private tServiceSettingsEnum optFieldsField;

            private tServiceSettingsEnum bufTimeField;

            private tServiceSettingsEnum trgOpsField;

            private tServiceSettingsEnum intgPdField;

            private bool resvTmsField;

            private bool ownerField;

            public tReportSettings()
            {
                this.rptIDField = tServiceSettingsEnum.Fix;
                this.optFieldsField = tServiceSettingsEnum.Fix;
                this.bufTimeField = tServiceSettingsEnum.Fix;
                this.trgOpsField = tServiceSettingsEnum.Fix;
                this.intgPdField = tServiceSettingsEnum.Fix;
                this.resvTmsField = false;
                this.ownerField = false;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(tServiceSettingsEnum.Fix)]
            public tServiceSettingsEnum rptID
            {
                get
                {
                    return this.rptIDField;
                }
                set
                {
                    this.rptIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(tServiceSettingsEnum.Fix)]
            public tServiceSettingsEnum optFields
            {
                get
                {
                    return this.optFieldsField;
                }
                set
                {
                    this.optFieldsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(tServiceSettingsEnum.Fix)]
            public tServiceSettingsEnum bufTime
            {
                get
                {
                    return this.bufTimeField;
                }
                set
                {
                    this.bufTimeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(tServiceSettingsEnum.Fix)]
            public tServiceSettingsEnum trgOps
            {
                get
                {
                    return this.trgOpsField;
                }
                set
                {
                    this.trgOpsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(tServiceSettingsEnum.Fix)]
            public tServiceSettingsEnum intgPd
            {
                get
                {
                    return this.intgPdField;
                }
                set
                {
                    this.intgPdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool resvTms
            {
                get
                {
                    return this.resvTmsField;
                }
                set
                {
                    this.resvTmsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool owner
            {
                get
                {
                    return this.ownerField;
                }
                set
                {
                    this.ownerField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tServiceWithMaxNonZero
        {

            private uint maxField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint max
            {
                get
                {
                    return this.maxField;
                }
                set
                {
                    this.maxField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tSMVsc))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tGOOSEcapabilities))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tServiceWithMaxAndModify))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tServiceWithMaxAndMaxAttributes))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tServiceForConfDataSet))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tServiceConfReportControl))]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tServiceWithMax
        {

            private uint maxField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint max
            {
                get
                {
                    return this.maxField;
                }
                set
                {
                    this.maxField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tSMVsc : tServiceWithMax
        {

            private tSMVDeliveryEnum deliveryField;

            private bool deliveryConfField;

            private bool svField;

            private bool rSVField;

            public tSMVsc()
            {
                this.deliveryField = tSMVDeliveryEnum.multicast;
                this.deliveryConfField = false;
                this.svField = true;
                this.rSVField = false;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(tSMVDeliveryEnum.multicast)]
            public tSMVDeliveryEnum delivery
            {
                get
                {
                    return this.deliveryField;
                }
                set
                {
                    this.deliveryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool deliveryConf
            {
                get
                {
                    return this.deliveryConfField;
                }
                set
                {
                    this.deliveryConfField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(true)]
            public bool sv
            {
                get
                {
                    return this.svField;
                }
                set
                {
                    this.svField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool rSV
            {
                get
                {
                    return this.rSVField;
                }
                set
                {
                    this.rSVField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public enum tSMVDeliveryEnum
        {

            /// <remarks/>
            unicast,

            /// <remarks/>
            multicast,

            /// <remarks/>
            both,
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tGOOSEcapabilities : tServiceWithMax
        {

            private bool fixedOffsField;

            private bool gooseField;

            private bool rGOOSEField;

            public tGOOSEcapabilities()
            {
                this.fixedOffsField = false;
                this.gooseField = true;
                this.rGOOSEField = false;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool fixedOffs
            {
                get
                {
                    return this.fixedOffsField;
                }
                set
                {
                    this.fixedOffsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(true)]
            public bool goose
            {
                get
                {
                    return this.gooseField;
                }
                set
                {
                    this.gooseField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool rGOOSE
            {
                get
                {
                    return this.rGOOSEField;
                }
                set
                {
                    this.rGOOSEField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tServiceWithMaxAndModify : tServiceWithMax
        {

            private bool modifyField;

            public tServiceWithMaxAndModify()
            {
                this.modifyField = true;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(true)]
            public bool modify
            {
                get
                {
                    return this.modifyField;
                }
                set
                {
                    this.modifyField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tServiceForConfDataSet))]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tServiceWithMaxAndMaxAttributes : tServiceWithMax
        {

            private uint maxAttributesField;

            private bool maxAttributesFieldSpecified;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint maxAttributes
            {
                get
                {
                    return this.maxAttributesField;
                }
                set
                {
                    this.maxAttributesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool maxAttributesSpecified
            {
                get
                {
                    return this.maxAttributesFieldSpecified;
                }
                set
                {
                    this.maxAttributesFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tServiceForConfDataSet : tServiceWithMaxAndMaxAttributes
        {

            private bool modifyField;

            public tServiceForConfDataSet()
            {
                this.modifyField = true;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(true)]
            public bool modify
            {
                get
                {
                    return this.modifyField;
                }
                set
                {
                    this.modifyField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tServiceConfReportControl : tServiceWithMax
        {

            private tServiceConfReportControlBufMode bufModeField;

            private bool bufConfField;

            private uint maxBufField;

            private bool maxBufFieldSpecified;

            public tServiceConfReportControl()
            {
                this.bufModeField = tServiceConfReportControlBufMode.both;
                this.bufConfField = false;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(tServiceConfReportControlBufMode.both)]
            public tServiceConfReportControlBufMode bufMode
            {
                get
                {
                    return this.bufModeField;
                }
                set
                {
                    this.bufModeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool bufConf
            {
                get
                {
                    return this.bufConfField;
                }
                set
                {
                    this.bufConfField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint maxBuf
            {
                get
                {
                    return this.maxBufField;
                }
                set
                {
                    this.maxBufField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool maxBufSpecified
            {
                get
                {
                    return this.maxBufFieldSpecified;
                }
                set
                {
                    this.maxBufFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public enum tServiceConfReportControlBufMode
        {

            /// <remarks/>
            unbuffered,

            /// <remarks/>
            buffered,

            /// <remarks/>
            both,
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tSettingGroups
        {

            private tSettingGroupsSGEdit sGEditField;

            private tSettingGroupsConfSG confSGField;

            /// <remarks/>
            public tSettingGroupsSGEdit SGEdit
            {
                get
                {
                    return this.sGEditField;
                }
                set
                {
                    this.sGEditField = value;
                }
            }

            /// <remarks/>
            public tSettingGroupsConfSG ConfSG
            {
                get
                {
                    return this.confSGField;
                }
                set
                {
                    this.confSGField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tSettingGroupsSGEdit : tServiceYesNo
        {

            private bool resvTmsField;

            public tSettingGroupsSGEdit()
            {
                this.resvTmsField = false;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool resvTms
            {
                get
                {
                    return this.resvTmsField;
                }
                set
                {
                    this.resvTmsField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tSettingGroupsConfSG : tServiceYesNo
        {

            private bool resvTmsField;

            public tSettingGroupsConfSG()
            {
                this.resvTmsField = false;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool resvTms
            {
                get
                {
                    return this.resvTmsField;
                }
                set
                {
                    this.resvTmsField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tServiceWithOptionalMax
        {

            private uint maxField;

            private bool maxFieldSpecified;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint max
            {
                get
                {
                    return this.maxField;
                }
                set
                {
                    this.maxField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool maxSpecified
            {
                get
                {
                    return this.maxFieldSpecified;
                }
                set
                {
                    this.maxFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tServices
        {

            private tServiceWithOptionalMax dynAssociationField;

            private tSettingGroups settingGroupsField;

            private tServiceYesNo getDirectoryField;

            private tServiceYesNo getDataObjectDefinitionField;

            private tServiceYesNo dataObjectDirectoryField;

            private tServiceYesNo getDataSetValueField;

            private tServiceYesNo setDataSetValueField;

            private tServiceYesNo dataSetDirectoryField;

            private tServiceForConfDataSet confDataSetField;

            private tServiceWithMaxAndMaxAttributes dynDataSetField;

            private tServiceYesNo readWriteField;

            private tServiceYesNo timerActivatedControlField;

            private tServiceConfReportControl confReportControlField;

            private tServiceYesNo getCBValuesField;

            private tServiceWithMaxNonZero confLogControlField;

            private tReportSettings reportSettingsField;

            private tLogSettings logSettingsField;

            private tGSESettings gSESettingsField;

            private tSMVSettings sMVSettingsField;

            private tServiceYesNo gSEDirField;

            private tGOOSEcapabilities gOOSEField;

            private tServiceWithMax gSSEField;

            private tSMVsc sMVscField;

            private tFileHandling fileHandlingField;

            private tConfLNs confLNsField;

            private tClientServices clientServicesField;

            private tServiceYesNo confLdNameField;

            private tSupSubscription supSubscriptionField;

            private tServiceWithMaxNonZero confSigRefField;

            private tValueHandling valueHandlingField;

            private tRedProt redProtField;

            private tTimeSyncProt timeSyncProtField;

            private tCommProt commProtField;

            private string nameLengthField;

            public tServices()
            {
                this.nameLengthField = "32";
            }

            /// <remarks/>
            public tServiceWithOptionalMax DynAssociation
            {
                get
                {
                    return this.dynAssociationField;
                }
                set
                {
                    this.dynAssociationField = value;
                }
            }

            /// <remarks/>
            public tSettingGroups SettingGroups
            {
                get
                {
                    return this.settingGroupsField;
                }
                set
                {
                    this.settingGroupsField = value;
                }
            }

            /// <remarks/>
            public tServiceYesNo GetDirectory
            {
                get
                {
                    return this.getDirectoryField;
                }
                set
                {
                    this.getDirectoryField = value;
                }
            }

            /// <remarks/>
            public tServiceYesNo GetDataObjectDefinition
            {
                get
                {
                    return this.getDataObjectDefinitionField;
                }
                set
                {
                    this.getDataObjectDefinitionField = value;
                }
            }

            /// <remarks/>
            public tServiceYesNo DataObjectDirectory
            {
                get
                {
                    return this.dataObjectDirectoryField;
                }
                set
                {
                    this.dataObjectDirectoryField = value;
                }
            }

            /// <remarks/>
            public tServiceYesNo GetDataSetValue
            {
                get
                {
                    return this.getDataSetValueField;
                }
                set
                {
                    this.getDataSetValueField = value;
                }
            }

            /// <remarks/>
            public tServiceYesNo SetDataSetValue
            {
                get
                {
                    return this.setDataSetValueField;
                }
                set
                {
                    this.setDataSetValueField = value;
                }
            }

            /// <remarks/>
            public tServiceYesNo DataSetDirectory
            {
                get
                {
                    return this.dataSetDirectoryField;
                }
                set
                {
                    this.dataSetDirectoryField = value;
                }
            }

            /// <remarks/>
            public tServiceForConfDataSet ConfDataSet
            {
                get
                {
                    return this.confDataSetField;
                }
                set
                {
                    this.confDataSetField = value;
                }
            }

            /// <remarks/>
            public tServiceWithMaxAndMaxAttributes DynDataSet
            {
                get
                {
                    return this.dynDataSetField;
                }
                set
                {
                    this.dynDataSetField = value;
                }
            }

            /// <remarks/>
            public tServiceYesNo ReadWrite
            {
                get
                {
                    return this.readWriteField;
                }
                set
                {
                    this.readWriteField = value;
                }
            }

            /// <remarks/>
            public tServiceYesNo TimerActivatedControl
            {
                get
                {
                    return this.timerActivatedControlField;
                }
                set
                {
                    this.timerActivatedControlField = value;
                }
            }

            /// <remarks/>
            public tServiceConfReportControl ConfReportControl
            {
                get
                {
                    return this.confReportControlField;
                }
                set
                {
                    this.confReportControlField = value;
                }
            }

            /// <remarks/>
            public tServiceYesNo GetCBValues
            {
                get
                {
                    return this.getCBValuesField;
                }
                set
                {
                    this.getCBValuesField = value;
                }
            }

            /// <remarks/>
            public tServiceWithMaxNonZero ConfLogControl
            {
                get
                {
                    return this.confLogControlField;
                }
                set
                {
                    this.confLogControlField = value;
                }
            }

            /// <remarks/>
            public tReportSettings ReportSettings
            {
                get
                {
                    return this.reportSettingsField;
                }
                set
                {
                    this.reportSettingsField = value;
                }
            }

            /// <remarks/>
            public tLogSettings LogSettings
            {
                get
                {
                    return this.logSettingsField;
                }
                set
                {
                    this.logSettingsField = value;
                }
            }

            /// <remarks/>
            public tGSESettings GSESettings
            {
                get
                {
                    return this.gSESettingsField;
                }
                set
                {
                    this.gSESettingsField = value;
                }
            }

            /// <remarks/>
            public tSMVSettings SMVSettings
            {
                get
                {
                    return this.sMVSettingsField;
                }
                set
                {
                    this.sMVSettingsField = value;
                }
            }

            /// <remarks/>
            public tServiceYesNo GSEDir
            {
                get
                {
                    return this.gSEDirField;
                }
                set
                {
                    this.gSEDirField = value;
                }
            }

            /// <remarks/>
            public tGOOSEcapabilities GOOSE
            {
                get
                {
                    return this.gOOSEField;
                }
                set
                {
                    this.gOOSEField = value;
                }
            }

            /// <remarks/>
            public tServiceWithMax GSSE
            {
                get
                {
                    return this.gSSEField;
                }
                set
                {
                    this.gSSEField = value;
                }
            }

            /// <remarks/>
            public tSMVsc SMVsc
            {
                get
                {
                    return this.sMVscField;
                }
                set
                {
                    this.sMVscField = value;
                }
            }

            /// <remarks/>
            public tFileHandling FileHandling
            {
                get
                {
                    return this.fileHandlingField;
                }
                set
                {
                    this.fileHandlingField = value;
                }
            }

            /// <remarks/>
            public tConfLNs ConfLNs
            {
                get
                {
                    return this.confLNsField;
                }
                set
                {
                    this.confLNsField = value;
                }
            }

            /// <remarks/>
            public tClientServices ClientServices
            {
                get
                {
                    return this.clientServicesField;
                }
                set
                {
                    this.clientServicesField = value;
                }
            }

            /// <remarks/>
            public tServiceYesNo ConfLdName
            {
                get
                {
                    return this.confLdNameField;
                }
                set
                {
                    this.confLdNameField = value;
                }
            }

            /// <remarks/>
            public tSupSubscription SupSubscription
            {
                get
                {
                    return this.supSubscriptionField;
                }
                set
                {
                    this.supSubscriptionField = value;
                }
            }

            /// <remarks/>
            public tServiceWithMaxNonZero ConfSigRef
            {
                get
                {
                    return this.confSigRefField;
                }
                set
                {
                    this.confSigRefField = value;
                }
            }

            /// <remarks/>
            public tValueHandling ValueHandling
            {
                get
                {
                    return this.valueHandlingField;
                }
                set
                {
                    this.valueHandlingField = value;
                }
            }

            /// <remarks/>
            public tRedProt RedProt
            {
                get
                {
                    return this.redProtField;
                }
                set
                {
                    this.redProtField = value;
                }
            }

            /// <remarks/>
            public tTimeSyncProt TimeSyncProt
            {
                get
                {
                    return this.timeSyncProtField;
                }
                set
                {
                    this.timeSyncProtField = value;
                }
            }

            /// <remarks/>
            public tCommProt CommProt
            {
                get
                {
                    return this.commProtField;
                }
                set
                {
                    this.commProtField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
            [System.ComponentModel.DefaultValueAttribute("32")]
            public string nameLength
            {
                get
                {
                    return this.nameLengthField;
                }
                set
                {
                    this.nameLengthField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tIDNaming))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tEnumType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tDAType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tDOType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tLNodeType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tNaming))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tSubNetwork))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tCertificate))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tLNodeContainer))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tConnectivityNode))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tPowerSystemResource))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tGeneralEquipmentContainer))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tProcess))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tLine))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tSubFunction))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tFunction))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tTapChanger))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tAbstractEqFuncSubFunc))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tEqSubFunction))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tEqFunction))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tSubEquipment))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tEquipment))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tPowerTransformer))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tGeneralEquipment))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tAbstractConductingEquipment))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tTransformerWinding))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tConductingEquipment))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tEquipmentContainer))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tBay))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tVoltageLevel))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tSubstation))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tUnNaming))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tSDO))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tDO))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tAbstractDataAttribute))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tBDA))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tDA))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tCommunication))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tPhysConn))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tControlBlock))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tSMV))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tGSE))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tConnectedAP))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tServerAt))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tSettingControl))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tLog))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tInputs))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tDAI))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tSDI))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tDOI))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tRptEnabled))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tControl))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tControlWithIEDName))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tSampledValueControl))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tGSEControl))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tControlWithTriggerOpt))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tLogControl))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tReportControl))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tDataSet))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tAnyLN))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tLN0))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tLN))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tLDevice))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tServer))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tAccessPoint))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tIED))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tTerminal))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tLNode))]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public abstract partial class tBaseElement
        {

            private System.Xml.XmlElement[] anyField;

            private tText textField;

            private tPrivate[] privateField;

            private System.Xml.XmlAttribute[] anyAttrField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAnyElementAttribute()]
            public System.Xml.XmlElement[] Any
            {
                get
                {
                    return this.anyField;
                }
                set
                {
                    this.anyField = value;
                }
            }

            /// <remarks/>
            public tText Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Private")]
            public tPrivate[] Private
            {
                get
                {
                    return this.privateField;
                }
                set
                {
                    this.privateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAnyAttributeAttribute()]
            public System.Xml.XmlAttribute[] AnyAttr
            {
                get
                {
                    return this.anyAttrField;
                }
                set
                {
                    this.anyAttrField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tEnumType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tDAType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tDOType))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tLNodeType))]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public abstract partial class tIDNaming : tBaseElement
        {

            private string idField;

            private string descField;

            public tIDNaming()
            {
                this.descField = "";
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            [System.ComponentModel.DefaultValueAttribute("")]
            public string desc
            {
                get
                {
                    return this.descField;
                }
                set
                {
                    this.descField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tEnumType : tIDNaming
        {

            private tEnumVal[] enumValField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("EnumVal")]
            public tEnumVal[] EnumVal
            {
                get
                {
                    return this.enumValField;
                }
                set
                {
                    this.enumValField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tDAType : tIDNaming
        {

            private tBDA[] bDAField;

            private tProtNs[] protNsField;

            private string iedTypeField;

            public tDAType()
            {
                this.iedTypeField = "";
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("BDA")]
            public tBDA[] BDA
            {
                get
                {
                    return this.bDAField;
                }
                set
                {
                    this.bDAField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("ProtNs")]
            public tProtNs[] ProtNs
            {
                get
                {
                    return this.protNsField;
                }
                set
                {
                    this.protNsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            [System.ComponentModel.DefaultValueAttribute("")]
            public string iedType
            {
                get
                {
                    return this.iedTypeField;
                }
                set
                {
                    this.iedTypeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tBDA : tAbstractDataAttribute
        {
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tBDA))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tDA))]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public abstract partial class tAbstractDataAttribute : tUnNaming
        {

            private tVal[] valField;

            private string nameField;

            private string sAddrField;

            private tBasicTypeEnum bTypeField;

            private tValKindEnum valKindField;

            private string typeField;

            private string countField;

            private bool valImportField;

            public tAbstractDataAttribute()
            {
                this.valKindField = tValKindEnum.Set;
                this.countField = "0";
                this.valImportField = false;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Val")]
            public tVal[] Val
            {
                get
                {
                    return this.valField;
                }
                set
                {
                    this.valField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string sAddr
            {
                get
                {
                    return this.sAddrField;
                }
                set
                {
                    this.sAddrField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public tBasicTypeEnum bType
            {
                get
                {
                    return this.bTypeField;
                }
                set
                {
                    this.bTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(tValKindEnum.Set)]
            public tValKindEnum valKind
            {
                get
                {
                    return this.valKindField;
                }
                set
                {
                    this.valKindField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute("0")]
            public string count
            {
                get
                {
                    return this.countField;
                }
                set
                {
                    this.countField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool valImport
            {
                get
                {
                    return this.valImportField;
                }
                set
                {
                    this.valImportField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public enum tBasicTypeEnum
        {

            /// <remarks/>
            BOOLEAN,

            /// <remarks/>
            INT8,

            /// <remarks/>
            INT16,

            /// <remarks/>
            INT24,

            /// <remarks/>
            INT32,

            /// <remarks/>
            INT64,

            /// <remarks/>
            INT128,

            /// <remarks/>
            INT8U,

            /// <remarks/>
            INT16U,

            /// <remarks/>
            INT24U,

            /// <remarks/>
            INT32U,

            /// <remarks/>
            FLOAT32,

            /// <remarks/>
            FLOAT64,

            /// <remarks/>
            Enum,

            /// <remarks/>
            Dbpos,

            /// <remarks/>
            Tcmd,

            /// <remarks/>
            Quality,

            /// <remarks/>
            Timestamp,

            /// <remarks/>
            VisString32,

            /// <remarks/>
            VisString64,

            /// <remarks/>
            VisString65,

            /// <remarks/>
            VisString129,

            /// <remarks/>
            VisString255,

            /// <remarks/>
            Octet64,

            /// <remarks/>
            Unicode255,

            /// <remarks/>
            Struct,

            /// <remarks/>
            EntryTime,

            /// <remarks/>
            Check,

            /// <remarks/>
            ObjRef,

            /// <remarks/>
            Currency,

            /// <remarks/>
            PhyComAddr,

            /// <remarks/>
            TrgOps,

            /// <remarks/>
            OptFlds,

            /// <remarks/>
            SvOptFlds,

            /// <remarks/>
            LogOptFlds,

            /// <remarks/>
            EntryID,

            /// <remarks/>
            Octet6,

            /// <remarks/>
            Octet16,
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public enum tValKindEnum
        {

            /// <remarks/>
            Spec,

            /// <remarks/>
            Conf,

            /// <remarks/>
            RO,

            /// <remarks/>
            Set,
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tSDO))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tDO))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tAbstractDataAttribute))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tBDA))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tDA))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tCommunication))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tPhysConn))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tControlBlock))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tSMV))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tGSE))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tConnectedAP))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tServerAt))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tSettingControl))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tLog))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tInputs))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tDAI))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tSDI))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tDOI))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tRptEnabled))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tControl))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tControlWithIEDName))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tSampledValueControl))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tGSEControl))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tControlWithTriggerOpt))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tLogControl))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tReportControl))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tDataSet))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tAnyLN))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tLN0))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tLN))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tLDevice))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tServer))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tAccessPoint))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tIED))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tTerminal))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tLNode))]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public abstract partial class tUnNaming : tBaseElement
        {

            private string descField;

            public tUnNaming()
            {
                this.descField = "";
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            [System.ComponentModel.DefaultValueAttribute("")]
            public string desc
            {
                get
                {
                    return this.descField;
                }
                set
                {
                    this.descField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tSDO : tUnNaming
        {

            private string nameField;

            private string typeField;

            private string countField;

            public tSDO()
            {
                this.countField = "0";
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "Name")]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute("0")]
            public string count
            {
                get
                {
                    return this.countField;
                }
                set
                {
                    this.countField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tDO : tUnNaming
        {

            private string nameField;

            private string typeField;

            private string accessControlField;

            private bool transientField;

            public tDO()
            {
                this.transientField = false;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "Name")]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string accessControl
            {
                get
                {
                    return this.accessControlField;
                }
                set
                {
                    this.accessControlField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool transient
            {
                get
                {
                    return this.transientField;
                }
                set
                {
                    this.transientField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tPhysConn : tUnNaming
        {

            private tP_PhysConn[] pField;

            private string typeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("P")]
            public tP_PhysConn[] P
            {
                get
                {
                    return this.pField;
                }
                set
                {
                    this.pField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tSMV))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tGSE))]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public abstract partial class tControlBlock : tUnNaming
        {

            private tP[] addressField;

            private string ldInstField;

            private string cbNameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("P", IsNullable = false)]
            public tP[] Address
            {
                get
                {
                    return this.addressField;
                }
                set
                {
                    this.addressField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string ldInst
            {
                get
                {
                    return this.ldInstField;
                }
                set
                {
                    this.ldInstField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "Name")]
            public string cbName
            {
                get
                {
                    return this.cbNameField;
                }
                set
                {
                    this.cbNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tSMV : tControlBlock
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tGSE : tControlBlock
        {

            private tDurationInMilliSec minTimeField;

            private tDurationInMilliSec maxTimeField;

            /// <remarks/>
            public tDurationInMilliSec MinTime
            {
                get
                {
                    return this.minTimeField;
                }
                set
                {
                    this.minTimeField = value;
                }
            }

            /// <remarks/>
            public tDurationInMilliSec MaxTime
            {
                get
                {
                    return this.maxTimeField;
                }
                set
                {
                    this.maxTimeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tConnectedAP : tUnNaming
        {

            private tP[] addressField;

            private tGSE[] gSEField;

            private tSMV[] sMVField;

            private tPhysConn[] physConnField;

            private string iedNameField;

            private string apNameField;

            private tRedProtEnum redProtField;

            private bool redProtFieldSpecified;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("P", IsNullable = false)]
            public tP[] Address
            {
                get
                {
                    return this.addressField;
                }
                set
                {
                    this.addressField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("GSE")]
            public tGSE[] GSE
            {
                get
                {
                    return this.gSEField;
                }
                set
                {
                    this.gSEField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("SMV")]
            public tSMV[] SMV
            {
                get
                {
                    return this.sMVField;
                }
                set
                {
                    this.sMVField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("PhysConn")]
            public tPhysConn[] PhysConn
            {
                get
                {
                    return this.physConnField;
                }
                set
                {
                    this.physConnField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "Name")]
            public string iedName
            {
                get
                {
                    return this.iedNameField;
                }
                set
                {
                    this.iedNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string apName
            {
                get
                {
                    return this.apNameField;
                }
                set
                {
                    this.apNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public tRedProtEnum redProt
            {
                get
                {
                    return this.redProtField;
                }
                set
                {
                    this.redProtField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool redProtSpecified
            {
                get
                {
                    return this.redProtFieldSpecified;
                }
                set
                {
                    this.redProtFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public enum tRedProtEnum
        {

            /// <remarks/>
            none,

            /// <remarks/>
            hsr,

            /// <remarks/>
            prp,

            /// <remarks/>
            rstp,
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tServerAt : tUnNaming
        {

            private string apNameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string apName
            {
                get
                {
                    return this.apNameField;
                }
                set
                {
                    this.apNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tSettingControl : tUnNaming
        {

            private uint numOfSGsField;

            private uint actSGField;

            private ushort resvTmsField;

            private bool resvTmsFieldSpecified;

            public tSettingControl()
            {
                this.actSGField = ((uint)(1));
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint numOfSGs
            {
                get
                {
                    return this.numOfSGsField;
                }
                set
                {
                    this.numOfSGsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(typeof(uint), "1")]
            public uint actSG
            {
                get
                {
                    return this.actSGField;
                }
                set
                {
                    this.actSGField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort resvTms
            {
                get
                {
                    return this.resvTmsField;
                }
                set
                {
                    this.resvTmsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool resvTmsSpecified
            {
                get
                {
                    return this.resvTmsFieldSpecified;
                }
                set
                {
                    this.resvTmsFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tLog : tUnNaming
        {

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "Name")]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tInputs : tUnNaming
        {

            private tExtRef[] extRefField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("ExtRef")]
            public tExtRef[] ExtRef
            {
                get
                {
                    return this.extRefField;
                }
                set
                {
                    this.extRefField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tDAI : tUnNaming
        {

            private tVal[] valField;

            private string nameField;

            private string sAddrField;

            private tValKindEnum valKindField;

            private bool valKindFieldSpecified;

            private uint ixField;

            private bool ixFieldSpecified;

            private bool valImportField;

            private bool valImportFieldSpecified;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Val")]
            public tVal[] Val
            {
                get
                {
                    return this.valField;
                }
                set
                {
                    this.valField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string sAddr
            {
                get
                {
                    return this.sAddrField;
                }
                set
                {
                    this.sAddrField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public tValKindEnum valKind
            {
                get
                {
                    return this.valKindField;
                }
                set
                {
                    this.valKindField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool valKindSpecified
            {
                get
                {
                    return this.valKindFieldSpecified;
                }
                set
                {
                    this.valKindFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint ix
            {
                get
                {
                    return this.ixField;
                }
                set
                {
                    this.ixField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool ixSpecified
            {
                get
                {
                    return this.ixFieldSpecified;
                }
                set
                {
                    this.ixFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool valImport
            {
                get
                {
                    return this.valImportField;
                }
                set
                {
                    this.valImportField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool valImportSpecified
            {
                get
                {
                    return this.valImportFieldSpecified;
                }
                set
                {
                    this.valImportFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tSDI : tUnNaming
        {

            private tUnNaming[] itemsField;

            private string nameField;

            private uint ixField;

            private bool ixFieldSpecified;

            private string sAddrField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("DAI", typeof(tDAI))]
            [System.Xml.Serialization.XmlElementAttribute("SDI", typeof(tSDI))]
            public tUnNaming[] Items
            {
                get
                {
                    return this.itemsField;
                }
                set
                {
                    this.itemsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint ix
            {
                get
                {
                    return this.ixField;
                }
                set
                {
                    this.ixField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool ixSpecified
            {
                get
                {
                    return this.ixFieldSpecified;
                }
                set
                {
                    this.ixFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string sAddr
            {
                get
                {
                    return this.sAddrField;
                }
                set
                {
                    this.sAddrField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tDOI : tUnNaming
        {

            private tUnNaming[] itemsField;

            private string nameField;

            private uint ixField;

            private bool ixFieldSpecified;

            private string accessControlField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("DAI", typeof(tDAI))]
            [System.Xml.Serialization.XmlElementAttribute("SDI", typeof(tSDI))]
            public tUnNaming[] Items
            {
                get
                {
                    return this.itemsField;
                }
                set
                {
                    this.itemsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "Name")]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint ix
            {
                get
                {
                    return this.ixField;
                }
                set
                {
                    this.ixField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool ixSpecified
            {
                get
                {
                    return this.ixFieldSpecified;
                }
                set
                {
                    this.ixFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string accessControl
            {
                get
                {
                    return this.accessControlField;
                }
                set
                {
                    this.accessControlField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tRptEnabled : tUnNaming
        {

            private tClientLN[] clientLNField;

            private uint maxField;

            public tRptEnabled()
            {
                this.maxField = ((uint)(1));
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("ClientLN")]
            public tClientLN[] ClientLN
            {
                get
                {
                    return this.clientLNField;
                }
                set
                {
                    this.clientLNField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(typeof(uint), "1")]
            public uint max
            {
                get
                {
                    return this.maxField;
                }
                set
                {
                    this.maxField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tControlWithIEDName))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tSampledValueControl))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tGSEControl))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tControlWithTriggerOpt))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tLogControl))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tReportControl))]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public abstract partial class tControl : tUnNaming
        {

            private string nameField;

            private string datSetField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "Name")]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "Name")]
            public string datSet
            {
                get
                {
                    return this.datSetField;
                }
                set
                {
                    this.datSetField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tSampledValueControl))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tGSEControl))]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tControlWithIEDName : tControl
        {

            private tControlWithIEDNameIEDName[] iEDNameField;

            private uint confRevField;

            private bool confRevFieldSpecified;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("IEDName")]
            public tControlWithIEDNameIEDName[] IEDName
            {
                get
                {
                    return this.iEDNameField;
                }
                set
                {
                    this.iEDNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint confRev
            {
                get
                {
                    return this.confRevField;
                }
                set
                {
                    this.confRevField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool confRevSpecified
            {
                get
                {
                    return this.confRevFieldSpecified;
                }
                set
                {
                    this.confRevFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tControlWithIEDNameIEDName
        {

            private string apRefField;

            private string ldInstField;

            private string prefixField;

            private string lnClassField;

            private string lnInstField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string apRef
            {
                get
                {
                    return this.apRefField;
                }
                set
                {
                    this.apRefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string ldInst
            {
                get
                {
                    return this.ldInstField;
                }
                set
                {
                    this.ldInstField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string prefix
            {
                get
                {
                    return this.prefixField;
                }
                set
                {
                    this.prefixField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string lnClass
            {
                get
                {
                    return this.lnClassField;
                }
                set
                {
                    this.lnClassField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string lnInst
            {
                get
                {
                    return this.lnInstField;
                }
                set
                {
                    this.lnInstField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute(DataType = "Name")]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tSampledValueControl : tControlWithIEDName
        {

            private tSampledValueControlSmvOpts smvOptsField;

            private tProtocol protocolField;

            private string smvIDField;

            private bool multicastField;

            private uint smpRateField;

            private uint nofASDUField;

            private tSmpMod smpModField;

            private tPredefinedTypeOfSecurityEnum securityEnableField;

            public tSampledValueControl()
            {
                this.multicastField = true;
                this.smpModField = tSmpMod.SmpPerPeriod;
                this.securityEnableField = tPredefinedTypeOfSecurityEnum.None;
            }

            /// <remarks/>
            public tSampledValueControlSmvOpts SmvOpts
            {
                get
                {
                    return this.smvOptsField;
                }
                set
                {
                    this.smvOptsField = value;
                }
            }

            /// <remarks/>
            // CODEGEN Warning: 'fixed' attribute supported only for primitive types.  Ignoring fixed='R-SV' attribute.
            public tProtocol Protocol
            {
                get
                {
                    return this.protocolField;
                }
                set
                {
                    this.protocolField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string smvID
            {
                get
                {
                    return this.smvIDField;
                }
                set
                {
                    this.smvIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(true)]
            public bool multicast
            {
                get
                {
                    return this.multicastField;
                }
                set
                {
                    this.multicastField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint smpRate
            {
                get
                {
                    return this.smpRateField;
                }
                set
                {
                    this.smpRateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint nofASDU
            {
                get
                {
                    return this.nofASDUField;
                }
                set
                {
                    this.nofASDUField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(tSmpMod.SmpPerPeriod)]
            public tSmpMod smpMod
            {
                get
                {
                    return this.smpModField;
                }
                set
                {
                    this.smpModField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(tPredefinedTypeOfSecurityEnum.None)]
            public tPredefinedTypeOfSecurityEnum securityEnable
            {
                get
                {
                    return this.securityEnableField;
                }
                set
                {
                    this.securityEnableField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tSampledValueControlSmvOpts
        {

            private bool refreshTimeField;

            private bool sampleSynchronizedField;

            private bool sampleSynchronizedFieldSpecified;

            private bool sampleRateField;

            private bool dataSetField;

            private bool securityField;

            private bool timestampField;

            private bool synchSourceIdField;

            public tSampledValueControlSmvOpts()
            {
                this.refreshTimeField = false;
                this.sampleSynchronizedField = true;
                this.sampleRateField = false;
                this.dataSetField = false;
                this.securityField = false;
                this.timestampField = false;
                this.synchSourceIdField = false;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool refreshTime
            {
                get
                {
                    return this.refreshTimeField;
                }
                set
                {
                    this.refreshTimeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool sampleSynchronized
            {
                get
                {
                    return this.sampleSynchronizedField;
                }
                set
                {
                    this.sampleSynchronizedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool sampleSynchronizedSpecified
            {
                get
                {
                    return this.sampleSynchronizedFieldSpecified;
                }
                set
                {
                    this.sampleSynchronizedFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool sampleRate
            {
                get
                {
                    return this.sampleRateField;
                }
                set
                {
                    this.sampleRateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool dataSet
            {
                get
                {
                    return this.dataSetField;
                }
                set
                {
                    this.dataSetField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool security
            {
                get
                {
                    return this.securityField;
                }
                set
                {
                    this.securityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool timestamp
            {
                get
                {
                    return this.timestampField;
                }
                set
                {
                    this.timestampField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool synchSourceId
            {
                get
                {
                    return this.synchSourceIdField;
                }
                set
                {
                    this.synchSourceIdField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public enum tSmpMod
        {

            /// <remarks/>
            SmpPerPeriod,

            /// <remarks/>
            SmpPerSec,

            /// <remarks/>
            SecPerSmp,
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public enum tPredefinedTypeOfSecurityEnum
        {

            /// <remarks/>
            None,

            /// <remarks/>
            Signature,

            /// <remarks/>
            SignatureAndEncryption,
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tGSEControl : tControlWithIEDName
        {

            private tProtocol protocolField;

            private tGSEControlTypeEnum typeField;

            private string appIDField;

            private bool fixedOffsField;

            private tPredefinedTypeOfSecurityEnum securityEnableField;

            public tGSEControl()
            {
                this.typeField = tGSEControlTypeEnum.GOOSE;
                this.fixedOffsField = false;
                this.securityEnableField = tPredefinedTypeOfSecurityEnum.None;
            }

            /// <remarks/>
            // CODEGEN Warning: 'fixed' attribute supported only for primitive types.  Ignoring fixed='R-GOOSE' attribute.
            public tProtocol Protocol
            {
                get
                {
                    return this.protocolField;
                }
                set
                {
                    this.protocolField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(tGSEControlTypeEnum.GOOSE)]
            public tGSEControlTypeEnum type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string appID
            {
                get
                {
                    return this.appIDField;
                }
                set
                {
                    this.appIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool fixedOffs
            {
                get
                {
                    return this.fixedOffsField;
                }
                set
                {
                    this.fixedOffsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(tPredefinedTypeOfSecurityEnum.None)]
            public tPredefinedTypeOfSecurityEnum securityEnable
            {
                get
                {
                    return this.securityEnableField;
                }
                set
                {
                    this.securityEnableField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public enum tGSEControlTypeEnum
        {

            /// <remarks/>
            GSSE,

            /// <remarks/>
            GOOSE,
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tLogControl))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tReportControl))]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public abstract partial class tControlWithTriggerOpt : tControl
        {

            private tTrgOps trgOpsField;

            private uint intgPdField;

            public tControlWithTriggerOpt()
            {
                this.intgPdField = ((uint)(0));
            }

            /// <remarks/>
            public tTrgOps TrgOps
            {
                get
                {
                    return this.trgOpsField;
                }
                set
                {
                    this.trgOpsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
            public uint intgPd
            {
                get
                {
                    return this.intgPdField;
                }
                set
                {
                    this.intgPdField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tLogControl : tControlWithTriggerOpt
        {

            private string ldInstField;

            private string prefixField;

            private string lnClassField;

            private string lnInstField;

            private string logNameField;

            private bool logEnaField;

            private bool reasonCodeField;

            private uint bufTimeField;

            public tLogControl()
            {
                this.prefixField = "";
                this.lnClassField = "LLN0";
                this.logEnaField = true;
                this.reasonCodeField = true;
                this.bufTimeField = ((uint)(0));
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string ldInst
            {
                get
                {
                    return this.ldInstField;
                }
                set
                {
                    this.ldInstField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            [System.ComponentModel.DefaultValueAttribute("")]
            public string prefix
            {
                get
                {
                    return this.prefixField;
                }
                set
                {
                    this.prefixField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute("LLN0")]
            public string lnClass
            {
                get
                {
                    return this.lnClassField;
                }
                set
                {
                    this.lnClassField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string lnInst
            {
                get
                {
                    return this.lnInstField;
                }
                set
                {
                    this.lnInstField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "Name")]
            public string logName
            {
                get
                {
                    return this.logNameField;
                }
                set
                {
                    this.logNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(true)]
            public bool logEna
            {
                get
                {
                    return this.logEnaField;
                }
                set
                {
                    this.logEnaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(true)]
            public bool reasonCode
            {
                get
                {
                    return this.reasonCodeField;
                }
                set
                {
                    this.reasonCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
            public uint bufTime
            {
                get
                {
                    return this.bufTimeField;
                }
                set
                {
                    this.bufTimeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tReportControl : tControlWithTriggerOpt
        {

            private tReportControlOptFields optFieldsField;

            private tRptEnabled rptEnabledField;

            private string rptIDField;

            private uint confRevField;

            private bool bufferedField;

            private uint bufTimeField;

            private bool indexedField;

            public tReportControl()
            {
                this.bufferedField = false;
                this.bufTimeField = ((uint)(0));
                this.indexedField = true;
            }

            /// <remarks/>
            public tReportControlOptFields OptFields
            {
                get
                {
                    return this.optFieldsField;
                }
                set
                {
                    this.optFieldsField = value;
                }
            }

            /// <remarks/>
            public tRptEnabled RptEnabled
            {
                get
                {
                    return this.rptEnabledField;
                }
                set
                {
                    this.rptEnabledField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string rptID
            {
                get
                {
                    return this.rptIDField;
                }
                set
                {
                    this.rptIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint confRev
            {
                get
                {
                    return this.confRevField;
                }
                set
                {
                    this.confRevField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool buffered
            {
                get
                {
                    return this.bufferedField;
                }
                set
                {
                    this.bufferedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
            public uint bufTime
            {
                get
                {
                    return this.bufTimeField;
                }
                set
                {
                    this.bufTimeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(true)]
            public bool indexed
            {
                get
                {
                    return this.indexedField;
                }
                set
                {
                    this.indexedField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tReportControlOptFields
        {

            private bool seqNumField;

            private bool timeStampField;

            private bool dataSetField;

            private bool reasonCodeField;

            private bool dataRefField;

            private bool entryIDField;

            private bool configRefField;

            private bool bufOvflField;

            public tReportControlOptFields()
            {
                this.seqNumField = false;
                this.timeStampField = false;
                this.dataSetField = false;
                this.reasonCodeField = false;
                this.dataRefField = false;
                this.entryIDField = false;
                this.configRefField = false;
                this.bufOvflField = true;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool seqNum
            {
                get
                {
                    return this.seqNumField;
                }
                set
                {
                    this.seqNumField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool timeStamp
            {
                get
                {
                    return this.timeStampField;
                }
                set
                {
                    this.timeStampField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool dataSet
            {
                get
                {
                    return this.dataSetField;
                }
                set
                {
                    this.dataSetField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool reasonCode
            {
                get
                {
                    return this.reasonCodeField;
                }
                set
                {
                    this.reasonCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool dataRef
            {
                get
                {
                    return this.dataRefField;
                }
                set
                {
                    this.dataRefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool entryID
            {
                get
                {
                    return this.entryIDField;
                }
                set
                {
                    this.entryIDField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool configRef
            {
                get
                {
                    return this.configRefField;
                }
                set
                {
                    this.configRefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(true)]
            public bool bufOvfl
            {
                get
                {
                    return this.bufOvflField;
                }
                set
                {
                    this.bufOvflField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tDataSet : tUnNaming
        {

            private tFCDA[] itemsField;

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("FCDA")]
            public tFCDA[] Items
            {
                get
                {
                    return this.itemsField;
                }
                set
                {
                    this.itemsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "Name")]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tLN0))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tLN))]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public abstract partial class tAnyLN : tUnNaming
        {

            private tDataSet[] dataSetField;

            private tReportControl[] reportControlField;

            private tLogControl[] logControlField;

            private tDOI[] dOIField;

            private tInputs inputsField;

            private tLog[] logField;

            private string lnTypeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("DataSet")]
            public tDataSet[] DataSet
            {
                get
                {
                    return this.dataSetField;
                }
                set
                {
                    this.dataSetField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("ReportControl")]
            public tReportControl[] ReportControl
            {
                get
                {
                    return this.reportControlField;
                }
                set
                {
                    this.reportControlField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("LogControl")]
            public tLogControl[] LogControl
            {
                get
                {
                    return this.logControlField;
                }
                set
                {
                    this.logControlField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("DOI")]
            public tDOI[] DOI
            {
                get
                {
                    return this.dOIField;
                }
                set
                {
                    this.dOIField = value;
                }
            }

            /// <remarks/>
            public tInputs Inputs
            {
                get
                {
                    return this.inputsField;
                }
                set
                {
                    this.inputsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Log")]
            public tLog[] Log
            {
                get
                {
                    return this.logField;
                }
                set
                {
                    this.logField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string lnType
            {
                get
                {
                    return this.lnTypeField;
                }
                set
                {
                    this.lnTypeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tLN0 : tAnyLN
        {

            private tGSEControl[] gSEControlField;

            private tSampledValueControl[] sampledValueControlField;

            private tSettingControl settingControlField;

            private string lnClassField;

            private string instField;

            public tLN0()
            {
                this.lnClassField = "LLN0";
                this.instField = "";
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("GSEControl")]
            public tGSEControl[] GSEControl
            {
                get
                {
                    return this.gSEControlField;
                }
                set
                {
                    this.gSEControlField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("SampledValueControl")]
            public tSampledValueControl[] SampledValueControl
            {
                get
                {
                    return this.sampledValueControlField;
                }
                set
                {
                    this.sampledValueControlField = value;
                }
            }

            /// <remarks/>
            public tSettingControl SettingControl
            {
                get
                {
                    return this.settingControlField;
                }
                set
                {
                    this.settingControlField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string lnClass
            {
                get
                {
                    return this.lnClassField;
                }
                set
                {
                    this.lnClassField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string inst
            {
                get
                {
                    return this.instField;
                }
                set
                {
                    this.instField = value;
                }
            }

        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tLDevice : tUnNaming
        {

            private LN0 lN0Field;

            private tLN[] lnField;

            private tAccessControl accessControlField;

            private string instField;

            private string ldNameField;

            /// <remarks/>
            public LN0 LN0
            {
                get
                {
                    return this.lN0Field;
                }
                set
                {
                    this.lN0Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("LN")]
            public tLN[] LN
            {
                get
                {
                    return this.lnField;
                }
                set
                {
                    this.lnField = value;
                }
            }

            /// <remarks/>
            public tAccessControl AccessControl
            {
                get
                {
                    return this.accessControlField;
                }
                set
                {
                    this.accessControlField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string inst
            {
                get
                {
                    return this.instField;
                }
                set
                {
                    this.instField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string ldName
            {
                get
                {
                    return this.ldNameField;
                }
                set
                {
                    this.ldNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iec.ch/61850/2003/SCL")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL", IsNullable = false)]
        public partial class LN0 : tLN0
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        [System.Xml.Serialization.XmlRootAttribute("LN", Namespace = "http://www.iec.ch/61850/2003/SCL", IsNullable = false)]
        public partial class tLN : tAnyLN
        {

            private string prefixField;

            private string lnClassField;

            private string instField;

            public tLN()
            {
                this.prefixField = "";
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            [System.ComponentModel.DefaultValueAttribute("")]
            public string prefix
            {
                get
                {
                    return this.prefixField;
                }
                set
                {
                    this.prefixField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string lnClass
            {
                get
                {
                    return this.lnClassField;
                }
                set
                {
                    this.lnClassField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string inst
            {
                get
                {
                    return this.instField;
                }
                set
                {
                    this.instField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tServer : tUnNaming
        {

            private tServerAuthentication authenticationField;

            private tLDevice[] lDeviceField;

            private tAssociation[] associationField;

            private uint timeoutField;

            public tServer()
            {
                this.timeoutField = ((uint)(30));
            }

            /// <remarks/>
            public tServerAuthentication Authentication
            {
                get
                {
                    return this.authenticationField;
                }
                set
                {
                    this.authenticationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("LDevice")]
            public tLDevice[] LDevice
            {
                get
                {
                    return this.lDeviceField;
                }
                set
                {
                    this.lDeviceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Association")]
            public tAssociation[] Association
            {
                get
                {
                    return this.associationField;
                }
                set
                {
                    this.associationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(typeof(uint), "30")]
            public uint timeout
            {
                get
                {
                    return this.timeoutField;
                }
                set
                {
                    this.timeoutField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tServerAuthentication
        {

            private bool noneField;

            private bool passwordField;

            private bool weakField;

            private bool strongField;

            private bool certificateField;

            public tServerAuthentication()
            {
                this.noneField = true;
                this.passwordField = false;
                this.weakField = false;
                this.strongField = false;
                this.certificateField = false;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(true)]
            public bool none
            {
                get
                {
                    return this.noneField;
                }
                set
                {
                    this.noneField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool password
            {
                get
                {
                    return this.passwordField;
                }
                set
                {
                    this.passwordField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool weak
            {
                get
                {
                    return this.weakField;
                }
                set
                {
                    this.weakField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool strong
            {
                get
                {
                    return this.strongField;
                }
                set
                {
                    this.strongField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool certificate
            {
                get
                {
                    return this.certificateField;
                }
                set
                {
                    this.certificateField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tAccessPoint : tUnNaming
        {

            private tUnNaming[] itemsField;

            private tServices servicesField;

            private tCertificate[] gOOSESecurityField;

            private tCertificate[] sMVSecurityField;

            private string nameField;

            private bool routerField;

            private bool clockField;

            private bool kdcField;

            public tAccessPoint()
            {
                this.routerField = false;
                this.clockField = false;
                this.kdcField = false;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("LN", typeof(tLN))]
            [System.Xml.Serialization.XmlElementAttribute("Server", typeof(tServer))]
            [System.Xml.Serialization.XmlElementAttribute("ServerAt", typeof(tServerAt))]
            public tUnNaming[] Items
            {
                get
                {
                    return this.itemsField;
                }
                set
                {
                    this.itemsField = value;
                }
            }

            /// <remarks/>
            public tServices Services
            {
                get
                {
                    return this.servicesField;
                }
                set
                {
                    this.servicesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("GOOSESecurity")]
            public tCertificate[] GOOSESecurity
            {
                get
                {
                    return this.gOOSESecurityField;
                }
                set
                {
                    this.gOOSESecurityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("SMVSecurity")]
            public tCertificate[] SMVSecurity
            {
                get
                {
                    return this.sMVSecurityField;
                }
                set
                {
                    this.sMVSecurityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool router
            {
                get
                {
                    return this.routerField;
                }
                set
                {
                    this.routerField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool clock
            {
                get
                {
                    return this.clockField;
                }
                set
                {
                    this.clockField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool kdc
            {
                get
                {
                    return this.kdcField;
                }
                set
                {
                    this.kdcField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tCertificate : tNaming
        {

            private tCert subjectField;

            private tCert issuerNameField;

            private uint xferNumberField;

            private bool xferNumberFieldSpecified;

            private string serialNumberField;

            /// <remarks/>
            public tCert Subject
            {
                get
                {
                    return this.subjectField;
                }
                set
                {
                    this.subjectField = value;
                }
            }

            /// <remarks/>
            public tCert IssuerName
            {
                get
                {
                    return this.issuerNameField;
                }
                set
                {
                    this.issuerNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint xferNumber
            {
                get
                {
                    return this.xferNumberField;
                }
                set
                {
                    this.xferNumberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool xferNumberSpecified
            {
                get
                {
                    return this.xferNumberFieldSpecified;
                }
                set
                {
                    this.xferNumberFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string serialNumber
            {
                get
                {
                    return this.serialNumberField;
                }
                set
                {
                    this.serialNumberField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tSubNetwork))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tCertificate))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tLNodeContainer))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tConnectivityNode))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tPowerSystemResource))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tGeneralEquipmentContainer))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tProcess))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tLine))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tSubFunction))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tFunction))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tTapChanger))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tAbstractEqFuncSubFunc))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tEqSubFunction))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tEqFunction))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tSubEquipment))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tEquipment))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tPowerTransformer))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tGeneralEquipment))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tAbstractConductingEquipment))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tTransformerWinding))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tConductingEquipment))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tEquipmentContainer))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tBay))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tVoltageLevel))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tSubstation))]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public abstract partial class tNaming : tBaseElement
        {

            private string nameField;

            private string descField;

            public tNaming()
            {
                this.descField = "";
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            [System.ComponentModel.DefaultValueAttribute("")]
            public string desc
            {
                get
                {
                    return this.descField;
                }
                set
                {
                    this.descField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tSubNetwork : tNaming
        {

            private tBitRateInMbPerSec bitRateField;

            private tConnectedAP[] connectedAPField;

            private string typeField;

            /// <remarks/>
            public tBitRateInMbPerSec BitRate
            {
                get
                {
                    return this.bitRateField;
                }
                set
                {
                    this.bitRateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("ConnectedAP")]
            public tConnectedAP[] ConnectedAP
            {
                get
                {
                    return this.connectedAPField;
                }
                set
                {
                    this.connectedAPField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tConnectivityNode))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tPowerSystemResource))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tGeneralEquipmentContainer))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tProcess))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tLine))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tSubFunction))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tFunction))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tTapChanger))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tAbstractEqFuncSubFunc))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tEqSubFunction))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tEqFunction))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tSubEquipment))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tEquipment))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tPowerTransformer))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tGeneralEquipment))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tAbstractConductingEquipment))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tTransformerWinding))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tConductingEquipment))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tEquipmentContainer))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tBay))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tVoltageLevel))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tSubstation))]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public abstract partial class tLNodeContainer : tNaming
        {

            private tLNode[] lNodeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("LNode")]
            public tLNode[] LNode
            {
                get
                {
                    return this.lNodeField;
                }
                set
                {
                    this.lNodeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tLNode : tUnNaming
        {

            private string iedNameField;

            private string ldInstField;

            private string prefixField;

            private string lnClassField;

            private string lnInstField;

            private string lnTypeField;

            public tLNode()
            {
                this.iedNameField = "None";
                this.ldInstField = "";
                this.prefixField = "";
                this.lnInstField = "";
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute("None")]
            public string iedName
            {
                get
                {
                    return this.iedNameField;
                }
                set
                {
                    this.iedNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute("")]
            public string ldInst
            {
                get
                {
                    return this.ldInstField;
                }
                set
                {
                    this.ldInstField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            [System.ComponentModel.DefaultValueAttribute("")]
            public string prefix
            {
                get
                {
                    return this.prefixField;
                }
                set
                {
                    this.prefixField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string lnClass
            {
                get
                {
                    return this.lnClassField;
                }
                set
                {
                    this.lnClassField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute("")]
            public string lnInst
            {
                get
                {
                    return this.lnInstField;
                }
                set
                {
                    this.lnInstField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string lnType
            {
                get
                {
                    return this.lnTypeField;
                }
                set
                {
                    this.lnTypeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tConnectivityNode : tLNodeContainer
        {

            private string pathNameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string pathName
            {
                get
                {
                    return this.pathNameField;
                }
                set
                {
                    this.pathNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tGeneralEquipmentContainer))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tProcess))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tLine))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tSubFunction))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tFunction))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tTapChanger))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tAbstractEqFuncSubFunc))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tEqSubFunction))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tEqFunction))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tSubEquipment))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tEquipment))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tPowerTransformer))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tGeneralEquipment))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tAbstractConductingEquipment))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tTransformerWinding))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tConductingEquipment))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tEquipmentContainer))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tBay))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tVoltageLevel))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tSubstation))]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public abstract partial class tPowerSystemResource : tLNodeContainer
        {
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tProcess))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tLine))]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public abstract partial class tGeneralEquipmentContainer : tPowerSystemResource
        {

            private tGeneralEquipment[] generalEquipmentField;

            private tFunction[] functionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("GeneralEquipment")]
            public tGeneralEquipment[] GeneralEquipment
            {
                get
                {
                    return this.generalEquipmentField;
                }
                set
                {
                    this.generalEquipmentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Function")]
            public tFunction[] Function
            {
                get
                {
                    return this.functionField;
                }
                set
                {
                    this.functionField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tGeneralEquipment : tEquipment
        {

            private tEqFunction[] eqFunctionField;

            private string typeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("EqFunction")]
            public tEqFunction[] EqFunction
            {
                get
                {
                    return this.eqFunctionField;
                }
                set
                {
                    this.eqFunctionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tEqFunction : tAbstractEqFuncSubFunc
        {
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tEqSubFunction))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tEqFunction))]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public abstract partial class tAbstractEqFuncSubFunc : tPowerSystemResource
        {

            private tGeneralEquipment[] generalEquipmentField;

            private tEqSubFunction[] eqSubFunctionField;

            private string typeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("GeneralEquipment")]
            public tGeneralEquipment[] GeneralEquipment
            {
                get
                {
                    return this.generalEquipmentField;
                }
                set
                {
                    this.generalEquipmentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("EqSubFunction")]
            public tEqSubFunction[] EqSubFunction
            {
                get
                {
                    return this.eqSubFunctionField;
                }
                set
                {
                    this.eqSubFunctionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tEqSubFunction : tAbstractEqFuncSubFunc
        {
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tPowerTransformer))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tGeneralEquipment))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tAbstractConductingEquipment))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tTransformerWinding))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tConductingEquipment))]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public abstract partial class tEquipment : tPowerSystemResource
        {

            private bool virtualField;

            public tEquipment()
            {
                this.virtualField = false;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool @virtual
            {
                get
                {
                    return this.virtualField;
                }
                set
                {
                    this.virtualField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tPowerTransformer : tEquipment
        {

            private tTransformerWinding[] transformerWindingField;

            private tSubEquipment[] subEquipmentField;

            private tEqFunction[] eqFunctionField;

            private tPowerTransformerEnum typeField;

            public tPowerTransformer()
            {
                this.typeField = tPowerTransformerEnum.PTR;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("TransformerWinding")]
            public tTransformerWinding[] TransformerWinding
            {
                get
                {
                    return this.transformerWindingField;
                }
                set
                {
                    this.transformerWindingField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("SubEquipment")]
            public tSubEquipment[] SubEquipment
            {
                get
                {
                    return this.subEquipmentField;
                }
                set
                {
                    this.subEquipmentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("EqFunction")]
            public tEqFunction[] EqFunction
            {
                get
                {
                    return this.eqFunctionField;
                }
                set
                {
                    this.eqFunctionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public tPowerTransformerEnum type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tTransformerWinding : tAbstractConductingEquipment
        {

            private tTapChanger tapChangerField;

            private tTerminal neutralPointField;

            private tEqFunction[] eqFunctionField;

            private tTransformerWindingEnum typeField;

            public tTransformerWinding()
            {
                this.typeField = tTransformerWindingEnum.PTW;
            }

            /// <remarks/>
            public tTapChanger TapChanger
            {
                get
                {
                    return this.tapChangerField;
                }
                set
                {
                    this.tapChangerField = value;
                }
            }

            /// <remarks/>
            public tTerminal NeutralPoint
            {
                get
                {
                    return this.neutralPointField;
                }
                set
                {
                    this.neutralPointField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("EqFunction")]
            public tEqFunction[] EqFunction
            {
                get
                {
                    return this.eqFunctionField;
                }
                set
                {
                    this.eqFunctionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public tTransformerWindingEnum type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tTapChanger : tPowerSystemResource
        {

            private tSubEquipment[] subEquipmentField;

            private tEqFunction[] eqFunctionField;

            private string typeField;

            private bool virtualField;

            public tTapChanger()
            {
                this.typeField = "LTC";
                this.virtualField = false;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("SubEquipment")]
            public tSubEquipment[] SubEquipment
            {
                get
                {
                    return this.subEquipmentField;
                }
                set
                {
                    this.subEquipmentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("EqFunction")]
            public tEqFunction[] EqFunction
            {
                get
                {
                    return this.eqFunctionField;
                }
                set
                {
                    this.eqFunctionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "Name")]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool @virtual
            {
                get
                {
                    return this.virtualField;
                }
                set
                {
                    this.virtualField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tSubEquipment : tPowerSystemResource
        {

            private tEqFunction[] eqFunctionField;

            private tPhaseEnum phaseField;

            private bool virtualField;

            public tSubEquipment()
            {
                this.phaseField = tPhaseEnum.none;
                this.virtualField = false;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("EqFunction")]
            public tEqFunction[] EqFunction
            {
                get
                {
                    return this.eqFunctionField;
                }
                set
                {
                    this.eqFunctionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(tPhaseEnum.none)]
            public tPhaseEnum phase
            {
                get
                {
                    return this.phaseField;
                }
                set
                {
                    this.phaseField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool @virtual
            {
                get
                {
                    return this.virtualField;
                }
                set
                {
                    this.virtualField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public enum tPhaseEnum
        {

            /// <remarks/>
            A,

            /// <remarks/>
            B,

            /// <remarks/>
            C,

            /// <remarks/>
            N,

            /// <remarks/>
            all,

            /// <remarks/>
            none,

            /// <remarks/>
            AB,

            /// <remarks/>
            BC,

            /// <remarks/>
            CA,
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tTerminal : tUnNaming
        {

            private string nameField;

            private string connectivityNodeField;

            private string processNameField;

            private string substationNameField;

            private string voltageLevelNameField;

            private string bayNameField;

            private string cNodeNameField;

            private string lineNameField;

            public tTerminal()
            {
                this.nameField = "";
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            [System.ComponentModel.DefaultValueAttribute("")]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string connectivityNode
            {
                get
                {
                    return this.connectivityNodeField;
                }
                set
                {
                    this.connectivityNodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string processName
            {
                get
                {
                    return this.processNameField;
                }
                set
                {
                    this.processNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string substationName
            {
                get
                {
                    return this.substationNameField;
                }
                set
                {
                    this.substationNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string voltageLevelName
            {
                get
                {
                    return this.voltageLevelNameField;
                }
                set
                {
                    this.voltageLevelNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string bayName
            {
                get
                {
                    return this.bayNameField;
                }
                set
                {
                    this.bayNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string cNodeName
            {
                get
                {
                    return this.cNodeNameField;
                }
                set
                {
                    this.cNodeNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string lineName
            {
                get
                {
                    return this.lineNameField;
                }
                set
                {
                    this.lineNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public enum tTransformerWindingEnum
        {

            /// <remarks/>
            PTW,
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tTransformerWinding))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tConductingEquipment))]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public abstract partial class tAbstractConductingEquipment : tEquipment
        {

            private tTerminal[] terminalField;

            private tSubEquipment[] subEquipmentField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Terminal")]
            public tTerminal[] Terminal
            {
                get
                {
                    return this.terminalField;
                }
                set
                {
                    this.terminalField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("SubEquipment")]
            public tSubEquipment[] SubEquipment
            {
                get
                {
                    return this.subEquipmentField;
                }
                set
                {
                    this.subEquipmentField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tConductingEquipment : tAbstractConductingEquipment
        {

            private tEqFunction[] eqFunctionField;

            private string typeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("EqFunction")]
            public tEqFunction[] EqFunction
            {
                get
                {
                    return this.eqFunctionField;
                }
                set
                {
                    this.eqFunctionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public enum tPowerTransformerEnum
        {

            /// <remarks/>
            PTR,
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tFunction : tPowerSystemResource
        {

            private tSubFunction[] subFunctionField;

            private tGeneralEquipment[] generalEquipmentField;

            private tConductingEquipment[] conductingEquipmentField;

            private string typeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("SubFunction")]
            public tSubFunction[] SubFunction
            {
                get
                {
                    return this.subFunctionField;
                }
                set
                {
                    this.subFunctionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("GeneralEquipment")]
            public tGeneralEquipment[] GeneralEquipment
            {
                get
                {
                    return this.generalEquipmentField;
                }
                set
                {
                    this.generalEquipmentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("ConductingEquipment")]
            public tConductingEquipment[] ConductingEquipment
            {
                get
                {
                    return this.conductingEquipmentField;
                }
                set
                {
                    this.conductingEquipmentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tSubFunction : tPowerSystemResource
        {

            private tGeneralEquipment[] generalEquipmentField;

            private tConductingEquipment[] conductingEquipmentField;

            private tSubFunction[] subFunctionField;

            private string typeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("GeneralEquipment")]
            public tGeneralEquipment[] GeneralEquipment
            {
                get
                {
                    return this.generalEquipmentField;
                }
                set
                {
                    this.generalEquipmentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("ConductingEquipment")]
            public tConductingEquipment[] ConductingEquipment
            {
                get
                {
                    return this.conductingEquipmentField;
                }
                set
                {
                    this.conductingEquipmentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("SubFunction")]
            public tSubFunction[] SubFunction
            {
                get
                {
                    return this.subFunctionField;
                }
                set
                {
                    this.subFunctionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tBay))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tVoltageLevel))]
        [System.Xml.Serialization.XmlIncludeAttribute(typeof(tSubstation))]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public abstract partial class tEquipmentContainer : tPowerSystemResource
        {

            private tPowerTransformer[] powerTransformerField;

            private tGeneralEquipment[] generalEquipmentField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("PowerTransformer")]
            public tPowerTransformer[] PowerTransformer
            {
                get
                {
                    return this.powerTransformerField;
                }
                set
                {
                    this.powerTransformerField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("GeneralEquipment")]
            public tGeneralEquipment[] GeneralEquipment
            {
                get
                {
                    return this.generalEquipmentField;
                }
                set
                {
                    this.generalEquipmentField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tBay : tEquipmentContainer
        {

            private tConductingEquipment[] conductingEquipmentField;

            private tConnectivityNode[] connectivityNodeField;

            private tFunction[] functionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("ConductingEquipment")]
            public tConductingEquipment[] ConductingEquipment
            {
                get
                {
                    return this.conductingEquipmentField;
                }
                set
                {
                    this.conductingEquipmentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("ConnectivityNode")]
            public tConnectivityNode[] ConnectivityNode
            {
                get
                {
                    return this.connectivityNodeField;
                }
                set
                {
                    this.connectivityNodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Function")]
            public tFunction[] Function
            {
                get
                {
                    return this.functionField;
                }
                set
                {
                    this.functionField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tDA : tAbstractDataAttribute
        {

            private tProtNs[] protNsField;

            private bool dchgField;

            private bool qchgField;

            private bool dupdField;

            private tFCEnum fcField;

            public tDA()
            {
                this.dchgField = false;
                this.qchgField = false;
                this.dupdField = false;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("ProtNs")]
            public tProtNs[] ProtNs
            {
                get
                {
                    return this.protNsField;
                }
                set
                {
                    this.protNsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool dchg
            {
                get
                {
                    return this.dchgField;
                }
                set
                {
                    this.dchgField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool qchg
            {
                get
                {
                    return this.qchgField;
                }
                set
                {
                    this.qchgField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(false)]
            public bool dupd
            {
                get
                {
                    return this.dupdField;
                }
                set
                {
                    this.dupdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public tFCEnum fc
            {
                get
                {
                    return this.fcField;
                }
                set
                {
                    this.fcField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tDOType : tIDNaming
        {

            private tUnNaming[] itemsField;

            private string iedTypeField;

            private tCDCEnum cdcField;

            public tDOType()
            {
                this.iedTypeField = "";
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("DA", typeof(tDA))]
            [System.Xml.Serialization.XmlElementAttribute("SDO", typeof(tSDO))]
            public tUnNaming[] Items
            {
                get
                {
                    return this.itemsField;
                }
                set
                {
                    this.itemsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            [System.ComponentModel.DefaultValueAttribute("")]
            public string iedType
            {
                get
                {
                    return this.iedTypeField;
                }
                set
                {
                    this.iedTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public tCDCEnum cdc
            {
                get
                {
                    return this.cdcField;
                }
                set
                {
                    this.cdcField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public enum tCDCEnum
        {

            /// <remarks/>
            SPS,

            /// <remarks/>
            DPS,

            /// <remarks/>
            INS,

            /// <remarks/>
            ENS,

            /// <remarks/>
            ACT,

            /// <remarks/>
            ACD,

            /// <remarks/>
            SEC,

            /// <remarks/>
            BCR,

            /// <remarks/>
            HST,

            /// <remarks/>
            VSS,

            /// <remarks/>
            MV,

            /// <remarks/>
            CMV,

            /// <remarks/>
            SAV,

            /// <remarks/>
            WYE,

            /// <remarks/>
            DEL,

            /// <remarks/>
            SEQ,

            /// <remarks/>
            HMV,

            /// <remarks/>
            HWYE,

            /// <remarks/>
            HDEL,

            /// <remarks/>
            SPC,

            /// <remarks/>
            DPC,

            /// <remarks/>
            INC,

            /// <remarks/>
            ENC,

            /// <remarks/>
            BSC,

            /// <remarks/>
            ISC,

            /// <remarks/>
            APC,

            /// <remarks/>
            BAC,

            /// <remarks/>
            SPG,

            /// <remarks/>
            ING,

            /// <remarks/>
            ENG,

            /// <remarks/>
            ORG,

            /// <remarks/>
            TSG,

            /// <remarks/>
            CUG,

            /// <remarks/>
            VSG,

            /// <remarks/>
            ASG,

            /// <remarks/>
            CURVE,

            /// <remarks/>
            CSG,

            /// <remarks/>
            DPL,

            /// <remarks/>
            LPL,

            /// <remarks/>
            CSD,

            /// <remarks/>
            CST,

            /// <remarks/>
            BTS,

            /// <remarks/>
            UTS,

            /// <remarks/>
            LTS,

            /// <remarks/>
            GTS,

            /// <remarks/>
            MTS,

            /// <remarks/>
            NTS,

            /// <remarks/>
            STS,

            /// <remarks/>
            CTS,

            /// <remarks/>
            OTS,

            /// <remarks/>
            VSD,

            /// <remarks/>
            ORS,

            /// <remarks/>
            TCS,
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tLNodeType : tIDNaming
        {

            private tDO[] doField;

            private string iedTypeField;

            private string lnClassField;

            public tLNodeType()
            {
                this.iedTypeField = "";
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("DO")]
            public tDO[] DO
            {
                get
                {
                    return this.doField;
                }
                set
                {
                    this.doField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            [System.ComponentModel.DefaultValueAttribute("")]
            public string iedType
            {
                get
                {
                    return this.iedTypeField;
                }
                set
                {
                    this.iedTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string lnClass
            {
                get
                {
                    return this.lnClassField;
                }
                set
                {
                    this.lnClassField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public partial class tDurationInSec : tValueWithUnit
        {
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        [System.Xml.Serialization.XmlRootAttribute("Process", Namespace = "http://www.iec.ch/61850/2003/SCL", IsNullable = false)]
        public partial class tProcess : tGeneralEquipmentContainer
        {

            private tConductingEquipment[] conductingEquipmentField;

            private tSubstation[] substationField;

            private tLine[] lineField;

            private tProcess[] processField;

            private string typeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("ConductingEquipment")]
            public tConductingEquipment[] ConductingEquipment
            {
                get
                {
                    return this.conductingEquipmentField;
                }
                set
                {
                    this.conductingEquipmentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Substation")]
            public tSubstation[] Substation
            {
                get
                {
                    return this.substationField;
                }
                set
                {
                    this.substationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Line")]
            public tLine[] Line
            {
                get
                {
                    return this.lineField;
                }
                set
                {
                    this.lineField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Process")]
            public tProcess[] Process
            {
                get
                {
                    return this.processField;
                }
                set
                {
                    this.processField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        [System.Xml.Serialization.XmlRootAttribute("Line", Namespace = "http://www.iec.ch/61850/2003/SCL", IsNullable = false)]
        public partial class tLine : tGeneralEquipmentContainer
        {

            private tVoltage voltageField;

            private tConductingEquipment[] conductingEquipmentField;

            private tConnectivityNode[] connectivityNodeField;

            private string typeField;

            private decimal nomFreqField;

            private bool nomFreqFieldSpecified;

            private byte numPhasesField;

            private bool numPhasesFieldSpecified;

            /// <remarks/>
            public tVoltage Voltage
            {
                get
                {
                    return this.voltageField;
                }
                set
                {
                    this.voltageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("ConductingEquipment")]
            public tConductingEquipment[] ConductingEquipment
            {
                get
                {
                    return this.conductingEquipmentField;
                }
                set
                {
                    this.conductingEquipmentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("ConnectivityNode")]
            public tConnectivityNode[] ConnectivityNode
            {
                get
                {
                    return this.connectivityNodeField;
                }
                set
                {
                    this.connectivityNodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal nomFreq
            {
                get
                {
                    return this.nomFreqField;
                }
                set
                {
                    this.nomFreqField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool nomFreqSpecified
            {
                get
                {
                    return this.nomFreqFieldSpecified;
                }
                set
                {
                    this.nomFreqFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte numPhases
            {
                get
                {
                    return this.numPhasesField;
                }
                set
                {
                    this.numPhasesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool numPhasesSpecified
            {
                get
                {
                    return this.numPhasesFieldSpecified;
                }
                set
                {
                    this.numPhasesFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        [System.Xml.Serialization.XmlRootAttribute("IED", Namespace = "http://www.iec.ch/61850/2003/SCL", IsNullable = false)]
        public partial class tIED : tUnNaming
        {

            private tServices servicesField;

            private tAccessPoint[] accessPointField;

            private tKDC[] kDCField;

            private string nameField;

            private string typeField;

            private string manufacturerField;

            private string configVersionField;

            private string originalSclVersionField;

            private string originalSclRevisionField;

            private byte originalSclReleaseField;

            private tRightEnum engRightField;

            private string ownerField;

            public tIED()
            {
                this.originalSclVersionField = "2003";
                this.originalSclRevisionField = "A";
                this.originalSclReleaseField = ((byte)(1));
                this.engRightField = tRightEnum.full;
            }

            /// <remarks/>
            public tServices Services
            {
                get
                {
                    return this.servicesField;
                }
                set
                {
                    this.servicesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("AccessPoint")]
            public tAccessPoint[] AccessPoint
            {
                get
                {
                    return this.accessPointField;
                }
                set
                {
                    this.accessPointField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("KDC")]
            public tKDC[] KDC
            {
                get
                {
                    return this.kDCField;
                }
                set
                {
                    this.kDCField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "Name")]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string manufacturer
            {
                get
                {
                    return this.manufacturerField;
                }
                set
                {
                    this.manufacturerField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string configVersion
            {
                get
                {
                    return this.configVersionField;
                }
                set
                {
                    this.configVersionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            [System.ComponentModel.DefaultValueAttribute("2003")]
            public string originalSclVersion
            {
                get
                {
                    return this.originalSclVersionField;
                }
                set
                {
                    this.originalSclVersionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "Name")]
            [System.ComponentModel.DefaultValueAttribute("A")]
            public string originalSclRevision
            {
                get
                {
                    return this.originalSclRevisionField;
                }
                set
                {
                    this.originalSclRevisionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(typeof(byte), "1")]
            public byte originalSclRelease
            {
                get
                {
                    return this.originalSclReleaseField;
                }
                set
                {
                    this.originalSclReleaseField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            [System.ComponentModel.DefaultValueAttribute(tRightEnum.full)]
            public tRightEnum engRight
            {
                get
                {
                    return this.engRightField;
                }
                set
                {
                    this.engRightField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string owner
            {
                get
                {
                    return this.ownerField;
                }
                set
                {
                    this.ownerField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        public enum tRightEnum
        {

            /// <remarks/>
            full,

            /// <remarks/>
            fix,

            /// <remarks/>
            dataflow,
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        [System.Xml.Serialization.XmlRootAttribute("Communication", Namespace = "http://www.iec.ch/61850/2003/SCL", IsNullable = false)]
        public partial class tCommunication : tUnNaming
        {

            private tSubNetwork[] subNetworkField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("SubNetwork")]
            public tSubNetwork[] SubNetwork
            {
                get
                {
                    return this.subNetworkField;
                }
                set
                {
                    this.subNetworkField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL")]
        [System.Xml.Serialization.XmlRootAttribute("DataTypeTemplates", Namespace = "http://www.iec.ch/61850/2003/SCL", IsNullable = false)]
        public partial class tDataTypeTemplates
        {

            private tLNodeType[] lNodeTypeField;

            private tDOType[] dOTypeField;

            private tDAType[] dATypeField;

            private tEnumType[] enumTypeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("LNodeType")]
            public tLNodeType[] LNodeType
            {
                get
                {
                    return this.lNodeTypeField;
                }
                set
                {
                    this.lNodeTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("DOType")]
            public tDOType[] DOType
            {
                get
                {
                    return this.dOTypeField;
                }
                set
                {
                    this.dOTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("DAType")]
            public tDAType[] DAType
            {
                get
                {
                    return this.dATypeField;
                }
                set
                {
                    this.dATypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("EnumType")]
            public tEnumType[] EnumType
            {
                get
                {
                    return this.enumTypeField;
                }
                set
                {
                    this.enumTypeField = value;
                }
            }
        }

        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iec.ch/61850/2003/SCL")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.iec.ch/61850/2003/SCL", IsNullable = false)]
        public partial class SCL : tBaseElement
        {

            private tHeader headerField;

            private tSubstation[] substationField;

            private tCommunication communicationField;

            private tIED[] iEDField;

            private tDataTypeTemplates dataTypeTemplatesField;

            private tLine[] lineField;

            private tProcess[] processField;

            private string versionField;

            private string revisionField;

            private byte releaseField;

            public SCL()
            {
                this.versionField = "2007";
                this.revisionField = "B";
                this.releaseField = ((byte)(4));
            }


            //[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Header")]
            public tHeader Header
            {
                get
                {
                    return this.headerField;
                }
                set
                {
                    this.headerField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Substation")]
            public tSubstation[] Substation
            {
                get
                {
                    return this.substationField;
                }
                set
                {
                    this.substationField = value;
                }
            }

            /// <remarks/>
            public tCommunication Communication
            {
                get
                {
                    return this.communicationField;
                }
                set
                {
                    this.communicationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("IED")]
            public tIED[] IED
            {
                get
                {
                    return this.iEDField;
                }
                set
                {
                    this.iEDField = value;
                }
            }

            /// <remarks/>
            public tDataTypeTemplates DataTypeTemplates
            {
                get
                {
                    return this.dataTypeTemplatesField;
                }
                set
                {
                    this.dataTypeTemplatesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Line")]
            public tLine[] Line
            {
                get
                {
                    return this.lineField;
                }
                set
                {
                    this.lineField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Process")]
            public tProcess[] Process
            {
                get
                {
                    return this.processField;
                }
                set
                {
                    this.processField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
            public string version
            {
                get
                {
                    return this.versionField;
                }
                set
                {
                    this.versionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "Name")]
            public string revision
            {
                get
                {
                    return this.revisionField;
                }
                set
                {
                    this.revisionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte release
            {
                get
                {
                    return this.releaseField;
                }
                set
                {
                    this.releaseField = value;
                }
            }
        }



    }
}
