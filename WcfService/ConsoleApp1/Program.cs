using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.MsmqIntegration;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputBindingElements(new BasicHttpBinding());
            OutputBindingElements(new BasicHttpContextBinding());
            OutputBindingElements(new BasicHttpsBinding());
            OutputBindingElements(new NetHttpBinding());
            OutputBindingElements(new NetHttpsBinding());

            OutputBindingElements(new NetMsmqBinding());
            OutputBindingElements(new MsmqIntegrationBinding());
            
            Console.ReadLine();
        }

        static void OutputBindingElements(Binding binding)
        {
            Console.WriteLine("Привязка: {0}", binding.GetType().Name);
            BindingElementCollection elements = binding.CreateBindingElements();

            foreach(BindingElement element in elements)
                Console.WriteLine("{0}", element.GetType().FullName);


            Console.WriteLine( );
        }
    }
}
