//------------------------------------------------------------------------------
// <автоматически создаваемое>
//     Этот код создан программой.
//     //
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторного создания кода.
// </автоматически создаваемое>
//------------------------------------------------------------------------------

namespace PochtaPacket
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://fclient.russianpost.org", ConfigurationName="PochtaPacket.FederalClient")]
    internal interface FederalClient
    {
        
        // CODEGEN: Создается контракт сообщения, так как операция имеет много возвращаемых значений.
        [System.ServiceModel.OperationContractAttribute(Action="http://fclient.russianpost.org/FederalClient/getTicketRequest", ReplyAction="http://fclient.russianpost.org/FederalClient/getTicketResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<PochtaPacket.getTicketResponse> getTicketAsync(PochtaPacket.getTicketRequest request);
        
        // CODEGEN: Создается контракт сообщения, так как операция имеет много возвращаемых значений.
        [System.ServiceModel.OperationContractAttribute(Action="http://fclient.russianpost.org/FederalClient/getResponseByTicketRequest", ReplyAction="http://fclient.russianpost.org/FederalClient/getResponseByTicketResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<PochtaPacket.getResponseByTicketResponse> getResponseByTicketAsync(PochtaPacket.getResponseByTicketRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fclient.russianpost.org")]
    public partial class file
    {
        
        private item[] itemField;
        
        private string fileNameField;
        
        private string fileTypeIDField;
        
        private string fileNumberField;
        
        private string senderIDField;
        
        private string recipientIDField;
        
        private string datePreparationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Item", Order=0)]
        public item[] Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string FileTypeID
        {
            get
            {
                return this.fileTypeIDField;
            }
            set
            {
                this.fileTypeIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string FileNumber
        {
            get
            {
                return this.fileNumberField;
            }
            set
            {
                this.fileNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string SenderID
        {
            get
            {
                return this.senderIDField;
            }
            set
            {
                this.senderIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string RecipientID
        {
            get
            {
                return this.recipientIDField;
            }
            set
            {
                this.recipientIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DatePreparation
        {
            get
            {
                return this.datePreparationField;
            }
            set
            {
                this.datePreparationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fclient.russianpost.org")]
    public partial class item
    {
        
        private operation[] operationField;
        
        private error[] errorField;
        
        private string barcodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Operation", Order=0)]
        public operation[] Operation
        {
            get
            {
                return this.operationField;
            }
            set
            {
                this.operationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Error", Order=1)]
        public error[] Error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }
        
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fclient.russianpost.org")]
    public partial class operation
    {
        
        private string operTypeIDField;
        
        private string operCtgIDField;
        
        private string operNameField;
        
        private string dateOperField;
        
        private string indexOperField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string OperTypeID
        {
            get
            {
                return this.operTypeIDField;
            }
            set
            {
                this.operTypeIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string OperCtgID
        {
            get
            {
                return this.operCtgIDField;
            }
            set
            {
                this.operCtgIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OperName
        {
            get
            {
                return this.operNameField;
            }
            set
            {
                this.operNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DateOper
        {
            get
            {
                return this.dateOperField;
            }
            set
            {
                this.dateOperField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IndexOper
        {
            get
            {
                return this.indexOperField;
            }
            set
            {
                this.indexOperField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fclient.russianpost.org")]
    public partial class error
    {
        
        private string errorTypeIDField;
        
        private string errorNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string ErrorTypeID
        {
            get
            {
                return this.errorTypeIDField;
            }
            set
            {
                this.errorTypeIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ErrorName
        {
            get
            {
                return this.errorNameField;
            }
            set
            {
                this.errorNameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ticketRequest", WrapperNamespace="http://fclient.russianpost.org/postserver", IsWrapped=true)]
    internal partial class getTicketRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://fclient.russianpost.org/postserver", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PochtaPacket.file request;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://fclient.russianpost.org/postserver", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string login;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://fclient.russianpost.org/postserver", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string password;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://fclient.russianpost.org/postserver", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.ComponentModel.DefaultValueAttribute("RUS")]
        public string language;
        
        public getTicketRequest()
        {
        }
        
        public getTicketRequest(PochtaPacket.file request, string login, string password, string language)
        {
            this.request = request;
            this.login = login;
            this.password = password;
            this.language = language;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ticketResponse", WrapperNamespace="http://fclient.russianpost.org/postserver", IsWrapped=true)]
    internal partial class getTicketResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://fclient.russianpost.org/postserver", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string value;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://fclient.russianpost.org/postserver", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PochtaPacket.error error;
        
        public getTicketResponse()
        {
        }
        
        public getTicketResponse(string value, PochtaPacket.error error)
        {
            this.value = value;
            this.error = error;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="answerByTicketRequest", WrapperNamespace="http://fclient.russianpost.org/postserver", IsWrapped=true)]
    internal partial class getResponseByTicketRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://fclient.russianpost.org/postserver", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ticket;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://fclient.russianpost.org/postserver", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string login;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://fclient.russianpost.org/postserver", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string password;
        
        public getResponseByTicketRequest()
        {
        }
        
        public getResponseByTicketRequest(string ticket, string login, string password)
        {
            this.ticket = ticket;
            this.login = login;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="answerByTicketResponse", WrapperNamespace="http://fclient.russianpost.org/postserver", IsWrapped=true)]
    internal partial class getResponseByTicketResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://fclient.russianpost.org/postserver", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PochtaPacket.file value;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://fclient.russianpost.org/postserver", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PochtaPacket.error error;
        
        public getResponseByTicketResponse()
        {
        }
        
        public getResponseByTicketResponse(PochtaPacket.file value, PochtaPacket.error error)
        {
            this.value = value;
            this.error = error;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    internal interface FederalClientChannel : PochtaPacket.FederalClient, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    internal partial class FederalClientClient : System.ServiceModel.ClientBase<PochtaPacket.FederalClient>, PochtaPacket.FederalClient
    {
        
    /// <summary>
    /// Реализуйте этот разделяемый метод для настройки конечной точки службы.
    /// </summary>
    /// <param name="serviceEndpoint">Настраиваемая конечная точка</param>
    /// <param name="clientCredentials">Учетные данные клиента.</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public FederalClientClient() : 
                base(FederalClientClient.GetDefaultBinding(), FederalClientClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.ItemDataServicePort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FederalClientClient(EndpointConfiguration endpointConfiguration) : 
                base(FederalClientClient.GetBindingForEndpoint(endpointConfiguration), FederalClientClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FederalClientClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(FederalClientClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FederalClientClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(FederalClientClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FederalClientClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<PochtaPacket.getTicketResponse> getTicketAsync(PochtaPacket.getTicketRequest request)
        {
            return base.Channel.getTicketAsync(request);
        }
        
        public System.Threading.Tasks.Task<PochtaPacket.getResponseByTicketResponse> getResponseByTicketAsync(PochtaPacket.getResponseByTicketRequest request)
        {
            return base.Channel.getResponseByTicketAsync(request);
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
            if ((endpointConfiguration == EndpointConfiguration.ItemDataServicePort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ItemDataServicePort))
            {
                return new System.ServiceModel.EndpointAddress("https://tracking.russianpost.ru/fc");
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return FederalClientClient.GetBindingForEndpoint(EndpointConfiguration.ItemDataServicePort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return FederalClientClient.GetEndpointAddress(EndpointConfiguration.ItemDataServicePort);
        }
        
        public enum EndpointConfiguration
        {
            
            ItemDataServicePort,
        }
    }
}
