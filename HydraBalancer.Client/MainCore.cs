using System;
using System.Collections.Generic;
using System.Text;
using Grpc.Core;
using Balancer;


namespace HydraBalancer.Client
{
    public class MainCore
    {
        public MainCore(string IP, string port)
        {
            Channel channel = new Channel(IP + ":" + port, ChannelCredentials.Insecure); //Creamos un nuevo canal de cliente incresando direccion y puerto del servidor
            client = new SrvBalancer.SrvBalancerClient(channel); //Creamos un nuevo cliente, pasandole el servicio de proto (Greeter) y junto con el canal.

            //channel.ShutdownAsync().Wait();
        }

        SrvBalancer.SrvBalancerClient client;
        
        public ChooseO Choose(ChooseI input)
        {
            var _out = client.Choose(input);
            return _out;
        }
    }
}