using System.IO;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Host.Abstract
{
    [MessageContract]
    public class EvFileUploadRequestMessage
    {
        [MessageHeader]
        public string FileName { get; set; }
        [MessageHeader]
        public long Size { get; set; }
        //[MessageHeader]
        //public bool Exist { get; set; }
        //[MessageHeader]
        //public string Sha1 { get; set; }
        [MessageBodyMember]
        public Stream Content { get; set; }
    }

    [MessageContract]
    public class EvFileUploaResponseMessage
    {
        [MessageHeader]
        public string FileName { get; set; }
        [MessageHeader]
        public long Size { get; set; }
        [MessageHeader]
        public bool Success { get; set; }
    }

    [MessageContract]
    public class EvFileDownloadRequestMessage
    {
        [MessageHeader]
        public string FileName { get; set; }
    }

    [MessageContract]
    public class EvFileDownloadResponseMessage
    {
        [MessageHeader]
        public string FileName { get; set; }
        [MessageHeader]
        public long Size { get; set; }
        [MessageHeader]
        public bool Exist { get; set; }
        //[MessageHeader]
        //public string Sha1 { get; set; }
        [MessageBodyMember]
        public Stream Content { get; set; }
    }

    //[MessageContract]
    //public class EvStreamTestMessage
    //{
    //    [MessageBodyMember]
    //    public Stream Content { get; set; }
    //}
    [DataContract]
    public class EvStreamTestMessage
    {
        [DataMember]
        public Stream Content { get; set; }
    }

}