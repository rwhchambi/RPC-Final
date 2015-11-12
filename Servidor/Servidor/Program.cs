using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels.Tcp;
using ClsCalcular;
namespace SerRemoto

{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            
RemotingConfiguration.RegisterWellKnownServiceType
(typeof(ClsCalcular.Calculadora), "Calculadora",
            WellKnownObjectMode.SingleCall);
            TcpChannel chn1 = new TcpChannel(1235);
            Console.WriteLine("Servidor Remoto Activado");
            Console.ReadLine();
        }
    }
}
