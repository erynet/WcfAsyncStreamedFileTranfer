using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost serviceHost = new ServiceHost(typeof (Contract)))
            {
                serviceHost.Opening += ReportServiceState;
                serviceHost.Opened += ReportServiceState;
                serviceHost.Closing += ReportServiceState;
                serviceHost.Closed += ReportServiceState;
                serviceHost.Faulted += ReportServiceState;
                serviceHost.UnknownMessageReceived += ReportServiceState;

                serviceHost.Open();

                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press <ENTER> to terminate service.");
                Console.WriteLine();
                Console.ReadLine();
            }
        }

        static private void ReportServiceState(object sender, EventArgs e)
        {
            ServiceHost host = (ServiceHost)sender;
            switch (host.State)
            {
                case CommunicationState.Opening:
                    Console.WriteLine($@"Opening ..");
                    break;
                case CommunicationState.Opened:
                    Console.WriteLine($@"Ready for connection");
                    break;
                case CommunicationState.Closing:
                    Console.WriteLine($@"Closing ..");
                    break;
                case CommunicationState.Closed:
                    Console.WriteLine($@"Successfully closed");
                    break;
                case CommunicationState.Faulted:
                    // 이게 뭐인지 잘 모르겠다.
                    Console.WriteLine($@"Channel faulted");
                    break;
                default:
                    Console.WriteLine($@"Unknown Message received");
                    break;
            }
        }
    }
}
