using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        private static string _path = @"c:\t2\";
        static void Main(string[] args)
        {
            using (var cl = new Client.AsyncStream.ContractClient())
            {
                Console.WriteLine(cl.PingAsync().Result);
                
                MemoryStream ms = new MemoryStream();
                StreamWriter sw = new StreamWriter(ms);
                
                sw.Write("ABCDEFGHIJKMLNOP");
                sw.Flush();
                ms.Position = 0;

                L("StreamTestAsync12 Sync-Call Ready");
                Stream ts = cl.StreamTestAsync01();
                StreamReader tsr = new StreamReader(ts);
                Console.WriteLine(tsr.ReadToEndAsync().Result);
                L("StreamTestAsync01 Sync-Called");


                L("StreamTestAsync01 Async-Call Ready");
                FireAndForget(Task.Factory.StartNew(() => cl.StreamTestAsync01()));
                L("StreamTestAsync01 Async-Called");


                L("StreamTestAsync02 Sync-Call Ready");
                ms.Position = 0;
                cl.StreamTestAsync02(ms);
                L("StreamTestAsync02 Sync-Called");


                L("StreamTestAsync02 Async-Call Ready");
                ms.Position = 0;
                FireAndForget(Task.Factory.StartNew(() => cl.StreamTestAsync02(ms)));
                L("StreamTestAsync02 Async-Called");


                //Stream s = cl.StreamTestAsync01();
                //FireAndForget(Task.Factory.StartNew(() => cl.StreamTestAsync01()));

                foreach (var f in cl.FileListAsync().Result)
                {
                    L($"Downloading ... {f}");
                    FileInfo fi = new FileInfo(_path + f);
                    using (FileStream fs = fi.OpenWrite())
                    {
                        Task<Stream> t = cl.DownLoadFileTestAsync(f);
                        Stream ss = t.Result;
                        Task t2 = ss.CopyToAsync(fs);
                        Stopwatch st = new Stopwatch();
                        st.Restart();
                        while (!t2.Wait(100))
                        {
                            L($"{ss.Position} / , {st.ElapsedMilliseconds} ms");
                        }
                        L($"Complete, {ss.Position} Bytes, {st.ElapsedMilliseconds} ms, {(ss.Position/(st.ElapsedMilliseconds/1000.0))/(1024.0*1024.0):F2} mb/s");
                    }
                }
                
                L("Waiting ...");
                Console.ReadLine();

                //Stream st1 = cl.StreamTest2();
                //Console.WriteLine(st1.ToString());

                //foreach (var f in cl.FileList())
                //{
                //    Console.WriteLine($"{f} Downloading ...");
                //    var t = cl.FileDownloadAsync(f);
                //    var r = t.Result;
                //    FileInfo newFile = new FileInfo(_path + r.FileName);
                //    using (FileStream fs = newFile.OpenWrite())
                //    {
                //        Task task = r.Content.CopyToAsync(fs);
                //        while (true)
                //        {
                //            if (task.Wait(100))
                //            {
                //                Console.WriteLine($"{r.FileName} Download Completed");
                //                break;
                //            }
                //            L("{r.Content.Position} / {r.Content.Length}");
                //        }
                //    }
                //}
            }
        }

        private static async void FireAndForget(Task t)
        {
            await t.ConfigureAwait(false);
        }

        private static async void FireAndForget(Task<Stream> t)
        {
            L("FireAndForget #1");
            Stream s = await t.ConfigureAwait(false);
            using (StreamReader sr = new StreamReader(s))
            {
                L("FireAndForget #2");
                L("StreamTestAsync01 : {await sr.ReadToEndAsync()}");
                L("FireAndForget #3");
            }
        }

        private static async void FireAndForget(Task<string> t)
        {
            await t.ConfigureAwait(false);
        }

        private static void L(string s)
        {
            Console.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")} : {s}");
        }
    }
}
