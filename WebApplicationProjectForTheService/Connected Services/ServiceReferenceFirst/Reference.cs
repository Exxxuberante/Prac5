//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationProjectForTheService.ServiceReferenceFirst {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceFirst.WebServiceSoap")]
    public interface WebServiceSoap {
        
        // CODEGEN: Контракт генерации сообщений с именем HelloWorldResult из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        WebApplicationProjectForTheService.ServiceReferenceFirst.HelloWorldResponse HelloWorld(WebApplicationProjectForTheService.ServiceReferenceFirst.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApplicationProjectForTheService.ServiceReferenceFirst.HelloWorldResponse> HelloWorldAsync(WebApplicationProjectForTheService.ServiceReferenceFirst.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        double Add(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<double> AddAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Subst", ReplyAction="*")]
        double Subst(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Subst", ReplyAction="*")]
        System.Threading.Tasks.Task<double> SubstAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Div", ReplyAction="*")]
        double Div(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Div", ReplyAction="*")]
        System.Threading.Tasks.Task<double> DivAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Mult", ReplyAction="*")]
        double Mult(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Mult", ReplyAction="*")]
        System.Threading.Tasks.Task<double> MultAsync(double a, double b);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public WebApplicationProjectForTheService.ServiceReferenceFirst.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(WebApplicationProjectForTheService.ServiceReferenceFirst.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApplicationProjectForTheService.ServiceReferenceFirst.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(WebApplicationProjectForTheService.ServiceReferenceFirst.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : WebApplicationProjectForTheService.ServiceReferenceFirst.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<WebApplicationProjectForTheService.ServiceReferenceFirst.WebServiceSoap>, WebApplicationProjectForTheService.ServiceReferenceFirst.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplicationProjectForTheService.ServiceReferenceFirst.HelloWorldResponse WebApplicationProjectForTheService.ServiceReferenceFirst.WebServiceSoap.HelloWorld(WebApplicationProjectForTheService.ServiceReferenceFirst.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            WebApplicationProjectForTheService.ServiceReferenceFirst.HelloWorldRequest inValue = new WebApplicationProjectForTheService.ServiceReferenceFirst.HelloWorldRequest();
            inValue.Body = new WebApplicationProjectForTheService.ServiceReferenceFirst.HelloWorldRequestBody();
            WebApplicationProjectForTheService.ServiceReferenceFirst.HelloWorldResponse retVal = ((WebApplicationProjectForTheService.ServiceReferenceFirst.WebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplicationProjectForTheService.ServiceReferenceFirst.HelloWorldResponse> WebApplicationProjectForTheService.ServiceReferenceFirst.WebServiceSoap.HelloWorldAsync(WebApplicationProjectForTheService.ServiceReferenceFirst.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplicationProjectForTheService.ServiceReferenceFirst.HelloWorldResponse> HelloWorldAsync() {
            WebApplicationProjectForTheService.ServiceReferenceFirst.HelloWorldRequest inValue = new WebApplicationProjectForTheService.ServiceReferenceFirst.HelloWorldRequest();
            inValue.Body = new WebApplicationProjectForTheService.ServiceReferenceFirst.HelloWorldRequestBody();
            return ((WebApplicationProjectForTheService.ServiceReferenceFirst.WebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        public double Add(double a, double b) {
            return base.Channel.Add(a, b);
        }
        
        public System.Threading.Tasks.Task<double> AddAsync(double a, double b) {
            return base.Channel.AddAsync(a, b);
        }
        
        public double Subst(double a, double b) {
            return base.Channel.Subst(a, b);
        }
        
        public System.Threading.Tasks.Task<double> SubstAsync(double a, double b) {
            return base.Channel.SubstAsync(a, b);
        }
        
        public double Div(double a, double b) {
            return base.Channel.Div(a, b);
        }
        
        public System.Threading.Tasks.Task<double> DivAsync(double a, double b) {
            return base.Channel.DivAsync(a, b);
        }
        
        public double Mult(double a, double b) {
            return base.Channel.Mult(a, b);
        }
        
        public System.Threading.Tasks.Task<double> MultAsync(double a, double b) {
            return base.Channel.MultAsync(a, b);
        }
    }
}
