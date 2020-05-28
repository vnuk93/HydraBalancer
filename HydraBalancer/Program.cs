using System;
using System.Threading.Tasks;
using Grpc.Core;
using Balancer;

namespace HydraBalancer
{
    class Program
    {
        static string hola { get; set; }
        static void Main(string[] args)
        {
            
            #region SrvBalancer Server gRPC
            const int Port = 1004;
            Console.WriteLine("> Starting HydraBalancer");
            Server server = new Server
            {
                Services = { SrvBalancer.BindService(new Controllers.HydraBalancerController()) }, //Servicios disponibles generados por proto
                Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) } //direccion, puerto y seguridad
            };
            server.Start();
            Console.WriteLine("> HydraBalancer server listening on port " + Port);
            #endregion

            //HydraBalancer.MainCore _ = new MainCore();
            
            Console.ReadKey();
            server.ShutdownAsync().Wait(); //Detiene el SrvBalancer
        }
    }
}
