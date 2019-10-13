using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace Example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicHttpBinding binding = new BasicHttpBinding(BasicHttpSecurityMode.None);

            Uri address = new Uri("http://localhost/request");
            BindingParameterCollection bpc = new BindingParameterCollection();

            Console.WriteLine("Запускается служба...");

            IChannelListener<IReplyChannel> listener = binding.BuildChannelListener<IReplyChannel>(address, bpc);

            listener.Open();
            IReplyChannel channel = listener.AcceptChannel();
            channel.Open();
            Console.WriteLine("Служба запущена!");

            Console.WriteLine("Ожидание запроса...");
            RequestContext request = channel.ReceiveRequest();
            Message message = request.RequestMessage;
            string data = message.GetBody<string>();
            Message replymessage = Message.CreateMessage(message.Version, "http://localhost/reply", data);
            request.Reply(replymessage);
            Console.WriteLine("Служба остановлена!");

            message.Close();
            request.Close();
            channel.Close();
            listener.Close();
            Console.ReadLine();
        }
    }
}
