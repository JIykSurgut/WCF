using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference.ServerClient client = new ServiceReference.ServerClient();
            ICommunicationObject commObj = client;
            commObj.Opened += CommObj_Opened;
            commObj.Opening += CommObj_Opening;
            commObj.Closing += CommObj_Closing;
            commObj.Closed += Closed;
            commObj.Faulted += CommObj_Faulted;
            
            string value = client.GetData(5);
            Console.ReadLine();

        }

        private static void CommObj_Faulted(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private static void CommObj_Closing(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private static void CommObj_Opening(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private static void CommObj_Opened(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        static void Closed(object sender, EventArgs e)
        { 
        //
        }
    }
}
