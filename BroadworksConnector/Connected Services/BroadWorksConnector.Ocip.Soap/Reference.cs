﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BroadWorksConnector.Ocip.Soap
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:com:broadsoft:webservice", ConfigurationName="BroadWorksConnector.Ocip.Soap.BWProvisioningService")]
    public interface BWProvisioningService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<BroadWorksConnector.Ocip.Soap.processMessageResponse> processMessageAsync(BroadWorksConnector.Ocip.Soap.processMessageRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<BroadWorksConnector.Ocip.Soap.processOCIMessageResponse> processOCIMessageAsync(BroadWorksConnector.Ocip.Soap.processOCIMessageRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class processMessageRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="processMessage", Namespace="urn:com:broadsoft:webservice", Order=0)]
        public BroadWorksConnector.Ocip.Soap.processMessageRequestBody Body;
        
        public processMessageRequest()
        {
        }
        
        public processMessageRequest(BroadWorksConnector.Ocip.Soap.processMessageRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="urn:com:broadsoft:webservice")]
    public partial class processMessageRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string in0;
        
        public processMessageRequestBody()
        {
        }
        
        public processMessageRequestBody(string in0)
        {
            this.in0 = in0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class processMessageResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="processMessageResponse", Namespace="urn:com:broadsoft:webservice", Order=0)]
        public BroadWorksConnector.Ocip.Soap.processMessageResponseBody Body;
        
        public processMessageResponse()
        {
        }
        
        public processMessageResponse(BroadWorksConnector.Ocip.Soap.processMessageResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="urn:com:broadsoft:webservice")]
    public partial class processMessageResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string processMessageReturn;
        
        public processMessageResponseBody()
        {
        }
        
        public processMessageResponseBody(string processMessageReturn)
        {
            this.processMessageReturn = processMessageReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class processOCIMessageRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="processOCIMessage", Namespace="urn:com:broadsoft:webservice", Order=0)]
        public BroadWorksConnector.Ocip.Soap.processOCIMessageRequestBody Body;
        
        public processOCIMessageRequest()
        {
        }
        
        public processOCIMessageRequest(BroadWorksConnector.Ocip.Soap.processOCIMessageRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="urn:com:broadsoft:webservice")]
    public partial class processOCIMessageRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string in0;
        
        public processOCIMessageRequestBody()
        {
        }
        
        public processOCIMessageRequestBody(string in0)
        {
            this.in0 = in0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class processOCIMessageResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="processOCIMessageResponse", Namespace="urn:com:broadsoft:webservice", Order=0)]
        public BroadWorksConnector.Ocip.Soap.processOCIMessageResponseBody Body;
        
        public processOCIMessageResponse()
        {
        }
        
        public processOCIMessageResponse(BroadWorksConnector.Ocip.Soap.processOCIMessageResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="urn:com:broadsoft:webservice")]
    public partial class processOCIMessageResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string processOCIMessageReturn;
        
        public processOCIMessageResponseBody()
        {
        }
        
        public processOCIMessageResponseBody(string processOCIMessageReturn)
        {
            this.processOCIMessageReturn = processOCIMessageReturn;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface BWProvisioningServiceChannel : BroadWorksConnector.Ocip.Soap.BWProvisioningService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class BWProvisioningServiceClient : System.ServiceModel.ClientBase<BroadWorksConnector.Ocip.Soap.BWProvisioningService>, BroadWorksConnector.Ocip.Soap.BWProvisioningService
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public BWProvisioningServiceClient() : 
                base(BWProvisioningServiceClient.GetDefaultBinding(), BWProvisioningServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.ProvisioningService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BWProvisioningServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(BWProvisioningServiceClient.GetBindingForEndpoint(endpointConfiguration), BWProvisioningServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BWProvisioningServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(BWProvisioningServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BWProvisioningServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(BWProvisioningServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BWProvisioningServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BroadWorksConnector.Ocip.Soap.processMessageResponse> BroadWorksConnector.Ocip.Soap.BWProvisioningService.processMessageAsync(BroadWorksConnector.Ocip.Soap.processMessageRequest request)
        {
            return base.Channel.processMessageAsync(request);
        }
        
        public System.Threading.Tasks.Task<BroadWorksConnector.Ocip.Soap.processMessageResponse> processMessageAsync(string in0)
        {
            BroadWorksConnector.Ocip.Soap.processMessageRequest inValue = new BroadWorksConnector.Ocip.Soap.processMessageRequest();
            inValue.Body = new BroadWorksConnector.Ocip.Soap.processMessageRequestBody();
            inValue.Body.in0 = in0;
            return ((BroadWorksConnector.Ocip.Soap.BWProvisioningService)(this)).processMessageAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BroadWorksConnector.Ocip.Soap.processOCIMessageResponse> BroadWorksConnector.Ocip.Soap.BWProvisioningService.processOCIMessageAsync(BroadWorksConnector.Ocip.Soap.processOCIMessageRequest request)
        {
            return base.Channel.processOCIMessageAsync(request);
        }
        
        public System.Threading.Tasks.Task<BroadWorksConnector.Ocip.Soap.processOCIMessageResponse> processOCIMessageAsync(string in0)
        {
            BroadWorksConnector.Ocip.Soap.processOCIMessageRequest inValue = new BroadWorksConnector.Ocip.Soap.processOCIMessageRequest();
            inValue.Body = new BroadWorksConnector.Ocip.Soap.processOCIMessageRequestBody();
            inValue.Body.in0 = in0;
            return ((BroadWorksConnector.Ocip.Soap.BWProvisioningService)(this)).processOCIMessageAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.ProvisioningService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        { 
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return BWProvisioningServiceClient.GetBindingForEndpoint(EndpointConfiguration.ProvisioningService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return BWProvisioningServiceClient.GetEndpointAddress(EndpointConfiguration.ProvisioningService);
        }
        
        public enum EndpointConfiguration
        {
            
            ProvisioningService,
        }
    }
}