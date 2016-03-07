﻿//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.AsyncStream {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AsyncStream.IContract")]
    public interface IContract {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/Ping", ReplyAction="http://tempuri.org/IContract/PingResponse")]
        bool Ping();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/Ping", ReplyAction="http://tempuri.org/IContract/PingResponse")]
        System.Threading.Tasks.Task<bool> PingAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/FileList", ReplyAction="http://tempuri.org/IContract/FileListResponse")]
        string[] FileList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/FileList", ReplyAction="http://tempuri.org/IContract/FileListResponse")]
        System.Threading.Tasks.Task<string[]> FileListAsync();
        
        // CODEGEN: EvFileDownloadRequestMessage 메시지의 래퍼 이름(EvFileDownloadRequestMessage)이 기본값(FileDownload)과 일치하지 않으므로 메시지 계약을 생성합니다.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/FileDownload", ReplyAction="http://tempuri.org/IContract/FileDownloadResponse")]
        Client.AsyncStream.EvFileDownloadResponseMessage FileDownload(Client.AsyncStream.EvFileDownloadRequestMessage request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/FileDownload", ReplyAction="http://tempuri.org/IContract/FileDownloadResponse")]
        System.Threading.Tasks.Task<Client.AsyncStream.EvFileDownloadResponseMessage> FileDownloadAsync(Client.AsyncStream.EvFileDownloadRequestMessage request);
        
        // CODEGEN: EvFileUploadRequestMessage 메시지의 래퍼 이름(EvFileUploadRequestMessage)이 기본값(FileUpload)과 일치하지 않으므로 메시지 계약을 생성합니다.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/FileUpload", ReplyAction="http://tempuri.org/IContract/FileUploadResponse")]
        Client.AsyncStream.EvFileUploaResponseMessage FileUpload(Client.AsyncStream.EvFileUploadRequestMessage request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/FileUpload", ReplyAction="http://tempuri.org/IContract/FileUploadResponse")]
        System.Threading.Tasks.Task<Client.AsyncStream.EvFileUploaResponseMessage> FileUploadAsync(Client.AsyncStream.EvFileUploadRequestMessage request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/StreamTestSync01", ReplyAction="http://tempuri.org/IContract/StreamTestSync01Response")]
        System.IO.Stream StreamTestSync01();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/StreamTestSync01", ReplyAction="http://tempuri.org/IContract/StreamTestSync01Response")]
        System.Threading.Tasks.Task<System.IO.Stream> StreamTestSync01Async();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/StreamTestSync02", ReplyAction="http://tempuri.org/IContract/StreamTestSync02Response")]
        void StreamTestSync02(System.IO.Stream s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/StreamTestSync02", ReplyAction="http://tempuri.org/IContract/StreamTestSync02Response")]
        System.Threading.Tasks.Task StreamTestSync02Async(System.IO.Stream s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/StreamTestAsync01", ReplyAction="http://tempuri.org/IContract/StreamTestAsync01Response")]
        System.IO.Stream StreamTestAsync01();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/StreamTestAsync01", ReplyAction="http://tempuri.org/IContract/StreamTestAsync01Response")]
        System.Threading.Tasks.Task<System.IO.Stream> StreamTestAsync01Async();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/StreamTestAsync02", ReplyAction="http://tempuri.org/IContract/StreamTestAsync02Response")]
        void StreamTestAsync02(System.IO.Stream m);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/StreamTestAsync02", ReplyAction="http://tempuri.org/IContract/StreamTestAsync02Response")]
        System.Threading.Tasks.Task StreamTestAsync02Async(System.IO.Stream m);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/DownLoadFileTest", ReplyAction="http://tempuri.org/IContract/DownLoadFileTestResponse")]
        System.IO.Stream DownLoadFileTest(string fn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/DownLoadFileTest", ReplyAction="http://tempuri.org/IContract/DownLoadFileTestResponse")]
        System.Threading.Tasks.Task<System.IO.Stream> DownLoadFileTestAsync(string fn);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EvFileDownloadRequestMessage", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class EvFileDownloadRequestMessage {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string FileName;
        
        public EvFileDownloadRequestMessage() {
        }
        
        public EvFileDownloadRequestMessage(string FileName) {
            this.FileName = FileName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EvFileDownloadResponseMessage", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class EvFileDownloadResponseMessage {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public bool Exist;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string FileName;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public long Size;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.IO.Stream Content;
        
        public EvFileDownloadResponseMessage() {
        }
        
        public EvFileDownloadResponseMessage(bool Exist, string FileName, long Size, System.IO.Stream Content) {
            this.Exist = Exist;
            this.FileName = FileName;
            this.Size = Size;
            this.Content = Content;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EvFileUploadRequestMessage", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class EvFileUploadRequestMessage {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string FileName;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public long Size;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.IO.Stream Content;
        
        public EvFileUploadRequestMessage() {
        }
        
        public EvFileUploadRequestMessage(string FileName, long Size, System.IO.Stream Content) {
            this.FileName = FileName;
            this.Size = Size;
            this.Content = Content;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EvFileUploaResponseMessage", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class EvFileUploaResponseMessage {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string FileName;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public long Size;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public bool Success;
        
        public EvFileUploaResponseMessage() {
        }
        
        public EvFileUploaResponseMessage(string FileName, long Size, bool Success) {
            this.FileName = FileName;
            this.Size = Size;
            this.Success = Success;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IContractChannel : Client.AsyncStream.IContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ContractClient : System.ServiceModel.ClientBase<Client.AsyncStream.IContract>, Client.AsyncStream.IContract {
        
        public ContractClient() {
        }
        
        public ContractClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ContractClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Ping() {
            return base.Channel.Ping();
        }
        
        public System.Threading.Tasks.Task<bool> PingAsync() {
            return base.Channel.PingAsync();
        }
        
        public string[] FileList() {
            return base.Channel.FileList();
        }
        
        public System.Threading.Tasks.Task<string[]> FileListAsync() {
            return base.Channel.FileListAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Client.AsyncStream.EvFileDownloadResponseMessage Client.AsyncStream.IContract.FileDownload(Client.AsyncStream.EvFileDownloadRequestMessage request) {
            return base.Channel.FileDownload(request);
        }
        
        public bool FileDownload(ref string FileName, out long Size, out System.IO.Stream Content) {
            Client.AsyncStream.EvFileDownloadRequestMessage inValue = new Client.AsyncStream.EvFileDownloadRequestMessage();
            inValue.FileName = FileName;
            Client.AsyncStream.EvFileDownloadResponseMessage retVal = ((Client.AsyncStream.IContract)(this)).FileDownload(inValue);
            FileName = retVal.FileName;
            Size = retVal.Size;
            Content = retVal.Content;
            return retVal.Exist;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Client.AsyncStream.EvFileDownloadResponseMessage> Client.AsyncStream.IContract.FileDownloadAsync(Client.AsyncStream.EvFileDownloadRequestMessage request) {
            return base.Channel.FileDownloadAsync(request);
        }
        
        public System.Threading.Tasks.Task<Client.AsyncStream.EvFileDownloadResponseMessage> FileDownloadAsync(string FileName) {
            Client.AsyncStream.EvFileDownloadRequestMessage inValue = new Client.AsyncStream.EvFileDownloadRequestMessage();
            inValue.FileName = FileName;
            return ((Client.AsyncStream.IContract)(this)).FileDownloadAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Client.AsyncStream.EvFileUploaResponseMessage Client.AsyncStream.IContract.FileUpload(Client.AsyncStream.EvFileUploadRequestMessage request) {
            return base.Channel.FileUpload(request);
        }
        
        public bool FileUpload(ref string FileName, ref long Size, System.IO.Stream Content) {
            Client.AsyncStream.EvFileUploadRequestMessage inValue = new Client.AsyncStream.EvFileUploadRequestMessage();
            inValue.FileName = FileName;
            inValue.Size = Size;
            inValue.Content = Content;
            Client.AsyncStream.EvFileUploaResponseMessage retVal = ((Client.AsyncStream.IContract)(this)).FileUpload(inValue);
            FileName = retVal.FileName;
            Size = retVal.Size;
            return retVal.Success;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Client.AsyncStream.EvFileUploaResponseMessage> Client.AsyncStream.IContract.FileUploadAsync(Client.AsyncStream.EvFileUploadRequestMessage request) {
            return base.Channel.FileUploadAsync(request);
        }
        
        public System.Threading.Tasks.Task<Client.AsyncStream.EvFileUploaResponseMessage> FileUploadAsync(string FileName, long Size, System.IO.Stream Content) {
            Client.AsyncStream.EvFileUploadRequestMessage inValue = new Client.AsyncStream.EvFileUploadRequestMessage();
            inValue.FileName = FileName;
            inValue.Size = Size;
            inValue.Content = Content;
            return ((Client.AsyncStream.IContract)(this)).FileUploadAsync(inValue);
        }
        
        public System.IO.Stream StreamTestSync01() {
            return base.Channel.StreamTestSync01();
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> StreamTestSync01Async() {
            return base.Channel.StreamTestSync01Async();
        }
        
        public void StreamTestSync02(System.IO.Stream s) {
            base.Channel.StreamTestSync02(s);
        }
        
        public System.Threading.Tasks.Task StreamTestSync02Async(System.IO.Stream s) {
            return base.Channel.StreamTestSync02Async(s);
        }
        
        public System.IO.Stream StreamTestAsync01() {
            return base.Channel.StreamTestAsync01();
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> StreamTestAsync01Async() {
            return base.Channel.StreamTestAsync01Async();
        }
        
        public void StreamTestAsync02(System.IO.Stream m) {
            base.Channel.StreamTestAsync02(m);
        }
        
        public System.Threading.Tasks.Task StreamTestAsync02Async(System.IO.Stream m) {
            return base.Channel.StreamTestAsync02Async(m);
        }
        
        public System.IO.Stream DownLoadFileTest(string fn) {
            return base.Channel.DownLoadFileTest(fn);
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> DownLoadFileTestAsync(string fn) {
            return base.Channel.DownLoadFileTestAsync(fn);
        }
    }
}
