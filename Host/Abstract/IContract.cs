using System.Collections.Generic;
using System.IO;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Host.Abstract
{
    [ServiceContract]
    public interface IContract
    {
        //[OperationContract]
        //bool Ping();

        [OperationContract]
        Task<bool> PingAsync();
        
        //[OperationContract]
        //List<string> FileList();

        [OperationContract]
        Task<List<string>> FileListAsync();

        //[OperationContract]
        //EvFileUploadRequestMessage FileDownload(string file);

        [OperationContract]
        Task<EvFileDownloadResponseMessage> FileDownloadAsync(EvFileDownloadRequestMessage m);

        //[OperationContract]
        //string FileUpload(EvFileUploadRequestMessage m);

        [OperationContract]
        Task<EvFileUploaResponseMessage> FileUploadAsync(EvFileUploadRequestMessage m);

        [OperationContract]
        Stream StreamTestSync01();

        [OperationContract]
        void StreamTestSync02(Stream s);

        [OperationContract]
        Task<Stream> StreamTestAsync01();

        [OperationContract]
        Task StreamTestAsync02(Stream m);

        [OperationContract]
        Task UploadFileTestAsync(Stream s);

        [OperationContract]
        Task<Stream> DownLoadFileTestAsync(string fn);
    }
}