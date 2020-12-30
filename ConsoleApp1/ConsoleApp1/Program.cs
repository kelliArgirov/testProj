using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TitaniumAS.Opc.Client.Common;
using TitaniumAS.Opc.Client.Da;
using TitaniumAS.Opc.Client.Da.Browsing;
using System.Threading;
using System.IO.Ports;
using Modbus.Device;

namespace ConsoleApp1
{

    class Program
    {
       


        static void Main(string[] args)
        {

            SerialPort serialPort = new SerialPort(); //Create a new SerialPort object.
            serialPort.PortName = "COM1";
            serialPort.BaudRate = 9600;
            serialPort.DataBits = 8;
            serialPort.Parity = Parity.None;
            serialPort.StopBits = StopBits.One;
            ModbusSerialMaster master = ModbusSerialMaster.CreateRtu(serialPort);
            return;

           var fact = new OpcCom.Factory();
           var server = new Opc.Da.Server(fact, null);
          var  url = new Opc.URL("opcda://localhost/RSLinx OPC Server");
            server.Url = url;
            server.Connect();
            


            //TitaniumAS.Opc.Client.Bootstrap.Initialize();

            //Uri url = UrlBuilder.Build("Matrikon.OPC.Simulation.1");

            //using (var server = new OpcDaServer(url))
            //{
            //    server.Connect();
            //    var bro = new OpcDaBrowserAuto(server);
            //    BrowseChildren(bro);
            //}
            //void BrowseChildren(IOpcDaBrowser browser, string itemId = null, int indent = 0)
            //{
            //    OpcDaBrowseElement[] elements = browser.GetElements(itemId);

            //    foreach (OpcDaBrowseElement element in elements)
            //    {
            //        Console.Write(new string(' ', indent));
            //        Console.WriteLine(element);

            //        if (!element.HasChildren)
            //            continue;

            //        BrowseChildren(browser, element.ItemId, indent + 2);


            //    }
            //}
        }

       
    }
}
