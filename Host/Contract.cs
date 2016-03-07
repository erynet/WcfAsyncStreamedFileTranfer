using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using Host.Abstract;

namespace Host
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class Contract : IContract
    {
        private readonly string _path = @"c:\t\";

        public async Task<bool> PingAsync()
        {
            return await Task.Factory.StartNew(() => true);
        }

        public async Task<List<string>> FileListAsync()
        {
            DirectoryInfo d = new DirectoryInfo(_path);
            if (d.Exists)
            {
                return
                    await
                        Task.Factory.StartNew(
                            () => (from f in d.GetFiles() orderby f.Name ascending select f.Name).ToList()
                            );
            }
            return await Task.Factory.StartNew(() => new List<string>());
        }

        public async Task<EvFileDownloadResponseMessage> FileDownloadAsync(EvFileDownloadRequestMessage m)
        {
            FileInfo f = new FileInfo(_path + m.FileName);
            if (f.Exists)
            {
                using (Stream s = f.OpenRead())
                {
                    return await Task.Factory.StartNew(() => new EvFileDownloadResponseMessage()
                    {
                        FileName = m.FileName,
                        Size = s.Length,
                        Exist = true,
                        Content = s
                    });
                }
            }
            return await Task.Factory.StartNew(() => new EvFileDownloadResponseMessage()
            {
                FileName = m.FileName,
                Size = 0,
                Exist = false,
                Content = null
            });
        }

        public async Task<EvFileUploaResponseMessage> FileUploadAsync(EvFileUploadRequestMessage m)
        {
            Stopwatch st = new Stopwatch();
            FileInfo f = new FileInfo(_path + m.FileName);
            if (f.Exists)
            {
                return await Task.Factory.StartNew(() => new EvFileUploaResponseMessage()
                {
                    FileName = m.FileName,
                    Size = 0,
                    Success = false
                });
            }

            using (FileStream fs = f.OpenWrite())
            {
                st.Restart();
                var totalBytes = m.Content.Length;
                Task t = m.Content.CopyToAsync(fs);
                while (true)
                {
                    if (!t.Wait(10))
                    {
                        var recieveBytes = m.Content.Position;
                        var percent = (recieveBytes * 100.0) / totalBytes;
                        Console.WriteLine($"{recieveBytes} / {totalBytes}, {percent}%");
                    }
                    Console.WriteLine($"{totalBytes} Bytes, {st.ElapsedMilliseconds} ms");
                    return await Task.Factory.StartNew(() => new EvFileUploaResponseMessage()
                    {
                        FileName = m.FileName,
                        Size = totalBytes,
                        Success = true
                    });
                }
            }
        }

        public Stream StreamTestSync01()
        {
            MemoryStream ms = new MemoryStream();

            using (StreamWriter sw = new StreamWriter(ms))
            {
                sw.Write("ABCDEFG");
                sw.Flush();
                ms.Position = 0;
                return ms;
            }
        }

        public void StreamTestSync02(Stream s)
        {
            using (StreamReader sr = new StreamReader(s))
            {
                string result = sr.ReadToEnd();
                Console.WriteLine(result);
            }
        }
        
        public async Task<Stream> StreamTestAsync01()
        {
            Thread.Sleep(250);
            MemoryStream ms = new MemoryStream();

            //using (MemoryStream ms = new MemoryStream())
            //{
                Stream ts = GenerateStreamFromString("QWERTYUI");
                await ts.CopyToAsync(ms);
                ms.Position = 0;
            //return ms;
            //return await Task.Factory.StartNew(() => ms);
            ts.Position = 0;
            return await Task.Factory.StartNew(() => ts);
            //}
            //using (MemoryStream ms = new MemoryStream())
            //{
            //    await s.CopyToAsync(ms);

            //    ms.Position = 0;
            //    return await Task.Factory.StartNew(() => ms);
            //}
            //throw new NotImplementedException();
        }

        public async Task StreamTestAsync02(Stream s)
        {
            Thread.Sleep(250);
            MemoryStream ms = new MemoryStream();
            await s.CopyToAsync(ms);
            ms.Position = 0;
            StreamReader sr = new StreamReader(ms);
            Console.WriteLine($"{DateTime.Now} : {await sr.ReadToEndAsync()}");


            //using (MemoryStream ms = new MemoryStream())
            //{
            //    await s.CopyToAsync(ms);
            //    ms.Position = 0;
            //    using (StreamReader sr = new StreamReader(ms))
            //    {
            //        Console.WriteLine($"{DateTime.Now} : {await sr.ReadToEndAsync()}");
            //    }
            //}
        }

        public async Task<Stream> DownLoadFileTestAsync(string fn)
        {
            FileInfo fi = new FileInfo(_path + fn);
            FileStream fs = fi.OpenRead();

            return fs;
            //return await Task.Factory.StartNew(() => fs);
            //MemoryStream ms = new MemoryStream();
            ////StreamWriter sw = new StreamWriter(ms);

            //Task t = fs.CopyToAsync(ms);
            //while (true)
            //{
            //    if (!t.Wait(10))
            //    {
            //        Console.WriteLine($"{DateTime.Now} : {fn}");
            //        continue;
            //    }
            //}

            //return ms
        }


        private Stream GenerateStreamFromString(string s)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
    }
}