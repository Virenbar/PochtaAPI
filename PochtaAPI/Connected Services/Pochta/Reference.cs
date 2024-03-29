﻿//------------------------------------------------------------------------------
// <автоматически создаваемое>
//     Этот код создан программой.
//     //
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторного создания кода.
// </автоматически создаваемое>
//------------------------------------------------------------------------------

namespace Pochta
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.russianpost.org/custom-duty-info/data")]
    public partial class CustomDutyEventsForMailFault
    {
        
        private CustomDutyEventsForMailErrors errorIDField;
        
        private bool errorIDFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CustomDutyEventsForMailErrors ErrorID
        {
            get
            {
                return this.errorIDField;
            }
            set
            {
                this.errorIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ErrorIDSpecified
        {
            get
            {
                return this.errorIDFieldSpecified;
            }
            set
            {
                this.errorIDFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.russianpost.org/custom-duty-info/data")]
    public enum CustomDutyEventsForMailErrors
    {
        
        /// <remarks/>
        BarcodeIsNull,
        
        /// <remarks/>
        InternalServiceError,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.russianpost.org/custom-duty-info/data")]
    public partial class CustomDutyEvent
    {
        
        private string numberField;
        
        private System.DateTime eventDateTimeField;
        
        private bool eventDateTimeFieldSpecified;
        
        private string eventTypeField;
        
        private string eventNameField;
        
        private string indexToField;
        
        private string indexEventField;
        
        private string countryEventCodeField;
        
        private string countryToCodeField;
        
        private string sumPaymentForwardField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime EventDateTime
        {
            get
            {
                return this.eventDateTimeField;
            }
            set
            {
                this.eventDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EventDateTimeSpecified
        {
            get
            {
                return this.eventDateTimeFieldSpecified;
            }
            set
            {
                this.eventDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string EventType
        {
            get
            {
                return this.eventTypeField;
            }
            set
            {
                this.eventTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EventName
        {
            get
            {
                return this.eventNameField;
            }
            set
            {
                this.eventNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IndexTo
        {
            get
            {
                return this.indexToField;
            }
            set
            {
                this.indexToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IndexEvent
        {
            get
            {
                return this.indexEventField;
            }
            set
            {
                this.indexEventField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CountryEventCode
        {
            get
            {
                return this.countryEventCodeField;
            }
            set
            {
                this.countryEventCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CountryToCode
        {
            get
            {
                return this.countryToCodeField;
            }
            set
            {
                this.countryToCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string SumPaymentForward
        {
            get
            {
                return this.sumPaymentForwardField;
            }
            set
            {
                this.sumPaymentForwardField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.russianpost.org/custom-duty-info/data")]
    public partial class CustomDutyEventsForMailInput
    {
        
        private string barcodeField;
        
        private string languageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Barcode
        {
            get
            {
                return this.barcodeField;
            }
            set
            {
                this.barcodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://russianpost.org/operationhistory/data")]
    public partial class UserParameters
    {
        
        private Rtm02Parameter sendCtgField;
        
        private string sndrField;
        
        private string rcpnField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public Rtm02Parameter SendCtg
        {
            get
            {
                return this.sendCtgField;
            }
            set
            {
                this.sendCtgField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Sndr
        {
            get
            {
                return this.sndrField;
            }
            set
            {
                this.sndrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Rcpn
        {
            get
            {
                return this.rcpnField;
            }
            set
            {
                this.rcpnField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://russianpost.org/operationhistory/data")]
    public partial class Rtm02Parameter
    {
        
        private int idField;
        
        private string nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Id
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
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Name
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://russianpost.org/operationhistory/data")]
    public partial class OperationParameters
    {
        
        private Rtm02Parameter operTypeField;
        
        private Rtm02Parameter operAttrField;
        
        private System.DateTime operDateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public Rtm02Parameter OperType
        {
            get
            {
                return this.operTypeField;
            }
            set
            {
                this.operTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public Rtm02Parameter OperAttr
        {
            get
            {
                return this.operAttrField;
            }
            set
            {
                this.operAttrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public System.DateTime OperDate
        {
            get
            {
                return this.operDateField;
            }
            set
            {
                this.operDateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://russianpost.org/operationhistory/data")]
    public partial class ItemParameters
    {
        
        private string barcodeField;
        
        private string internumField;
        
        private bool validRuTypeField;
        
        private bool validEnTypeField;
        
        private string complexItemNameField;
        
        private Rtm02Parameter mailRankField;
        
        private Rtm02Parameter postMarkField;
        
        private Rtm02Parameter mailTypeField;
        
        private Rtm02Parameter mailCtgField;
        
        private string massField;
        
        private string maxMassRUField;
        
        private string maxMassENField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Barcode
        {
            get
            {
                return this.barcodeField;
            }
            set
            {
                this.barcodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Internum
        {
            get
            {
                return this.internumField;
            }
            set
            {
                this.internumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool ValidRuType
        {
            get
            {
                return this.validRuTypeField;
            }
            set
            {
                this.validRuTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool ValidEnType
        {
            get
            {
                return this.validEnTypeField;
            }
            set
            {
                this.validEnTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string ComplexItemName
        {
            get
            {
                return this.complexItemNameField;
            }
            set
            {
                this.complexItemNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public Rtm02Parameter MailRank
        {
            get
            {
                return this.mailRankField;
            }
            set
            {
                this.mailRankField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public Rtm02Parameter PostMark
        {
            get
            {
                return this.postMarkField;
            }
            set
            {
                this.postMarkField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public Rtm02Parameter MailType
        {
            get
            {
                return this.mailTypeField;
            }
            set
            {
                this.mailTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public Rtm02Parameter MailCtg
        {
            get
            {
                return this.mailCtgField;
            }
            set
            {
                this.mailCtgField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=9)]
        public string Mass
        {
            get
            {
                return this.massField;
            }
            set
            {
                this.massField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=10)]
        public string MaxMassRU
        {
            get
            {
                return this.maxMassRUField;
            }
            set
            {
                this.maxMassRUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=11)]
        public string MaxMassEN
        {
            get
            {
                return this.maxMassENField;
            }
            set
            {
                this.maxMassENField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://russianpost.org/operationhistory/data")]
    public partial class FinanceParameters
    {
        
        private string paymentField;
        
        private string valueField;
        
        private string massRateField;
        
        private string insrRateField;
        
        private string airRateField;
        
        private string rateField;
        
        private string customDutyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=0)]
        public string Payment
        {
            get
            {
                return this.paymentField;
            }
            set
            {
                this.paymentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=1)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=2)]
        public string MassRate
        {
            get
            {
                return this.massRateField;
            }
            set
            {
                this.massRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=3)]
        public string InsrRate
        {
            get
            {
                return this.insrRateField;
            }
            set
            {
                this.insrRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=4)]
        public string AirRate
        {
            get
            {
                return this.airRateField;
            }
            set
            {
                this.airRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=5)]
        public string Rate
        {
            get
            {
                return this.rateField;
            }
            set
            {
                this.rateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=6)]
        public string CustomDuty
        {
            get
            {
                return this.customDutyField;
            }
            set
            {
                this.customDutyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://russianpost.org/operationhistory/data")]
    public partial class Country
    {
        
        private int idField;
        
        private string code2AField;
        
        private string code3AField;
        
        private string nameField;
        
        private string nameRUField;
        
        private string nameENField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Id
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
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Code2A
        {
            get
            {
                return this.code2AField;
            }
            set
            {
                this.code2AField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Code3A
        {
            get
            {
                return this.code3AField;
            }
            set
            {
                this.code3AField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Name
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
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string NameRU
        {
            get
            {
                return this.nameRUField;
            }
            set
            {
                this.nameRUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string NameEN
        {
            get
            {
                return this.nameENField;
            }
            set
            {
                this.nameENField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://russianpost.org/operationhistory/data")]
    public partial class Address
    {
        
        private string indexField;
        
        private string descriptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Index
        {
            get
            {
                return this.indexField;
            }
            set
            {
                this.indexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://russianpost.org/operationhistory/data")]
    public partial class AddressParameters
    {
        
        private Address destinationAddressField;
        
        private Address operationAddressField;
        
        private Country mailDirectField;
        
        private Country countryFromField;
        
        private Country countryOperField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public Address DestinationAddress
        {
            get
            {
                return this.destinationAddressField;
            }
            set
            {
                this.destinationAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public Address OperationAddress
        {
            get
            {
                return this.operationAddressField;
            }
            set
            {
                this.operationAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public Country MailDirect
        {
            get
            {
                return this.mailDirectField;
            }
            set
            {
                this.mailDirectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public Country CountryFrom
        {
            get
            {
                return this.countryFromField;
            }
            set
            {
                this.countryFromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public Country CountryOper
        {
            get
            {
                return this.countryOperField;
            }
            set
            {
                this.countryOperField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://russianpost.org/operationhistory/data")]
    public partial class OperationHistoryRecord
    {
        
        private AddressParameters addressParametersField;
        
        private FinanceParameters financeParametersField;
        
        private ItemParameters itemParametersField;
        
        private OperationParameters operationParametersField;
        
        private UserParameters userParametersField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public AddressParameters AddressParameters
        {
            get
            {
                return this.addressParametersField;
            }
            set
            {
                this.addressParametersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public FinanceParameters FinanceParameters
        {
            get
            {
                return this.financeParametersField;
            }
            set
            {
                this.financeParametersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public ItemParameters ItemParameters
        {
            get
            {
                return this.itemParametersField;
            }
            set
            {
                this.itemParametersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public OperationParameters OperationParameters
        {
            get
            {
                return this.operationParametersField;
            }
            set
            {
                this.operationParametersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public UserParameters UserParameters
        {
            get
            {
                return this.userParametersField;
            }
            set
            {
                this.userParametersField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.russianpost.org/RTM/DataExchangeESPP/Data")]
    public partial class PostalOrderEventsForMailError
    {
        
        private PostalOrderEventsForMailErrors errorIDField;
        
        private bool errorIDFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PostalOrderEventsForMailErrors ErrorID
        {
            get
            {
                return this.errorIDField;
            }
            set
            {
                this.errorIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ErrorIDSpecified
        {
            get
            {
                return this.errorIDFieldSpecified;
            }
            set
            {
                this.errorIDFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.russianpost.org/RTM/DataExchangeESPP/Data")]
    public enum PostalOrderEventsForMailErrors
    {
        
        /// <remarks/>
        InvalidLoginOrPassword,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://russianpost.org/operationhistory", ConfigurationName="Pochta.OperationHistory12")]
    internal interface OperationHistory12
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://russianpost.org/operationhistory/OperationHistory12/getOperationHistoryReq" +
            "uest", ReplyAction="http://russianpost.org/operationhistory/OperationHistory12/getOperationHistoryRes" +
            "ponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://russianpost.org/operationhistory/OperationHistory12/getOperationHistory/Fa" +
            "ult/OperationHistoryFault", Name="OperationHistoryFaultReason", Namespace="http://russianpost.org/operationhistory/data")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://russianpost.org/operationhistory/OperationHistory12/getOperationHistory/Fa" +
            "ult/AuthorizationFault", Name="AuthorizationFaultReason", Namespace="http://russianpost.org/operationhistory/data")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Pochta.getOperationHistoryResponse> getOperationHistoryAsync(Pochta.getOperationHistoryRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://russianpost.org/operationhistory/OperationHistory12/getLanguagesRequest", ReplyAction="http://russianpost.org/operationhistory/OperationHistory12/getLanguagesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://russianpost.org/operationhistory/OperationHistory12/getLanguages/Fault/Ope" +
            "rationHistoryFault", Name="OperationHistoryFaultReason", Namespace="http://russianpost.org/operationhistory/data")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://russianpost.org/operationhistory/OperationHistory12/getLanguages/Fault/Aut" +
            "horizationFault", Name="AuthorizationFaultReason", Namespace="http://russianpost.org/operationhistory/data")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://russianpost.org/operationhistory/OperationHistory12/getLanguages/Fault/Lan" +
            "guageFault", Name="LanguageFaultReason", Namespace="http://russianpost.org/operationhistory/data")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Pochta.getLanguagesResponse> getLanguagesAsync(Pochta.getLanguagesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://russianpost.org/operationhistory/OperationHistory12/getCustomDutyEventsFor" +
            "MailRequest", ReplyAction="http://russianpost.org/operationhistory/OperationHistory12/getCustomDutyEventsFor" +
            "MailResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Pochta.CustomDutyEventsForMailFault), Action="http://russianpost.org/operationhistory/OperationHistory12/getCustomDutyEventsFor" +
            "Mail/Fault/CustomDutyEventsForMailFault", Name="CustomDutyEventsForMailFault", Namespace="http://www.russianpost.org/custom-duty-info/data")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://russianpost.org/operationhistory/OperationHistory12/getCustomDutyEventsFor" +
            "Mail/Fault/AuthorizationFault", Name="AuthorizationFaultReason", Namespace="http://russianpost.org/operationhistory/data")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://russianpost.org/operationhistory/OperationHistory12/getCustomDutyEventsFor" +
            "Mail/Fault/LanguageFault", Name="LanguageFaultReason", Namespace="http://russianpost.org/operationhistory/data")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Pochta.getCustomDutyEventsForMailResponse> getCustomDutyEventsForMailAsync(Pochta.getCustomDutyEventsForMailRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://russianpost.org/operationhistory/OperationHistory12/getSmsHistoryRequest", ReplyAction="http://russianpost.org/operationhistory/OperationHistory12/getSmsHistoryResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://russianpost.org/operationhistory/OperationHistory12/getSmsHistory/Fault/Sm" +
            "sHistoryFault", Name="SmsHistoryFaultReason", Namespace="http://russianpost.org/sms-info/data")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://russianpost.org/operationhistory/OperationHistory12/getSmsHistory/Fault/Au" +
            "thorizationFault", Name="AuthorizationFaultReason", Namespace="http://russianpost.org/operationhistory/data")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://russianpost.org/operationhistory/OperationHistory12/getSmsHistory/Fault/La" +
            "nguageFault", Name="LanguageFaultReason", Namespace="http://russianpost.org/operationhistory/data")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Pochta.getSmsHistoryResponse> getSmsHistoryAsync(Pochta.getSmsHistoryRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://russianpost.org/operationhistory/OperationHistory12/PostalOrderEventsForMa" +
            "ilRequest", ReplyAction="http://russianpost.org/operationhistory/OperationHistory12/PostalOrderEventsForMa" +
            "ilResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Pochta.PostalOrderEventsForMailError[]), Action="http://russianpost.org/operationhistory/OperationHistory12/PostalOrderEventsForMa" +
            "il/Fault/PostalOrderEventsForMailFault", Name="PostalOrderEventsForMailFault", Namespace="http://www.russianpost.org/RTM/DataExchangeESPP/Data")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Pochta.PostalOrderEventsForMailResponse> PostalOrderEventsForMailAsync(Pochta.PostalOrderEventsForMailRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://russianpost.org/operationhistory/data")]
    public partial class OperationHistoryRequest
    {
        
        private string barcodeField;
        
        private int messageTypeField;
        
        private string languageField;
        
        public OperationHistoryRequest()
        {
            this.languageField = "RUS";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Barcode
        {
            get
            {
                return this.barcodeField;
            }
            set
            {
                this.barcodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int MessageType
        {
            get
            {
                return this.messageTypeField;
            }
            set
            {
                this.messageTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        [System.ComponentModel.DefaultValueAttribute("RUS")]
        public string Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://russianpost.org/operationhistory/data")]
    public partial class AuthorizationHeader
    {
        
        private string loginField;
        
        private string passwordField;
        
        private string mustUnderstandField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string login
        {
            get
            {
                return this.loginField;
            }
            set
            {
                this.loginField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string password
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
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://schemas.xmlsoap.org/soap/envelope/")]
        public string mustUnderstand
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
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getOperationHistory", WrapperNamespace="http://russianpost.org/operationhistory", IsWrapped=true)]
    internal partial class getOperationHistoryRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://russianpost.org/operationhistory/data", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://russianpost.org/operationhistory/data")]
        public Pochta.OperationHistoryRequest OperationHistoryRequest;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://russianpost.org/operationhistory/data", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://russianpost.org/operationhistory/data")]
        public Pochta.AuthorizationHeader AuthorizationHeader;
        
        public getOperationHistoryRequest()
        {
        }
        
        public getOperationHistoryRequest(Pochta.OperationHistoryRequest OperationHistoryRequest, Pochta.AuthorizationHeader AuthorizationHeader)
        {
            this.OperationHistoryRequest = OperationHistoryRequest;
            this.AuthorizationHeader = AuthorizationHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getOperationHistoryResponse", WrapperNamespace="http://russianpost.org/operationhistory", IsWrapped=true)]
    internal partial class getOperationHistoryResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://russianpost.org/operationhistory/data", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://russianpost.org/operationhistory/data")]
        [System.Xml.Serialization.XmlArrayItemAttribute("historyRecord")]
        public Pochta.OperationHistoryRecord[] OperationHistoryData;
        
        public getOperationHistoryResponse()
        {
        }
        
        public getOperationHistoryResponse(Pochta.OperationHistoryRecord[] OperationHistoryData)
        {
            this.OperationHistoryData = OperationHistoryData;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://russianpost.org/operationhistory/data")]
    public partial class LanguageDataLanguage
    {
        
        private string nameField;
        
        private string codeField;
        
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
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getLanguages", WrapperNamespace="http://russianpost.org/operationhistory", IsWrapped=true)]
    internal partial class getLanguagesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://russianpost.org/operationhistory/data", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://russianpost.org/operationhistory/data")]
        public Pochta.AuthorizationHeader AuthorizationHeader;
        
        public getLanguagesRequest()
        {
        }
        
        public getLanguagesRequest(Pochta.AuthorizationHeader AuthorizationHeader)
        {
            this.AuthorizationHeader = AuthorizationHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getLanguagesResponse", WrapperNamespace="http://russianpost.org/operationhistory", IsWrapped=true)]
    internal partial class getLanguagesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://russianpost.org/operationhistory/data", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://russianpost.org/operationhistory/data")]
        [System.Xml.Serialization.XmlArrayItemAttribute("Language", IsNullable=false)]
        public Pochta.LanguageDataLanguage[] LanguageData;
        
        public getLanguagesResponse()
        {
        }
        
        public getLanguagesResponse(Pochta.LanguageDataLanguage[] LanguageData)
        {
            this.LanguageData = LanguageData;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCustomDutyEventsForMail", WrapperNamespace="http://russianpost.org/operationhistory", IsWrapped=true)]
    internal partial class getCustomDutyEventsForMailRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://russianpost.org/operationhistory/data", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://russianpost.org/operationhistory/data")]
        public Pochta.AuthorizationHeader AuthorizationHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.russianpost.org/custom-duty-info/data", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.russianpost.org/custom-duty-info/data")]
        public Pochta.CustomDutyEventsForMailInput CustomDutyEventsForMailInput;
        
        public getCustomDutyEventsForMailRequest()
        {
        }
        
        public getCustomDutyEventsForMailRequest(Pochta.AuthorizationHeader AuthorizationHeader, Pochta.CustomDutyEventsForMailInput CustomDutyEventsForMailInput)
        {
            this.AuthorizationHeader = AuthorizationHeader;
            this.CustomDutyEventsForMailInput = CustomDutyEventsForMailInput;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCustomDutyEventsForMailResponse", WrapperNamespace="http://russianpost.org/operationhistory", IsWrapped=true)]
    internal partial class getCustomDutyEventsForMailResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.russianpost.org/custom-duty-info/data", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://www.russianpost.org/custom-duty-info/data")]
        [System.Xml.Serialization.XmlArrayItemAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public Pochta.CustomDutyEvent[] CustomDutyEventsForMailOutput;
        
        public getCustomDutyEventsForMailResponse()
        {
        }
        
        public getCustomDutyEventsForMailResponse(Pochta.CustomDutyEvent[] CustomDutyEventsForMailOutput)
        {
            this.CustomDutyEventsForMailOutput = CustomDutyEventsForMailOutput;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://russianpost.org/sms-info/data")]
    public partial class SmsHistoryRequest
    {
        
        private string barcodeField;
        
        private string languageField;
        
        public SmsHistoryRequest()
        {
            this.languageField = "RUS";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Barcode
        {
            get
            {
                return this.barcodeField;
            }
            set
            {
                this.barcodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        [System.ComponentModel.DefaultValueAttribute("RUS")]
        public string Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://russianpost.org/sms-info/data")]
    public partial class SmsHistoryRecord
    {
        
        private string idField;
        
        private string numberField;
        
        private string notificationTypeIDField;
        
        private string notificationTypeNameField;
        
        private string notificationStatusIDField;
        
        private string notificationStatusNameField;
        
        private System.DateTime notificationStatusDateField;
        
        private string sendedIDField;
        
        private string sourceOperationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=0)]
        public string Id
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
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=2)]
        public string NotificationTypeID
        {
            get
            {
                return this.notificationTypeIDField;
            }
            set
            {
                this.notificationTypeIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string NotificationTypeName
        {
            get
            {
                return this.notificationTypeNameField;
            }
            set
            {
                this.notificationTypeNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=4)]
        public string NotificationStatusID
        {
            get
            {
                return this.notificationStatusIDField;
            }
            set
            {
                this.notificationStatusIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string NotificationStatusName
        {
            get
            {
                return this.notificationStatusNameField;
            }
            set
            {
                this.notificationStatusNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public System.DateTime NotificationStatusDate
        {
            get
            {
                return this.notificationStatusDateField;
            }
            set
            {
                this.notificationStatusDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=7)]
        public string SendedID
        {
            get
            {
                return this.sendedIDField;
            }
            set
            {
                this.sendedIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string SourceOperation
        {
            get
            {
                return this.sourceOperationField;
            }
            set
            {
                this.sourceOperationField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getSmsHistory", WrapperNamespace="http://russianpost.org/operationhistory", IsWrapped=true)]
    internal partial class getSmsHistoryRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://russianpost.org/operationhistory/data", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://russianpost.org/operationhistory/data")]
        public Pochta.AuthorizationHeader AuthorizationHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://russianpost.org/sms-info/data", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://russianpost.org/sms-info/data")]
        public Pochta.SmsHistoryRequest SmsHistoryRequest;
        
        public getSmsHistoryRequest()
        {
        }
        
        public getSmsHistoryRequest(Pochta.AuthorizationHeader AuthorizationHeader, Pochta.SmsHistoryRequest SmsHistoryRequest)
        {
            this.AuthorizationHeader = AuthorizationHeader;
            this.SmsHistoryRequest = SmsHistoryRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getSmsHistoryResponse", WrapperNamespace="http://russianpost.org/operationhistory", IsWrapped=true)]
    internal partial class getSmsHistoryResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://russianpost.org/sms-info/data", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://russianpost.org/sms-info/data")]
        [System.Xml.Serialization.XmlArrayItemAttribute("historyRecord")]
        public Pochta.SmsHistoryRecord[] SmsHistoryData;
        
        public getSmsHistoryResponse()
        {
        }
        
        public getSmsHistoryResponse(Pochta.SmsHistoryRecord[] SmsHistoryData)
        {
            this.SmsHistoryData = SmsHistoryData;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.russianpost.org/RTM/DataExchangeESPP/Data")]
    public partial class PostalOrderEventsForMailInput
    {
        
        private string barcodeField;
        
        private string languageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Barcode
        {
            get
            {
                return this.barcodeField;
            }
            set
            {
                this.barcodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.russianpost.org/RTM/DataExchangeESPP/Data")]
    public partial class PostalOrderEvent
    {
        
        private string numberField;
        
        private System.DateTime eventDateTimeField;
        
        private bool eventDateTimeFieldSpecified;
        
        private string eventTypeField;
        
        private string eventNameField;
        
        private string indexToField;
        
        private string indexEventField;
        
        private string sumPaymentForwardField;
        
        private string countryEventCodeField;
        
        private string countryToCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime EventDateTime
        {
            get
            {
                return this.eventDateTimeField;
            }
            set
            {
                this.eventDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EventDateTimeSpecified
        {
            get
            {
                return this.eventDateTimeFieldSpecified;
            }
            set
            {
                this.eventDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string EventType
        {
            get
            {
                return this.eventTypeField;
            }
            set
            {
                this.eventTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EventName
        {
            get
            {
                return this.eventNameField;
            }
            set
            {
                this.eventNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string IndexTo
        {
            get
            {
                return this.indexToField;
            }
            set
            {
                this.indexToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string IndexEvent
        {
            get
            {
                return this.indexEventField;
            }
            set
            {
                this.indexEventField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string SumPaymentForward
        {
            get
            {
                return this.sumPaymentForwardField;
            }
            set
            {
                this.sumPaymentForwardField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CountryEventCode
        {
            get
            {
                return this.countryEventCodeField;
            }
            set
            {
                this.countryEventCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CountryToCode
        {
            get
            {
                return this.countryToCodeField;
            }
            set
            {
                this.countryToCodeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="PostalOrderEventsForMail", WrapperNamespace="http://russianpost.org/operationhistory", IsWrapped=true)]
    internal partial class PostalOrderEventsForMailRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://russianpost.org/operationhistory/data", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://russianpost.org/operationhistory/data")]
        public Pochta.AuthorizationHeader AuthorizationHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.russianpost.org/RTM/DataExchangeESPP/Data", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.russianpost.org/RTM/DataExchangeESPP/Data")]
        public Pochta.PostalOrderEventsForMailInput PostalOrderEventsForMailInput;
        
        public PostalOrderEventsForMailRequest()
        {
        }
        
        public PostalOrderEventsForMailRequest(Pochta.AuthorizationHeader AuthorizationHeader, Pochta.PostalOrderEventsForMailInput PostalOrderEventsForMailInput)
        {
            this.AuthorizationHeader = AuthorizationHeader;
            this.PostalOrderEventsForMailInput = PostalOrderEventsForMailInput;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="PostalOrderEventsForMailResponse", WrapperNamespace="http://russianpost.org/operationhistory", IsWrapped=true)]
    internal partial class PostalOrderEventsForMailResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.russianpost.org/RTM/DataExchangeESPP/Data", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://www.russianpost.org/RTM/DataExchangeESPP/Data")]
        [System.Xml.Serialization.XmlArrayItemAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public Pochta.PostalOrderEvent[] PostalOrderEventsForMaiOutput;
        
        public PostalOrderEventsForMailResponse()
        {
        }
        
        public PostalOrderEventsForMailResponse(Pochta.PostalOrderEvent[] PostalOrderEventsForMaiOutput)
        {
            this.PostalOrderEventsForMaiOutput = PostalOrderEventsForMaiOutput;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    internal interface OperationHistory12Channel : Pochta.OperationHistory12, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    internal partial class OperationHistory12Client : System.ServiceModel.ClientBase<Pochta.OperationHistory12>, Pochta.OperationHistory12
    {
        
    /// <summary>
    /// Реализуйте этот разделяемый метод для настройки конечной точки службы.
    /// </summary>
    /// <param name="serviceEndpoint">Настраиваемая конечная точка</param>
    /// <param name="clientCredentials">Учетные данные клиента.</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public OperationHistory12Client() : 
                base(OperationHistory12Client.GetDefaultBinding(), OperationHistory12Client.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.OperationHistory12Port.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public OperationHistory12Client(EndpointConfiguration endpointConfiguration) : 
                base(OperationHistory12Client.GetBindingForEndpoint(endpointConfiguration), OperationHistory12Client.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public OperationHistory12Client(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(OperationHistory12Client.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public OperationHistory12Client(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(OperationHistory12Client.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public OperationHistory12Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Pochta.getOperationHistoryResponse> Pochta.OperationHistory12.getOperationHistoryAsync(Pochta.getOperationHistoryRequest request)
        {
            return base.Channel.getOperationHistoryAsync(request);
        }
        
        public System.Threading.Tasks.Task<Pochta.getOperationHistoryResponse> getOperationHistoryAsync(Pochta.OperationHistoryRequest OperationHistoryRequest, Pochta.AuthorizationHeader AuthorizationHeader)
        {
            Pochta.getOperationHistoryRequest inValue = new Pochta.getOperationHistoryRequest();
            inValue.OperationHistoryRequest = OperationHistoryRequest;
            inValue.AuthorizationHeader = AuthorizationHeader;
            return ((Pochta.OperationHistory12)(this)).getOperationHistoryAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Pochta.getLanguagesResponse> Pochta.OperationHistory12.getLanguagesAsync(Pochta.getLanguagesRequest request)
        {
            return base.Channel.getLanguagesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Pochta.getLanguagesResponse> getLanguagesAsync(Pochta.AuthorizationHeader AuthorizationHeader)
        {
            Pochta.getLanguagesRequest inValue = new Pochta.getLanguagesRequest();
            inValue.AuthorizationHeader = AuthorizationHeader;
            return ((Pochta.OperationHistory12)(this)).getLanguagesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Pochta.getCustomDutyEventsForMailResponse> Pochta.OperationHistory12.getCustomDutyEventsForMailAsync(Pochta.getCustomDutyEventsForMailRequest request)
        {
            return base.Channel.getCustomDutyEventsForMailAsync(request);
        }
        
        public System.Threading.Tasks.Task<Pochta.getCustomDutyEventsForMailResponse> getCustomDutyEventsForMailAsync(Pochta.AuthorizationHeader AuthorizationHeader, Pochta.CustomDutyEventsForMailInput CustomDutyEventsForMailInput)
        {
            Pochta.getCustomDutyEventsForMailRequest inValue = new Pochta.getCustomDutyEventsForMailRequest();
            inValue.AuthorizationHeader = AuthorizationHeader;
            inValue.CustomDutyEventsForMailInput = CustomDutyEventsForMailInput;
            return ((Pochta.OperationHistory12)(this)).getCustomDutyEventsForMailAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Pochta.getSmsHistoryResponse> Pochta.OperationHistory12.getSmsHistoryAsync(Pochta.getSmsHistoryRequest request)
        {
            return base.Channel.getSmsHistoryAsync(request);
        }
        
        public System.Threading.Tasks.Task<Pochta.getSmsHistoryResponse> getSmsHistoryAsync(Pochta.AuthorizationHeader AuthorizationHeader, Pochta.SmsHistoryRequest SmsHistoryRequest)
        {
            Pochta.getSmsHistoryRequest inValue = new Pochta.getSmsHistoryRequest();
            inValue.AuthorizationHeader = AuthorizationHeader;
            inValue.SmsHistoryRequest = SmsHistoryRequest;
            return ((Pochta.OperationHistory12)(this)).getSmsHistoryAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Pochta.PostalOrderEventsForMailResponse> Pochta.OperationHistory12.PostalOrderEventsForMailAsync(Pochta.PostalOrderEventsForMailRequest request)
        {
            return base.Channel.PostalOrderEventsForMailAsync(request);
        }
        
        public System.Threading.Tasks.Task<Pochta.PostalOrderEventsForMailResponse> PostalOrderEventsForMailAsync(Pochta.AuthorizationHeader AuthorizationHeader, Pochta.PostalOrderEventsForMailInput PostalOrderEventsForMailInput)
        {
            Pochta.PostalOrderEventsForMailRequest inValue = new Pochta.PostalOrderEventsForMailRequest();
            inValue.AuthorizationHeader = AuthorizationHeader;
            inValue.PostalOrderEventsForMailInput = PostalOrderEventsForMailInput;
            return ((Pochta.OperationHistory12)(this)).PostalOrderEventsForMailAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.OperationHistory12Port))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpsTransportBindingElement httpsBindingElement = new System.ServiceModel.Channels.HttpsTransportBindingElement();
                httpsBindingElement.AllowCookies = true;
                httpsBindingElement.MaxBufferSize = int.MaxValue;
                httpsBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpsBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.OperationHistory12Port))
            {
                return new System.ServiceModel.EndpointAddress("https://tracking.russianpost.ru/rtm34");
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return OperationHistory12Client.GetBindingForEndpoint(EndpointConfiguration.OperationHistory12Port);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return OperationHistory12Client.GetEndpointAddress(EndpointConfiguration.OperationHistory12Port);
        }
        
        public enum EndpointConfiguration
        {
            
            OperationHistory12Port,
        }
    }
}
